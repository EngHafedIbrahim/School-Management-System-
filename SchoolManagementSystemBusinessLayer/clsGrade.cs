using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsGrade
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int GradeID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public int ExamTypeID { get; set; }
        public decimal GradeValue { get; set; }
        public decimal OutOfValue { get; set; }
        public int AcademicYearID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public clsStudent StudentInfo => clsStudent.Find(this.StudentID);
        public clsCourse CourseInfo => clsCourse.Find(this.CourseID);
        public clsExamType ExamTypeInfo => clsExamType.Find(this.ExamTypeID);
        public clsAcademicYear AcademicYearInfo => clsAcademicYear.Find(this.AcademicYearID);

        public clsGrade()
        {
            this.GradeID = -1;
            this.StudentID = -1;
            this.CourseID = -1;
            this.ExamTypeID = -1;
            this.GradeValue = -1;
            this.OutOfValue = -1;
            this.AcademicYearID = -1;
            this.CreatedBy = -1;
            this.CreatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsGrade(int GradeID, int StudentID, int CourseID, int ExamTypeID, decimal GradeValue, decimal OutOfValue, int AcademicYearID, int CreatedBy, DateTime CreatedAt)
        {
            this.GradeID = GradeID;
            this.StudentID = StudentID;
            this.CourseID = CourseID;
            this.ExamTypeID = ExamTypeID;
            this.GradeValue = GradeValue;
            this.OutOfValue = OutOfValue;
            this.AcademicYearID = AcademicYearID;
            this.CreatedBy = CreatedBy;
            this.CreatedAt = CreatedAt;
            Mode = enMode.Update;
        }

        public static clsGrade Find(int GradeID)
        {
            int StudentID = -1;
            int CourseID = -1;
            int ExamTypeID = -1;
            decimal GradeValue = -1;
            decimal OutOfValue = -1;
            int AcademicYearID = -1;
            int CreatedBy = -1;
            DateTime CreatedAt = DateTime.Now;
            if (clsDAGrade.Find(GradeID, ref StudentID, ref CourseID, ref ExamTypeID, ref GradeValue, ref OutOfValue, ref AcademicYearID, ref CreatedBy, ref CreatedAt))
                return new clsGrade(GradeID, StudentID, CourseID, ExamTypeID, GradeValue, OutOfValue, AcademicYearID, CreatedBy, CreatedAt);
            return null;
        }

        private bool _AddNewGrade()
        {
            this.GradeID = clsDAGrade.AddNewGrade(this.StudentID, this.CourseID, this.ExamTypeID, this.GradeValue, this.OutOfValue, this.AcademicYearID, this.CreatedBy, this.CreatedAt);
            return (this.GradeID != -1);
        }

        private bool _UpdateGrade()
        {
            return clsDAGrade.UpdateGrade(this.GradeID, this.StudentID, this.CourseID, this.ExamTypeID, this.GradeValue, this.OutOfValue, this.AcademicYearID, this.CreatedBy, this.CreatedAt);
        }

        
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (GradeValue < 0 || OutOfValue <= 0 || GradeValue > OutOfValue)
            {
                errorMessage = "Grade value must be positive and cannot exceed OutOfValue.";
                return false;
            }

            System.Data.DataTable dt = GetAllGrades();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["GradeID"] != this.GradeID)
                {
                    if ((int)row["StudentID"] == this.StudentID && (int)row["CourseID"] == this.CourseID && (int)row["ExamTypeID"] == this.ExamTypeID && (int)row["AcademicYearID"] == this.AcademicYearID)
                    {
                        errorMessage = "Student already has a grade for this course, exam type, and academic year.";
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
                throw new Exception(errorMessage); // Throw exception to be handled by Presentation Layer
            }

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewGrade())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateGrade();
            }
            return false;
        }

        public static DataTable GetAllGrades() => clsDAGrade.GetAllGrades();
        public static bool IsGradeExist(int GradeID) => clsDAGrade.IsGradeExist(GradeID);
        public static bool DeleteGrade(int GradeID) => clsDAGrade.DeleteGrade(GradeID);
    
        public static DataTable GetGradesByStudentID(int studentID) => clsDAGrade.GetGradesByStudentID(studentID);

}
}
