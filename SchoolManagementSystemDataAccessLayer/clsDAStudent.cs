using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDAStudent
    {
        public static bool Find(int StudentID, ref string FirstName, ref string LastName, ref string NationalID, ref DateTime DateOfBirth, ref int GenderID, ref string Nationality, ref string BloodType, ref string Address, ref string PhoneNumber, ref string Email, ref string AdmissionNo, ref DateTime AdmissionDate, ref string PreviousSchool, ref string HealthStatus, ref string ProfileImageURL, ref int CreatedBy, ref int UpdatedBy, ref DateTime CreatedAt, ref DateTime UpdatedAt)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Student WHERE StudentID = @StudentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", StudentID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                                                FirstName = reader["FirstName"] != DBNull.Value ? (string)reader["FirstName"] : "";
                                LastName = reader["LastName"] != DBNull.Value ? (string)reader["LastName"] : "";
                                NationalID = reader["NationalID"] != DBNull.Value ? (string)reader["NationalID"] : "";
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                GenderID = (int)reader["GenderID"];
                                Nationality = reader["Nationality"] != DBNull.Value ? (string)reader["Nationality"] : "";
                                BloodType = reader["BloodType"] != DBNull.Value ? (string)reader["BloodType"] : "";
                                Address = reader["Address"] != DBNull.Value ? (string)reader["Address"] : "";
                                PhoneNumber = reader["PhoneNumber"] != DBNull.Value ? (string)reader["PhoneNumber"] : "";
                                Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                                AdmissionNo = reader["AdmissionNo"] != DBNull.Value ? (string)reader["AdmissionNo"] : "";
                                AdmissionDate = (DateTime)reader["AdmissionDate"];
                                PreviousSchool = reader["PreviousSchool"] != DBNull.Value ? (string)reader["PreviousSchool"] : "";
                                HealthStatus = reader["HealthStatus"] != DBNull.Value ? (string)reader["HealthStatus"] : "";
                                ProfileImageURL = reader["ProfileImageURL"] != DBNull.Value ? (string)reader["ProfileImageURL"] : "";
                                CreatedBy = (int)reader["CreatedBy"];
                                UpdatedBy = (int)reader["UpdatedBy"];
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

        public static int AddNewStudent(string FirstName, string LastName, string NationalID, DateTime DateOfBirth, int GenderID, string Nationality, string BloodType, string Address, string PhoneNumber, string Email, string AdmissionNo, DateTime AdmissionDate, string PreviousSchool, string HealthStatus, string ProfileImageURL, int CreatedBy, int UpdatedBy, DateTime CreatedAt, DateTime UpdatedAt)
        {
            int StudentID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Student (FirstName, LastName, NationalID, DateOfBirth, GenderID, Nationality, BloodType, Address, PhoneNumber, Email, AdmissionNo, AdmissionDate, PreviousSchool, HealthStatus, ProfileImageURL, CreatedBy, UpdatedBy, CreatedAt, UpdatedAt) 
                                     VALUES (@FirstName, @LastName, @NationalID, @DateOfBirth, @GenderID, @Nationality, @BloodType, @Address, @PhoneNumber, @Email, @AdmissionNo, @AdmissionDate, @PreviousSchool, @HealthStatus, @ProfileImageURL, @CreatedBy, @UpdatedBy, @CreatedAt, @UpdatedAt);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@FirstName", (object)FirstName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", (object)LastName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalID", (object)NationalID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@GenderID", GenderID);
                        command.Parameters.AddWithValue("@Nationality", (object)Nationality ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BloodType", (object)BloodType ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PhoneNumber", (object)PhoneNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AdmissionNo", (object)AdmissionNo ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AdmissionDate", AdmissionDate);
                        command.Parameters.AddWithValue("@PreviousSchool", (object)PreviousSchool ?? DBNull.Value);
                        command.Parameters.AddWithValue("@HealthStatus", (object)HealthStatus ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ProfileImageURL", (object)ProfileImageURL ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        command.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            StudentID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return StudentID;
        }

        public static bool UpdateStudent(int StudentID, string FirstName, string LastName, string NationalID, DateTime DateOfBirth, int GenderID, string Nationality, string BloodType, string Address, string PhoneNumber, string Email, string AdmissionNo, DateTime AdmissionDate, string PreviousSchool, string HealthStatus, string ProfileImageURL, int CreatedBy, int UpdatedBy, DateTime CreatedAt, DateTime UpdatedAt)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [Student] 
                                     SET FirstName = @FirstName, LastName = @LastName, NationalID = @NationalID, DateOfBirth = @DateOfBirth, GenderID = @GenderID, Nationality = @Nationality, BloodType = @BloodType, Address = @Address, PhoneNumber = @PhoneNumber, Email = @Email, AdmissionNo = @AdmissionNo, AdmissionDate = @AdmissionDate, PreviousSchool = @PreviousSchool, HealthStatus = @HealthStatus, ProfileImageURL = @ProfileImageURL, CreatedBy = @CreatedBy, UpdatedBy = @UpdatedBy, CreatedAt = @CreatedAt, UpdatedAt = @UpdatedAt
                                     WHERE StudentID = @StudentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", StudentID);
                                                command.Parameters.AddWithValue("@FirstName", (object)FirstName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", (object)LastName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalID", (object)NationalID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@GenderID", GenderID);
                        command.Parameters.AddWithValue("@Nationality", (object)Nationality ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BloodType", (object)BloodType ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PhoneNumber", (object)PhoneNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AdmissionNo", (object)AdmissionNo ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AdmissionDate", AdmissionDate);
                        command.Parameters.AddWithValue("@PreviousSchool", (object)PreviousSchool ?? DBNull.Value);
                        command.Parameters.AddWithValue("@HealthStatus", (object)HealthStatus ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ProfileImageURL", (object)ProfileImageURL ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        command.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);
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

        public static bool DeleteStudent(int StudentID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM Student WHERE StudentID = @StudentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", StudentID);
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

        public static DataTable GetAllStudents()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT
                                            [StudentID],
                                            CASE
                                                WHEN [LastName] IS NULL OR LTRIM(RTRIM([LastName])) = ''
                                                    THEN [FirstName]
                                                ELSE CONCAT([FirstName], ' ', [LastName])
                                            END AS [FullName],
                                            [NationalID],
                                            [DateOfBirth],
                                            CASE WHEN [GenderID] = 1 THEN 'Male' ELSE 'Female' END AS [Gender],
                                            [Nationality],
                                            [BloodType],
                                            [Address],
                                            [PhoneNumber],
                                            [Email],
                                            [AdmissionNo],
                                            [AdmissionDate],
                                            [PreviousSchool],
                                            [HealthStatus],
                                            [ProfileImageURL],
                                            [CreatedBy],
                                            [CreatedAt]
                                        FROM [dbo].[Student];";
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

        public static bool IsStudentExist(int StudentID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Student WHERE StudentID = @StudentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", StudentID);
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

        public static bool DoesEmailAlreadyExist(string Email)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1  FROM Student WHERE Email = @Email";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", Email);
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
        public static bool DoesAdmissionNoAlreadyExist(string AdmissionNo)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1  FROM Student WHERE AdmissionNo = @AdmissionNo";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AdmissionNo", AdmissionNo);
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
        public static bool DoesNationalIDAlreadyExist(string NationalID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1  FROM Student WHERE NationalID = @NationalID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalID", NationalID);
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

        /*
            Does NationalID already exist?
            Does AdmissionNo already exist?
            Does Email already exist?
         */
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

}
}
