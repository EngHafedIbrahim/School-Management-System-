using System;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public static class clsDashboard
    {
        public static DashboardStatsDTO GetDashboardStats()
        {
            return clsDADashboard.GetDashboardStats();
        }
    }
}
