using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsSchedule
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int ScheduleID { get; set; }
        public int ClassCourseID { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int RoomID { get; set; }
        public int AcademicYearID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public clsClassCourse ClassCourseInfo => clsClassCourse.Find(this.ClassCourseID);
        public clsRoom RoomInfo => clsRoom.Find(this.RoomID);
        public clsAcademicYear AcademicYearInfo => clsAcademicYear.Find(this.AcademicYearID);

        public clsSchedule()
        {
            this.ScheduleID = -1;
            this.ClassCourseID = -1;
            this.DayOfWeek = "";
            this.StartTime = TimeSpan.Zero;
            this.EndTime = TimeSpan.Zero;
            this.RoomID = -1;
            this.AcademicYearID = -1;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsSchedule(int ScheduleID, int ClassCourseID, string DayOfWeek, TimeSpan StartTime, TimeSpan EndTime, int RoomID, int AcademicYearID, DateTime CreatedAt, DateTime UpdatedAt)
        {
            this.ScheduleID = ScheduleID;
            this.ClassCourseID = ClassCourseID;
            this.DayOfWeek = DayOfWeek;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.RoomID = RoomID;
            this.AcademicYearID = AcademicYearID;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            Mode = enMode.Update;
        }

        public static clsSchedule Find(int ScheduleID)
        {
            int ClassCourseID = -1;
            string DayOfWeek = "";
            TimeSpan StartTime = TimeSpan.Zero;
            TimeSpan EndTime = TimeSpan.Zero;
            int RoomID = -1;
            int AcademicYearID = -1;
            DateTime CreatedAt = DateTime.Now;
            DateTime UpdatedAt = DateTime.Now;
            if (clsDASchedule.Find(ScheduleID, ref ClassCourseID, ref DayOfWeek, ref StartTime, ref EndTime, ref RoomID, ref AcademicYearID, ref CreatedAt, ref UpdatedAt))
                return new clsSchedule(ScheduleID, ClassCourseID, DayOfWeek, StartTime, EndTime, RoomID, AcademicYearID, CreatedAt, UpdatedAt);
            return null;
        }

        private bool _AddNewSchedule()
        {
            this.ScheduleID = clsDASchedule.AddNewSchedule(this.ClassCourseID, this.DayOfWeek, this.StartTime, this.EndTime, this.RoomID, this.AcademicYearID, this.CreatedAt, this.UpdatedAt);
            return (this.ScheduleID != -1);
        }

        private bool _UpdateSchedule()
        {
            return clsDASchedule.UpdateSchedule(this.ScheduleID, this.ClassCourseID, this.DayOfWeek, this.StartTime, this.EndTime, this.RoomID, this.AcademicYearID, this.CreatedAt, this.UpdatedAt);
        }

        
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (StartTime >= EndTime)
            {
                errorMessage = "Start time must be before end time.";
                return false;
            }

            if(clsSchedule.CheckScheduleConflict(this.ScheduleID, this.AcademicYearID, this.DayOfWeek, this.StartTime, this.EndTime, this.RoomID, this.ClassCourseID, out string conflictReason))
            {
                errorMessage = conflictReason;
                return false;
            }

            return true;
        }


        bool IsOverlap()
        {
            return false; 
        }
        public bool Save()
        {
            string errorMessage;
            if (!Validate(out errorMessage))
            {
                throw new Exception(errorMessage);
            }

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSchedule())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateSchedule();
            }
            return false;
        }

        public static DataTable GetAllSchedules() => clsDASchedule.GetAllSchedules();
        public static bool IsScheduleExist(int ScheduleID) => clsDASchedule.IsScheduleExist(ScheduleID);
        public static bool DeleteSchedule(int ScheduleID) => clsDASchedule.DeleteSchedule(ScheduleID);
    
        public static DataTable GetSchedulesByClassID(int classID) => clsDASchedule.GetSchedulesByClassID(classID);
        public static DataTable GetSchedulesByTeacherID(int teacherID) => clsDASchedule.GetSchedulesByTeacherID(teacherID);
        public static DataTable GetAllSchedulesDetailed() => clsDASchedule.GetAllSchedulesDetailed();
        public static bool CheckScheduleConflict(int? currentScheduleID, int academicYearID, string dayOfWeek, TimeSpan startTime, TimeSpan endTime, int roomID, int classCourseID, out string conflictReason) =>
            clsDASchedule.CheckScheduleConflictNew(currentScheduleID, academicYearID, dayOfWeek, startTime, endTime, roomID, classCourseID, out conflictReason);

}
}
