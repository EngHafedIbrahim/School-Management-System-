using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDAParent
    {
        public static bool Find(int ParentID, ref string FirstName, ref string LastName, ref string PhoneNumber, ref string Email, ref string Address, ref string RelationshipType, ref DateTime CreatedAt, ref DateTime UpdatedAt, ref bool IsDeleted)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Parent WHERE ParentID = @ParentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ParentID", ParentID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                FirstName = reader["FirstName"] != DBNull.Value ? (string)reader["FirstName"] : "";
                                LastName = reader["LastName"] != DBNull.Value ? (string)reader["LastName"] : "";
                                PhoneNumber = reader["PhoneNumber"] != DBNull.Value ? (string)reader["PhoneNumber"] : "";
                                Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                                Address = reader["Address"] != DBNull.Value ? (string)reader["Address"] : "";
                                RelationshipType = reader["RelationshipType"] != DBNull.Value ? (string)reader["RelationshipType"] : "";
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

        public static int AddNewParent(string FirstName, string LastName, string PhoneNumber, string Email, string Address, string RelationshipType, DateTime CreatedAt, DateTime UpdatedAt, bool IsDeleted)
        {
            int ParentID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Parent (FirstName, LastName, PhoneNumber, Email, Address, RelationshipType, CreatedAt, UpdatedAt, IsDeleted) 
                                     VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @Address, @RelationshipType, @CreatedAt, @UpdatedAt, @IsDeleted);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@FirstName", (object)FirstName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", (object)LastName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PhoneNumber", (object)PhoneNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@RelationshipType", (object)RelationshipType ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        command.Parameters.AddWithValue("@IsDeleted", IsDeleted);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ParentID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return ParentID;
        }

        public static bool UpdateParent(int ParentID, string FirstName, string LastName, string PhoneNumber, string Email, string Address, string RelationshipType, DateTime CreatedAt, DateTime UpdatedAt, bool IsDeleted)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [Parent] 
                                     SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Email = @Email, Address = @Address, RelationshipType = @RelationshipType, CreatedAt = @CreatedAt, UpdatedAt = @UpdatedAt, IsDeleted = @IsDeleted
                                     WHERE ParentID = @ParentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ParentID", ParentID);
                                                command.Parameters.AddWithValue("@FirstName", (object)FirstName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", (object)LastName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PhoneNumber", (object)PhoneNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@RelationshipType", (object)RelationshipType ?? DBNull.Value);
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

        public static bool DeleteParent(int ParentID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM Parent WHERE ParentID = @ParentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ParentID", ParentID);
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

        public static DataTable GetAllParents()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Parent";
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

        public static bool DoesEmailExist(string Email)
        {
            bool isFound = false;
            //DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Parent where Email = @Email";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Email", Email);
                        connection.Open();
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                            object result = command.ExecuteScalar();
                            
                            if (result != null)
                            {
                                isFound = Convert.ToInt32(result) > 0;
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
        public static bool IsParentExist(int ParentID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Parent WHERE ParentID = @ParentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ParentID", ParentID);
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
    
        public static DataTable GetAllParentsWithChildrenCount()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            p.ParentID,
                            (p.FirstName + ' ' + p.LastName) AS FullName,
                            p.PhoneNumber,
                            p.Email,
                            p.Address,
                            COUNT(sp.StudentID) AS NumberOfChildren
                        FROM [Parent] p
                        LEFT JOIN StudentParent sp ON p.ParentID = sp.ParentID
                        GROUP BY p.ParentID, p.FirstName, p.LastName, p.PhoneNumber, p.Email, p.Address";
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
