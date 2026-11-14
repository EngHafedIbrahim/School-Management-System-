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
                                     SET InvoiceNumber = @InvoiceNumber, StudentID = @StudentID,
                                    AcademicYearID = @AcademicYearID,
                                    FeeStructureID = @FeeStructureID, IssueDate = @IssueDate,
                                    DueDate = @DueDate, Subtotal = @Subtotal,
                                    DiscountAmount = @DiscountAmount, TaxAmount = @TaxAmount, TotalAmount = @TotalAmount,
                                    Status = @Status, CreatedBy = @CreatedBy
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
                    // I'm created the trigger to update  status of invoice instead delete it ....
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
                    string query = @"dbo.sp_GetAllInvoicesByStudentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StudentID", SqlDbType.Int).Value = studentID;
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


        public static DataTable GetInvoiceDetailed(int invoiceID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    /*string query = @"
                    //    SELECT 
                    //        i.InvoiceID, i.InvoiceNumber,
                    //        i.StudentID, (s.FirstName + ' ' + s.LastName) AS StudentName, s.AdmissionNo AS AdmissionNumber,
                    //        i.AcademicYearID, ay.YearName AS AcademicYear,
                    //        i.FeeStructureID,
                    //        i.IssueDate, i.DueDate,
                    //        i.Subtotal, i.DiscountAmount, i.TaxAmount, i.TotalAmount,
                    //        i.Status, i.CreatedBy,
                    //        ISNULL((SELECT SUM(p.Amount) FROM Payment p WHERE p.InvoiceID = i.InvoiceID), 0) AS PaidAmount,
                    //        i.TotalAmount - ISNULL((SELECT SUM(p.Amount) FROM Payment p WHERE p.InvoiceID = i.InvoiceID), 0) AS RemainingAmount
                    //    FROM Invoice i
                    //    INNER JOIN Student s ON i.StudentID = s.StudentID
                    //    INNER JOIN AcademicYear ay ON i.AcademicYearID = ay.AcademicYearID
                    //    INNER JOIN FeeStructure fs ON i.FeeStructureID = fs.FeeStructureID
                    //    WHERE i.InvoiceID = @InvoiceID";
                    */

                    string query = @"[dbo].[sp_GetAllInvoicesWithDetailsByInvoiceID]";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@InvoiceID", SqlDbType.Int).Value = invoiceID;
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

        public static DataTable GetAllInvoicesDetailed()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    /*string query = @"
                        SELECT 
                            i.InvoiceID, i.InvoiceNumber,
                            i.StudentID, (s.FirstName + ' ' + s.LastName) AS StudentName,
                            i.AcademicYearID, ay.YearName AS AcademicYear,
                            i.TotalAmount,
                            ISNULL((SELECT SUM(p.Amount) FROM Payment p WHERE p.InvoiceID = i.InvoiceID), 0) AS PaidAmount,
                            i.TotalAmount - ISNULL((SELECT SUM(p.Amount) FROM Payment p WHERE p.InvoiceID = i.InvoiceID), 0) AS RemainingAmount,
                            i.Status, i.IssueDate, i.DueDate
                        FROM Invoice i
                        INNER JOIN Student s ON i.StudentID = s.StudentID
                        INNER JOIN AcademicYear ay ON i.AcademicYearID = ay.AcademicYearID
                        ORDER BY i.IssueDate DESC";*/

                    string query = @"[dbo].[sp_GetAllInvoicesWithDetailed]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
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

        public static decimal GetTotalPaidByInvoiceID(int invoiceID)
        {
            decimal totalPaid = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT ISNULL(SUM(Amount), 0) FROM Payment WHERE InvoiceID = @InvoiceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InvoiceID", invoiceID);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            totalPaid = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return totalPaid;
        }

        public static bool UpdateInvoiceStatus(int invoiceID, string status)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "UPDATE Invoice SET Status = @Status WHERE InvoiceID = @InvoiceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InvoiceID", invoiceID);
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


        // Get next sequential invoice number (concurrency-safe)
        public static string GetNextInvoiceNumber()
        {
            string invoiceNumber = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    /*string query = @"
                        DECLARE @NextNum INT;
                        SELECT @NextNum = ISNULL(MAX(
                            CASE WHEN ISNUMERIC(RIGHT(InvoiceNumber, 4)) = 1 
                                 THEN CAST(RIGHT(InvoiceNumber, 4) AS INT) 
                                 ELSE 0 END
                        ), 0) + 1 
                        FROM Invoice 
                        WHERE InvoiceNumber LIKE 'INV-' + FORMAT(GETDATE(), 'yyyyMM') + '-%';
                        SELECT 'INV-' + FORMAT(GETDATE(), 'yyyyMM') + '-' + RIGHT('0000' + CAST(@NextNum AS VARCHAR(10)), 4)";
                    */

                    string query = @"select dbo.fn_GetNextInvoiceNumber() ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                            invoiceNumber = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
                invoiceNumber = $"INV-{DateTime.Now:yyyyMM}-{new Random().Next(1000,9999):D4}";
            }
            return invoiceNumber;
        }

        // Check if student already has an active (non-cancelled) invoice for the same fee structure and year
        public static bool HasActiveInvoiceForStudentAndYear(int studentID, int academicYearID, int feeStructureID)
        {
            bool hasActive = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT TOP 1 1 FROM Invoice 
                                     WHERE StudentID = @StudentID 
                                       AND AcademicYearID = @AcademicYearID 
                                       AND FeeStructureID = @FeeStructureID
                                       AND Status != 'Cancelled'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.Parameters.AddWithValue("@AcademicYearID", academicYearID);
                        command.Parameters.AddWithValue("@FeeStructureID", feeStructureID);
                        connection.Open();
                        hasActive = (command.ExecuteScalar() != null);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return hasActive;
        }

        // Check if an invoice has any payments recorded against it
        public static bool HasPayments(int invoiceID)
        {
            bool hasPay = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Payment WHERE InvoiceID = @InvoiceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InvoiceID", invoiceID);
                        connection.Open();
                        hasPay = (command.ExecuteScalar() != null);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return hasPay;
        }

        // Get student enrollment info for auto-detecting grade level
        public static DataTable GetStudentEnrollmentInfo(int studentID, int academicYearID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    /*string query = @"
                        SELECT 
                            se.StudentID, se.ClassID, se.Status AS EnrollmentStatus,
                            c.Name AS ClassName, c.GradeLevelID,
                            gl.Name AS GradeLevelName
                        FROM StudentEnrollment se
                        INNER JOIN Class c ON se.ClassID = c.ClassID
                        INNER JOIN GradeLevel gl ON c.GradeLevelID = gl.GradeLevelID
                        WHERE se.StudentID = @StudentID 
                          AND se.AcademicYearID = @AcademicYearID 
                          AND se.Status = 'Active'";*/

                    string query = @"dbo.sp_GetStudentEnrollmentInfo ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.Parameters.AddWithValue("@AcademicYearID", academicYearID);
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

    }
}