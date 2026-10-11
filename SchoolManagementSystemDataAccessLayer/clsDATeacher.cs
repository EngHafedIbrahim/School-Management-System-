using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public static class clsDATeacher
    {
        public static bool Find(int TeacherID, ref string FirstName, ref string LastName, ref string Address, ref string PhoneNumber, ref string Email, ref string Specialization, ref string Qualification, ref DateTime HireDate, ref string EmploymentStatus, ref string About, ref int GenderID, ref int CreatedBy, ref int UpdatedBy, ref DateTime CreatedAt, ref DateTime UpdatedAt)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Teacher WHERE TeacherID = @TeacherID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TeacherID", TeacherID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                                                FirstName = reader["FirstName"] != DBNull.Value ? (string)reader["FirstName"] : "";
                                LastName = reader["LastName"] != DBNull.Value ? (string)reader["LastName"] : "";
                                Address = reader["Address"] != DBNull.Value ? (string)reader["Address"] : "";
                                PhoneNumber = reader["PhoneNumber"] != DBNull.Value ? (string)reader["PhoneNumber"] : "";
                                Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                                Specialization = reader["Specialization"] != DBNull.Value ? (string)reader["Specialization"] : "";
                                Qualification = reader["Qualification"] != DBNull.Value ? (string)reader["Qualification"] : "";
                                HireDate = (DateTime)reader["HireDate"];
                                EmploymentStatus = reader["EmploymentStatus"] != DBNull.Value ? (string)reader["EmploymentStatus"] : "";
                                About = reader["About"] != DBNull.Value ? (string)reader["About"] : "";
                                GenderID = (int)reader["GenderID"];
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

        public static int AddNewTeacher(string FirstName, string LastName, string Address, string PhoneNumber, string Email, string Specialization, string Qualification, DateTime HireDate, string EmploymentStatus, string About, int GenderID, int CreatedBy, int UpdatedBy, DateTime CreatedAt, DateTime UpdatedAt)
        {
            int TeacherID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Teacher (FirstName, LastName, Address, PhoneNumber, Email, Specialization, Qualification, HireDate, EmploymentStatus, About, GenderID, CreatedBy, UpdatedBy, CreatedAt, UpdatedAt) 
                                     VALUES (@FirstName, @LastName, @Address, @PhoneNumber, @Email, @Specialization, @Qualification, @HireDate, @EmploymentStatus, @About, @GenderID, @CreatedBy, @UpdatedBy, @CreatedAt, @UpdatedAt);
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                                                command.Parameters.AddWithValue("@FirstName", (object)FirstName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", (object)LastName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PhoneNumber", (object)PhoneNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Specialization", (object)Specialization ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Qualification", (object)Qualification ?? DBNull.Value);
                        command.Parameters.AddWithValue("@HireDate", HireDate);
                        command.Parameters.AddWithValue("@EmploymentStatus", (object)EmploymentStatus ?? DBNull.Value);
                        command.Parameters.AddWithValue("@About", (object)About ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GenderID", GenderID);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        command.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            TeacherID = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return TeacherID;
        }

        public static bool UpdateTeacher(int TeacherID, string FirstName, string LastName, string Address, string PhoneNumber, string Email, string Specialization, string Qualification, DateTime HireDate, string EmploymentStatus, string About, int GenderID, int CreatedBy, int UpdatedBy, DateTime CreatedAt, DateTime UpdatedAt)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [Teacher] 
                                     SET FirstName = @FirstName, LastName = @LastName, Address = @Address, PhoneNumber = @PhoneNumber, Email = @Email, Specialization = @Specialization, Qualification = @Qualification, HireDate = @HireDate, EmploymentStatus = @EmploymentStatus, About = @About, GenderID = @GenderID, CreatedBy = @CreatedBy, UpdatedBy = @UpdatedBy, CreatedAt = @CreatedAt, UpdatedAt = @UpdatedAt
                                     WHERE TeacherID = @TeacherID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TeacherID", TeacherID);
                                                command.Parameters.AddWithValue("@FirstName", (object)FirstName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", (object)LastName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PhoneNumber", (object)PhoneNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Specialization", (object)Specialization ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Qualification", (object)Qualification ?? DBNull.Value);
                        command.Parameters.AddWithValue("@HireDate", HireDate);
                        command.Parameters.AddWithValue("@EmploymentStatus", (object)EmploymentStatus ?? DBNull.Value);
                        command.Parameters.AddWithValue("@About", (object)About ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GenderID", GenderID);
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

        public static bool DeleteTeacher(int TeacherID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM Teacher WHERE TeacherID = @TeacherID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TeacherID", TeacherID);
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

        public static DataTable GetAllTeachers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Teacher";
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

        public static bool IsTeacherExist(int TeacherID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Teacher WHERE TeacherID = @TeacherID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TeacherID", TeacherID);
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


        public static bool IsEmailExist(string Email)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Teacher WHERE Email = @Email";
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

        /// <summary>
        ///  use this when user wants update Teacher info
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="TeacherID"></param>
        /// <returns></returns>
        public static bool HasAnyTeacherSameThisEmail(string Email, int TeacherID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT TOP 1 1 FROM Teacher WHERE Email = @Email and TeacherID != @TeacherID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@TeacherID", TeacherID);
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

        public static DataTable GetTeachersDetailed()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            TeacherID,
                            (FirstName + ' ' + LastName) AS FullName,
                            PhoneNumber,
                            Email,
                            Specialization,
                            Qualification,
                            HireDate,
                            EmploymentStatus, 
                              Case 
                                WHEN GenderID = 1 THEN 'Male' ELSE 'Female' END AS Gender,
                            Address,
                            About
                        FROM [Teacher] 
                        ORDER BY FirstName, LastName";
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
