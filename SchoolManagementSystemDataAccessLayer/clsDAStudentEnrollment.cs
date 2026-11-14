using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDAStudentEnrollment
    {
        public static bool Find(int StudentEnrollmentID, ref int StudentID, ref int GradeLevelID, ref int ClassID, ref int AcademicYearID, ref DateTime EnrollmentDate, ref DateTime? WithdrawalDate, ref string Status, ref DateTime CreatedAt, ref DateTime? UpdatedAt)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM StudentEnrollment WHERE StudentEnrollmentID = @StudentEnrollmentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentEnrollmentID", StudentEnrollmentID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                StudentID = (int)reader["StudentID"];
                                ClassID = (int)reader["ClassID"];
                                GradeLevelID = (int)reader["GradeLevelID"];
                                AcademicYearID = (int)reader["AcademicYearID"];
                                EnrollmentDate = (DateTime)reader["EnrollmentDate"];
                                WithdrawalDate = reader["WithdrawalDate"] != DBNull.Value ? (DateTime?)reader["WithdrawalDate"] : null;
                                Status = reader["Status"] != DBNull.Value ? (string)reader["Status"] : "";
                                CreatedAt = (DateTime)reader["CreatedAt"];
                                UpdatedAt = reader["UpdatedAt"] != DBNull.Value ? (DateTime?)reader["UpdatedAt"] : null; 
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

        public static int AddNewStudentEnrollment(int StudentID,int GradeLevelID, int ClassID, int AcademicYearID, DateTime EnrollmentDate, DateTime? WithdrawalDate, string Status, DateTime CreatedAt, DateTime? UpdatedAt)
        {
            int StudentEnrollmentID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO StudentEnrollment (StudentID,GradeLevelID, ClassID, AcademicYearID, EnrollmentDate, WithdrawalDate, Status, CreatedAt, UpdatedAt) 
                                     VALUES (@StudentID,@GradeLevelID, @ClassID, @AcademicYearID, @EnrollmentDate, @WithdrawalDate, @Status, @CreatedAt, @UpdatedAt);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@ClassID", ClassID);
                        command.Parameters.AddWithValue("@GradeLevelID", GradeLevelID);
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
                        command.Parameters.AddWithValue("@EnrollmentDate", EnrollmentDate);
                        command.Parameters.AddWithValue("@WithdrawalDate", (object)WithdrawalDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Status", (object)Status ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            StudentEnrollmentID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return StudentEnrollmentID;
        }

        public static bool UpdateStudentEnrollment(int StudentEnrollmentID, int StudentID, int GradeLevelID, int ClassID, int AcademicYearID, DateTime EnrollmentDate, DateTime? WithdrawalDate, string Status, DateTime CreatedAt, DateTime? UpdatedAt)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [StudentEnrollment] 
                                     SET GradeLevelID =@GradeLevelID,
                                          StudentID = @StudentID, ClassID = @ClassID, AcademicYearID = @AcademicYearID, EnrollmentDate = @EnrollmentDate, WithdrawalDate = @WithdrawalDate, Status = @Status, CreatedAt = @CreatedAt, UpdatedAt = @UpdatedAt
                                     WHERE StudentEnrollmentID = @StudentEnrollmentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentEnrollmentID", StudentEnrollmentID);
                        command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@ClassID", ClassID);
                        command.Parameters.AddWithValue("@GradeLevelID", GradeLevelID);
                        command.Parameters.AddWithValue("@AcademicYearID", AcademicYearID);
                        command.Parameters.AddWithValue("@EnrollmentDate", EnrollmentDate);
                        command.Parameters.AddWithValue("@WithdrawalDate", (object)WithdrawalDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Status", (object)Status ?? DBNull.Value);
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

        public static bool DeleteStudentEnrollment(int StudentEnrollmentID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM StudentEnrollment WHERE StudentEnrollmentID = @StudentEnrollmentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentEnrollmentID", StudentEnrollmentID);
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

        public static DataTable GetAllStudentEnrollments()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM StudentEnrollment";
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

        public static bool IsStudentEnrollmentExist(int StudentEnrollmentID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM StudentEnrollment WHERE StudentEnrollmentID = @StudentEnrollmentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentEnrollmentID", StudentEnrollmentID);
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

        public static DataTable GetAllEnrollmentsDetailed()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                         SELECT 
     se.StudentEnrollmentID ,
     s.AdmissionNo,gl.Name as LevelName,
     (s.FirstName + ' ' + s.LastName) AS StudentName,
     ay.YearName AS AcademicYear,
     c.Name AS ClassName,
     se.EnrollmentDate,
     se.WithdrawalDate,
     se.Status,c.ClassID,ay.AcademicYearID,s.StudentID
 FROM StudentEnrollment se
 INNER JOIN Student s ON se.StudentID = s.StudentID
 INNER JOIN AcademicYear ay ON se.AcademicYearID = ay.AcademicYearID
 INNER JOIN Class c ON se.ClassID = c.ClassID
 Inner join GradeLevel gl on gl.GradeLevelID = se.GradeLevelID
 ORDER BY se.EnrollmentDate DESC";
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

        public static bool IsStudentEnrolledInYear(int studentID, int academicYearID, int excludeEnrollmentID = -1)
        {
            bool isEnrolled = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT TOP 1 1 
                        FROM StudentEnrollment 
                        WHERE StudentID = @StudentID 
                          AND AcademicYearID = @AcademicYearID 
                          AND StudentEnrollmentID <> @ExcludeEnrollmentID
                          AND Status <> 'Withdrawn'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.Parameters.AddWithValue("@AcademicYearID", academicYearID);
                        command.Parameters.AddWithValue("@ExcludeEnrollmentID", excludeEnrollmentID);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        isEnrolled = (result != null);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return isEnrolled;
        }

        public static bool UpdateEnrollmentStatus(int studentEnrollmentID, string newStatus, DateTime? withdrawalDate)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        UPDATE StudentEnrollment 
                        SET Status = @Status, 
                            WithdrawalDate = @WithdrawalDate, 
                            UpdatedAt = GETDATE()
                        WHERE StudentEnrollmentID = @StudentEnrollmentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", newStatus);
                        command.Parameters.AddWithValue("@WithdrawalDate", (object)withdrawalDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StudentEnrollmentID", studentEnrollmentID);
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
    }
}
