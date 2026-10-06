using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsGender
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int GenderID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public clsGender()
        {
            this.GenderID = -1;
            this.Name = "";
            this.Description = "";
            Mode = enMode.AddNew;
        }

        private clsGender(int GenderID, string Name, string Description)
        {
            this.GenderID = GenderID;
            this.Name = Name;
            this.Description = Description;
            Mode = enMode.Update;
        }

        public static clsGender Find(int GenderID)
        {
            string Name = "";
            string Description = "";
            if (clsDAGender.Find(GenderID, ref Name, ref Description))
                return new clsGender(GenderID, Name, Description);
            return null;
        }

        private bool _AddNewGender()
        {
            this.GenderID = clsDAGender.AddNewGender(this.Name, this.Description);
            return (this.GenderID != -1);
        }

        private bool _UpdateGender()
        {
            return clsDAGender.UpdateGender(this.GenderID, this.Name, this.Description);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewGender())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateGender();
            }
            return false;
        }

        public static DataTable GetAllGenders() => clsDAGender.GetAllGenders();
        public static bool IsGenderExist(int GenderID) => clsDAGender.IsGenderExist(GenderID);
        public static bool DeleteGender(int GenderID) => clsDAGender.DeleteGender(GenderID);
    }
}
