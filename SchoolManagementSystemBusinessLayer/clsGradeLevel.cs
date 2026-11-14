using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsGradeLevel
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int GradeLevelID { get; set; }
        public string Name { get; set; }
        public int OrderNo { get; set; }
        public string Description { get; set; }


        public clsGradeLevel()
        {
            this.GradeLevelID = -1;
            this.Name = "";
            this.OrderNo = -1;
            this.Description = "";
            Mode = enMode.AddNew;
        }

        private clsGradeLevel(int GradeLevelID, string Name, int OrderNo, string Description)
        {
            this.GradeLevelID = GradeLevelID;
            this.Name = Name;
            this.OrderNo = OrderNo;
            this.Description = Description;
            Mode = enMode.Update;
        }

        public static clsGradeLevel Find(int GradeLevelID)
        {
            string Name = "";
            int OrderNo = -1;
            string Description = "";
            if (clsDAGradeLevel.Find(GradeLevelID, ref Name, ref OrderNo, ref Description))
                return new clsGradeLevel(GradeLevelID, Name, OrderNo, Description);
            return null;
        }

        private bool _AddNewGradeLevel()
        {
            this.GradeLevelID = clsDAGradeLevel.AddNewGradeLevel(this.Name, this.OrderNo, this.Description);
            return (this.GradeLevelID != -1);
        }

        private bool _UpdateGradeLevel()
        {
            return clsDAGradeLevel.UpdateGradeLevel(this.GradeLevelID, this.Name, this.OrderNo, this.Description);
        }

        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(this.Name))
            {
                errorMessage = "Grade Level Name is required.";
                return false;
            }
            if (this.OrderNo <= 0)
            {
                errorMessage = "Order number must be greater than zero.";
                return false;
            }

            if(Mode == enMode.AddNew)
            {
                if (clsGradeLevel.IsGradeLevelExist(this.Name))
                {
                    errorMessage = "A Grade Level with this name already exists.";
                    return false;
                }

            }


            /*/DataTable dt = GetAllGradeLevels();
            //foreach (DataRow row in dt.Rows)
            //{
            //    if ((int)row["GradeLevelID"] != this.GradeLevelID)
            //    {
            //        if (row["Name"].ToString().Trim().Equals(this.Name.Trim(), StringComparison.OrdinalIgnoreCase))
            //        {
            //            errorMessage = "A Grade Level with this name already exists.";
            //            return false;
            //        }
            //    }
            /}*/

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
                    if (_AddNewGradeLevel())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateGradeLevel();
            }
            return false;
        }

        public static DataTable GetAllGradeLevels() => clsDAGradeLevel.GetAllGradeLevels();
        public static bool IsGradeLevelExist(int GradeLevelID) => clsDAGradeLevel.IsGradeLevelExist(GradeLevelID);
        public static bool IsGradeLevelExist(string GradeLevelName) => clsDAGradeLevel.IsGradeLevelExist(GradeLevelName);
        public static bool DeleteGradeLevel(int GradeLevelID) => clsDAGradeLevel.DeleteGradeLevel(GradeLevelID);
    }
}
