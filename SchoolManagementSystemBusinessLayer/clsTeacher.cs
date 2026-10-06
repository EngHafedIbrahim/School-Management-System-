using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsTeacher
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Specialization { get; set; }
        public string Qualification { get; set; }
        public DateTime HireDate { get; set; }
        public string EmploymentStatus { get; set; }
        public string About { get; set; }
        public int GenderID { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public clsGender GenderInfo => clsGender.Find(this.GenderID);

        public clsTeacher()
        {
            this.TeacherID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Address = "";
            this.PhoneNumber = "";
            this.Email = "";
            this.Specialization = "";
            this.Qualification = "";
            this.HireDate = DateTime.Now;
            this.EmploymentStatus = "";
            this.About = "";
            this.GenderID = -1;
            this.CreatedBy = -1;
            this.UpdatedBy = -1;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsTeacher(int TeacherID, string FirstName, string LastName, string Address, string PhoneNumber, string Email, string Specialization, string Qualification, DateTime HireDate, string EmploymentStatus, string About, int GenderID, int CreatedBy, int UpdatedBy, DateTime CreatedAt, DateTime UpdatedAt)
        {
            this.TeacherID = TeacherID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Specialization = Specialization;
            this.Qualification = Qualification;
            this.HireDate = HireDate;
            this.EmploymentStatus = EmploymentStatus;
            this.About = About;
            this.GenderID = GenderID;
            this.CreatedBy = CreatedBy;
            this.UpdatedBy = UpdatedBy;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            Mode = enMode.Update;
        }

        public static clsTeacher Find(int TeacherID)
        {
            string FirstName = "";
            string LastName = "";
            string Address = "";
            string PhoneNumber = "";
            string Email = "";
            string Specialization = "";
            string Qualification = "";
            DateTime HireDate = DateTime.Now;
            string EmploymentStatus = "";
            string About = "";
            int GenderID = -1;
            int CreatedBy = -1;
            int UpdatedBy = -1;
            DateTime CreatedAt = DateTime.Now;
            DateTime UpdatedAt = DateTime.Now;
            if (clsDATeacher.Find(TeacherID, ref FirstName, ref LastName, ref Address, ref PhoneNumber, ref Email, ref Specialization, ref Qualification, ref HireDate, ref EmploymentStatus, ref About, ref GenderID, ref CreatedBy, ref UpdatedBy, ref CreatedAt, ref UpdatedAt))
                return new clsTeacher(TeacherID, FirstName, LastName, Address, PhoneNumber, Email, Specialization, Qualification, HireDate, EmploymentStatus, About, GenderID, CreatedBy, UpdatedBy, CreatedAt, UpdatedAt);
            return null;
        }

        private bool _AddNewTeacher()
        {
            this.TeacherID = clsDATeacher.AddNewTeacher(this.FirstName, this.LastName, this.Address, this.PhoneNumber, this.Email, this.Specialization, this.Qualification, this.HireDate, this.EmploymentStatus, this.About, this.GenderID, this.CreatedBy, this.UpdatedBy, this.CreatedAt, this.UpdatedAt);
            return (this.TeacherID != -1);
        }

        private bool _UpdateTeacher()
        {
            return clsDATeacher.UpdateTeacher(this.TeacherID, this.FirstName, this.LastName, this.Address, this.PhoneNumber, this.Email, this.Specialization, this.Qualification, this.HireDate, this.EmploymentStatus, this.About, this.GenderID, this.CreatedBy, this.UpdatedBy, this.CreatedAt, this.UpdatedAt);
        }

        
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
            {
                errorMessage = "A valid Email is required.";
                return false;
            }
            if (HireDate > DateTime.Now)
            {
                errorMessage = "Hire date cannot be in the future.";
                return false;
            }

            System.Data.DataTable dt = GetAllTeachers();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["TeacherID"] != this.TeacherID)
                {
                    if (row["Email"].ToString() == this.Email)
                    {
                        errorMessage = "Email already exists.";
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
                    if (_AddNewTeacher())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateTeacher();
            }
            return false;
        }

        public static DataTable GetAllTeachers() => clsDATeacher.GetAllTeachers();
        public static bool IsTeacherExist(int TeacherID) => clsDATeacher.IsTeacherExist(TeacherID);
        public static bool DeleteTeacher(int TeacherID) => clsDATeacher.DeleteTeacher(TeacherID);
    }
}
