using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDAClass
    {
        public static bool Find(int ClassID, ref string Name, ref int GradeLevelID, ref string Details, ref int CreatedBy, ref int UpdatedBy, ref DateTime CreatedAt, ref DateTime UpdatedAt, ref bool IsDeleted)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Class WHERE ClassID = @ClassID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassID", ClassID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                                                Name = reader["Name"] != DBNull.Value ? (string)reader["Name"] : "";
                                GradeLevelID = (int)reader["GradeLevelID"];
                                Details = reader["Details"] != DBNull.Value ? (string)reader["Details"] : "";
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

        public static int AddNewClass(string Name, int GradeLevelID, string Details, int CreatedBy, int UpdatedBy, DateTime CreatedAt, DateTime UpdatedAt, bool IsDeleted)
        {
            int ClassID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Class (Name, GradeLevelID, Details, CreatedBy, UpdatedBy, CreatedAt, UpdatedAt, IsDeleted) 
                                     VALUES (@Name, @GradeLevelID, @Details, @CreatedBy, @UpdatedBy, @CreatedAt, @UpdatedAt, @IsDeleted);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@Name", (object)Name ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GradeLevelID", GradeLevelID);
                        command.Parameters.AddWithValue("@Details", (object)Details ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        command.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        command.Parameters.AddWithValue("@IsDeleted", IsDeleted);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ClassID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return ClassID;
        }

        public static bool UpdateClass(int ClassID, string Name, int GradeLevelID, string Details, int CreatedBy, int UpdatedBy, DateTime CreatedAt, DateTime UpdatedAt, bool IsDeleted)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [Class] 
                                     SET Name = @Name, GradeLevelID = @GradeLevelID, Details = @Details, CreatedBy = @CreatedBy, UpdatedBy = @UpdatedBy, CreatedAt = @CreatedAt, UpdatedAt = @UpdatedAt, IsDeleted = @IsDeleted
                                     WHERE ClassID = @ClassID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassID", ClassID);
                                                command.Parameters.AddWithValue("@Name", (object)Name ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GradeLevelID", GradeLevelID);
                        command.Parameters.AddWithValue("@Details", (object)Details ?? DBNull.Value);
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

        public static bool DeleteClass(int ClassID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM Class WHERE ClassID = @ClassID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassID", ClassID);
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

        public static DataTable GetAllClasss()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Class";
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

        public static DataTable GetAllClasss(int GradeLevelID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Class where GradeLevelID = @GradeLevelID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GradeLevelID", GradeLevelID);
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


        public static bool IsClassExistWithGradeLevel(string Name, int GradeLevelID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Class WHERE Name = @Name AND GradeLevelID =@GradeLevelID ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@GradeLevelID", GradeLevelID);
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
        public static bool IsClassExist(int ClassID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Class WHERE ClassID = @ClassID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassID", ClassID);
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

        public static DataTable GetClassesDetailed()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT c.ClassID, c.Name AS ClassName, g.Name AS GradeLevelName, c.GradeLevelID, c.Details, c.IsDeleted
                                     FROM Class c
                                     INNER JOIN GradeLevel g ON c.GradeLevelID = g.GradeLevelID
                                     WHERE c.IsDeleted = 0
                                     ORDER BY g.OrderNo, c.Name";
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
    }
}
