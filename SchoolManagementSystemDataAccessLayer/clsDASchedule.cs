using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Timers;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDASchedule
    {
        public static bool Find(int ScheduleID, ref int ClassCourseID, ref string DayOfWeek, ref TimeSpan StartTime, ref TimeSpan EndTime, ref int RoomID, ref int AcademicYearID, ref DateTime CreatedAt, ref DateTime UpdatedAt)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Schedule WHERE ScheduleID = @ScheduleID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ScheduleID", ScheduleID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                                                ClassCourseID = (int)reader["ClassCourseID"];
                                DayOfWeek = reader["DayOfWeek"] != DBNull.Value ? (string)reader["DayOfWeek"] : "";
                                StartTime = (TimeSpan)reader["StartTime"];
                                EndTime = (TimeSpan)reader["EndTime"];
                                RoomID = (int)reader["RoomID"];
                                AcademicYearID = (int)reader["AcademicYearID"];
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

        public static int AddNewSchedule(int ClassCourseID, string DayOfWeek, TimeSpan StartTime, TimeSpan EndTime, int RoomID, int AcademicYearID, DateTime CreatedAt, DateTime UpdatedAt)
        {
            int ScheduleID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Schedule (ClassCourseID, DayOfWeek, StartTime, EndTime, RoomID, AcademicYearID, CreatedAt, UpdatedAt) 
                                     VALUES (@ClassCourseID, @DayOfWeek, @StartTime, @EndTime, @RoomID, @AcademicYearID, @CreatedAt, @UpdatedAt);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@ClassCourseID", ClassCourseID);
                        command.Parameters.AddWithValue("@DayOfWeek", (object)DayOfWeek ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StartTime", StartTime);
                        command.Parameters.AddWithValue("@EndTime", EndTime);
                        command.Parameters.AddWithValue("@RoomID", RoomID);
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ScheduleID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return ScheduleID;
        }

        public static bool UpdateSchedule(int ScheduleID, int ClassCourseID, string DayOfWeek, TimeSpan StartTime, TimeSpan EndTime, int RoomID, int AcademicYearID, DateTime CreatedAt, DateTime UpdatedAt)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [Schedule] 
                                     SET ClassCourseID = @ClassCourseID, DayOfWeek = @DayOfWeek, StartTime = @StartTime, EndTime = @EndTime, RoomID = @RoomID, AcademicYearID = @AcademicYearID, CreatedAt = @CreatedAt, UpdatedAt = @UpdatedAt
                                     WHERE ScheduleID = @ScheduleID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ScheduleID", ScheduleID);
                                                command.Parameters.AddWithValue("@ClassCourseID", ClassCourseID);
                        command.Parameters.AddWithValue("@DayOfWeek", (object)DayOfWeek ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StartTime", StartTime);
                        command.Parameters.AddWithValue("@EndTime", EndTime);
                        command.Parameters.AddWithValue("@RoomID", RoomID);
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
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

        public static bool DeleteSchedule(int ScheduleID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM Schedule WHERE ScheduleID = @ScheduleID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ScheduleID", ScheduleID);
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

        public static DataTable GetAllSchedules()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Schedule";
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

        public static bool IsScheduleExist(int ScheduleID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Schedule WHERE ScheduleID = @ScheduleID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ScheduleID", ScheduleID);
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
    
        public static DataTable GetSchedulesByClassID(int classID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            s.ScheduleID,
                            s.DayOfWeek,
                            s.StartTime,
                            s.EndTime,
                            c.Name AS CourseName,
                            (t.FirstName + ' ' + t.LastName) AS TeacherName,
                            r.Name AS RoomName,
                            ay.YearName AS AcademicYear
                        FROM Schedule s
                        INNER JOIN ClassCourse cc ON s.ClassCourseID = cc.ClassCourseID
                        INNER JOIN Course c ON cc.CourseID = c.CourseID
                        INNER JOIN Teacher t ON cc.TeacherID = t.TeacherID
                        INNER JOIN Room r ON s.RoomID = r.RoomID
                        INNER JOIN AcademicYear ay ON s.AcademicYearID = ay.AcademicYearID
                        WHERE cc.ClassID = @ClassID
                        ORDER BY CASE s.DayOfWeek 
                            WHEN 'Sunday' THEN 1 WHEN 'Monday' THEN 2 WHEN 'Tuesday' THEN 3
                            WHEN 'Wednesday' THEN 4 WHEN 'Thursday' THEN 5 WHEN 'Friday' THEN 6 WHEN 'Saturday' THEN 7
                            ELSE 8 END, s.StartTime";
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

        public static DataTable GetSchedulesByTeacherID(int teacherID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            s.ScheduleID,
                            s.DayOfWeek,
                            s.StartTime,
                            s.EndTime,
                            cl.Name AS ClassName,
                            c.Name AS CourseName,
                            r.Name AS RoomName,
                            ay.YearName AS AcademicYear
                        FROM Schedule s
                        INNER JOIN ClassCourse cc ON s.ClassCourseID = cc.ClassCourseID
                        INNER JOIN Class cl ON cc.ClassID = cl.ClassID
                        INNER JOIN Course c ON cc.CourseID = c.CourseID
                        INNER JOIN Room r ON s.RoomID = r.RoomID
                        INNER JOIN AcademicYear ay ON s.AcademicYearID = ay.AcademicYearID
                        WHERE cc.TeacherID = @TeacherID
                        ORDER BY CASE s.DayOfWeek 
                            WHEN 'Sunday' THEN 1 WHEN 'Monday' THEN 2 WHEN 'Tuesday' THEN 3
                            WHEN 'Wednesday' THEN 4 WHEN 'Thursday' THEN 5 WHEN 'Friday' THEN 6 WHEN 'Saturday' THEN 7
                            ELSE 8 END, s.StartTime";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TeacherID", teacherID);
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

        public static DataTable GetAllSchedulesDetailed()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            s.ScheduleID,
                            s.ClassCourseID,
                            cl.ClassID,
                            cl.Name AS ClassName,
                            c.CourseID,
                            c.Name AS CourseName,
                            t.TeacherID,
                            (t.FirstName + ' ' + t.LastName) AS TeacherName,
                            r.RoomID,
                            r.Name AS RoomName,
                            s.AcademicYearID,
                            ay.YearName AS AcademicYear,
                            s.DayOfWeek,
                            s.StartTime,
                            s.EndTime
                        FROM Schedule s
                        INNER JOIN ClassCourse cc ON s.ClassCourseID = cc.ClassCourseID
                        INNER JOIN Class cl ON cc.ClassID = cl.ClassID
                        INNER JOIN Course c ON cc.CourseID = c.CourseID
                        INNER JOIN Teacher t ON cc.TeacherID = t.TeacherID
                        INNER JOIN Room r ON s.RoomID = r.RoomID
                        INNER JOIN AcademicYear ay ON s.AcademicYearID = ay.AcademicYearID
                        ORDER BY ay.StartDate DESC, CASE s.DayOfWeek 
                            WHEN 'Sunday' THEN 1 WHEN 'Monday' THEN 2 WHEN 'Tuesday' THEN 3
                            WHEN 'Wednesday' THEN 4 WHEN 'Thursday' THEN 5 WHEN 'Friday' THEN 6 WHEN 'Saturday' THEN 7
                            ELSE 8 END, s.StartTime";
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

        /// <summary>
        /// Old method that contain two queries and two connections,
        /// replaced by the new method above
        /// </summary>
        /// <param name="currentScheduleID"></param>
        /// <param name="academicYearID"></param>
        /// <param name="dayOfWeek"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="roomID"></param>
        /// <param name="classCourseID"></param>
        /// <param name="conflictReason"></param>
        /// <returns></returns>
        [Obsolete("Use CheckScheduleConflictNew instead.")]
        public static bool CheckScheduleConflict(int? currentScheduleID, int academicYearID, string dayOfWeek, TimeSpan startTime, TimeSpan endTime, int roomID, int classCourseID, out string conflictReason)
        {
            conflictReason = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            s.ScheduleID,
                            cl.Name AS ClassName,
                            c.Name AS CourseName,
                            (t.FirstName + ' ' + t.LastName) AS TeacherName,
                            r.Name AS RoomName,
                            s.StartTime,
                            s.EndTime,
                            s.RoomID,
                            cc.ClassID,
                            cc.TeacherID
                        FROM Schedule s
                        INNER JOIN ClassCourse cc ON s.ClassCourseID = cc.ClassCourseID
                        INNER JOIN Class cl ON cc.ClassID = cl.ClassID
                        INNER JOIN Course c ON cc.CourseID = c.CourseID
                        INNER JOIN Teacher t ON cc.TeacherID = t.TeacherID
                        INNER JOIN Room r ON s.RoomID = r.RoomID
                        WHERE s.AcademicYearID = @AcademicYearID
                          AND s.DayOfWeek = @DayOfWeek
                          AND (@CurrentScheduleID IS NULL OR s.ScheduleID <> @CurrentScheduleID)
                          AND (s.StartTime < @EndTime AND s.EndTime > @StartTime)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AcademicYearID", academicYearID);
                        command.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);
                        command.Parameters.AddWithValue("@StartTime", startTime);
                        command.Parameters.AddWithValue("@EndTime", endTime);
                        command.Parameters.AddWithValue("@CurrentScheduleID", (object)currentScheduleID ?? DBNull.Value);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Fetch target class and teacher for the current classCourseID
                            int targetClassID = -1;
                            int targetTeacherID = -1;
                            using (SqlConnection c2 = new SqlConnection(clsDataAccessSettings.ConnectionString))
                            {
                                string q2 = "SELECT ClassID, TeacherID FROM ClassCourse WHERE ClassCourseID = @CCID";
                                using (SqlCommand cmd2 = new SqlCommand(q2, c2))
                                {
                                    cmd2.Parameters.AddWithValue("@CCID", classCourseID);
                                    c2.Open();
                                    using (SqlDataReader r2 = cmd2.ExecuteReader())
                                    {
                                        if (r2.Read())
                                        {
                                            targetClassID = (int)r2["ClassID"];
                                            targetTeacherID = (int)r2["TeacherID"];
                                        }
                                    }
                                }
                            }

                            while (reader.Read())
                            {
                                int existingRoomID = (int) reader["RoomID"];
                                int existingClassID = (int)reader["ClassID"];
                                int existingTeacherID=(int)reader["TeacherID"];
                                string rName = reader["RoomName"].ToString();
                                string tName = reader["TeacherName"].ToString();
                                string clName= reader["ClassName"].ToString();
                                string timeStr = $"{((TimeSpan)reader["StartTime"]).ToString(@"hh\:mm")} - {((TimeSpan)reader["EndTime"]).ToString(@"hh\:mm")}";

                                if (existingRoomID == roomID)
                                {
                                    conflictReason = $"Room conflict: Room '{rName}' is already occupied during {timeStr} by {clName}.";
                                    return true;
                                }
                                if (existingTeacherID == targetTeacherID)
                                {
                                    conflictReason = $"Teacher conflict: Teacher '{tName}' is already assigned to {clName} during {timeStr}.";
                                    return true;
                                }
                                if (existingClassID == targetClassID)
                                {
                                    conflictReason = $"Class conflict: Class '{clName}' is already scheduled for another lesson during {timeStr}.";
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return false;
        }

        public static bool CheckScheduleConflictNew(
            int? currentScheduleID, int academicYearID, string dayOfWeek,
            TimeSpan startTime, TimeSpan endTime,
            int roomID, int classCourseID,
            out string conflictReason)
        {
            conflictReason = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                SELECT TOP 1
                    CASE 
                        WHEN s.RoomID = @RoomID THEN 'Room'
                        WHEN ccExisting.TeacherID = ccTarget.TeacherID THEN 'Teacher'
                        WHEN ccExisting.ClassID = ccTarget.ClassID THEN 'Class'
                    END AS ConflictType,
                    r.Name AS RoomName,
                    (t.FirstName + ' ' + t.LastName) AS TeacherName,
                    cl.Name AS ClassName,
                    s.StartTime,
                    s.EndTime
                FROM Schedule s
                INNER JOIN ClassCourse ccExisting ON s.ClassCourseID = ccExisting.ClassCourseID
                INNER JOIN ClassCourse ccTarget   ON ccTarget.ClassCourseID = @ClassCourseID
                INNER JOIN Class cl ON ccExisting.ClassID = cl.ClassID
                INNER JOIN Teacher t ON ccExisting.TeacherID = t.TeacherID
                INNER JOIN Room r ON s.RoomID = r.RoomID
                WHERE s.AcademicYearID = @AcademicYearID
                  AND s.DayOfWeek = @DayOfWeek
                  AND s.StartTime < @EndTime AND s.EndTime > @StartTime
                  AND (@CurrentScheduleID IS NULL OR s.ScheduleID <> @CurrentScheduleID)
                  AND (s.RoomID = @RoomID 
                       OR ccExisting.TeacherID = ccTarget.TeacherID 
                       OR ccExisting.ClassID = ccTarget.ClassID)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AcademicYearID", academicYearID);
                        command.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);
                        command.Parameters.AddWithValue("@StartTime", startTime);
                        command.Parameters.AddWithValue("@EndTime", endTime);
                        command.Parameters.AddWithValue("@RoomID", roomID);
                        command.Parameters.AddWithValue("@ClassCourseID", classCourseID);
                        command.Parameters.AddWithValue("@CurrentScheduleID", (object)currentScheduleID ?? DBNull.Value);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string conflictType = reader["ConflictType"].ToString();
                                string timeRange = $"{((TimeSpan)reader["StartTime"]):hh\\:mm} - {((TimeSpan)reader["EndTime"]):hh\\:mm}";
                                string roomName = reader["RoomName"].ToString();
                                string teacherName = reader["TeacherName"].ToString();
                                string className = reader["ClassName"].ToString();

                                conflictReason = conflictType switch
                                {
                                    "Room" =>
                                        $"Room Conflict: Room [{roomName}] is already occupied by {className} from ({timeRange}).",

                                    "Teacher" =>
                                        $"Teacher Conflict: Teacher [{teacherName}] is already assigned to {className} from ({timeRange}).",

                                    "Class" =>
                                        $"Class Conflict: Class [{className}] already has another session scheduled from ({timeRange}).",

                                    _ => $"Time Conflict: A scheduling conflict was detected from ({timeRange})."
                                };

                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }

            return false;
        }

    }
}
