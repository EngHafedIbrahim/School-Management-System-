using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsAttendance
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int AttendanceID { get; set; }
        public int StudentID { get; set; }
        public int ClassID { get; set; }
        public int SessionID { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public clsStudent StudentInfo => clsStudent.Find(this.StudentID);
        public clsClass ClassInfo => clsClass.Find(this.ClassID);

        public clsAttendance()
        {
            this.AttendanceID = -1;
            this.StudentID = -1;
            this.ClassID = -1;
            this.SessionID = -1;
            this.Date = DateTime.Now;
            this.Status = "";
            this.Note = "";
            this.CreatedBy = -1;
            this.CreatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsAttendance(int AttendanceID, int StudentID, int ClassID, int SessionID, DateTime Date, string Status, string Note, int CreatedBy, DateTime CreatedAt)
        {
            this.AttendanceID = AttendanceID;
            this.StudentID = StudentID;
            this.ClassID = ClassID;
            this.SessionID = SessionID;
            this.Date = Date;
            this.Status = Status;
            this.Note = Note;
            this.CreatedBy = CreatedBy;
            this.CreatedAt = CreatedAt;
            Mode = enMode.Update;
        }

        public static clsAttendance Find(int AttendanceID)
        {
            int StudentID = -1;
            int ClassID = -1;
            int SessionID = -1;
            DateTime Date = DateTime.Now;
            string Status = "";
            string Note = "";
            int CreatedBy = -1;
            DateTime CreatedAt = DateTime.Now;
            if (clsDAAttendance.Find(AttendanceID, ref StudentID, ref ClassID, ref SessionID, ref Date, ref Status, ref Note, ref CreatedBy, ref CreatedAt))
                return new clsAttendance(AttendanceID, StudentID, ClassID, SessionID, Date, Status, Note, CreatedBy, CreatedAt);
            return null;
        }

        private bool _AddNewAttendance()
        {
            this.AttendanceID = clsDAAttendance.AddNewAttendance(this.StudentID, this.ClassID, this.SessionID, this.Date, this.Status, this.Note, this.CreatedBy, this.CreatedAt);
            return (this.AttendanceID != -1);
        }

        private bool _UpdateAttendance()
        {
            return clsDAAttendance.UpdateAttendance(this.AttendanceID, this.StudentID, this.ClassID, this.SessionID, this.Date, this.Status, this.Note, this.CreatedBy, this.CreatedAt);
        }

        // FIXED: Added 'Excused' as valid status
        // FIXED: Replaced expensive full-table scan with targeted SQL query
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (Date > DateTime.Now)
            {
                errorMessage = "Cannot record attendance for a future date.";
                return false;
            }
            if (Status != "Present" && Status != "Absent" && Status != "Late" && Status != "Excused")
            {
                errorMessage = "Status must be Present, Absent, Late, or Excused.";
                return false;
            }

            if (IsDuplicateAttendance(this.StudentID, this.SessionID, this.Date, this.AttendanceID))
            {
                errorMessage = "Duplicate attendance record for this student on the same session and date.";
                return false;
            }

            return true;
        }

        public bool Save()
        {
            string errorMessage;
            if (!Validate(out errorMessage))
            {
                throw new Exception(errorMessage); // Throw exception to be handled by Presentation Layer
            }

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAttendance())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateAttendance();
            }
            return false;
        }

        public static DataTable GetAllAttendances() => clsDAAttendance.GetAllAttendances();
        public static bool IsAttendanceExist(int AttendanceID) => clsDAAttendance.IsAttendanceExist(AttendanceID);
        public static bool DeleteAttendance(int AttendanceID) => clsDAAttendance.DeleteAttendance(AttendanceID);
    
        public static DataTable GetAttendanceByStudentID(int studentID) => clsDAAttendance.GetAttendanceByStudentID(studentID);

        public static DataTable GetAttendanceByClassID(int classID) => clsDAAttendance.GetAttendanceByClassID(classID);

        public static DataTable GetAttendanceSummaryByStudent(int studentID, int academicYearID) => clsDAAttendance.GetAttendanceSummaryByStudent(studentID, academicYearID);

        public static DataTable GetClassAttendanceByDateAndSession(int classID, DateTime date, int sessionID) => clsDAAttendance.GetClassAttendanceByDateAndSession(classID, date, sessionID);
        public static bool SaveBulkAttendance(DataTable dtAttendanceRecords, int createdBy) => clsDAAttendance.SaveBulkAttendance(dtAttendanceRecords, createdBy);

        // NEW: Targeted duplicate check — delegates to DAL
        public static bool IsDuplicateAttendance(int studentID, int sessionID, DateTime date, int excludeAttendanceID) => clsDAAttendance.IsDuplicateAttendance(studentID, sessionID, date, excludeAttendanceID);
    }
}
