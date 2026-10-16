"""
Phase 3: Append missing DAL/BLL methods for Screens 25-30
"""
import re

BASE = r"c:\Users\Eng.Hafed\Desktop\School Management System"
DAL = BASE + r"\SchoolManagementSystemDataAccessLayer"
BLL = BASE + r"\SchoolManagementSystemBusinessLayer"

def append_to_class(filepath, code_to_append):
    """Insert code before the last two closing braces of the file."""
    with open(filepath, 'r', encoding='utf-8-sig') as f:
        content = f.read()
    
    # Find last two closing braces
    last_brace = content.rfind('}')
    second_last_brace = content.rfind('}', 0, last_brace)
    
    if second_last_brace == -1:
        print(f"  ERROR: Could not find insertion point in {filepath}")
        return
    
    # Check if method already exists (use first method name as marker)
    first_line = code_to_append.strip().split('\n')[0].strip()
    marker = ""
    for word in first_line.split():
        if '(' in word:
            marker = word.split('(')[0]
            break
    
    if marker and marker in content:
        print(f"  SKIP: {marker} already exists in {filepath}")
        return
    
    new_content = content[:second_last_brace] + code_to_append + "\n" + content[second_last_brace:]
    
    with open(filepath, 'w', encoding='utf-8') as f:
        f.write(new_content)
    print(f"  OK: Appended to {filepath}")


# =====================================================================
# 1. clsDAInvoice — GetInvoiceDetailed + GetAllInvoicesDetailed + GetTotalPaidByInvoiceID
# =====================================================================
print("\n1. clsDAInvoice extensions...")
append_to_class(f"{DAL}\\clsDAInvoice.cs", """
        public static DataTable GetInvoiceDetailed(int invoiceID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            i.InvoiceID, i.InvoiceNumber,
                            i.StudentID, (s.FirstName + ' ' + s.LastName) AS StudentName, s.AdmissionNumber,
                            i.AcademicYearID, ay.YearName AS AcademicYear,
                            i.FeeStructureID, fs.Description AS FeeDescription,
                            i.IssueDate, i.DueDate,
                            i.Subtotal, i.DiscountAmount, i.TaxAmount, i.TotalAmount,
                            i.Status, i.CreatedBy,
                            ISNULL((SELECT SUM(p.Amount) FROM Payment p WHERE p.InvoiceID = i.InvoiceID), 0) AS PaidAmount,
                            i.TotalAmount - ISNULL((SELECT SUM(p.Amount) FROM Payment p WHERE p.InvoiceID = i.InvoiceID), 0) AS RemainingAmount
                        FROM Invoice i
                        INNER JOIN Student s ON i.StudentID = s.StudentID
                        INNER JOIN AcademicYear ay ON i.AcademicYearID = ay.AcademicYearID
                        INNER JOIN FeeStructure fs ON i.FeeStructureID = fs.FeeStructureID
                        WHERE i.InvoiceID = @InvoiceID";
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

        public static DataTable GetAllInvoicesDetailed()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
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
                        ORDER BY i.IssueDate DESC";
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
""")


# =====================================================================
# 2. clsDAPayment — GetPaymentsByInvoiceID + RecordPaymentWithTransaction
# =====================================================================
print("2. clsDAPayment extensions...")
append_to_class(f"{DAL}\\clsDAPayment.cs", """
        public static DataTable GetPaymentsByInvoiceID(int invoiceID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            p.PaymentID, p.ReceiptNumber, p.PaymentDate, p.Amount,
                            pt.Name AS PaymentTypeName,
                            p.Notes,
                            u.Username AS RecordedBy
                        FROM Payment p
                        INNER JOIN PaymentType pt ON p.PaymentTypeID = pt.PaymentTypeID
                        LEFT JOIN [User] u ON p.CreatedBy = u.UserID
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
""")


# =====================================================================
# 3. clsDAPaymentType — IsPaymentTypeUsed
# =====================================================================
print("3. clsDAPaymentType extensions...")
append_to_class(f"{DAL}\\clsDAPaymentType.cs", """
        public static bool IsPaymentTypeUsed(int paymentTypeID)
        {
            bool isUsed = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Payment WHERE PaymentTypeID = @PaymentTypeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentTypeID", paymentTypeID);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        isUsed = (result != null);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return isUsed;
        }
""")


