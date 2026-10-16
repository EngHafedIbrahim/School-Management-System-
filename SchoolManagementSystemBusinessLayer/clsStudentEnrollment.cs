using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsStudentEnrollment
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int StudentEnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int ClassID { get; set; }
        public int AcademicYearID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime? WithdrawalDate { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public clsStudent StudentInfo => clsStudent.Find(this.StudentID);
        public clsClass ClassInfo => clsClass.Find(this.ClassID);
        public clsAcademicYear AcademicYearInfo => clsAcademicYear.Find(this.AcademicYearID);

        public clsStudentEnrollment()
        {
            this.StudentEnrollmentID = -1;
            this.StudentID = -1;
            this.ClassID = -1;
            this.AcademicYearID = -1;
            this.EnrollmentDate = DateTime.Now;
            this.WithdrawalDate = null;
            this.Status = "";
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsStudentEnrollment(int StudentEnrollmentID, int StudentID, int ClassID, int AcademicYearID, DateTime EnrollmentDate, DateTime? WithdrawalDate, string Status, DateTime CreatedAt, DateTime UpdatedAt)
        {
            this.StudentEnrollmentID = StudentEnrollmentID;
            this.StudentID = StudentID;
            this.ClassID = ClassID;
            this.AcademicYearID = AcademicYearID;
            this.EnrollmentDate = EnrollmentDate;
            this.WithdrawalDate = WithdrawalDate;
            this.Status = Status;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            Mode = enMode.Update;
        }

        public static clsStudentEnrollment Find(int StudentEnrollmentID)
        {
            int StudentID = -1;
            int ClassID = -1;
            int AcademicYearID = -1;
            DateTime EnrollmentDate = DateTime.Now;
            DateTime? WithdrawalDate = null;
            string Status = "";
            DateTime CreatedAt = DateTime.Now;
            DateTime UpdatedAt = DateTime.Now;
            if (clsDAStudentEnrollment.Find(StudentEnrollmentID, ref StudentID, ref ClassID, ref AcademicYearID, ref EnrollmentDate, ref WithdrawalDate, ref Status, ref CreatedAt, ref UpdatedAt))
                return new clsStudentEnrollment(StudentEnrollmentID, StudentID, ClassID, AcademicYearID, EnrollmentDate, WithdrawalDate, Status, CreatedAt, UpdatedAt);
            return null;
        }

        private bool _AddNewStudentEnrollment()
        {
            this.StudentEnrollmentID = clsDAStudentEnrollment.AddNewStudentEnrollment(this.StudentID, this.ClassID, this.AcademicYearID, this.EnrollmentDate, this.WithdrawalDate, this.Status, this.CreatedAt, this.UpdatedAt);
            return (this.StudentEnrollmentID != -1);
        }

        private bool _UpdateStudentEnrollment()
        {
            return clsDAStudentEnrollment.UpdateStudentEnrollment(this.StudentEnrollmentID, this.StudentID, this.ClassID, this.AcademicYearID, this.EnrollmentDate, this.WithdrawalDate, this.Status, this.CreatedAt, this.UpdatedAt);
        }

        
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (EnrollmentDate > DateTime.Now)
            {
                errorMessage = "Enrollment date cannot be in the future.";
                return false;
            }

            System.Data.DataTable dt = GetAllStudentEnrollments();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["StudentEnrollmentID"] != this.StudentEnrollmentID)
                {
                    if ((int)row["StudentID"] == this.StudentID && (int)row["AcademicYearID"] == this.AcademicYearID)
                    {
                        errorMessage = "Student is already enrolled in a class for this academic year.";
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
                    if (_AddNewStudentEnrollment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateStudentEnrollment();
            }
            return false;
        }

        public static DataTable GetAllStudentEnrollments() => clsDAStudentEnrollment.GetAllStudentEnrollments();
        public static bool IsStudentEnrollmentExist(int StudentEnrollmentID) => clsDAStudentEnrollment.IsStudentEnrollmentExist(StudentEnrollmentID);
        public static bool DeleteStudentEnrollment(int StudentEnrollmentID) => clsDAStudentEnrollment.DeleteStudentEnrollment(StudentEnrollmentID);
    
        public static DataTable GetEnrollmentHistoryByStudentID(int studentID) => clsDAStudentEnrollment.GetEnrollmentHistoryByStudentID(studentID);


        public static DataTable GetStudentsByClassID(int classID) => clsDAStudentEnrollment.GetStudentsByClassID(classID);


        public static DataTable GetEnrollmentsByStudentID(int studentID) => clsDAStudentEnrollment.GetEnrollmentsByStudentID(studentID);

}
}
