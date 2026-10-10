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
                            a.AttendanceDate,
                            (s.FirstName + ' ' + s.LastName) AS StudentName,
                            s.AdmissionNo,
                            a.Status,
                            a.Remarks
                        FROM Attendance a
                        INNER JOIN [Student] s ON a.StudentID = s.StudentID
                        INNER JOIN Schedule sc ON a.ScheduleID = sc.ScheduleID
                        INNER JOIN ClassCourse cc ON sc.ClassCourseID = cc.ClassCourseID
                        WHERE cc.ClassID = @ClassID
                        ORDER BY a.AttendanceDate DESC";
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

}
}
