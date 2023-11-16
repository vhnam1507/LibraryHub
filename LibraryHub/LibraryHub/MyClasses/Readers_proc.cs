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
    internal class Readers_proc
    {
        private SqlConnection conn;
        private SqlDataAdapter adapt;
        private DataSet dataSet;
        private SqlCommand cmd;
        public Readers_proc()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["libraryHub"].ToString());
        }
        public DataTable GetAllReaders()
        {
            adapt = new SqlDataAdapter("Select readerID, name, address, phone, email from tbl_Readers", conn);
            dataSet = new DataSet();
            adapt.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable GetAllReaderID()
        {
            adapt = new SqlDataAdapter("Select readerID from tbl_Readers", conn);
            dataSet = new DataSet();
            adapt.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public string GetName( string readerID)
        {
            string queryCMD = "select name from tbl_Readers where readerID = @readerID";
            conn.Open();

            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@readerID", readerID);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : string.Empty;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally { conn.Close(); }
        }

        public DataTable SearchInReaders(string keyword)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Readers WHERE " +
                "address LIKE @keyword OR " +
                "phone LIKE @keyword OR " +
                "email LIKE @keyword OR " +
                "name LIKE @keyword OR " +
                "userID LIKE @keyword OR " +
                "readerID LIKE @keyword;", conn))
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
        public DataTable GetAllReaderInfo(string readerID)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT R.*, U.UserName, U.Password " +
                "FROM " +
                "tbl_Readers R " +
                "JOIN " +
                "tbl_Users U ON R.UserID = U.userID " +
                "WHERE R.readerID = @readerID ", conn))

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

        public bool UpdateReader(string readerID, string username, string userID, string name, string address, string phone, string email, string password)
        {
            string queryCMD = "UPDATE tbl_Readers " +
                   "SET name = @name, address = @address, phone = @phone, " +
                   "email = @email " +
                   "WHERE readerID = @readerID " +
                   "UPDATE tbl_Users " +
                   "SET password = @password, username = @username, name = @name " +
                   "WHERE userID = @userID ";

            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@readerID", readerID);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
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

        public bool InsertReader(string readerID, string username, string userID, string name, string address, string phone, string email, string password)
        {
            string usersRoleID = GenerateNewUserRoleID();
            string roleID = "ROLE02";

            string queryCMD = "INSERT INTO tbl_Users (userID, username, name, password) " +
                            "VALUES (@userID, @username, @name, @password);" +
                            "INSERT INTO tbl_UserRoles (usersRoleID, userID, roleID) " +
                            "VALUES (@usersRoleID, @userID, @roleID); " +
                            "INSERT INTO tbl_Readers (readerID, userID, name, address, phone, email) " +
                            "VALUES (@readerID, @userID, @name, @address, @phone, @email);";
            conn.Open();
            try
            {
                using (cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@readerID", readerID);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@roleID", roleID);
                    cmd.Parameters.AddWithValue("@usersRoleID", usersRoleID);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 3)
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
        
        public bool DeleteReader(string userID)
        {
            string queryCMD = "DELETE FROM tbl_Readers WHERE userID = @userID;  " +
                            "DELETE FROM tbl_UserRoles WHERE userID = @userID; ";
            string queryCMD2 = "DELETE FROM tbl_Users WHERE userID = @userID";

            conn.Open();
            try
            {
                using (SqlCommand deleteCmd = new SqlCommand(queryCMD, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@userID", userID);
                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        using (SqlCommand deleteCmd2 = new SqlCommand(queryCMD2, conn))
                        {
                            deleteCmd2.Parameters.AddWithValue("@userID", userID);
                            int rowsAffected2 = deleteCmd2.ExecuteNonQuery();

                            if (rowsAffected2 > 0)
                            {
                                return true;
                            }
                        }
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

        public string GenerateNewReaderID()
        {
            string newID = "READER001"; // Mã mặc định nếu danh sách rỗng

            string queryCMD = "SELECT TOP 1 readerID FROM tbl_Readers ORDER BY readerID DESC";
            conn.Open();
            try
            {
                using (cmd = new SqlCommand(queryCMD, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string lastID = reader["readerID"].ToString();

                        // Tạo mã mới bằng cách tăng số phiên bản
                        int version = int.Parse(lastID.Substring(6)) + 1;
                        newID = "READER" + version.ToString("D3");
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally { conn.Close(); }

            return newID;
        }

        public string GenerateNewUserRoleID()
        {
            string newID = "UR001"; // Mã mặc định nếu danh sách rỗng

            string queryCMD = "SELECT TOP 1 usersRoleID FROM tbl_UserRoles ORDER BY usersRoleID DESC";
            conn.Open();
            try
            {
                using (cmd = new SqlCommand(queryCMD, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string lastID = reader["usersRoleID"].ToString();

                        // Tạo mã mới bằng cách tăng số phiên bản
                        int version = int.Parse(lastID.Substring(2)) + 1;
                        newID = "UR" + version.ToString("D3");
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally { conn.Close(); }

            return newID;
        }

        public string GenerateNewUserID()
        {
            string newID = "USER001"; // Mã mặc định nếu danh sách rỗng

            string queryCMD = "SELECT TOP 1 userID FROM tbl_Users ORDER BY userID DESC";
            conn.Open();
            try
            {
                using (cmd = new SqlCommand(queryCMD, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string lastID = reader["userID"].ToString();

                        // Tạo mã mới bằng cách tăng số phiên bản
                        int version = int.Parse(lastID.Substring(4)) + 1;
                        newID = "USER" + version.ToString("D3");
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally { conn.Close(); }

            return newID;
        }

        public Tuple<string, string, string> GetReaderContact(string readerID)
        {
            string queryCMD = "SELECT address, email, phone FROM tbl_Readers " +
                              "WHERE readerID = @readerID";
            conn.Open();

            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@readerID", readerID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string address = $"{reader["address"]}";
                            string email = $"{reader["email"]}";
                            string phone = $"{reader["phone"]}";

                            return new Tuple<string, string, string>(address, email, phone);
                        }
                        else
                        {
                            return null;
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


    }
}
