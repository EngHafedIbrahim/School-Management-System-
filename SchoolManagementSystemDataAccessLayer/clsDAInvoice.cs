using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDAInvoice
    {
        public static bool Find(int InvoiceID, ref string InvoiceNumber, ref int StudentID, ref int AcademicYearID, ref int FeeStructureID, ref DateTime IssueDate, ref DateTime DueDate, ref decimal Subtotal, ref decimal DiscountAmount, ref decimal TaxAmount, ref decimal TotalAmount, ref string Status, ref int CreatedBy)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Invoice WHERE InvoiceID = @InvoiceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                                                InvoiceNumber = reader["InvoiceNumber"] != DBNull.Value ? (string)reader["InvoiceNumber"] : "";
                                StudentID = (int)reader["StudentID"];
                                AcademicYearID = (int)reader["AcademicYearID"];
                                FeeStructureID = (int)reader["FeeStructureID"];
                                IssueDate = (DateTime)reader["IssueDate"];
                                DueDate = (DateTime)reader["DueDate"];
                                Subtotal = (decimal)reader["Subtotal"];
                                DiscountAmount = (decimal)reader["DiscountAmount"];
                                TaxAmount = (decimal)reader["TaxAmount"];
                                TotalAmount = (decimal)reader["TotalAmount"];
                                Status = reader["Status"] != DBNull.Value ? (string)reader["Status"] : "";
                                CreatedBy = (int)reader["CreatedBy"];
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

        public static int AddNewInvoice(string InvoiceNumber, int StudentID, int AcademicYearID, int FeeStructureID, DateTime IssueDate, DateTime DueDate, decimal Subtotal, decimal DiscountAmount, decimal TaxAmount, decimal TotalAmount, string Status, int CreatedBy)
        {
            int InvoiceID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Invoice (InvoiceNumber, StudentID, AcademicYearID, FeeStructureID, IssueDate, DueDate, Subtotal, DiscountAmount, TaxAmount, TotalAmount, Status, CreatedBy) 
                                     VALUES (@InvoiceNumber, @StudentID, @AcademicYearID, @FeeStructureID, @IssueDate, @DueDate, @Subtotal, @DiscountAmount, @TaxAmount, @TotalAmount, @Status, @CreatedBy);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@InvoiceNumber", (object)InvoiceNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
                        command.Parameters.AddWithValue("@FeeStructureID", FeeStructureID);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@DueDate", DueDate);
                        command.Parameters.AddWithValue("@Subtotal", Subtotal);
                        command.Parameters.AddWithValue("@DiscountAmount", DiscountAmount);
                        command.Parameters.AddWithValue("@TaxAmount", TaxAmount);
                        command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        command.Parameters.AddWithValue("@Status", (object)Status ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            InvoiceID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return InvoiceID;
        }

        public static bool UpdateInvoice(int InvoiceID, string InvoiceNumber, int StudentID, int AcademicYearID, int FeeStructureID, DateTime IssueDate, DateTime DueDate, decimal Subtotal, decimal DiscountAmount, decimal TaxAmount, decimal TotalAmount, string Status, int CreatedBy)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [Invoice] 
                                     SET InvoiceNumber = @InvoiceNumber, StudentID = @StudentID, AcademicYearID = @AcademicYearID, FeeStructureID = @FeeStructureID, IssueDate = @IssueDate, DueDate = @DueDate, Subtotal = @Subtotal, DiscountAmount = @DiscountAmount, TaxAmount = @TaxAmount, TotalAmount = @TotalAmount, Status = @Status, CreatedBy = @CreatedBy
                                     WHERE InvoiceID = @InvoiceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                                                command.Parameters.AddWithValue("@InvoiceNumber", (object)InvoiceNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
                        command.Parameters.AddWithValue("@FeeStructureID", FeeStructureID);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@DueDate", DueDate);
                        command.Parameters.AddWithValue("@Subtotal", Subtotal);
                        command.Parameters.AddWithValue("@DiscountAmount", DiscountAmount);
                        command.Parameters.AddWithValue("@TaxAmount", TaxAmount);
                        command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        command.Parameters.AddWithValue("@Status", (object)Status ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
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

        public static bool DeleteInvoice(int InvoiceID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM Invoice WHERE InvoiceID = @InvoiceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
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

        public static DataTable GetAllInvoices()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Invoice";
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

        public static bool IsInvoiceExist(int InvoiceID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Invoice WHERE InvoiceID = @InvoiceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
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
    
        public static DataTable GetInvoicesByStudentID(int studentID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            i.InvoiceID,
                            i.InvoiceNumber,
                            ay.YearName AS AcademicYear,
                            i.TotalAmount,
                            i.Status,
                            i.IssueDate,
                            i.DueDate
                        FROM Invoice i
                        INNER JOIN AcademicYear ay ON i.AcademicYearID = ay.AcademicYearID
                        WHERE i.StudentID = @StudentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);
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
