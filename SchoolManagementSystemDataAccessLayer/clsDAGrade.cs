using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDAGrade
    {
        public static bool Find(int GradeID, ref int StudentID, ref int CourseID, ref int ExamTypeID, ref decimal GradeValue, ref decimal OutOfValue, ref int AcademicYearID, ref int CreatedBy, ref DateTime CreatedAt)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Grade WHERE GradeID = @GradeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GradeID", GradeID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                                                StudentID = (int)reader["StudentID"];
                                CourseID = (int)reader["CourseID"];
                                ExamTypeID = (int)reader["ExamTypeID"];
                                GradeValue = (decimal)reader["GradeValue"];
                                OutOfValue = (decimal)reader["OutOfValue"];
                                AcademicYearID = (int)reader["AcademicYearID"];
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

        public static int AddNewGrade(int StudentID, int CourseID, int ExamTypeID, decimal GradeValue, decimal OutOfValue, int AcademicYearID, int CreatedBy, DateTime CreatedAt)
        {
            int GradeID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Grade (StudentID, CourseID, ExamTypeID, GradeValue, OutOfValue, AcademicYearID, CreatedBy, CreatedAt) 
                                     VALUES (@StudentID, @CourseID, @ExamTypeID, @GradeValue, @OutOfValue, @AcademicYearID, @CreatedBy, @CreatedAt);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@CourseID", CourseID);
                        command.Parameters.AddWithValue("@ExamTypeID", ExamTypeID);
                        command.Parameters.AddWithValue("@GradeValue", GradeValue);
                        command.Parameters.AddWithValue("@OutOfValue", OutOfValue);
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            GradeID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return GradeID;
        }

        public static bool UpdateGrade(int GradeID, int StudentID, int CourseID, int ExamTypeID, decimal GradeValue, decimal OutOfValue, int AcademicYearID, int CreatedBy, DateTime CreatedAt)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [Grade] 
                                     SET StudentID = @StudentID, CourseID = @CourseID, ExamTypeID = @ExamTypeID, GradeValue = @GradeValue, OutOfValue = @OutOfValue, AcademicYearID = @AcademicYearID, CreatedBy = @CreatedBy, CreatedAt = @CreatedAt
                                     WHERE GradeID = @GradeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GradeID", GradeID);
                                                command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@CourseID", CourseID);
                        command.Parameters.AddWithValue("@ExamTypeID", ExamTypeID);
                        command.Parameters.AddWithValue("@GradeValue", GradeValue);
                        command.Parameters.AddWithValue("@OutOfValue", OutOfValue);
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
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

        public static bool DeleteGrade(int GradeID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM Grade WHERE GradeID = @GradeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GradeID", GradeID);
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

        public static DataTable GetAllGrades()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Grade";
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

        public static bool IsGradeExist(int GradeID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Grade WHERE GradeID = @GradeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GradeID", GradeID);
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

}
}
