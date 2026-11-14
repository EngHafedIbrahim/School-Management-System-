using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDAAttendance
    {
        public static bool Find(int AttendanceID, ref int StudentID, ref int ClassID, ref int SessionID, ref DateTime Date, ref string Status, ref string Note, ref int CreatedBy, ref DateTime CreatedAt)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Attendance WHERE AttendanceID = @AttendanceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AttendanceID", AttendanceID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                                        StudentID = (int)reader["StudentID"];
                                ClassID = (int)reader["ClassID"];
                                SessionID = (int)reader["SessionID"];
                                Date = (DateTime)reader["Date"];
                                Status = reader["Status"] != DBNull.Value ? (string)reader["Status"] : "";
                                Note = reader["Note"] != DBNull.Value ? (string)reader["Note"] : "";
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

        public static int AddNewAttendance(int StudentID, int ClassID, int SessionID, DateTime Date, string Status, string Note, int CreatedBy, DateTime CreatedAt)
        {
            int AttendanceID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Attendance (StudentID, ClassID, SessionID, Date, Status, Note, CreatedBy, CreatedAt) 
                                     VALUES (@StudentID, @ClassID, @SessionID, @Date, @Status, @Note, @CreatedBy, @CreatedAt);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@ClassID", ClassID);
                        command.Parameters.AddWithValue("@SessionID", SessionID);
                        command.Parameters.AddWithValue("@Date", Date);
                        command.Parameters.AddWithValue("@Status", (object)Status ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Note", (object)Note ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            AttendanceID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return AttendanceID;
        }

        public static bool UpdateAttendance(int AttendanceID, int StudentID, int ClassID, int SessionID, DateTime Date, string Status, string Note, int CreatedBy, DateTime CreatedAt)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [Attendance] 
                                     SET StudentID = @StudentID, ClassID = @ClassID, SessionID = @SessionID, Date = @Date, Status = @Status, Note = @Note, CreatedBy = @CreatedBy, CreatedAt = @CreatedAt
                                     WHERE AttendanceID = @AttendanceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AttendanceID", AttendanceID);
                                                command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@ClassID", ClassID);
                        command.Parameters.AddWithValue("@SessionID", SessionID);
                        command.Parameters.AddWithValue("@Date", Date);
                        command.Parameters.AddWithValue("@Status", (object)Status ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Note", (object)Note ?? DBNull.Value);
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

        public static bool DeleteAttendance(int AttendanceID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM Attendance WHERE AttendanceID = @AttendanceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AttendanceID", AttendanceID);
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

        public static DataTable GetAllAttendances()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Attendance";
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

        public static bool IsAttendanceExist(int AttendanceID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Attendance WHERE AttendanceID = @AttendanceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AttendanceID", AttendanceID);
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


        // FIXED: Corrected column names (Date instead of AttendanceDate, Note instead of Remarks)
        // FIXED: Removed invalid JOIN through Schedule/ClassCourse — use direct ClassID filter
        public static DataTable GetAttendanceByClassID(int classID)
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
                            a.SessionID,
                            (s.FirstName + ' ' + s.LastName) AS StudentName,
                            s.AdmissionNo,
                            a.Status,
                            a.Note
                        FROM Attendance a
                        INNER JOIN [Student] s ON a.StudentID = s.StudentID
                        WHERE a.ClassID = @ClassID
                        ORDER BY a.Date DESC, a.SessionID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassID", classID);
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


        // FIXED: Replaced invalid JOIN (Schedule.ScheduleID) with StudentEnrollment for AcademicYear filtering
        // ADDED: ExcusedCount column
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
                            SUM(CASE WHEN a.Status = 'Excused' THEN 1 ELSE 0 END) AS ExcusedCount,
                            CASE WHEN COUNT(*) > 0 
                                THEN ROUND(CAST(SUM(CASE WHEN a.Status IN ('Present','Late') THEN 1 ELSE 0 END) AS FLOAT) / COUNT(*) * 100, 2) 
                                ELSE 0 END AS AttendancePercentage
                        FROM Attendance a
                        INNER JOIN StudentEnrollment se 
                            ON a.StudentID = se.StudentID AND a.ClassID = se.ClassID
                        WHERE a.StudentID = @StudentID 
                            AND se.AcademicYearID = @AcademicYearID";
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

        public static DataTable GetClassAttendanceByDateAndSession(int classID, DateTime date, int sessionID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            se.StudentID,
                            (s.FirstName + ' ' + s.LastName) AS StudentName,
                            s.AdmissionNo,
                            ISNULL(a.AttendanceID, -1) AS AttendanceID,
                            ISNULL(a.Status, 'Present') AS Status,
                            ISNULL(a.Note, '') AS Note
                        FROM StudentEnrollment se
                        INNER JOIN Student s ON se.StudentID = s.StudentID
                        LEFT JOIN Attendance a ON a.StudentID = se.StudentID 
                                              AND a.ClassID = se.ClassID 
                                              AND CAST(a.Date AS DATE) = CAST(@Date AS DATE)
                                              AND a.SessionID = @SessionID
                        WHERE se.ClassID = @ClassID AND se.Status = 'Active'
                        ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassID", classID);
                        command.Parameters.AddWithValue("@Date", date.Date);
                        command.Parameters.AddWithValue("@SessionID", sessionID);
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

        public static bool SaveBulkAttendance(DataTable dtAttendanceRecords, int createdBy)
        {
            if (dtAttendanceRecords == null || dtAttendanceRecords.Rows.Count == 0)
                return false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            foreach (DataRow row in dtAttendanceRecords.Rows)
                            {
                                int attendanceID = Convert.ToInt32(row["AttendanceID"]);
                                int studentID = Convert.ToInt32(row["StudentID"]);
                                int classID = Convert.ToInt32(row["ClassID"]);
                                int sessionID = Convert.ToInt32(row["SessionID"]);
                                DateTime date = Convert.ToDateTime(row["Date"]);
                                string status = row["Status"].ToString();
                                string note = row["Note"] != DBNull.Value ? row["Note"].ToString() : "";

                                if (attendanceID > 0)
                                {
                                    // Update existing record
                                    string updateQuery = @"
                                        UPDATE Attendance 
                                        SET Status = @Status, Note = @Note, Date = @Date
                                        WHERE AttendanceID = @AttendanceID";
                                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@Status", status);
                                        cmd.Parameters.AddWithValue("@Note", note);
                                        cmd.Parameters.AddWithValue("@Date", date);
                                        cmd.Parameters.AddWithValue("@AttendanceID", attendanceID);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    // Delete any potential orphan for same student, session, date then Insert
                                    string deleteQuery = @"
                                        DELETE FROM Attendance 
                                        WHERE StudentID = @StudentID AND ClassID = @ClassID 
                                          AND CAST(Date AS DATE) = CAST(@Date AS DATE) AND SessionID = @SessionID";
                                    using (SqlCommand cmdDel = new SqlCommand(deleteQuery, connection, transaction))
                                    {
                                        cmdDel.Parameters.AddWithValue("@StudentID", studentID);
                                        cmdDel.Parameters.AddWithValue("@ClassID", classID);
                                        cmdDel.Parameters.AddWithValue("@Date", date.Date);
                                        cmdDel.Parameters.AddWithValue("@SessionID", sessionID);
                                        cmdDel.ExecuteNonQuery();
                                    }

                                    string insertQuery = @"
                                        INSERT INTO Attendance (StudentID, ClassID, SessionID, Date, Status, Note, CreatedBy, CreatedAt)
                                        VALUES (@StudentID, @ClassID, @SessionID, @Date, @Status, @Note, @CreatedBy, GETDATE())";
                                    using (SqlCommand cmdIns = new SqlCommand(insertQuery, connection, transaction))
                                    {
                                        cmdIns.Parameters.AddWithValue("@StudentID", studentID);
                                        cmdIns.Parameters.AddWithValue("@ClassID", classID);
                                        cmdIns.Parameters.AddWithValue("@SessionID", sessionID);
                                        cmdIns.Parameters.AddWithValue("@Date", date);
                                        cmdIns.Parameters.AddWithValue("@Status", status);
                                        cmdIns.Parameters.AddWithValue("@Note", note);
                                        cmdIns.Parameters.AddWithValue("@CreatedBy", createdBy);
                                        cmdIns.ExecuteNonQuery();
                                    }
                                }
                            }

                            transaction.Commit();
                            return true;
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
                return false;
            }
        }

        // NEW: Targeted duplicate check — replaces the expensive full-table scan in BLL
        public static bool IsDuplicateAttendance(int studentID, int sessionID, DateTime date, int excludeAttendanceID)
        {
            bool isDuplicate = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT TOP 1 1 FROM Attendance 
                                     WHERE StudentID = @StudentID 
                                       AND SessionID = @SessionID 
                                       AND CAST(Date AS DATE) = CAST(@Date AS DATE)
                                       AND AttendanceID <> @ExcludeAttendanceID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.Parameters.AddWithValue("@SessionID", sessionID);
                        command.Parameters.AddWithValue("@Date", date.Date);
                        command.Parameters.AddWithValue("@ExcludeAttendanceID", excludeAttendanceID);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        isDuplicate = (result != null);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return isDuplicate;
        }
    }
}
