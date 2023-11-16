using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;

namespace LibraryHub.MyClasses
{
    internal class Users_proc
    {
        private SqlConnection conn;
        private SqlDataAdapter adapt;
        private DataSet dataSet;
        private SqlCommand cmd;
        public Users_proc()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["libraryHub"].ToString());
        }
        public DataTable GetAlls()
        {
            adapt = new SqlDataAdapter("Select * from tbl_Users", conn);
            dataSet = new DataSet();
            adapt.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public bool UpdateUserPassword(string userID, string password)
        {
            string queryCMD = "UPDATE tbl_Users " +
                   "SET password = @password " +
                   "WHERE userID = @userID";

            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@userID", userID);
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

        public bool UpdateUser(string userID, string username, string name, string password)
        {
            string queryCMD = "UPDATE tbl_Users " +
                   "SET password = @password, username = @username, name = @name " +
                   "WHERE userID = @userID";

            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@userID", userID);
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

        public bool CheckUsernameExists(string username)
        {
            string queryCMD = "SELECT COUNT(*) FROM tbl_Users WHERE username = @username";

            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int userCount = (int)cmd.ExecuteScalar();

                    return userCount > 0;
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
        public bool CheckPassword(string username, string password)
        {
            string queryCMD = "Select password from tbl_Users " +
                   "WHERE username = @username";
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string resultPassword = $"{reader["password"]}";
                            if (password == resultPassword)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
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
            return false;
        }

        public string GetUserID(string username)
        {
            string queryCMD = "Select userID from tbl_Users " +
                   "WHERE username = @username";
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string userID = $"{reader["userID"]}";
                            return userID ;
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
            finally {conn.Close();}
        }

        public string GetUserRoleID(string userID)
        {
            string queryCMD = "Select roleID from tbl_UserRoles " +
                   "WHERE userID = @userID";
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string roleid = $"{reader["roleID"]}";
                            return roleid;
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

        public string GetName(string userID)
        {
            string queryCMD = "Select name from tbl_Users " +
                   "WHERE userID = @userID";
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = $"{reader["name"]}";
                            return name;
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

        public string GetReaderID(string userID)
        {
            string queryCMD = "Select readerID from tbl_Readers " +
                   "WHERE userID = @userID";
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string readerID = $"{reader["readerID"]}";
                            return readerID;
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

        public string GetPassword(string userID)
        {
            string queryCMD = "Select password from tbl_Users " +
                   "WHERE userID = @userID";
            conn.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryCMD, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string password = $"{reader["password"]}";
                            return password;
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
    }
}
