using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHub.MyClasses
{
    internal class Borrowings_proc
    {
        private SqlConnection conn;
        private SqlDataAdapter adapt;
        private DataSet dataSet;
        private SqlCommand cmd;

        public Borrowings_proc()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["libraryHub"].ToString());
        }
        public DataTable GetAllBorrowings()
        {
            adapt = new SqlDataAdapter("SELECT B.borrowingID, R.name, B.startDay, B.endDay, B.status " +
                "FROM tbl_Borrowing B " +
                "JOIN tbl_Readers R ON B.readerID = R.readerID;", conn);
            dataSet = new DataSet();
            adapt.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable GetDoneBorrowings()
        {
            adapt = new SqlDataAdapter("SELECT B.borrowingID, R.name, B.startDay, B.endDay, B.status " +
                "FROM tbl_Borrowing B " +
                "JOIN tbl_Readers R ON B.readerID = R.readerID " +
                "WHERE B.status = 'True';", conn);
            dataSet = new DataSet();
            adapt.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable GetNotYetBorrowings()
        {
            adapt = new SqlDataAdapter("SELECT B.borrowingID, R.name, B.startDay, B.endDay, B.status " +
                "FROM tbl_Borrowing B " +
                "JOIN tbl_Readers R ON B.readerID = R.readerID " +
                "WHERE B.status = 'False';", conn);
            dataSet = new DataSet();
            adapt.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable GetLateBorrowings()
        {
            DateTime currentTime = DateTime.Now;

            adapt = new SqlDataAdapter("SELECT B.borrowingID, R.name, B.startDay, B.endDay, B.status " +
                "FROM tbl_Borrowing B " +
                "JOIN tbl_Readers R ON B.readerID = R.readerID " +
                $"WHERE B.status = 'False' AND @currentTime > B.endDay;", conn);

            adapt.SelectCommand.Parameters.AddWithValue("@currentTime", currentTime);

            dataSet = new DataSet();
            adapt.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable GetBorrowingByReaderID(string readerID)
        {
            adapt = new SqlDataAdapter("SELECT B.borrowingID, R.name, B.startDay, B.endDay, B.status " +
                "FROM tbl_Borrowing B " +
                "JOIN tbl_Readers R ON B.readerID = R.readerID " +
                "WHERE B.readerID = @readerID", conn);

            adapt.SelectCommand.Parameters.AddWithValue("@readerID", readerID);
            dataSet = new DataSet();
            adapt.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable GetDoneBorrowingsByReaderID(string readerID)
        {
            adapt = new SqlDataAdapter("SELECT B.borrowingID, R.name, B.startDay, B.endDay, B.status " +
                "FROM tbl_Borrowing B " +
                "JOIN tbl_Readers R ON B.readerID = R.readerID " +
                "WHERE B.status = 'True' AND B.readerID = @readerID ;", conn);
            adapt.SelectCommand.Parameters.AddWithValue("@readerID", readerID);
            dataSet = new DataSet();
            adapt.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable GetNotYetBorrowingsByReaderID(string readerID)
        {
            adapt = new SqlDataAdapter("SELECT B.borrowingID, R.name, B.startDay, B.endDay, B.status " +
                "FROM tbl_Borrowing B " +
                "JOIN tbl_Readers R ON B.readerID = R.readerID " +
                "WHERE B.status = 'False' AND B.readerID = @readerID ;", conn);
            adapt.SelectCommand.Parameters.AddWithValue("@readerID", readerID);
            dataSet = new DataSet();
            adapt.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable GetLateBorrowingsByReaderID(string readerID)
        {
            DateTime currentTime = DateTime.Now;

            adapt = new SqlDataAdapter("SELECT B.borrowingID, R.name, B.startDay, B.endDay, B.status " +
                "FROM tbl_Borrowing B " +
                "JOIN tbl_Readers R ON B.readerID = R.readerID " +
                $"WHERE B.status = 'False' AND @currentTime > B.endDay AND B.readerID = @readerID;", conn);

            adapt.SelectCommand.Parameters.AddWithValue("@currentTime", currentTime);
            adapt.SelectCommand.Parameters.AddWithValue("@readerID", readerID);

            dataSet = new DataSet();
            adapt.Fill(dataSet);
            return dataSet.Tables[0];
        }

       


        public bool UpdateStatus(string borrowingID, string status)
        {
            string queryCMD = "UPDATE tbl_Borrowing " +
                   "SET status = @status " +
                   "WHERE borrowingID = @borrowingID ";

            conn.Open();
            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@borrowingID", borrowingID);
                    cmd.Parameters.AddWithValue("@status", status);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Lấy danh sách sách từ chi tiết phiếu mượn
                        string getBooksQuery = "SELECT bookID FROM tbl_BorrowingDetails WHERE borrowingID = @borrowingID;";
                        List<string> bookList = new List<string>();

                        using (SqlCommand getBooksCmd = new SqlCommand(getBooksQuery, conn, transaction))
                        {
                            getBooksCmd.Parameters.AddWithValue("@borrowingID", borrowingID);

                            using (SqlDataReader reader = getBooksCmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    bookList.Add(reader["bookID"].ToString());
                                }
                            }
                        }

                        // Cập nhật thông tin sách trong tbl_Books
                        foreach (string bookID in bookList)
                        {
                            string updateBooksQuery = "UPDATE tbl_Books SET onstock = onstock + 1, borrowed = borrowed - 1 WHERE bookID = @bookID;";

                            using (SqlCommand updateCmd = new SqlCommand(updateBooksQuery, conn, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@bookID", bookID);
                                int updateRowsAffected = updateCmd.ExecuteNonQuery();

                                if (updateRowsAffected != 1)
                                {
                                    transaction.Rollback();
                                    return false;
                                }
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return false;
            }
            finally { conn.Close(); }
        }

        public List<string> GetBooksByBorrowingID(string borrowingID)
        {
            List<string> bookList = new List<string>();

            string queryCMD = "SELECT B.bookID, B.name, B.author, B.publisher " +
                              "FROM tbl_Books B " +
                              "JOIN tbl_BorrowingDetails BD ON B.bookID = BD.bookID " +
                              "WHERE BD.borrowingID = @borrowingID";

            conn.Open();
            try
            {
                using (cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@borrowingID", borrowingID);

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adapt.Fill(dataSet);

                    DataTable dataTable = dataSet.Tables[0];

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string bookID = row["bookID"].ToString();
                        string bookName = row["name"].ToString();
                        string author = row["author"].ToString();
                        string publisher = row["publisher"].ToString();

                        string bookInfo = $"{bookID} - {bookName} - {author} - {publisher}";
                        bookList.Add(bookInfo);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally { conn.Close(); }

            return bookList;
        }

        public DataTable GetAllBorrowingsInfo(string borrowingID)
        {
            string queryCMD = "SELECT B.borrowingID, B.readerID, R.name, B.startDay, B.endDay, B.status " +
                "FROM tbl_Borrowing B " +
                "JOIN tbl_Readers R ON B.readerID = R.readerID " +
                $"WHERE B.borrowingID = @borrowingID";

            using (SqlCommand cmd = new SqlCommand(queryCMD, conn)) 
            {
                cmd.Parameters.AddWithValue("@borrowingID", borrowingID);

                using (SqlDataAdapter adapt = new SqlDataAdapter(cmd))
                {
                    DataSet dataSet = new DataSet();
                    adapt.Fill(dataSet);
                    return dataSet.Tables[0];
                }
            };
        }

        public DataTable SearchInBorrowing(string keyword)
        {
            DataTable dataTable = GetAllBorrowings();
            string lowerKeyword = keyword.ToLower();

            // Sử dụng LINQ để tìm kiếm trong DataTable
            var query = from DataRow row in dataTable.Rows
                        where row.Field<string>("borrowingID").ToLower().Contains(lowerKeyword) ||
                              row.Field<string>("name").ToLower().Contains(lowerKeyword) ||
                              row.Field<DateTime>("startDay").ToString("dd/MM/yyyy").ToLower().Contains(lowerKeyword) ||
                              row.Field<DateTime>("endDay").ToString("dd/MM/yyyy").ToLower().Contains(lowerKeyword) ||
                              row.Field<bool>("status").ToString().ToLower().Contains(lowerKeyword)
                        select row;

            if (query.Any())
            {
                DataTable resultTable = query.CopyToDataTable();
                return resultTable;
            }
            else
            {
                return null;
            }
        }


        public DataTable SearchInBorrowingByReaderID(string readerID, string keyword)
        {
            DataTable dataTable = GetBorrowingByReaderID(readerID);
            string lowerKeyword = keyword.ToLower();

            // Sử dụng LINQ để tìm kiếm trong DataTable
            var query = from DataRow row in dataTable.Rows
                        where row.Field<string>("borrowingID").ToLower().Contains(lowerKeyword) ||
                              row.Field<string>("name").ToLower().Contains(lowerKeyword) ||
                              row.Field<DateTime>("startDay").ToString("dd/MM/yyyy").ToLower().Contains(lowerKeyword) ||
                              row.Field<DateTime>("endDay").ToString("dd/MM/yyyy").ToLower().Contains(lowerKeyword) ||
                              row.Field<bool>("status").ToString().ToLower().Contains(lowerKeyword)
                        select row;

            if (query.Any())
            {
                DataTable resultTable = query.CopyToDataTable();
                return resultTable;
            }
            else
            {
                return null;
            }
        }

        public bool InsertBorrowing(string borrowingID, string readerID, string startDay, string endDay, string status, List<string> bookList)
        {
            Tuple<int, int, int> borrowingStats = GetReaderBorrowingStats(readerID);
            int currentlyBorrowed = borrowingStats.Item2;

            if (currentlyBorrowed != 0)
            {
                return false;
            }
            conn.Open();
            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                // Insert into tbl_Borrowing
                string queryCMD = "INSERT INTO tbl_Borrowing (borrowingID, readerID, startDay, endDay, status) " +
                                    "VALUES (@borrowingID, @readerID, @startDay, @endDay, @status);";

                using (cmd = new SqlCommand(queryCMD, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@borrowingID", borrowingID);
                    cmd.Parameters.AddWithValue("@readerID", readerID);
                    cmd.Parameters.AddWithValue("@startDay", startDay);
                    cmd.Parameters.AddWithValue("@endDay", endDay);
                    cmd.Parameters.AddWithValue("@status", status);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        // Insert into tbl_BorrowingDetails
                        string queryCMD2 = "INSERT INTO tbl_BorrowingDetails (detailsID, borrowingID, bookID) " +
                                            "VALUES (@detailsID, @borrowingID, @bookID);";

                        foreach (string item in bookList)
                        {
                            using (SqlCommand cmd2 = new SqlCommand(queryCMD2, conn, transaction))
                            {
                                string detailsID = GenerateNewBorringDetailsID();
                                cmd2.Parameters.AddWithValue("@detailsID", detailsID);
                                cmd2.Parameters.AddWithValue("@borrowingID", borrowingID);
                                cmd2.Parameters.AddWithValue("@bookID", item);
                                int rowsAffected2 = cmd2.ExecuteNonQuery();

                                if (rowsAffected2 != 1)
                                {
                                    transaction.Rollback();
                                    return false;
                                }
                            }

                            // Update tbl_Books
                            string updateBooksQuery = "UPDATE tbl_Books SET onstock = onstock - 1, borrowed = borrowed + 1 WHERE bookID = @bookID;";
                            using (SqlCommand updateCmd = new SqlCommand(updateBooksQuery, conn, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@bookID", item);
                                int updateRowsAffected = updateCmd.ExecuteNonQuery();

                                if (updateRowsAffected != 1)
                                {
                                    transaction.Rollback();
                                    return false;
                                }
                            }
                        }
                        transaction.Commit();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return false;
            }
            finally { conn.Close(); }
        }

        public string GenerateNewBorringDetailsID()
        {
            string newID = "DETAIL001"; // Mã mặc định nếu danh sách rỗng
            string queryCMD = "SELECT TOP 1 detailsID FROM tbl_BorrowingDetails ORDER BY detailsID DESC";
            try
            {
                using (cmd = new SqlCommand(queryCMD, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string lastID = reader["detailsID"].ToString();

                        // Tạo mã mới bằng cách tăng số phiên bản
                        int version = int.Parse(lastID.Substring(6)) + 1;
                        newID = "DETAIL" + version.ToString("D3");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
            }
            return newID;
        }

        public string GenerateNewBorrowingID()
        {
            string newID = "BR001"; // Mã mặc định nếu danh sách rỗng

            string queryCMD = "SELECT TOP 1 borrowingID FROM tbl_Borrowing ORDER BY borrowingID DESC";
            conn.Open();
            try
            {
                using (cmd = new SqlCommand(queryCMD, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string lastID = reader["borrowingID"].ToString();

                        // Tạo mã mới bằng cách tăng số phiên bản
                        int version = int.Parse(lastID.Substring(2)) + 1;
                        newID = "BR" + version.ToString("D3");
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally { conn.Close(); }

            return newID;
        }

        public Tuple<int, int, int> GetReaderBorrowingStats(string readerID)
        {
            int totalBorrowed = 0;
            int currentlyBorrowed = 0;
            int totalReturned = 0;

            string queryTotalBorrowed = "SELECT COUNT(*) FROM tbl_BorrowingDetails BD " +
                                        "JOIN tbl_Borrowing B ON BD.borrowingID = B.borrowingID " +
                                        "WHERE B.readerID = @readerID";

            string queryCurrentlyBorrowed = "SELECT COUNT(*) FROM tbl_BorrowingDetails BD " +
                                             "JOIN tbl_Borrowing B ON BD.borrowingID = B.borrowingID " +
                                             "WHERE B.readerID = @readerID AND B.status = 'False'";

            string queryTotalReturned = "SELECT COUNT(*) FROM tbl_BorrowingDetails BD " +
                                        "JOIN tbl_Borrowing B ON BD.borrowingID = B.borrowingID " +
                                        "WHERE B.readerID = @readerID AND B.status = 'True'";

            conn.Open();
            try
            {
                using (SqlCommand cmdTotalBorrowed = new SqlCommand(queryTotalBorrowed, conn))
                using (SqlCommand cmdCurrentlyBorrowed = new SqlCommand(queryCurrentlyBorrowed, conn))
                using (SqlCommand cmdTotalReturned = new SqlCommand(queryTotalReturned, conn))
                {
                    cmdTotalBorrowed.Parameters.AddWithValue("@readerID", readerID);
                    cmdCurrentlyBorrowed.Parameters.AddWithValue("@readerID", readerID);
                    cmdTotalReturned.Parameters.AddWithValue("@readerID", readerID);

                    totalBorrowed = (int)cmdTotalBorrowed.ExecuteScalar();
                    currentlyBorrowed = (int)cmdCurrentlyBorrowed.ExecuteScalar();
                    totalReturned = (int)cmdTotalReturned.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
            }
            finally { conn.Close(); }
            return Tuple.Create(totalBorrowed, currentlyBorrowed, totalReturned);
        }
    }
}
