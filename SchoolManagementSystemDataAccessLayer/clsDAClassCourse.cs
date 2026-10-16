using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDAClassCourse
    {
        public static bool Find(int ClassCourseID,ref int GradeLevelID, ref int ClassID, ref int CourseID, ref int TeacherID, ref int AcademicYearID, ref DateTime CreatedAt, ref DateTime UpdatedAt, ref bool IsDeleted)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Top (1) * FROM ClassCourse WHERE ClassCourseID = @ClassCourseID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassCourseID", ClassCourseID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                                                ClassID = (int)reader["ClassID"];
                                CourseID = (int)reader["CourseID"];
                                TeacherID = (int)reader["TeacherID"];
                                GradeLevelID = (int)reader["GradeLevelID"];
                                AcademicYearID = (int)reader["AcademicYearID"];
                                CreatedAt = (DateTime)reader["CreatedAt"];
                                UpdatedAt = (DateTime)reader["UpdatedAt"];
                                IsDeleted = (bool)reader["IsDeleted"];
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

        public static int AddNewClassCourse(int ClassID,int GradeLevelID, int CourseID, int TeacherID, int AcademicYearID, DateTime CreatedAt, DateTime UpdatedAt, bool IsDeleted)
        {
            int ClassCourseID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO ClassCourse (ClassID,GradeLevelID, CourseID ,TeacherID, AcademicYearID, CreatedAt, UpdatedAt, IsDeleted) 
                                     VALUES (@ClassID,@GradeLevelID, @CourseID, @TeacherID, @AcademicYearID, @CreatedAt, @UpdatedAt, @IsDeleted);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@ClassID", ClassID);
                        command.Parameters.AddWithValue("@CourseID", CourseID);
                        command.Parameters.AddWithValue("@TeacherID", TeacherID);
                        command.Parameters.AddWithValue("@GradeLevelID", GradeLevelID);
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        command.Parameters.AddWithValue("@IsDeleted", IsDeleted);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ClassCourseID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return ClassCourseID;
        }

        public static bool UpdateClassCourse(int ClassCourseID, int GradeLevelID, int ClassID, int CourseID, int TeacherID, int AcademicYearID, DateTime CreatedAt, DateTime UpdatedAt, bool IsDeleted)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [ClassCourse] 
                                     SET GradeLevelID = @GradeLevelID ,ClassID = @ClassID, CourseID = @CourseID, TeacherID = @TeacherID, AcademicYearID = @AcademicYearID, CreatedAt = @CreatedAt, UpdatedAt = @UpdatedAt, IsDeleted = @IsDeleted
                                     WHERE ClassCourseID = @ClassCourseID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassCourseID", ClassCourseID);
                                                command.Parameters.AddWithValue("@ClassID", ClassID);
                        command.Parameters.AddWithValue("@CourseID", CourseID);
                        command.Parameters.AddWithValue("@TeacherID", TeacherID);
                        command.Parameters.AddWithValue("@GradeLevelID", GradeLevelID);
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        command.Parameters.AddWithValue("@IsDeleted", IsDeleted);
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

        public static bool DeleteClassCourse(int ClassCourseID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM ClassCourse WHERE ClassCourseID = @ClassCourseID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassCourseID", ClassCourseID);
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

        public static DataTable GetAllClassCourses()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM ClassCourse";
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

        public static bool IsClassCourseExist(int ClassCourseID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM ClassCourse WHERE ClassCourseID = @ClassCourseID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassCourseID", ClassCourseID);
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
    
        public static bool DoesClassCourseWithThoseExist(int TeacherID,int CourseID,int ClassID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM ClassCourse WHERE TeacherID = @TeacherID and CourseID= @CourseID  and ClassID = @ClassID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TeacherID", TeacherID);
                        command.Parameters.AddWithValue("@ClassID", ClassID);
                        command.Parameters.AddWithValue("@CourseID", CourseID);
                        //command.Parameters.AddWithValue("@GradeLevelID", GradeLevelID);
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
                            cc.ClassID,gl.Name as GradeLevel,
                            cl.Name AS ClassName,
                            cc.CourseID,
                            c.Name AS CourseName,
                            cc.TeacherID,
                            (t.FirstName + ' ' + t.LastName) AS TeacherName,
                            cc.AcademicYearID,
                            ay.YearName AS AcademicYear
                        FROM ClassCourse cc
                        INNER JOIN Class cl ON cc.ClassID = cl.ClassID
                        INNER JOIN GradeLevel gl ON gl.GradeLevelID = cl.GradeLevelID
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

}
}