# =====================================================================
# 4. clsDAUser — GetAllUsersDetailed + IsUsernameExist + IsEmailExist
# =====================================================================
print("4. clsDAUser extensions...")
append_to_class(f"{DAL}\\clsDAUser.cs", """
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
""")


# =====================================================================
# 5. clsDAStudentParent — IsParentOfStudent
# =====================================================================
print("5. clsDAStudentParent extensions...")
append_to_class(f"{DAL}\\clsDAStudentParent.cs", """
        public static bool IsParentOfStudent(int parentID, int studentID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM StudentParent WHERE ParentID = @ParentID AND StudentID = @StudentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ParentID", parentID);
                        command.Parameters.AddWithValue("@StudentID", studentID);
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
""")


# =====================================================================
# 6. clsDAGrade — GetGradesByStudentAndYear (for report)
# =====================================================================
print("6. clsDAGrade extensions...")
append_to_class(f"{DAL}\\clsDAGrade.cs", """
        public static DataTable GetGradesByStudentAndYear(int studentID, int academicYearID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            g.GradeID, c.Name AS CourseName, et.Name AS ExamType,
                            g.GradeValue, g.OutOfValue,
                            CASE WHEN g.OutOfValue > 0 THEN ROUND((g.GradeValue / g.OutOfValue) * 100, 2) ELSE 0 END AS Percentage
                        FROM Grade g
                        INNER JOIN Course c ON g.CourseID = c.CourseID
                        INNER JOIN ExamType et ON g.ExamTypeID = et.ExamTypeID
                        WHERE g.StudentID = @StudentID AND g.AcademicYearID = @AcademicYearID
                        ORDER BY c.Name, et.Name";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
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
""")


# =====================================================================
# 7. clsDAAttendance — GetAttendanceSummaryByStudent
# =====================================================================
print("7. clsDAAttendance extensions...")
append_to_class(f"{DAL}\\clsDAAttendance.cs", """
        public static DataTable GetAttendanceSummaryByStudent(int studentID, int academicYearID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            COUNT(*) AS TotalSessions,
                            SUM(CASE WHEN a.Status = 'Present' THEN 1 ELSE 0 END) AS PresentCount,
                            SUM(CASE WHEN a.Status = 'Absent' THEN 1 ELSE 0 END) AS AbsentCount,
                            SUM(CASE WHEN a.Status = 'Late' THEN 1 ELSE 0 END) AS LateCount,
                            CASE WHEN COUNT(*) > 0 
                                THEN ROUND(CAST(SUM(CASE WHEN a.Status = 'Present' OR a.Status = 'Late' THEN 1 ELSE 0 END) AS FLOAT) / COUNT(*) * 100, 2) 
                                ELSE 0 END AS AttendancePercentage
                        FROM Attendance a
                        INNER JOIN Schedule sc ON a.ScheduleID = sc.ScheduleID
                        WHERE a.StudentID = @StudentID AND sc.AcademicYearID = @AcademicYearID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
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
""")


# =====================================================================
# 8. clsDAStudentEnrollment — GetEnrollmentsByStudentID
# =====================================================================
print("8. clsDAStudentEnrollment extensions...")
append_to_class(f"{DAL}\\clsDAStudentEnrollment.cs", """
        public static DataTable GetEnrollmentsByStudentID(int studentID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            se.EnrollmentID, ay.YearName AS AcademicYear,
                            cl.Name AS ClassName, se.EnrollmentDate, se.Status
                        FROM StudentEnrollment se
                        INNER JOIN AcademicYear ay ON se.AcademicYearID = ay.AcademicYearID
                        INNER JOIN Class cl ON se.ClassID = cl.ClassID
                        WHERE se.StudentID = @StudentID
                        ORDER BY ay.StartDate DESC";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);
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
""")


# =====================================================================
# BLL WRAPPERS
# =====================================================================

