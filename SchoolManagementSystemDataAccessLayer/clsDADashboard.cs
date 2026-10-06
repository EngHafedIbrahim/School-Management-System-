using System;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{
    public class DashboardStatsDTO
    {
        public int TotalStudents { get; set; }
        public int TotalTeachers { get; set; }
        public int TotalClasses { get; set; }
        public int TotalParents { get; set; }
        public string CurrentAcademicYear { get; set; } = "None";
    }

    public static class clsDADashboard
    {
        public static DashboardStatsDTO GetDashboardStats()
        {
            var stats = new DashboardStatsDTO();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            (SELECT COUNT(*) FROM Student) AS TotalStudents,
                            (SELECT COUNT(*) FROM Teacher) AS TotalTeachers,
                            (SELECT COUNT(*) FROM Class) AS TotalClasses,
                            (SELECT COUNT(*) FROM [Parent]) AS TotalParents,
                            ISNULL((SELECT TOP 1 YearName FROM AcademicYear WHERE IsCurrent = 1), 'None') AS CurrentYear;";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                stats.TotalStudents = reader["TotalStudents"] != DBNull.Value ? Convert.ToInt32(reader["TotalStudents"]) : 0;
                                stats.TotalTeachers = reader["TotalTeachers"] != DBNull.Value ? Convert.ToInt32(reader["TotalTeachers"]) : 0;
                                stats.TotalClasses = reader["TotalClasses"] != DBNull.Value ? Convert.ToInt32(reader["TotalClasses"]) : 0;
                                stats.TotalParents = reader["TotalParents"] != DBNull.Value ? Convert.ToInt32(reader["TotalParents"]) : 0;
                                stats.CurrentAcademicYear = reader["CurrentYear"]?.ToString() ?? "None";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
            }
            return stats;
        }
    }
}
