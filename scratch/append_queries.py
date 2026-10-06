import os

dal_dir = r"C:\Users\Eng.Hafed\Desktop\School Management System\SchoolManagementSystemDataAccessLayer"
bll_dir = r"C:\Users\Eng.Hafed\Desktop\School Management System\SchoolManagementSystemBusinessLayer"

def append_to_class(filepath, methods_code):
    with open(filepath, "r", encoding="utf-8") as f:
        content = f.read()
    
    # Insert right before the last closing brace of the class
    idx = content.rfind("}")
    if idx != -1:
        # Find the second to last closing brace if there is a namespace
        idx2 = content.rfind("}", 0, idx)
        if idx2 != -1:
            content = content[:idx2] + methods_code + "\n" + content[idx2:]
            with open(filepath, "w", encoding="utf-8") as f:
                f.write(content)
            print(f"Updated {os.path.basename(filepath)}")

# 1. clsDAStudent & clsStudent
da_student_methods = """
        public static DataTable GetStudentsDetailed()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            s.StudentID,
                            s.AdmissionNo,
                            (s.FirstName + ' ' + s.LastName) AS FullName,
                            ISNULL(g.Name, 'N/A') AS Gender,
                            s.DateOfBirth,
                            s.PhoneNumber,
                            ISNULL(c.Name, 'Not Enrolled') AS CurrentClass,
                            s.HealthStatus AS Status
                        FROM [Student] s
                        LEFT JOIN [Gender] g ON s.GenderID = g.GenderID
                        LEFT JOIN [StudentEnrollment] se ON s.StudentID = se.StudentID 
                            AND se.AcademicYearID = (SELECT TOP 1 AcademicYearID FROM AcademicYear WHERE IsCurrent = 1)
                        LEFT JOIN [Class] c ON se.ClassID = c.ClassID";
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
"""

bll_student_methods = """
        public static DataTable GetStudentsDetailed() => clsDAStudent.GetStudentsDetailed();
"""

# 2. clsDAParent & clsParent
da_parent_methods = """
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
"""

bll_parent_methods = """
        public static DataTable GetAllParentsWithChildrenCount() => clsDAParent.GetAllParentsWithChildrenCount();
"""

# 3. clsDAStudentParent & clsStudentParent
da_studentparent_methods = """
        public static DataTable GetParentsByStudentID(int studentID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            sp.StudentParentID,
                            p.ParentID,
                            (p.FirstName + ' ' + p.LastName) AS ParentName,
                            p.PhoneNumber,
                            p.Email,
                            sp.Relationship,
                            sp.IsPrimaryContact
                        FROM StudentParent sp
                        INNER JOIN [Parent] p ON sp.ParentID = p.ParentID
                        WHERE sp.StudentID = @StudentID";
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

        public static DataTable GetStudentsByParentID(int parentID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            sp.StudentParentID,
                            s.StudentID,
                            (s.FirstName + ' ' + s.LastName) AS StudentName,
                            s.AdmissionNo,
                            ISNULL(c.Name, 'Not Enrolled') AS CurrentClass,
                            ISNULL(ay.YearName, 'N/A') AS AcademicYear,
                            sp.Relationship,
                            sp.IsPrimaryContact
                        FROM StudentParent sp
                        INNER JOIN [Student] s ON sp.StudentID = s.StudentID
                        LEFT JOIN StudentEnrollment se ON s.StudentID = se.StudentID 
                            AND se.AcademicYearID = (SELECT TOP 1 AcademicYearID FROM AcademicYear WHERE IsCurrent = 1)
                        LEFT JOIN Class c ON se.ClassID = c.ClassID
                        LEFT JOIN AcademicYear ay ON se.AcademicYearID = ay.AcademicYearID
                        WHERE sp.ParentID = @ParentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ParentID", parentID);
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
"""

bll_studentparent_methods = """
        public static DataTable GetParentsByStudentID(int studentID) => clsDAStudentParent.GetParentsByStudentID(studentID);
        public static DataTable GetStudentsByParentID(int parentID) => clsDAStudentParent.GetStudentsByParentID(parentID);
"""

