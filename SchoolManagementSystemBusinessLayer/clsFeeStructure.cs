using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsFeeStructure
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int FeeStructureID { get; set; }
        public string Name { get; set; }
        public int GradeLevelID { get; set; }
        public int AcademicYearID { get; set; }
        public decimal TuitionFee { get; set; }
        public decimal TransportFee { get; set; }
        public decimal BookFee { get; set; }
        public decimal OtherFees { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public clsGradeLevel GradeLevelInfo => clsGradeLevel.Find(this.GradeLevelID);
        public clsAcademicYear AcademicYearInfo => clsAcademicYear.Find(this.AcademicYearID);

        public clsFeeStructure()
        {
            this.FeeStructureID = -1;
            this.Name = "";
            this.GradeLevelID = -1;
            this.AcademicYearID = -1;
            this.TuitionFee = -1;
            this.TransportFee = -1;
            this.BookFee = -1;
            this.OtherFees = -1;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsFeeStructure(int FeeStructureID, string Name, int GradeLevelID, int AcademicYearID, decimal TuitionFee, decimal TransportFee, decimal BookFee, decimal OtherFees, DateTime CreatedAt, DateTime UpdatedAt)
        {
            this.FeeStructureID = FeeStructureID;
            this.Name = Name;
            this.GradeLevelID = GradeLevelID;
            this.AcademicYearID = AcademicYearID;
            this.TuitionFee = TuitionFee;
            this.TransportFee = TransportFee;
            this.BookFee = BookFee;
            this.OtherFees = OtherFees;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            Mode = enMode.Update;
        }

        public static clsFeeStructure Find(int FeeStructureID)
        {
            string Name = "";
            int GradeLevelID = -1;
            int AcademicYearID = -1;
            decimal TuitionFee = -1;
            decimal TransportFee = -1;
            decimal BookFee = -1;
            decimal OtherFees = -1;
            DateTime CreatedAt = DateTime.Now;
            DateTime UpdatedAt = DateTime.Now;
            if (clsDAFeeStructure.Find(FeeStructureID, ref Name, ref GradeLevelID, ref AcademicYearID, ref TuitionFee, ref TransportFee, ref BookFee, ref OtherFees, ref CreatedAt, ref UpdatedAt))
                return new clsFeeStructure(FeeStructureID, Name, GradeLevelID, AcademicYearID, TuitionFee, TransportFee, BookFee, OtherFees, CreatedAt, UpdatedAt);
            return null;
        }

        private bool _AddNewFeeStructure()
        {
            this.FeeStructureID = clsDAFeeStructure.AddNewFeeStructure(this.Name, this.GradeLevelID, this.AcademicYearID, this.TuitionFee, this.TransportFee, this.BookFee, this.OtherFees, this.CreatedAt, this.UpdatedAt);
            return (this.FeeStructureID != -1);
        }

        private bool _UpdateFeeStructure()
        {
            return clsDAFeeStructure.UpdateFeeStructure(this.FeeStructureID, this.Name, this.GradeLevelID, this.AcademicYearID, this.TuitionFee, this.TransportFee, this.BookFee, this.OtherFees, this.CreatedAt, this.UpdatedAt);
        }

        
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (TuitionFee < 0 || TransportFee < 0 || BookFee < 0 || OtherFees < 0)
            {
                errorMessage = "Fee amounts must be positive numbers.";
                return false;
            }

            System.Data.DataTable dt = GetAllFeeStructures();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["FeeStructureID"] != this.FeeStructureID)
                {
                    if ((int)row["GradeLevelID"] == this.GradeLevelID && (int)row["AcademicYearID"] == this.AcademicYearID)
                    {
                        errorMessage = "A fee structure already exists for this grade level and academic year.";
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
                    if (_AddNewFeeStructure())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateFeeStructure();
            }
            return false;
        }

        public static DataTable GetAllFeeStructures() => clsDAFeeStructure.GetAllFeeStructures();
        public static bool IsFeeStructureExist(int FeeStructureID) => clsDAFeeStructure.IsFeeStructureExist(FeeStructureID);
        public static bool DeleteFeeStructure(int FeeStructureID) => clsDAFeeStructure.DeleteFeeStructure(FeeStructureID);
    }
}
