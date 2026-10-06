using System;
using System.Data;
using System.Data.SqlClient;
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
    }
}
