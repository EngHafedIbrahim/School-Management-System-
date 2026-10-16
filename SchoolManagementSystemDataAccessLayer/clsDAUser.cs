using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDAUser
    {
        public static bool Find(int UserID, ref string Username, ref string PasswordHash, ref string Email, ref string Status, ref string UserType, ref int? ReferenceID, ref DateTime CreatedAt, ref DateTime UpdatedAt)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM [User] WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                                                Username = reader["Username"] != DBNull.Value ? (string)reader["Username"] : "";
                                PasswordHash = reader["PasswordHash"] != DBNull.Value ? (string)reader["PasswordHash"] : "";
                                Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                                Status = reader["Status"] != DBNull.Value ? (string)reader["Status"] : "";
                                UserType = reader["UserType"] != DBNull.Value ? (string)reader["UserType"] : "";
                                ReferenceID = reader["ReferenceID"] != DBNull.Value ? (int?)reader["ReferenceID"] : null;
                                CreatedAt = (DateTime)reader["CreatedAt"];
                                UpdatedAt = (DateTime)reader["UpdatedAt"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return isFound;
        }

        public static int GetUserInfoByUserNameAndPass( string Username, string PasswordHash, ref string Email, ref string Status, ref string UserType, ref int? ReferenceID, ref DateTime CreatedAt, ref DateTime UpdatedAt)
        {
            bool isFound = false;

            int UserID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM [User] WHERE Username = @Username and PasswordHash = @PasswordHash";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@PasswordHash", PasswordHash);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                UserID = reader["UserID"] != DBNull.Value ? (int)reader["UserID"] : -1;
                                //Username = reader["Username"] != DBNull.Value ? (string)reader["Username"] : "";
                                //PasswordHash = reader["PasswordHash"] != DBNull.Value ? (string)reader["PasswordHash"] : "";
                                Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                                Status = reader["Status"] != DBNull.Value ? (string)reader["Status"] : "";
                                UserType = reader["UserType"] != DBNull.Value ? (string)reader["UserType"] : "";
                                ReferenceID = reader["ReferenceID"] != DBNull.Value ? (int?)reader["ReferenceID"] : null;
                                CreatedAt = (DateTime)reader["CreatedAt"];
                                UpdatedAt = (DateTime)reader["UpdatedAt"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return UserID;
        }

        public static int AddNewUser(string Username, string PasswordHash, string Email, string Status, string UserType, int? ReferenceID, DateTime CreatedAt, DateTime UpdatedAt)
        {
            int UserID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO [User] (Username, PasswordHash, Email, Status, UserType, ReferenceID, CreatedAt, UpdatedAt) 
                                     VALUES (@Username, @PasswordHash, @Email, @Status, @UserType, @ReferenceID, @CreatedAt, @UpdatedAt);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@Username", (object)Username ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PasswordHash", (object)PasswordHash ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Status", (object)Status ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UserType", (object)UserType ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReferenceID", (object)ReferenceID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            UserID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return UserID;
        }

        public static bool UpdateUser(int UserID, string Username, string PasswordHash, string Email, string Status, string UserType, int? ReferenceID, DateTime CreatedAt, DateTime UpdatedAt)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [User] 
                                     SET Username = @Username, PasswordHash = @PasswordHash, Email = @Email, Status = @Status, UserType = @UserType, ReferenceID = @ReferenceID, CreatedAt = @CreatedAt, UpdatedAt = @UpdatedAt
                                     WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                                                command.Parameters.AddWithValue("@Username", (object)Username ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PasswordHash", (object)PasswordHash ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Status", (object)Status ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UserType", (object)UserType ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReferenceID", (object)ReferenceID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return (rowsAffected > 0);
        }

        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM [User] WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM [User]";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return dt;
        }

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM [User] WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            isFound = Convert.ToInt32(result) > 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return isFound;
        }
    
        public static DataTable GetAllUsersDetailed()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            u.UserID, u.Username, u.Email, u.UserType, u.Status,
                            u.ReferenceID, u.CreatedAt,
                            CASE 
                                WHEN u.UserType = 'Teacher' THEN (SELECT t.FirstName + ' ' + t.LastName FROM Teacher t WHERE t.TeacherID = u.ReferenceID)
                                WHEN u.UserType = 'Parent'  THEN (SELECT p.FirstName + ' ' + p.LastName FROM Parent p WHERE p.ParentID = u.ReferenceID)
                                WHEN u.UserType = 'Student' THEN (SELECT s.FirstName + ' ' + s.LastName FROM Student s WHERE s.StudentID = u.ReferenceID)
                                WHEN u.UserType = 'Admin'   THEN 'System Admin'
                                ELSE ''
                            END AS LinkedEntityName
                        FROM [User] u
                        ORDER BY u.CreatedAt DESC";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return dt;
        }

        public static bool IsUsernameExist(string username, int excludeUserID = -1)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM [User] WHERE Username = @Username AND UserID <> @ExcludeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@ExcludeID", excludeUserID);
                        connection.Open();
                        isFound = (command.ExecuteScalar() != null);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return isFound;
        }

        public static bool IsEmailExist(string email, int excludeUserID = -1)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM [User] WHERE Email = @Email AND UserID <> @ExcludeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@ExcludeID", excludeUserID);
                        connection.Open();
                        isFound = (command.ExecuteScalar() != null);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return isFound;
        }

        public static bool UpdateUserStatus(int userID, string status)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "UPDATE [User] SET Status = @Status, UpdatedAt = GETDATE() WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@Status", status);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return (rowsAffected > 0);
        }

        public static bool ResetPassword(int userID, string newPasswordHash)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "UPDATE [User] SET PasswordHash = @PasswordHash, UpdatedAt = GETDATE() WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@PasswordHash", newPasswordHash);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return (rowsAffected > 0);
        }

        public static bool IsReferenceAlreadyLinked(string userType, int referenceID, int excludeUserID = -1)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM [User] WHERE UserType = @UserType AND ReferenceID = @ReferenceID AND UserID <> @ExcludeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserType", userType);
                        command.Parameters.AddWithValue("@ReferenceID", referenceID);
                        command.Parameters.AddWithValue("@ExcludeID", excludeUserID);
                        connection.Open();
                        isFound = (command.ExecuteScalar() != null);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return isFound;
        }

}
}
