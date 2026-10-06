using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsCourse
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int CourseID { get; set; }
        public string Name { get; set; }
        public int CreditHours { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }


        public clsCourse()
        {
            this.CourseID = -1;
            this.Name = "";
            this.CreditHours = -1;
            this.Description = "";
            this.CreatedBy = -1;
            this.UpdatedBy = -1;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.IsDeleted = false;
            Mode = enMode.AddNew;
        }

        private clsCourse(int CourseID, string Name, int CreditHours, string Description, int CreatedBy, int UpdatedBy, DateTime CreatedAt, DateTime UpdatedAt, bool IsDeleted)
        {
            this.CourseID = CourseID;
            this.Name = Name;
            this.CreditHours = CreditHours;
            this.Description = Description;
            this.CreatedBy = CreatedBy;
            this.UpdatedBy = UpdatedBy;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.IsDeleted = IsDeleted;
            Mode = enMode.Update;
        }

        public static clsCourse Find(int CourseID)
        {
            string Name = "";
            int CreditHours = -1;
            string Description = "";
            int CreatedBy = -1;
            int UpdatedBy = -1;
            DateTime CreatedAt = DateTime.Now;
            DateTime UpdatedAt = DateTime.Now;
            bool IsDeleted = false;
            if (clsDACourse.Find(CourseID, ref Name, ref CreditHours, ref Description, ref CreatedBy, ref UpdatedBy, ref CreatedAt, ref UpdatedAt, ref IsDeleted))
                return new clsCourse(CourseID, Name, CreditHours, Description, CreatedBy, UpdatedBy, CreatedAt, UpdatedAt, IsDeleted);
            return null;
        }

        private bool _AddNewCourse()
        {
            this.CourseID = clsDACourse.AddNewCourse(this.Name, this.CreditHours, this.Description, this.CreatedBy, this.UpdatedBy, this.CreatedAt, this.UpdatedAt, this.IsDeleted);
            return (this.CourseID != -1);
        }

        private bool _UpdateCourse()
        {
            return clsDACourse.UpdateCourse(this.CourseID, this.Name, this.CreditHours, this.Description, this.CreatedBy, this.UpdatedBy, this.CreatedAt, this.UpdatedAt, this.IsDeleted);
        }

        
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (CreditHours <= 0)
            {
                errorMessage = "Credit Hours must be a positive integer.";
                return false;
            }

            System.Data.DataTable dt = GetAllCourses();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["CourseID"] != this.CourseID)
                {
                    if (row["Name"].ToString() == this.Name)
                    {
                        errorMessage = "Course Name already exists.";
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
                    if (_AddNewCourse())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateCourse();
            }
            return false;
        }

        public static DataTable GetAllCourses() => clsDACourse.GetAllCourses();
        public static bool IsCourseExist(int CourseID) => clsDACourse.IsCourseExist(CourseID);
        public static bool DeleteCourse(int CourseID) => clsDACourse.DeleteCourse(CourseID);
    }
}
