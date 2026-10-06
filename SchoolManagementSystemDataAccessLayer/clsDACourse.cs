using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDACourse
    {
        public static bool Find(int CourseID, ref string Name, ref int CreditHours, ref string Description, ref int CreatedBy, ref int UpdatedBy, ref DateTime CreatedAt, ref DateTime UpdatedAt, ref bool IsDeleted)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Course WHERE CourseID = @CourseID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseID", CourseID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                                                Name = reader["Name"] != DBNull.Value ? (string)reader["Name"] : "";
                                CreditHours = (int)reader["CreditHours"];
                                Description = reader["Description"] != DBNull.Value ? (string)reader["Description"] : "";
                                CreatedBy = (int)reader["CreatedBy"];
                                UpdatedBy = (int)reader["UpdatedBy"];
                                CreatedAt = (DateTime)reader["CreatedAt"];
                                UpdatedAt = (DateTime)reader["UpdatedAt"];
                                IsDeleted = (bool)reader["IsDeleted"];
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

        public static int AddNewCourse(string Name, int CreditHours, string Description, int CreatedBy, int UpdatedBy, DateTime CreatedAt, DateTime UpdatedAt, bool IsDeleted)
        {
            int CourseID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Course (Name, CreditHours, Description, CreatedBy, UpdatedBy, CreatedAt, UpdatedAt, IsDeleted) 
                                     VALUES (@Name, @CreditHours, @Description, @CreatedBy, @UpdatedBy, @CreatedAt, @UpdatedAt, @IsDeleted);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@Name", (object)Name ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreditHours", CreditHours);
                        command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        command.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        command.Parameters.AddWithValue("@IsDeleted", IsDeleted);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            CourseID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return CourseID;
        }

        public static bool UpdateCourse(int CourseID, string Name, int CreditHours, string Description, int CreatedBy, int UpdatedBy, DateTime CreatedAt, DateTime UpdatedAt, bool IsDeleted)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [Course] 
                                     SET Name = @Name, CreditHours = @CreditHours, Description = @Description, CreatedBy = @CreatedBy, UpdatedBy = @UpdatedBy, CreatedAt = @CreatedAt, UpdatedAt = @UpdatedAt, IsDeleted = @IsDeleted
                                     WHERE CourseID = @CourseID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseID", CourseID);
                                                command.Parameters.AddWithValue("@Name", (object)Name ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreditHours", CreditHours);
                        command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        command.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        command.Parameters.AddWithValue("@IsDeleted", IsDeleted);
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

        public static bool DeleteCourse(int CourseID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM Course WHERE CourseID = @CourseID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseID", CourseID);
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

        public static DataTable GetAllCourses()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Course";
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

        public static bool IsCourseExist(int CourseID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Course WHERE CourseID = @CourseID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseID", CourseID);
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
    }
}
