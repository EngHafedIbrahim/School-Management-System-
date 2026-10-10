using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsClassCourse
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int ClassCourseID { get; set; }
        public int ClassID { get; set; }
        public int CourseID { get; set; }
        public int TeacherID { get; set; }
        public int AcademicYearID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public clsClass ClassInfo => clsClass.Find(this.ClassID);
        public clsCourse CourseInfo => clsCourse.Find(this.CourseID);
        public clsTeacher TeacherInfo => clsTeacher.Find(this.TeacherID);
        public clsAcademicYear AcademicYearInfo => clsAcademicYear.Find(this.AcademicYearID);

        public clsClassCourse()
        {
            this.ClassCourseID = -1;
            this.ClassID = -1;
            this.CourseID = -1;
            this.TeacherID = -1;
            this.AcademicYearID = -1;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.IsDeleted = false;
            Mode = enMode.AddNew;
        }

        private clsClassCourse(int ClassCourseID, int ClassID, int CourseID, int TeacherID, int AcademicYearID, DateTime CreatedAt, DateTime UpdatedAt, bool IsDeleted)
        {
            this.ClassCourseID = ClassCourseID;
            this.ClassID = ClassID;
            this.CourseID = CourseID;
            this.TeacherID = TeacherID;
            this.AcademicYearID = AcademicYearID;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.IsDeleted = IsDeleted;
            Mode = enMode.Update;
        }

        public static clsClassCourse Find(int ClassCourseID)
        {
            int ClassID = -1;
            int CourseID = -1;
            int TeacherID = -1;
            int AcademicYearID = -1;
            DateTime CreatedAt = DateTime.Now;
            DateTime UpdatedAt = DateTime.Now;
            bool IsDeleted = false;
            if (clsDAClassCourse.Find(ClassCourseID, ref ClassID, ref CourseID, ref TeacherID, ref AcademicYearID, ref CreatedAt, ref UpdatedAt, ref IsDeleted))
                return new clsClassCourse(ClassCourseID, ClassID, CourseID, TeacherID, AcademicYearID, CreatedAt, UpdatedAt, IsDeleted);
            return null;
        }

        private bool _AddNewClassCourse()
        {
            this.ClassCourseID = clsDAClassCourse.AddNewClassCourse(this.ClassID, this.CourseID, this.TeacherID, this.AcademicYearID, this.CreatedAt, this.UpdatedAt, this.IsDeleted);
            return (this.ClassCourseID != -1);
        }

        private bool _UpdateClassCourse()
        {
            return clsDAClassCourse.UpdateClassCourse(this.ClassCourseID, this.ClassID, this.CourseID, this.TeacherID, this.AcademicYearID, this.CreatedAt, this.UpdatedAt, this.IsDeleted);
        }

        
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            System.Data.DataTable dt = GetAllClassCourses();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["ClassCourseID"] != this.ClassCourseID)
                {
                    if ((int)row["ClassID"] == this.ClassID && (int)row["CourseID"] == this.CourseID && (int)row["TeacherID"] == this.TeacherID && (int)row["AcademicYearID"] == this.AcademicYearID)
                    {
                        errorMessage = "This course is already assigned to this class with the same teacher in this academic year.";
                        return false;
                    }
                }
            }
            return true;
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
                    if (_AddNewClassCourse())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateClassCourse();
            }
            return false;
        }

        public static DataTable GetAllClassCourses() => clsDAClassCourse.GetAllClassCourses();
        public static bool IsClassCourseExist(int ClassCourseID) => clsDAClassCourse.IsClassCourseExist(ClassCourseID);
        public static bool DeleteClassCourse(int ClassCourseID) => clsDAClassCourse.DeleteClassCourse(ClassCourseID);
    
        public static DataTable GetCoursesByClassID(int classID) => clsDAClassCourse.GetCoursesByClassID(classID);
        public static DataTable GetAssignmentsByTeacherID(int teacherID) => clsDAClassCourse.GetAssignmentsByTeacherID(teacherID);
        public static DataTable GetAllClassCoursesDetailed() => clsDAClassCourse.GetAllClassCoursesDetailed();

}
}
