using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDAFeeStructure
    {
        public static bool Find(int FeeStructureID, ref string Name, ref int GradeLevelID, ref int AcademicYearID, ref decimal TuitionFee, ref decimal TransportFee, ref decimal BookFee, ref decimal OtherFees, ref DateTime CreatedAt, ref DateTime UpdatedAt)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM FeeStructure WHERE FeeStructureID = @FeeStructureID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FeeStructureID", FeeStructureID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                                                Name = reader["Name"] != DBNull.Value ? (string)reader["Name"] : "";
                                GradeLevelID = (int)reader["GradeLevelID"];
                                AcademicYearID = (int)reader["AcademicYearID"];
                                TuitionFee = (decimal)reader["TuitionFee"];
                                TransportFee = (decimal)reader["TransportFee"];
                                BookFee = (decimal)reader["BookFee"];
                                OtherFees = (decimal)reader["OtherFees"];
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

        public static int AddNewFeeStructure(string Name, int GradeLevelID, int AcademicYearID, decimal TuitionFee, decimal TransportFee, decimal BookFee, decimal OtherFees, DateTime CreatedAt, DateTime UpdatedAt)
        {
            int FeeStructureID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO FeeStructure (Name, GradeLevelID, AcademicYearID, TuitionFee, TransportFee, BookFee, OtherFees, CreatedAt, UpdatedAt) 
                                     VALUES (@Name, @GradeLevelID, @AcademicYearID, @TuitionFee, @TransportFee, @BookFee, @OtherFees, @CreatedAt, @UpdatedAt);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@Name", (object)Name ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GradeLevelID", GradeLevelID);
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
                        command.Parameters.AddWithValue("@TuitionFee", TuitionFee);
                        command.Parameters.AddWithValue("@TransportFee", TransportFee);
                        command.Parameters.AddWithValue("@BookFee", BookFee);
                        command.Parameters.AddWithValue("@OtherFees", OtherFees);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            FeeStructureID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return FeeStructureID;
        }

        public static bool UpdateFeeStructure(int FeeStructureID, string Name, int GradeLevelID, int AcademicYearID, decimal TuitionFee, decimal TransportFee, decimal BookFee, decimal OtherFees, DateTime CreatedAt, DateTime UpdatedAt)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [FeeStructure] 
                                     SET Name = @Name, GradeLevelID = @GradeLevelID, AcademicYearID = @AcademicYearID, TuitionFee = @TuitionFee, TransportFee = @TransportFee, BookFee = @BookFee, OtherFees = @OtherFees, CreatedAt = @CreatedAt, UpdatedAt = @UpdatedAt
                                     WHERE FeeStructureID = @FeeStructureID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FeeStructureID", FeeStructureID);
                                                command.Parameters.AddWithValue("@Name", (object)Name ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GradeLevelID", GradeLevelID);
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
                        command.Parameters.AddWithValue("@TuitionFee", TuitionFee);
                        command.Parameters.AddWithValue("@TransportFee", TransportFee);
                        command.Parameters.AddWithValue("@BookFee", BookFee);
                        command.Parameters.AddWithValue("@OtherFees", OtherFees);
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

        public static bool DeleteFeeStructure(int FeeStructureID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM FeeStructure WHERE FeeStructureID = @FeeStructureID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FeeStructureID", FeeStructureID);
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

        public static DataTable GetAllFeeStructures()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM FeeStructure";
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

        public static bool IsFeeStructureExist(int FeeStructureID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM FeeStructure WHERE FeeStructureID = @FeeStructureID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FeeStructureID", FeeStructureID);
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
