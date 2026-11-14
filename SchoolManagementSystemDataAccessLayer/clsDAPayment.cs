using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDAPayment
    {
        public static bool Find(int PaymentID, ref int InvoiceID, ref DateTime PaymentDate, ref decimal Amount, ref string PaymentMethod, ref int PaymentTypeID, ref string TransactionID, ref string ReceiptNumber, ref string Notes, ref int CreatedBy, ref DateTime CreatedAt)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Payment WHERE PaymentID = @PaymentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                InvoiceID = (int)reader["InvoiceID"];
                                PaymentDate = (DateTime)reader["PaymentDate"];
                                Amount = (decimal)reader["Amount"];
                                PaymentMethod = reader["PaymentMethod"] != DBNull.Value ? (string)reader["PaymentMethod"] : "";
                                PaymentTypeID = (int)reader["PaymentTypeID"];
                                TransactionID = reader["TransactionID"] != DBNull.Value ? (string)reader["TransactionID"] : "";
                                ReceiptNumber = reader["ReceiptNumber"] != DBNull.Value ? (string)reader["ReceiptNumber"] : "";
                                Notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : "";
                                CreatedBy = (int)reader["CreatedBy"];
                                CreatedAt = (DateTime)reader["CreatedAt"];
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

        public static int AddNewPayment(int InvoiceID, DateTime PaymentDate, decimal Amount, string PaymentMethod, int PaymentTypeID, string TransactionID, string ReceiptNumber, string Notes, int CreatedBy, DateTime CreatedAt)
        {
            int PaymentID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Payment (InvoiceID, PaymentDate, Amount, PaymentMethod, PaymentTypeID, TransactionID, ReceiptNumber, Notes, CreatedBy, CreatedAt) 
                                     VALUES (@InvoiceID, @PaymentDate, @Amount, @PaymentMethod, @PaymentTypeID, @TransactionID, @ReceiptNumber, @Notes, @CreatedBy, @CreatedAt);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                        command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@PaymentMethod", (object)PaymentMethod ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PaymentTypeID", PaymentTypeID);
                        command.Parameters.AddWithValue("@TransactionID", (object)TransactionID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReceiptNumber", (object)ReceiptNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PaymentID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return PaymentID;
        }

        public static bool UpdatePayment(int PaymentID, int InvoiceID, DateTime PaymentDate, decimal Amount, string PaymentMethod, int PaymentTypeID, string TransactionID, string ReceiptNumber, string Notes, int CreatedBy, DateTime CreatedAt)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [Payment] 
                                     SET InvoiceID = @InvoiceID, PaymentDate = @PaymentDate, Amount = @Amount, PaymentMethod = @PaymentMethod, PaymentTypeID = @PaymentTypeID, TransactionID = @TransactionID, ReceiptNumber = @ReceiptNumber, Notes = @Notes, CreatedBy = @CreatedBy, CreatedAt = @CreatedAt
                                     WHERE PaymentID = @PaymentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                        command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@PaymentMethod", (object)PaymentMethod ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PaymentTypeID", PaymentTypeID);
                        command.Parameters.AddWithValue("@TransactionID", (object)TransactionID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReceiptNumber", (object)ReceiptNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
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

        public static bool DeletePayment(int PaymentID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM Payment WHERE PaymentID = @PaymentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
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

        public static DataTable GetAllPayments()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Payment";
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

        public static bool IsPaymentExist(int PaymentID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Payment WHERE PaymentID = @PaymentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
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
    
        public static DataTable GetPaymentsByInvoiceID(int invoiceID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    //string query = @"
                    //    SELECT 
                    //        p.PaymentID, p.ReceiptNumber, p.PaymentDate, p.Amount,
                    //        pt.Name AS PaymentTypeName,
                    //        p.Notes,
                    //        u.Username AS RecordedBy
                    //    FROM Payment p
                    //    INNER JOIN PaymentType pt ON p.PaymentTypeID = pt.PaymentTypeID
                    //    LEFT JOIN [User] u ON p.CreatedBy = u.UserID
                    //    WHERE p.InvoiceID = @InvoiceID
                    //    ORDER BY p.PaymentDate DESC";
                    string query = @"
                        SELECT 
                            p.PaymentID, p.ReceiptNumber, p.PaymentDate, p.Amount,
                            pt.Name AS PaymentTypeName,
                            p.Notes
                           
                        FROM Payment p
                        INNER JOIN PaymentType pt ON p.PaymentTypeID = pt.PaymentTypeID
                        
                        WHERE p.InvoiceID = @InvoiceID
                        ORDER BY p.PaymentDate DESC";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InvoiceID", invoiceID);
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

        public static int RecordPaymentWithTransaction(int invoiceID, DateTime paymentDate, decimal amount,
            string paymentMethod, int paymentTypeID, string transactionID, string receiptNumber,
            string notes, int createdBy, out string errorMessage)
        {
            errorMessage = "";
            int paymentID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Step 1: Get invoice total and current paid amount INSIDE transaction (concurrency safe)
                            decimal totalAmount = 0;
                            decimal totalPaid = 0;
                            string currentStatus = "";

                            string queryInvoice = @"
                                SELECT i.TotalAmount, i.Status,
                                       ISNULL((SELECT SUM(p.Amount) FROM Payment p WHERE p.InvoiceID = i.InvoiceID), 0) AS TotalPaid
                                FROM Invoice i WHERE i.InvoiceID = @InvoiceID";
                            using (SqlCommand cmd = new SqlCommand(queryInvoice, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@InvoiceID", invoiceID);
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        totalAmount = (decimal)reader["TotalAmount"];
                                        totalPaid = (decimal)reader["TotalPaid"];
                                        currentStatus = reader["Status"].ToString();
                                    }
                                    else
                                    {
                                        errorMessage = "Invoice not found.";
                                        transaction.Rollback();
                                        return -1;
                                    }
                                }
                            }

                            decimal remaining = totalAmount - totalPaid;
                            if (amount > remaining)
                            {
                                errorMessage = $"Payment amount ({amount:N2}) exceeds remaining balance ({remaining:N2}).";
                                transaction.Rollback();
                                return -1;
                            }
                            if (amount <= 0)
                            {
                                errorMessage = "Payment amount must be greater than zero.";
                                transaction.Rollback();
                                return -1;
                            }

                            // Step 2: Insert Payment
                            string queryInsert = @"
                                INSERT INTO Payment (InvoiceID, PaymentDate, Amount, PaymentMethod, PaymentTypeID, TransactionID, ReceiptNumber, Notes, CreatedBy, CreatedAt)
                                VALUES (@InvoiceID, @PaymentDate, @Amount, @PaymentMethod, @PaymentTypeID, @TransactionID, @ReceiptNumber, @Notes, @CreatedBy, GETDATE());
                                SELECT SCOPE_IDENTITY();";
                            using (SqlCommand cmd = new SqlCommand(queryInsert, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@InvoiceID", invoiceID);
                                cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                                cmd.Parameters.AddWithValue("@Amount", amount);
                                cmd.Parameters.AddWithValue("@PaymentMethod", (object)paymentMethod ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@PaymentTypeID", paymentTypeID);
                                cmd.Parameters.AddWithValue("@TransactionID", (object)transactionID ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@ReceiptNumber", (object)receiptNumber ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@Notes", (object)notes ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@CreatedBy", createdBy);

                                object result = cmd.ExecuteScalar();
                                if (result != null && int.TryParse(result.ToString(), out int id))
                                    paymentID = id;
                            }

                            // Step 3: Calculate new status and update invoice
                            decimal newTotalPaid = totalPaid + amount;
                            string newStatus;
                            if (newTotalPaid >= totalAmount)
                                newStatus = "Paid";
                            else if (newTotalPaid > 0)
                                newStatus = "Partially Paid";
                            else
                                newStatus = "Unpaid";

                            string queryUpdate = "UPDATE Invoice SET Status = @Status WHERE InvoiceID = @InvoiceID";
                            using (SqlCommand cmd = new SqlCommand(queryUpdate, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Status", newStatus);
                                cmd.Parameters.AddWithValue("@InvoiceID", invoiceID);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
                errorMessage = "Database error: " + ex.Message;
                paymentID = -1;
            }
            return paymentID;
        }

        public static DataTable GetAllPaymentsDetailed()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                   /* string query = @"
                        SELECT 
                            p.PaymentID,
                            p.ReceiptNumber,
                            p.PaymentDate,
                            p.Amount,
                            p.PaymentMethod as PaymentMethod,
                            ISNULL(pt.Name, p.PaymentMethod) AS PaymentTypeName,
                            p.TransactionID,
                            p.Notes,
                            i.InvoiceID,
                            i.InvoiceNumber,
                            i.TotalAmount AS InvoiceTotal,
                            s.StudentID,
                            (s.FirstName + ' ' + s.LastName) AS StudentName,
                            s.AdmissionNo,
                            ISNULL(u.Username, 'Admin') AS ReceivedBy
                        FROM Payment p
                        INNER JOIN Invoice i ON p.InvoiceID = i.InvoiceID
                        INNER JOIN Student s ON i.StudentID = s.StudentID
                        LEFT JOIN PaymentType pt ON p.PaymentTypeID = pt.PaymentTypeID
                        LEFT JOIN [User] u ON p.CreatedBy = u.UserID
                        ORDER BY p.PaymentDate DESC";*/
                    string query = @"
                         SELECT 
                            p.PaymentID,
                            p.ReceiptNumber,
                            p.PaymentDate,
                            p.Amount,
                            p.PaymentMethod as PaymentMethod,
                            ISNULL(pt.Name, p.PaymentMethod) AS PaymentTypeName,
                            p.TransactionID,
                            p.Notes,
                            i.InvoiceID,
                            i.InvoiceNumber,
                            i.TotalAmount AS InvoiceTotal,
                            s.StudentID,
                            (s.FirstName + ' ' + s.LastName) AS StudentName,
                            s.AdmissionNo
                        FROM Payment p
                        INNER JOIN Invoice i ON p.InvoiceID = i.InvoiceID
                        INNER JOIN Student s ON i.StudentID = s.StudentID
                        LEFT JOIN PaymentType pt ON p.PaymentTypeID = pt.PaymentTypeID
                       
                        ORDER BY p.PaymentDate DESC";
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

        public static bool GetPaymentStatistics(ref decimal totalCollected, ref decimal todayCollected, ref decimal monthCollected, ref int paymentCount)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            ISNULL(SUM(Amount), 0) AS TotalCollected,
                            ISNULL(SUM(CASE WHEN CAST(PaymentDate AS DATE) = CAST(GETDATE() AS DATE) THEN Amount ELSE 0 END), 0) AS TodayCollected,
                            ISNULL(SUM(CASE WHEN MONTH(PaymentDate) = MONTH(GETDATE()) AND YEAR(PaymentDate) = YEAR(GETDATE()) THEN Amount ELSE 0 END), 0) AS MonthCollected,
                            COUNT(*) AS PaymentCount
                        FROM Payment";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                totalCollected = Convert.ToDecimal(reader["TotalCollected"]);
                                todayCollected = Convert.ToDecimal(reader["TodayCollected"]);
                                monthCollected = Convert.ToDecimal(reader["MonthCollected"]);
                                paymentCount = Convert.ToInt32(reader["PaymentCount"]);
                                isSuccess = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return isSuccess;
        }

        public static DataTable GetPaymentReceiptDetails(int paymentID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            p.PaymentID,
                            p.ReceiptNumber,
                            p.PaymentDate,
                            p.Amount,
                            p.PaymentMethod,
                            ISNULL(pt.Name, p.PaymentMethod) AS PaymentTypeName,
                            p.TransactionID,
                            p.Notes,
                            i.InvoiceID,
                            i.InvoiceNumber,
                            i.TotalAmount AS InvoiceTotal,
                            ISNULL((SELECT SUM(p2.Amount) FROM Payment p2 WHERE p2.InvoiceID = i.InvoiceID), 0) AS TotalPaidOnInvoice,
                            i.TotalAmount - ISNULL((SELECT SUM(p2.Amount) FROM Payment p2 WHERE p2.InvoiceID = i.InvoiceID), 0) AS BalanceRemaining,
                            s.StudentID,
                            (s.FirstName + ' ' + s.LastName) AS StudentName,
                            s.AdmissionNo,
                            ay.YearName AS AcademicYear,
                            ISNULL(u.Username, 'Admin') AS ReceivedBy
                        FROM Payment p
                        INNER JOIN Invoice i ON p.InvoiceID = i.InvoiceID
                        INNER JOIN Student s ON i.StudentID = s.StudentID
                        INNER JOIN AcademicYear ay ON i.AcademicYearID = ay.AcademicYearID
                        LEFT JOIN PaymentType pt ON p.PaymentTypeID = pt.PaymentTypeID
                        LEFT JOIN [User] u ON p.CreatedBy = u.UserID
                        WHERE p.PaymentID = @PaymentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", paymentID);
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
    
        // Get next sequential receipt number (concurrency-safe)
        public static string GetNextReceiptNumber()
        {
            string receiptNumber = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        DECLARE @NextNum INT;
                        SELECT @NextNum = ISNULL(MAX(
                            CASE WHEN ISNUMERIC(RIGHT(ReceiptNumber, 4)) = 1 
                                 THEN CAST(RIGHT(ReceiptNumber, 4) AS INT) 
                                 ELSE 0 END
                        ), 0) + 1
                        FROM Payment
                        WHERE ReceiptNumber LIKE 'REC-' + FORMAT(GETDATE(), 'yyyyMM') + '-%';
                        SELECT 'REC-' + FORMAT(GETDATE(), 'yyyyMM') + '-' + RIGHT('0000' + CAST(@NextNum AS VARCHAR(10)), 4)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                            receiptNumber = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
                receiptNumber = $"REC-{DateTime.Now:yyyyMM}-{new Random().Next(1000,9999):D4}";
            }
            return receiptNumber;
        }

}
}