# 9. clsInvoice BLL
print("\n9. clsInvoice BLL extensions...")
append_to_class(f"{BLL}\\clsInvoice.cs", """
        public static DataTable GetInvoiceDetailed(int invoiceID) => clsDAInvoice.GetInvoiceDetailed(invoiceID);
        public static DataTable GetAllInvoicesDetailed() => clsDAInvoice.GetAllInvoicesDetailed();
        public static decimal GetTotalPaidByInvoiceID(int invoiceID) => clsDAInvoice.GetTotalPaidByInvoiceID(invoiceID);
        public static bool UpdateInvoiceStatus(int invoiceID, string status) => clsDAInvoice.UpdateInvoiceStatus(invoiceID, status);
""")

# 10. clsPayment BLL
print("10. clsPayment BLL extensions...")
append_to_class(f"{BLL}\\clsPayment.cs", """
        public static DataTable GetPaymentsByInvoiceID(int invoiceID) => clsDAPayment.GetPaymentsByInvoiceID(invoiceID);
        
        public static int RecordPaymentWithTransaction(int invoiceID, DateTime paymentDate, decimal amount,
            string paymentMethod, int paymentTypeID, string transactionID, string receiptNumber,
            string notes, int createdBy, out string errorMessage)
        {
            return clsDAPayment.RecordPaymentWithTransaction(invoiceID, paymentDate, amount,
                paymentMethod, paymentTypeID, transactionID, receiptNumber, notes, createdBy, out errorMessage);
        }
""")

# 11. clsPaymentType BLL
print("11. clsPaymentType BLL extensions...")
append_to_class(f"{BLL}\\clsPaymentType.cs", """
        public static bool IsPaymentTypeUsed(int paymentTypeID) => clsDAPaymentType.IsPaymentTypeUsed(paymentTypeID);
""")

# 12. clsUser BLL
print("12. clsUser BLL extensions...")
append_to_class(f"{BLL}\\clsUser.cs", """
        public static DataTable GetAllUsersDetailed() => clsDAUser.GetAllUsersDetailed();
        public static bool IsUsernameExist(string username, int excludeUserID = -1) => clsDAUser.IsUsernameExist(username, excludeUserID);
        public static bool IsEmailExist(string email, int excludeUserID = -1) => clsDAUser.IsEmailExist(email, excludeUserID);
        public static bool UpdateUserStatus(int userID, string status) => clsDAUser.UpdateUserStatus(userID, status);
        public static bool ResetPassword(int userID, string newPasswordHash) => clsDAUser.ResetPassword(userID, newPasswordHash);
        public static bool IsReferenceAlreadyLinked(string userType, int referenceID, int excludeUserID = -1) => clsDAUser.IsReferenceAlreadyLinked(userType, referenceID, excludeUserID);
""")

# 13. clsStudentParent BLL
print("13. clsStudentParent BLL extensions...")
append_to_class(f"{BLL}\\clsStudentParent.cs", """
        public static bool IsParentOfStudent(int parentID, int studentID) => clsDAStudentParent.IsParentOfStudent(parentID, studentID);
""")

# 14. clsGrade BLL
print("14. clsGrade BLL extensions...")
append_to_class(f"{BLL}\\clsGrade.cs", """
        public static DataTable GetGradesByStudentAndYear(int studentID, int academicYearID) => clsDAGrade.GetGradesByStudentAndYear(studentID, academicYearID);
""")

# 15. clsAttendance BLL
print("15. clsAttendance BLL extensions...")
append_to_class(f"{BLL}\\clsAttendance.cs", """
        public static DataTable GetAttendanceSummaryByStudent(int studentID, int academicYearID) => clsDAAttendance.GetAttendanceSummaryByStudent(studentID, academicYearID);
""")

# 16. clsStudentEnrollment BLL
print("16. clsStudentEnrollment BLL extensions...")
append_to_class(f"{BLL}\\clsStudentEnrollment.cs", """
        public static DataTable GetEnrollmentsByStudentID(int studentID) => clsDAStudentEnrollment.GetEnrollmentsByStudentID(studentID);
""")

print("\n✅ Phase 3 DAL/BLL extensions completed!")
