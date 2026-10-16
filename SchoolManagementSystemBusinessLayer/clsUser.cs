using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsUser
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string UserType { get; set; }
        public int? ReferenceID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public clsUser()
        {
            this.UserID = -1;
            this.Username = "";
            this.PasswordHash = "";
            this.Email = "";
            this.Status = "";
            this.UserType = "";
            this.ReferenceID = null;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, string Username, string PasswordHash, string Email, string Status, string UserType, int? ReferenceID, DateTime CreatedAt, DateTime UpdatedAt)
        {
            this.UserID = UserID;
            this.Username = Username;
            this.PasswordHash = PasswordHash;
            this.Email = Email;
            this.Status = Status;
            this.UserType = UserType;
            this.ReferenceID = ReferenceID;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            Mode = enMode.Update;
        }

        public static clsUser Find(int UserID)
        {
            string Username = "";
            string PasswordHash = "";
            string Email = "";
            string Status = "";
            string UserType = "";
            int? ReferenceID = null;
            DateTime CreatedAt = DateTime.Now;
            DateTime UpdatedAt = DateTime.Now;
            if (clsDAUser.Find(UserID, ref Username, ref PasswordHash, ref Email, ref Status, ref UserType, ref ReferenceID, ref CreatedAt, ref UpdatedAt))
                return new clsUser(UserID, Username, PasswordHash, Email, Status, UserType, ReferenceID, CreatedAt, UpdatedAt);
            return null;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsDAUser.AddNewUser(this.Username, this.PasswordHash, this.Email, this.Status, this.UserType, this.ReferenceID, this.CreatedAt, this.UpdatedAt);
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsDAUser.UpdateUser(this.UserID, this.Username, this.PasswordHash, this.Email, this.Status, this.UserType, this.ReferenceID, this.CreatedAt, this.UpdatedAt);
        }

        
                public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (UserType != "Admin" && UserType != "Teacher" && UserType != "Parent" && UserType != "Student")
            {
                errorMessage = "UserType must be Admin, Teacher, Parent, or Student.";
                return false;
            }

            // Reference Integrity Check
            if (this.ReferenceID.HasValue)
            {
                if (UserType == "Student" && !clsStudent.IsStudentExist(this.ReferenceID.Value))
                {
                    errorMessage = "Linked Student does not exist.";
                    return false;
                }
                if (UserType == "Teacher" && !clsTeacher.IsTeacherExist(this.ReferenceID.Value))
                {
                    errorMessage = "Linked Teacher does not exist.";
                    return false;
                }
                if (UserType == "Parent" && !clsParent.IsParentExist(this.ReferenceID.Value))
                {
                    errorMessage = "Linked Parent does not exist.";
                    return false;
                }
            }

            System.Data.DataTable dt = GetAllUsers();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["UserID"] != this.UserID)
                {
                    if (row["Username"].ToString() == this.Username)
                    {
                        errorMessage = "Username already exists.";
                        return false;
                    }
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
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static DataTable GetAllUsers() => clsDAUser.GetAllUsers();
        public static bool IsUserExist(int UserID) => clsDAUser.IsUserExist(UserID);
        
        public static clsUser Login(string username, string passwordHash)
        {
            System.Data.DataTable dt = GetAllUsers();

            

            foreach (System.Data.DataRow row in dt.Rows)
            {
                if (row["Username"].ToString() == username && row["PasswordHash"].ToString() == passwordHash)
                {
                    if (row["Status"].ToString() != "Active")
                    {
                        throw new Exception("Account is inactive.");
                    }
                    return Find((int)row["UserID"]);
                }
            }
            return null;
        }

        public static bool DeleteUser(int UserID) => clsDAUser.DeleteUser(UserID);
    
        public static DataTable GetAllUsersDetailed() => clsDAUser.GetAllUsersDetailed();
        public static bool IsUsernameExist(string username, int excludeUserID = -1) => clsDAUser.IsUsernameExist(username, excludeUserID);
        public static bool IsEmailExist(string email, int excludeUserID = -1) => clsDAUser.IsEmailExist(email, excludeUserID);
        public static bool UpdateUserStatus(int userID, string status) => clsDAUser.UpdateUserStatus(userID, status);
        public static bool ResetPassword(int userID, string newPasswordHash) => clsDAUser.ResetPassword(userID, newPasswordHash);
        public static bool IsReferenceAlreadyLinked(string userType, int referenceID, int excludeUserID = -1) => clsDAUser.IsReferenceAlreadyLinked(userType, referenceID, excludeUserID);

}
}
