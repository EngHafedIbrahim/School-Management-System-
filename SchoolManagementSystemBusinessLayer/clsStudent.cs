using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsStudent
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GenderID { get; set; }
        public string Nationality { get; set; }
        public string BloodType { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AdmissionNo { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string PreviousSchool { get; set; }
        public string HealthStatus { get; set; }
        public string ProfileImageURL { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public clsGender GenderInfo => clsGender.Find(this.GenderID);

        public enum enGender { Male = 1 , Female = 2, Other = 3 }
        enGender eGender = enGender.Male;

        public clsStudent()
        {
            this.StudentID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.NationalID = "";
            this.DateOfBirth = DateTime.Now;
            this.GenderID = -1;
            this.Nationality = "";
            this.BloodType = "";
            this.Address = "";
            this.PhoneNumber = "";
            this.Email = "";
            this.AdmissionNo = "";
            this.AdmissionDate = DateTime.Now;
            this.PreviousSchool = "";
            this.HealthStatus = "";
            this.ProfileImageURL = "";
            this.CreatedBy = -1;
            this.UpdatedBy = -1;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsStudent(int StudentID, string FirstName, string LastName, string NationalID, DateTime DateOfBirth, int GenderID, string Nationality, string BloodType, string Address, string PhoneNumber, string Email, string AdmissionNo, DateTime AdmissionDate, string PreviousSchool, string HealthStatus, string ProfileImageURL, int CreatedBy, int UpdatedBy, DateTime CreatedAt, DateTime UpdatedAt)
        {
            this.StudentID = StudentID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NationalID = NationalID;
            this.DateOfBirth = DateOfBirth;
            this.GenderID = GenderID;
            this.Nationality = Nationality;
            this.BloodType = BloodType;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.AdmissionNo = AdmissionNo;
            this.AdmissionDate = AdmissionDate;
            this.PreviousSchool = PreviousSchool;
            this.HealthStatus = HealthStatus;
            this.ProfileImageURL = ProfileImageURL;
            this.CreatedBy = CreatedBy;
            this.UpdatedBy = UpdatedBy;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            Mode = enMode.Update;
        }

        public static clsStudent Find(int StudentID)
        {
            string FirstName = "";
            string LastName = "";
            string NationalID = "";
            DateTime DateOfBirth = DateTime.Now;
            int GenderID = -1;
            string Nationality = "";
            string BloodType = "";
            string Address = "";
            string PhoneNumber = "";
            string Email = "";
            string AdmissionNo = "";
            DateTime AdmissionDate = DateTime.Now;
            string PreviousSchool = "";
            string HealthStatus = "";
            string ProfileImageURL = "";
            int CreatedBy = -1;
            int UpdatedBy = -1;
            DateTime CreatedAt = DateTime.Now;
            DateTime UpdatedAt = DateTime.Now;
            if (clsDAStudent.Find(StudentID, ref FirstName, ref LastName, ref NationalID, ref DateOfBirth, ref GenderID, ref Nationality, ref BloodType, ref Address, ref PhoneNumber, ref Email, ref AdmissionNo, ref AdmissionDate, ref PreviousSchool, ref HealthStatus, ref ProfileImageURL, ref CreatedBy, ref UpdatedBy, ref CreatedAt, ref UpdatedAt))
                return new clsStudent(StudentID, FirstName, LastName, NationalID, DateOfBirth, GenderID, Nationality, BloodType, Address, PhoneNumber, Email, AdmissionNo, AdmissionDate, PreviousSchool, HealthStatus, ProfileImageURL, CreatedBy, UpdatedBy, CreatedAt, UpdatedAt);
            return null;
        }

        private bool _AddNewStudent()
        {
            this.StudentID = clsDAStudent.AddNewStudent(this.FirstName, this.LastName, this.NationalID, this.DateOfBirth, this.GenderID, this.Nationality, this.BloodType, this.Address, this.PhoneNumber, this.Email, this.AdmissionNo, this.AdmissionDate, this.PreviousSchool, this.HealthStatus, this.ProfileImageURL, this.CreatedBy, this.UpdatedBy, this.CreatedAt, this.UpdatedAt);
            return (this.StudentID != -1);
        }

        private bool _UpdateStudent()
        {

            return clsDAStudent.UpdateStudent(this.StudentID, this.FirstName, this.LastName, this.NationalID, this.DateOfBirth, this.GenderID, this.Nationality, this.BloodType, this.Address, this.PhoneNumber, this.Email, this.AdmissionNo, this.AdmissionDate, this.PreviousSchool, this.HealthStatus, this.ProfileImageURL, this.CreatedBy, this.UpdatedBy, this.CreatedAt, this.UpdatedAt);
        }

        string errorMessage;
        async public Task< bool> Validate()
        {
            errorMessage = "";
            
            if (string.IsNullOrWhiteSpace(NationalID))
            {
                errorMessage = "National ID is required.";
                
                return false;
            }
            if (string.IsNullOrWhiteSpace(AdmissionNo))
            {
                errorMessage = "Admission No is required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
            {
                errorMessage = "A valid Email is required.";
                return false;
            }
            
            // Check minimum age (e.g. 4 years)
            if (DateTime.Now.Year - DateOfBirth.Year < 4)
            {
                errorMessage = "Student must be at least 4 years old.";
                return false;
            }

            // Uniqueness checks (Using GetAll for simplicity in prototype, ideally use DAL methods)
            //System.Data.DataTable dt = GetAllStudents();

            
            if (clsStudent.DoesNationalIDAlreadyExist(this.NationalID) )
            {
                errorMessage = "National ID already exists.";
                return false;
            }
            if (clsStudent.DoesAdmissionNoAlreadyExist(this.AdmissionNo))
            {
                errorMessage = "Admission No already exists.";
                return false;
            }
            if (clsStudent.DoesEmailAlreadyExist( this.Email))
            {
                errorMessage = "Email already exists.";
                return false;
            }
         
            
            return true;
        }

        async public Task <bool> Save()
        {
            bool Valid = await Validate();
            
            //string errorMessage;
            if (!Valid)
            {
                throw new Exception(errorMessage); // Throw exception to be handled by Presentation Layer
            }

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewStudent())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateStudent();
            }
            return false;
        }
        public static DataTable GetAllStudents() => clsDAStudent.GetAllStudents();
        public static bool IsStudentExist(int StudentID) => clsDAStudent.IsStudentExist(StudentID);
        public static bool DeleteStudent(int StudentID) => clsDAStudent.DeleteStudent(StudentID);
        public static DataTable GetStudentsDetailed() => clsDAStudent.GetStudentsDetailed();
        public static bool DoesNationalIDAlreadyExist(string NationalID)
        {
            return clsDAStudent.DoesNationalIDAlreadyExist(NationalID);
        }
        public static bool DoesEmailAlreadyExist(string Email)
        {
            return clsDAStudent.DoesEmailAlreadyExist(Email);
        }
        public static bool DoesAdmissionNoAlreadyExist(string AdmissionNo)
        {
            return clsDAStudent.DoesAdmissionNoAlreadyExist(AdmissionNo);
        }


    }
}
