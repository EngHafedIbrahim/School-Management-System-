using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDAAcademicYear
    {
        public static bool Find(int AcademicYearID, ref string YearName, ref DateTime StartDate, ref DateTime EndDate, ref bool IsCurrent, ref DateTime CreatedAt, ref DateTime UpdatedAt)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM AcademicYear WHERE AcademicYearID = @AcademicYearID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                                                YearName = reader["YearName"] != DBNull.Value ? (string)reader["YearName"] : "";
                                StartDate = (DateTime)reader["StartDate"];
                                EndDate = (DateTime)reader["EndDate"];
                                IsCurrent = (bool)reader["IsCurrent"];
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

        public static int AddNewAcademicYear(string YearName, DateTime StartDate, DateTime EndDate, bool IsCurrent, DateTime CreatedAt, DateTime UpdatedAt)
        {
            int AcademicYearID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO AcademicYear (YearName, StartDate, EndDate, IsCurrent, CreatedAt, UpdatedAt) 
                                     VALUES (@YearName, @StartDate, @EndDate, @IsCurrent, @CreatedAt, @UpdatedAt);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@YearName", (object)YearName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StartDate", StartDate);
                        command.Parameters.AddWithValue("@EndDate", EndDate);
                        command.Parameters.AddWithValue("@IsCurrent", IsCurrent);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            AcademicYearID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return AcademicYearID;
        }

        public static bool UpdateAcademicYear(int AcademicYearID, string YearName, DateTime StartDate, DateTime EndDate, bool IsCurrent, DateTime CreatedAt, DateTime UpdatedAt)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [AcademicYear] 
                                     SET YearName = @YearName, StartDate = @StartDate, EndDate = @EndDate, IsCurrent = @IsCurrent, CreatedAt = @CreatedAt, UpdatedAt = @UpdatedAt
                                     WHERE AcademicYearID = @AcademicYearID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
                                                command.Parameters.AddWithValue("@YearName", (object)YearName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StartDate", StartDate);
                        command.Parameters.AddWithValue("@EndDate", EndDate);
                        command.Parameters.AddWithValue("@IsCurrent", IsCurrent);
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

        public static bool DeleteAcademicYear(int AcademicYearID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM AcademicYear WHERE AcademicYearID = @AcademicYearID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
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

        public static DataTable GetCurrentAcademicYear()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT top 1 *FROM AcademicYear where IsCurrent = 1";
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
        public static DataTable GetAllAcademicYears()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM AcademicYear";
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

        public static bool IsAcademicYearExist(int AcademicYearID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM AcademicYear WHERE AcademicYearID = @AcademicYearID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
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
    
        public static bool SetCurrentAcademicYear(int academicYearID)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string queryReset = "UPDATE AcademicYear SET IsCurrent = 0";
                            using (SqlCommand cmdReset = new SqlCommand(queryReset, connection, transaction))
                            {
                                cmdReset.ExecuteNonQuery();
                            }

                            string querySet = "UPDATE AcademicYear SET IsCurrent = 1, UpdatedAt = @UpdatedAt WHERE AcademicYearID = @AcademicYearID";
                            using (SqlCommand cmdSet = new SqlCommand(querySet, connection, transaction))
                            {
                                cmdSet.Parameters.AddWithValue("@AcademicYearID", academicYearID);
                                cmdSet.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                                cmdSet.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            isSuccess = true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            clsLogger.Error(ex.Message);
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
                throw;
            }
            return isSuccess;
        }

}
}
