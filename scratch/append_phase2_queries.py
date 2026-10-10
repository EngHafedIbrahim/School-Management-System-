import os

dal_dir = r"C:\Users\Eng.Hafed\Desktop\School Management System\SchoolManagementSystemDataAccessLayer"
bll_dir = r"C:\Users\Eng.Hafed\Desktop\School Management System\SchoolManagementSystemBusinessLayer"

def append_to_class(filepath, methods_code):
    with open(filepath, "r", encoding="utf-8") as f:
        content = f.read()
    
    idx = content.rfind("}")
    if idx != -1:
        idx2 = content.rfind("}", 0, idx)
        if idx2 != -1:
            content = content[:idx2] + methods_code + "\n" + content[idx2:]
            with open(filepath, "w", encoding="utf-8") as f:
                f.write(content)
            print(f"Updated {os.path.basename(filepath)}")

# 1. clsDAStudentEnrollment & clsStudentEnrollment: GetStudentsByClassID
da_se = """
        public static DataTable GetStudentsByClassID(int classID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            se.StudentEnrollmentID,
                            se.StudentID,
                            (s.FirstName + ' ' + s.LastName) AS StudentName,
                            s.AdmissionNo,
                            s.PhoneNumber,
                            se.EnrollmentDate,
                            se.Status,
                            ay.YearName AS AcademicYear
                        FROM StudentEnrollment se
                        INNER JOIN [Student] s ON se.StudentID = s.StudentID
                        INNER JOIN AcademicYear ay ON se.AcademicYearID = ay.AcademicYearID
                        WHERE se.ClassID = @ClassID
                        ORDER BY s.FirstName, s.LastName";
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
"""
bll_se = """
        public static DataTable GetStudentsByClassID(int classID) => clsDAStudentEnrollment.GetStudentsByClassID(classID);
"""

# 2. clsDAClassCourse & clsClassCourse: GetCoursesByClassID, GetAssignmentsByTeacherID, GetAllClassCoursesDetailed
da_cc = """
        public static DataTable GetCoursesByClassID(int classID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            cc.ClassCourseID,
                            cc.CourseID,
                            c.Name AS CourseName,
                            c.CreditHours,
                            cc.TeacherID,
                            (t.FirstName + ' ' + t.LastName) AS TeacherName,
                            ay.YearName AS AcademicYear
                        FROM ClassCourse cc
                        INNER JOIN Course c ON cc.CourseID = c.CourseID
                        INNER JOIN Teacher t ON cc.TeacherID = t.TeacherID
                        INNER JOIN AcademicYear ay ON cc.AcademicYearID = ay.AcademicYearID
                        WHERE cc.ClassID = @ClassID AND cc.IsDeleted = 0
                        ORDER BY c.Name";
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

        public static DataTable GetAssignmentsByTeacherID(int teacherID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            cc.ClassCourseID,
                            cl.ClassID,
                            cl.Name AS ClassName,
                            c.CourseID,
                            c.Name AS CourseName,
                            c.CreditHours,
                            ay.YearName AS AcademicYear
                        FROM ClassCourse cc
                        INNER JOIN Class cl ON cc.ClassID = cl.ClassID
                        INNER JOIN Course c ON cc.CourseID = c.CourseID
                        INNER JOIN AcademicYear ay ON cc.AcademicYearID = ay.AcademicYearID
                        WHERE cc.TeacherID = @TeacherID AND cc.IsDeleted = 0
                        ORDER BY ay.StartDate DESC, cl.Name";
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

        public static DataTable GetAllClassCoursesDetailed()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            cc.ClassCourseID,
                            cc.ClassID,
                            cl.Name AS ClassName,
                            cc.CourseID,
                            c.Name AS CourseName,
                            cc.TeacherID,
                            (t.FirstName + ' ' + t.LastName) AS TeacherName,
                            cc.AcademicYearID,
                            ay.YearName AS AcademicYear
                        FROM ClassCourse cc
                        INNER JOIN Class cl ON cc.ClassID = cl.ClassID
                        INNER JOIN Course c ON cc.CourseID = c.CourseID
                        INNER JOIN Teacher t ON cc.TeacherID = t.TeacherID
                        INNER JOIN AcademicYear ay ON cc.AcademicYearID = ay.AcademicYearID
                        WHERE cc.IsDeleted = 0
                        ORDER BY ay.StartDate DESC, cl.Name, c.Name";
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
bll_cc = """
        public static DataTable GetCoursesByClassID(int classID) => clsDAClassCourse.GetCoursesByClassID(classID);
        public static DataTable GetAssignmentsByTeacherID(int teacherID) => clsDAClassCourse.GetAssignmentsByTeacherID(teacherID);
        public static DataTable GetAllClassCoursesDetailed() => clsDAClassCourse.GetAllClassCoursesDetailed();
