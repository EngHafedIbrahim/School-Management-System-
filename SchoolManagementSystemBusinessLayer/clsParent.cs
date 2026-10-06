using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsParent
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int ParentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string RelationshipType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }


        public clsParent()
        {
            this.ParentID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.PhoneNumber = "";
            this.Email = "";
            this.Address = "";
            this.RelationshipType = "";
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.IsDeleted = false;
            Mode = enMode.AddNew;
        }

        private clsParent(int ParentID, string FirstName, string LastName, string PhoneNumber, string Email, string Address, string RelationshipType, DateTime CreatedAt, DateTime UpdatedAt, bool IsDeleted)
        {
            this.ParentID = ParentID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;
            this.RelationshipType = RelationshipType;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.IsDeleted = IsDeleted;
            Mode = enMode.Update;
        }

        public static clsParent Find(int ParentID)
        {
            string FirstName = "";
            string LastName = "";
            string PhoneNumber = "";
            string Email = "";
            string Address = "";
            string RelationshipType = "";
            DateTime CreatedAt = DateTime.Now;
            DateTime UpdatedAt = DateTime.Now;
            bool IsDeleted = false;
            if (clsDAParent.Find(ParentID, ref FirstName, ref LastName, ref PhoneNumber, ref Email, ref Address, ref RelationshipType, ref CreatedAt, ref UpdatedAt, ref IsDeleted))
                return new clsParent(ParentID, FirstName, LastName, PhoneNumber, Email, Address, RelationshipType, CreatedAt, UpdatedAt, IsDeleted);
            return null;
        }

        private bool _AddNewParent()
        {
            this.ParentID = clsDAParent.AddNewParent(this.FirstName, this.LastName, this.PhoneNumber, this.Email, this.Address, this.RelationshipType, this.CreatedAt, this.UpdatedAt, this.IsDeleted);
            return (this.ParentID != -1);
        }

        private bool _UpdateParent()
        {
            return clsDAParent.UpdateParent(this.ParentID, this.FirstName, this.LastName, this.PhoneNumber, this.Email, this.Address, this.RelationshipType, this.CreatedAt, this.UpdatedAt, this.IsDeleted);
        }

        
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
            {
                errorMessage = "A valid Email is required.";
                return false;
            }


            if (clsParent.DoesEmailExist(this.Email))
            {
                errorMessage = "Parent Email already exists.";
                return false;
            }

            /* 
            //System.Data.DataTable dt = GetAllParents();
            //foreach (System.Data.DataRow row in dt.Rows)
            //{
            //    if ((int)row["ParentID"] != this.ParentID)
            //    {
            //        if (row["Email"].ToString() == this.Email)
            //        {
            //            errorMessage = "Parent Email already exists.";
            //            return false;
            //        }
            //    }
            //}
            */
            return true;
        }



        public bool Save()
        {
            string errorMessage;
            if (!Validate(out errorMessage))
            {
                throw new Exception(errorMessage);
                return false;

            }

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewParent())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateParent();
            }
            return false;
        }

        public static DataTable GetAllParents() => clsDAParent.GetAllParents();
        public static bool IsParentExist(int ParentID) => clsDAParent.IsParentExist(ParentID);
        public static bool DeleteParent(int ParentID) => clsDAParent.DeleteParent(ParentID);
        public static DataTable GetAllParentsWithChildrenCount() => clsDAParent.GetAllParentsWithChildrenCount();
        public static bool DoesEmailExist(string Email) =>clsDAParent.DoesEmailExist(Email);
        
             
        
    }
}
