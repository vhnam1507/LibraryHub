using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net;
using System.Drawing;
using System.Security.Policy;
using System.Xml.Linq;

namespace LibraryHub.MyClasses
{
    internal class Books_proc
    {
        private SqlConnection conn;
        private SqlDataAdapter adapt;
        private DataSet dataSet;
        private SqlCommand cmd;
        public Books_proc()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["libraryHub"].ToString());
        }
        public DataTable GetAllBooks()
        {
            adapt = new SqlDataAdapter("Select * from tbl_Books", conn);
            dataSet = new DataSet();
            adapt.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable GetAvailableBooks()
        {
            adapt = new SqlDataAdapter("SELECT * FROM tbl_Books WHERE onStock > 0", conn);
            dataSet = new DataSet();
            adapt.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable GetWishlist(string readerID)
        {
            string queryCMD = "SELECT B.* " +
                              "FROM tbl_Wishlist W " +
                              "JOIN tbl_Books B ON W.bookID = B.bookID " +
                              "WHERE W.readerID = @readerID";

            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@readerID", readerID);
                    using (SqlDataAdapter adapt = new SqlDataAdapter(cmd))
                    {
                        DataSet dataSet = new DataSet();
                        adapt.Fill(dataSet);
                        return dataSet.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public string GetBookInfoByID(string bookID)
        {
            string queryCMD = "SELECT bookID, name, author, publisher FROM tbl_Books WHERE bookID = @bookID";
            conn.Open();

            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@bookID", bookID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string bookInfo = $"{reader["bookID"]} - {reader["name"]} - {reader["author"]} - {reader["publisher"]}";
                            return bookInfo;
                        }
                        else
                        {
                            return string.Empty; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally { conn.Close(); }
        }

        public DataTable SearchInBooks(string keyword)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Books WHERE " +
                "author LIKE @keyword OR " +
                "publisher LIKE @keyword OR " +
                "category LIKE @keyword OR " +
                "name LIKE @keyword OR " +
                "bookID LIKE @keyword;", conn))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                using (SqlDataAdapter adapt = new SqlDataAdapter(cmd))
                {
                    DataSet dataSet = new DataSet();
                    adapt.Fill(dataSet);
                    return dataSet.Tables[0];
                }
            }
        }

        public DataTable SearchInWishlist(string readerID, string keyword)
        {
            DataTable wishlistTable = GetWishlist(readerID);
            string lowerKeyword = keyword.ToLower();

            var query = from DataRow row in wishlistTable.Rows
                        where row.Field<string>("author").ToLower().Contains(lowerKeyword) ||
                              row.Field<string>("publisher").ToLower().Contains(lowerKeyword) ||
                              row.Field<string>("category").ToLower().Contains(lowerKeyword) ||
                              row.Field<string>("name").ToLower().Contains(lowerKeyword) ||
                              row.Field<string>("bookID").ToLower().Contains(lowerKeyword)
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

        public bool DeleteBook(string bookid)
        {
            string queryCMD = "DELETE FROM tbl_Books WHERE bookID = @bookid";

            conn.Open();
            try
            {
                using (SqlCommand deleteCmd = new SqlCommand(queryCMD, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@bookid", bookid);
                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { conn.Close(); }
        }

        public bool DeleteWish(string readerid, string bookid)
        {
            string queryCMD = "DELETE FROM tbl_Wishlist WHERE bookID = @bookid AND @readerID = @readerid";

            conn.Open();
            try
            {
                using (SqlCommand deleteCmd = new SqlCommand(queryCMD, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@bookid", bookid);
                    deleteCmd.Parameters.AddWithValue("@readerid", readerid);
                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { conn.Close(); }
        }

        public bool InsertBook(string boookID, string name, string gen, string author, string publisher, string total)
        {
            string queryCMD = "INSERT INTO tbl_Books (bookID, name, category, author, publisher, total, onstock, borrowed) " +
                            "VALUES (@bookID, @name, @gen, @author, @publisher, @total, @total, 0)";
            conn.Open();
            try
            {
                using (cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@bookID", boookID);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@gen", gen);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@publisher", publisher);
                    cmd.Parameters.AddWithValue("@total", total);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { conn.Close(); }
        }

        public bool UpdateBook(string bookID, string name, string gen, string author, string publisher, string total)
        {
            string queryCMD = "UPDATE tbl_Books " +
                   "SET name = @name, category = @gen, author = @author, " +
                   "publisher = @publisher, total = @total, onStock = @total - borrowed " +
                   "WHERE bookID = @bookID";

            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@bookID", bookID);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@gen", gen);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@publisher", publisher);
                    cmd.Parameters.AddWithValue("@total", total);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { conn.Close(); }
        }

        public string GenerateNewBookID()
        {
            string newID = "BOOK01"; // Mã mặc định nếu danh sách rỗng

            string queryCMD = "SELECT TOP 1 bookID FROM tbl_Books ORDER BY bookID DESC";
            conn.Open();
            try
            {
                using (cmd = new SqlCommand(queryCMD, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string lastID = reader["bookID"].ToString();

                        // Tạo mã mới bằng cách tăng số phiên bản
                        int version = int.Parse(lastID.Substring(4)) + 1;
                        newID = "BOOK" + version.ToString("D3");
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally { conn.Close(); }

            return newID;
        }

        public bool BookToWishlist(string bookID, string readerID)
        {
            string queryCMD = "INSERT INTO tbl_Wishlist (wishID, readerID, bookID) " +
                            "VALUES (@wishID, @readerID, @bookID)";
            string wishID = GenerateNewWishID();
            conn.Open();
            try
            {
                using (cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@wishID", wishID);
                    cmd.Parameters.AddWithValue("@readerID", readerID);
                    cmd.Parameters.AddWithValue("@bookID", bookID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { conn.Close(); }
        }

        public string GenerateNewWishID()
        {
            string newID = "WISH001"; // Mã mặc định nếu danh sách rỗng

            string queryCMD = "SELECT TOP 1 wishID FROM tbl_Wishlist ORDER BY wishID DESC";
            conn.Open();
            try
            {
                using (cmd = new SqlCommand(queryCMD, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string lastID = reader["wishID"].ToString();

                        // Tạo mã mới bằng cách tăng số phiên bản
                        int version = int.Parse(lastID.Substring(4)) + 1;
                        newID = "WISH" + version.ToString("D3");
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally { conn.Close(); }

            return newID;
        }

        public bool CheckDuplicateWish(string bookID, string readerID)
        {
            string queryCMD = "SELECT COUNT(*) " +
                              "FROM tbl_Wishlist " +
                              "WHERE bookID = @bookID AND readerID = @readerID";

            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@bookID", bookID);
                    cmd.Parameters.AddWithValue("@readerID", readerID);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable GetBorrowedBooksByReaderID(string readerID)
        {
            string queryCMD = "SELECT B.* " +
                              "FROM tbl_BorrowingDetails BD " +
                              "JOIN tbl_Books B ON BD.bookID = B.bookID " +
                              "WHERE BD.borrowingID IN (SELECT borrowingID FROM tbl_Borrowing WHERE readerID = @readerID)";

            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@readerID", readerID);

                    using (SqlDataAdapter adapt = new SqlDataAdapter(cmd))
                    {
                        DataSet dataSet = new DataSet();
                        adapt.Fill(dataSet);
                        return dataSet.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
