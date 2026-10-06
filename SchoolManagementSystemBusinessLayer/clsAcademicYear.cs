using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsAcademicYear
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;
        public int AcademicYearID { get; set; }
        public string YearName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCurrent { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public clsAcademicYear()
        {
            this.AcademicYearID = -1;
            this.YearName = "";
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now;
            this.IsCurrent = false;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }
        private clsAcademicYear(int AcademicYearID, string YearName, DateTime StartDate, DateTime EndDate, bool IsCurrent, DateTime CreatedAt, DateTime UpdatedAt)
        {
            this.AcademicYearID = AcademicYearID;
            this.YearName = YearName;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IsCurrent = IsCurrent;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            Mode = enMode.Update;
        }
        public static clsAcademicYear Find(int AcademicYearID)
        {
            string YearName = "";
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DateTime.Now;
            bool IsCurrent = false;
            DateTime CreatedAt = DateTime.Now;
            DateTime UpdatedAt = DateTime.Now;
            if (clsDAAcademicYear.Find(AcademicYearID, ref YearName, ref StartDate, ref EndDate, ref IsCurrent, ref CreatedAt, ref UpdatedAt))
                return new clsAcademicYear(AcademicYearID, YearName, StartDate, EndDate, IsCurrent, CreatedAt, UpdatedAt);
            return null;
        }
        private bool _AddNewAcademicYear()
        {
            this.AcademicYearID = clsDAAcademicYear.AddNewAcademicYear(this.YearName, this.StartDate, this.EndDate, this.IsCurrent, this.CreatedAt, this.UpdatedAt);
            return (this.AcademicYearID != -1);
        }
        private bool _UpdateAcademicYear()
        {
            return clsDAAcademicYear.UpdateAcademicYear(this.AcademicYearID, this.YearName, this.StartDate, this.EndDate, this.IsCurrent, this.CreatedAt, this.UpdatedAt);
        }
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            if (StartDate >= EndDate)
            {
                errorMessage = "Start date must be before end date.";
                return false;
            }

            System.Data.DataTable dt = GetAllAcademicYears();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["AcademicYearID"] != this.AcademicYearID)
                {
                    if (row["YearName"].ToString() == this.YearName)
                    {
                        errorMessage = "Academic Year Name already exists.";
                        return false;
                    }
                    if (this.IsCurrent && (bool)row["IsCurrent"])
                    {
                        errorMessage = "There can only be one Current Academic Year at a time.";
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
                    if (_AddNewAcademicYear())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateAcademicYear();
            }
            return false;
        }
        public static DataTable GetAllAcademicYears() => clsDAAcademicYear.GetAllAcademicYears();
        public static bool IsAcademicYearExist(int AcademicYearID) => clsDAAcademicYear.IsAcademicYearExist(AcademicYearID);
        public static bool DeleteAcademicYear(int AcademicYearID) => clsDAAcademicYear.DeleteAcademicYear(AcademicYearID);
        public static bool SetCurrentAcademicYear(int academicYearID) => clsDAAcademicYear.SetCurrentAcademicYear(academicYearID);
        public bool IsAcademicYearNameAlreadyExist()
        {
            return false;
        }
    }
}
