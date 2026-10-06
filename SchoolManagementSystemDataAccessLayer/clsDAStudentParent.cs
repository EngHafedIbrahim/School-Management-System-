using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDAStudentParent
    {
        public static bool Find(int StudentParentID, ref int StudentID, ref int ParentID, ref string Relationship, ref bool IsPrimaryContact)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM StudentParent WHERE StudentParentID = @StudentParentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentParentID", StudentParentID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                                                StudentID = (int)reader["StudentID"];
                                ParentID = (int)reader["ParentID"];
                                Relationship = reader["Relationship"] != DBNull.Value ? (string)reader["Relationship"] : "";
                                IsPrimaryContact = (bool)reader["IsPrimaryContact"];
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

        public static int AddNewStudentParent(int StudentID, int ParentID, string Relationship, bool IsPrimaryContact)
        {
            int StudentParentID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO StudentParent (StudentID, ParentID, Relationship, IsPrimaryContact) 
                                     VALUES (@StudentID, @ParentID, @Relationship, @IsPrimaryContact);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@ParentID", ParentID);
                        command.Parameters.AddWithValue("@Relationship", (object)Relationship ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsPrimaryContact", IsPrimaryContact);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            StudentParentID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return StudentParentID;
        }

        public static bool UpdateStudentParent(int StudentParentID, int StudentID, int ParentID, string Relationship, bool IsPrimaryContact)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [StudentParent] 
                                     SET StudentID = @StudentID, ParentID = @ParentID, Relationship = @Relationship, IsPrimaryContact = @IsPrimaryContact
                                     WHERE StudentParentID = @StudentParentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentParentID", StudentParentID);
                                                command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@ParentID", ParentID);
                        command.Parameters.AddWithValue("@Relationship", (object)Relationship ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsPrimaryContact", IsPrimaryContact);
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

        public static bool DeleteStudentParent(int StudentParentID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM StudentParent WHERE StudentParentID = @StudentParentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentParentID", StudentParentID);
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

        public static DataTable GetAllStudentParents()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM StudentParent";
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

        public static bool IsStudentParentExist(int StudentParentID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM StudentParent WHERE StudentParentID = @StudentParentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentParentID", StudentParentID);
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

        public static DataTable GetStudentsByParentID(int parentID,int AccadimicYearID = -1/*update by this parameter on Later */)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    // this part in query is a very important,because this query bind with Current year
                    //se.AcademicYearID = (SELECT TOP 1 AcademicYearID FROM AcademicYear WHERE IsCurrent = 1)
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

        public static bool IsThisStudentAlreadyLinkedToThisParent(int StudentID, int ParentID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM StudentParent WHERE ParentID = @ParentID AND StudentID = @StudentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ParentID", ParentID);
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

    }
}