# 4. clsDAStudentEnrollment & clsStudentEnrollment
da_enrollment_methods = """
        public static DataTable GetEnrollmentHistoryByStudentID(int studentID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            se.StudentEnrollmentID,
                            ay.YearName AS AcademicYear,
                            c.Name AS ClassName,
                            se.EnrollmentDate,
                            se.WithdrawalDate,
                            se.Status
                        FROM StudentEnrollment se
                        INNER JOIN AcademicYear ay ON se.AcademicYearID = ay.AcademicYearID
                        INNER JOIN Class c ON se.ClassID = c.ClassID
                        WHERE se.StudentID = @StudentID
                        ORDER BY ay.StartDate DESC";
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
"""

bll_enrollment_methods = """
        public static DataTable GetEnrollmentHistoryByStudentID(int studentID) => clsDAStudentEnrollment.GetEnrollmentHistoryByStudentID(studentID);
"""

# 5. clsDAAttendance & clsAttendance
da_attendance_methods = """
        public static DataTable GetAttendanceByStudentID(int studentID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            a.AttendanceID,
                            a.Date,
                            a.Status,
                            a.Note
                        FROM Attendance a
                        WHERE a.StudentID = @StudentID
                        ORDER BY a.Date DESC";
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
"""

bll_attendance_methods = """
        public static DataTable GetAttendanceByStudentID(int studentID) => clsDAAttendance.GetAttendanceByStudentID(studentID);
"""

# 6. clsDAGrade & clsGrade
da_grade_methods = """
        public static DataTable GetGradesByStudentID(int studentID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            g.GradeID,
                            c.Name AS CourseName,
                            et.Name AS ExamTypeName,
                            g.GradeValue,
                            g.OutOfValue,
                            ay.YearName AS AcademicYear
                        FROM Grade g
                        INNER JOIN Course c ON g.CourseID = c.CourseID
                        INNER JOIN ExamType et ON g.ExamTypeID = et.ExamTypeID
                        INNER JOIN AcademicYear ay ON g.AcademicYearID = ay.AcademicYearID
                        WHERE g.StudentID = @StudentID";
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
"""

bll_grade_methods = """
        public static DataTable GetGradesByStudentID(int studentID) => clsDAGrade.GetGradesByStudentID(studentID);
"""

# 7. clsDAInvoice & clsInvoice
da_invoice_methods = """
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
"""

bll_invoice_methods = """
        public static DataTable GetInvoicesByStudentID(int studentID) => clsDAInvoice.GetInvoicesByStudentID(studentID);
"""

append_to_class(os.path.join(dal_dir, "clsDAStudent.cs"), da_student_methods)
append_to_class(os.path.join(bll_dir, "clsStudent.cs"), bll_student_methods)

append_to_class(os.path.join(dal_dir, "clsDAParent.cs"), da_parent_methods)
append_to_class(os.path.join(bll_dir, "clsParent.cs"), bll_parent_methods)

append_to_class(os.path.join(dal_dir, "clsDAStudentParent.cs"), da_studentparent_methods)
append_to_class(os.path.join(bll_dir, "clsStudentParent.cs"), bll_studentparent_methods)

append_to_class(os.path.join(dal_dir, "clsDAStudentEnrollment.cs"), da_enrollment_methods)
append_to_class(os.path.join(bll_dir, "clsStudentEnrollment.cs"), bll_enrollment_methods)

append_to_class(os.path.join(dal_dir, "clsDAAttendance.cs"), da_attendance_methods)
append_to_class(os.path.join(bll_dir, "clsAttendance.cs"), bll_attendance_methods)

append_to_class(os.path.join(dal_dir, "clsDAGrade.cs"), da_grade_methods)
append_to_class(os.path.join(bll_dir, "clsGrade.cs"), bll_grade_methods)

append_to_class(os.path.join(dal_dir, "clsDAInvoice.cs"), da_invoice_methods)
append_to_class(os.path.join(bll_dir, "clsInvoice.cs"), bll_invoice_methods)

print("All extensions appended successfully.")
