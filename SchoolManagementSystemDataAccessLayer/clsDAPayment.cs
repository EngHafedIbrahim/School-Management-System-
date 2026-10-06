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
    }
}