"""

# 3. clsDASchedule & clsSchedule: GetSchedulesByClassID, GetSchedulesByTeacherID, GetAllSchedulesDetailed, CheckScheduleConflict
da_sch = """
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
                                int existingRoomID = (int)reader["RoomID"];
                                int existingClassID = (int)reader["ClassID"];
                                int existingTeacherID = (int)reader["TeacherID"];
                                string rName = reader["RoomName"].ToString();
                                string tName = reader["TeacherName"].ToString();
                                string clName = reader["ClassName"].ToString();
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
"""
bll_sch = """
        public static DataTable GetSchedulesByClassID(int classID) => clsDASchedule.GetSchedulesByClassID(classID);
        public static DataTable GetSchedulesByTeacherID(int teacherID) => clsDASchedule.GetSchedulesByTeacherID(teacherID);
        public static DataTable GetAllSchedulesDetailed() => clsDASchedule.GetAllSchedulesDetailed();
        public static bool CheckScheduleConflict(int? currentScheduleID, int academicYearID, string dayOfWeek, TimeSpan startTime, TimeSpan endTime, int roomID, int classCourseID, out string conflictReason) =>
            clsDASchedule.CheckScheduleConflict(currentScheduleID, academicYearID, dayOfWeek, startTime, endTime, roomID, classCourseID, out conflictReason);
"""

# 4. clsDATeacher & clsTeacher: GetTeachersDetailed
da_tea = """
        public static DataTable GetTeachersDetailed()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            t.TeacherID,
                            (t.FirstName + ' ' + t.LastName) AS FullName,
                            t.FirstName,
                            t.LastName,
                            t.PhoneNumber,
                            t.Email,
                            t.Specialization,
                            t.Qualification,
                            t.HireDate,
                            t.EmploymentStatus,
                            ISNULL(g.Name, 'N/A') AS Gender,
                            t.GenderID,
                            t.Address,
                            t.About
                        FROM [Teacher] t
                        LEFT JOIN [Gender] g ON t.GenderID = g.GenderID
                        ORDER BY t.FirstName, t.LastName";
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
bll_tea = """
        public static DataTable GetTeachersDetailed() => clsDATeacher.GetTeachersDetailed();
"""

# 5. clsDAAttendance & clsAttendance: GetAttendanceByClassID
da_att = """
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
"""
bll_att = """
        public static DataTable GetAttendanceByClassID(int classID) => clsDAAttendance.GetAttendanceByClassID(classID);
"""

# 6. clsDAGrade & clsGrade: GetGradesByClassID
da_grd = """
        public static DataTable GetGradesByClassID(int classID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            g.GradeID,
                            (s.FirstName + ' ' + s.LastName) AS StudentName,
                            s.AdmissionNo,
                            c.Name AS CourseName,
                            et.Name AS ExamType,
                            g.GradeValue,
                            g.OutOfValue,
                            g.Remarks
                        FROM Grade g
                        INNER JOIN [Student] s ON g.StudentID = s.StudentID
                        INNER JOIN Course c ON g.CourseID = c.CourseID
                        INNER JOIN ExamType et ON g.ExamTypeID = et.ExamTypeID
                        INNER JOIN StudentEnrollment se ON s.StudentID = se.StudentID
                        WHERE se.ClassID = @ClassID
                        ORDER BY s.FirstName, c.Name";
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
"""
bll_grd = """
        public static DataTable GetGradesByClassID(int classID) => clsDAGrade.GetGradesByClassID(classID);
"""

print("Appending queries...")
append_to_class(os.path.join(dal_dir, "clsDAStudentEnrollment.cs"), da_se)
append_to_class(bll_dir + r"\clsStudentEnrollment.cs", bll_se)

append_to_class(os.path.join(dal_dir, "clsDAClassCourse.cs"), da_cc)
append_to_class(bll_dir + r"\clsClassCourse.cs", bll_cc)

append_to_class(os.path.join(dal_dir, "clsDASchedule.cs"), da_sch)
append_to_class(bll_dir + r"\clsSchedule.cs", bll_sch)

append_to_class(os.path.join(dal_dir, "clsDATeacher.cs"), da_tea)
append_to_class(bll_dir + r"\clsTeacher.cs", bll_tea)

append_to_class(os.path.join(dal_dir, "clsDAAttendance.cs"), da_att)
append_to_class(bll_dir + r"\clsAttendance.cs", bll_att)

append_to_class(os.path.join(dal_dir, "clsDAGrade.cs"), da_grd)
append_to_class(bll_dir + r"\clsGrade.cs", bll_grd)

print("Done appending phase 2 queries!")
