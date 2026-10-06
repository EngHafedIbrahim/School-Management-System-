using System;
using System.Diagnostics;

namespace UtilityLib
{
    public class clsLogger
    {
        public static void Error(string msg)
        {
            try 
            {
                if (!EventLog.SourceExists("SchoolManagementSystem"))
                {
                    EventLog.CreateEventSource("SchoolManagementSystem", "Application");
                }
                EventLog.WriteEntry("SchoolManagementSystem", msg, EventLogEntryType.Error);
            }
            catch 
            {
                // Fallback logging or ignore if permission denied
            }
        }

        public static void Info(string msg)
        {
            try 
            {
                if (!EventLog.SourceExists("SchoolManagementSystem"))
                {
                    EventLog.CreateEventSource("SchoolManagementSystem", "Application");
                }
                EventLog.WriteEntry("SchoolManagementSystem", msg, EventLogEntryType.Information);
            }
            catch 
            {
                // Fallback logging or ignore if permission denied
            }
        }
    }
}
