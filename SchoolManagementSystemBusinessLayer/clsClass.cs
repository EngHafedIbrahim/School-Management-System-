using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsClass
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int ClassID { get; set; }
        public string Name { get; set; }
        public int GradeLevelID { get; set; }
        public string Details { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public clsGradeLevel GradeLevelInfo => clsGradeLevel.Find(this.GradeLevelID);

        public clsClass()
        {
            this.ClassID = -1;
            this.Name = "";
            this.GradeLevelID = -1;
            this.Details = "";
            this.CreatedBy = -1;
            this.UpdatedBy = -1;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.IsDeleted = false;
            Mode = enMode.AddNew;
        }

        private clsClass(int ClassID, string Name, int GradeLevelID, string Details, int CreatedBy, int UpdatedBy, DateTime CreatedAt, DateTime UpdatedAt, bool IsDeleted)
        {
            this.ClassID = ClassID;
            this.Name = Name;
            this.GradeLevelID = GradeLevelID;
            this.Details = Details;
            this.CreatedBy = CreatedBy;
            this.UpdatedBy = UpdatedBy;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.IsDeleted = IsDeleted;
            Mode = enMode.Update;
        }

        public static clsClass Find(int ClassID)
        {
            string Name = "";
            int GradeLevelID = -1;
            string Details = "";
            int CreatedBy = -1;
            int UpdatedBy = -1;
            DateTime CreatedAt = DateTime.Now;
            DateTime UpdatedAt = DateTime.Now;
            bool IsDeleted = false;
            if (clsDAClass.Find(ClassID, ref Name, ref GradeLevelID, ref Details, ref CreatedBy, ref UpdatedBy, ref CreatedAt, ref UpdatedAt, ref IsDeleted))
                return new clsClass(ClassID, Name, GradeLevelID, Details, CreatedBy, UpdatedBy, CreatedAt, UpdatedAt, IsDeleted);
            return null;
        }

        private bool _AddNewClass()
        {
            this.ClassID = clsDAClass.AddNewClass(this.Name, this.GradeLevelID, this.Details, this.CreatedBy, this.UpdatedBy, this.CreatedAt, this.UpdatedAt, this.IsDeleted);
            return (this.ClassID != -1);
        }

        private bool _UpdateClass()
        {
            return clsDAClass.UpdateClass(this.ClassID, this.Name, this.GradeLevelID, this.Details, this.CreatedBy, this.UpdatedBy, this.CreatedAt, this.UpdatedAt, this.IsDeleted);
        }

        public bool Validate(out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrEmpty(this.Name) || this.GradeLevelID <= 0)
            {
                errorMessage = "Class Name OR Grade Level are NULL .";
                return false;
            }

            if (this.IsClassExistWithGradeLevel())
            {
                errorMessage = "Class Name already exists in this Grade Level.";
                return false;
            }

            /*
                //System.Data.DataTable dt = GetAllClasss();
                //foreach (System.Data.DataRow row in dt.Rows)
                //{
                //    if ((int)row["ClassID"] != this.ClassID)
                //    {
                //        if (row["Name"].ToString() == this.Name && (int)row["GradeLevelID"] == this.GradeLevelID)
                //        {
                //            errorMessage = "Class Name already exists in this Grade Level.";
                //            return false;
                //        }
                //    }
                /}
            */
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
                    if (_AddNewClass())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateClass();
            }
            return false;
        }

        public  bool IsClassExistWithGradeLevel() => clsDAClass.IsClassExistWithGradeLevel(this.Name,this.GradeLevelID);
        public static DataTable GetAllClasss() => clsDAClass.GetAllClasss();
        public static DataTable GetClassesDetailed() => clsDAClass.GetClassesDetailed();
        public static bool IsClassExist(int ClassID) => clsDAClass.IsClassExist(ClassID);
        public static bool DeleteClass(int ClassID) => clsDAClass.DeleteClass(ClassID);


    }
}
