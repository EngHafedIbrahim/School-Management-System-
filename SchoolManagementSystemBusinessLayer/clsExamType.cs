using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsExamType
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int ExamTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public clsExamType()
        {
            this.ExamTypeID = -1;
            this.Name = "";
            this.Description = "";
            Mode = enMode.AddNew;
        }

        private clsExamType(int ExamTypeID, string Name, string Description)
        {
            this.ExamTypeID = ExamTypeID;
            this.Name = Name;
            this.Description = Description;
            Mode = enMode.Update;
        }

        public static clsExamType Find(int ExamTypeID)
        {
            string Name = "";
            string Description = "";
            if (clsDAExamType.Find(ExamTypeID, ref Name, ref Description))
                return new clsExamType(ExamTypeID, Name, Description);
            return null;
        }

        private bool _AddNewExamType()
        {
            this.ExamTypeID = clsDAExamType.AddNewExamType(this.Name, this.Description);
            return (this.ExamTypeID != -1);
        }

        private bool _UpdateExamType()
        {
            return clsDAExamType.UpdateExamType(this.ExamTypeID, this.Name, this.Description);
        }

        
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            System.Data.DataTable dt = GetAllExamTypes();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["ExamTypeID"] != this.ExamTypeID)
                {
                    if (row["Name"].ToString() == this.Name)
                    {
                        errorMessage = "Exam Type Name already exists.";
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
                    if (_AddNewExamType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateExamType();
            }
            return false;
        }

        public static DataTable GetAllExamTypes() => clsDAExamType.GetAllExamTypes();
        public static bool IsExamTypeExist(int ExamTypeID) => clsDAExamType.IsExamTypeExist(ExamTypeID);
        public static bool DeleteExamType(int ExamTypeID) => clsDAExamType.DeleteExamType(ExamTypeID);
    }
}
