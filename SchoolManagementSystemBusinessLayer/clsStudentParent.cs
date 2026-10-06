using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsStudentParent
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int StudentParentID { get; set; }
        public int StudentID { get; set; }
        public int ParentID { get; set; }
        public string Relationship { get; set; }
        public bool IsPrimaryContact { get; set; }

        public clsStudent StudentInfo => clsStudent.Find(this.StudentID);
        public clsParent ParentInfo => clsParent.Find(this.ParentID);

        public clsStudentParent()
        {
            this.StudentParentID = -1;
            this.StudentID = -1;
            this.ParentID = -1;
            this.Relationship = "";
            this.IsPrimaryContact = false;
            Mode = enMode.AddNew;
        }

        private clsStudentParent(int StudentParentID, int StudentID, int ParentID, string Relationship, bool IsPrimaryContact)
        {
            this.StudentParentID = StudentParentID;
            this.StudentID = StudentID;
            this.ParentID = ParentID;
            this.Relationship = Relationship;
            this.IsPrimaryContact = IsPrimaryContact;
            Mode = enMode.Update;
        }

        public static clsStudentParent Find(int StudentParentID)
        {
            int StudentID = -1;
            int ParentID = -1;
            string Relationship = "";
            bool IsPrimaryContact = false;
            if (clsDAStudentParent.Find(StudentParentID, ref StudentID, ref ParentID, ref Relationship, ref IsPrimaryContact))
                return new clsStudentParent(StudentParentID, StudentID, ParentID, Relationship, IsPrimaryContact);
            return null;
        }

        private bool _AddNewStudentParent()
        {
            this.StudentParentID = clsDAStudentParent.AddNewStudentParent(this.StudentID, this.ParentID, this.Relationship, this.IsPrimaryContact);
            return (this.StudentParentID != -1);
        }

        private bool _UpdateStudentParent()
        {
            return clsDAStudentParent.UpdateStudentParent(this.StudentParentID, this.StudentID, this.ParentID, this.Relationship, this.IsPrimaryContact);
        }

        public bool Validate(out string errorMessage)
        {
            errorMessage = "";

            if (this.IsThisStudentAlreadyLinkedToThisParent())
            {
                errorMessage = "This student is already linked to this parent with the same relationship.";
                return false;
            }


            /*
            //System.Data.DataTable dt = GetAllStudentParents();
            //bool hasPrimary = false;

            //foreach (System.Data.DataRow row in dt.Rows)
            //{
            //    if ((int)row["StudentParentID"] != this.StudentParentID)
            //    {
            //        if ((int)row["StudentID"] == this.StudentID && (int)row["ParentID"] == this.ParentID )
            //        {
            //            errorMessage = "This student is already linked to this parent with the same relationship.";
            //            return false;
            //        }
            //        if ((int)row["StudentID"] == this.StudentID && (bool)row["IsPrimaryContact"])
            //        {
            //            hasPrimary = true;
            //        }
            //    }
            //}

            // If this is not primary and student has no primary, we must enforce it.
            // Simplified: UI should enforce at least one primary.
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
                    if (_AddNewStudentParent())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateStudentParent();
            }
            return false;
        }
        public static DataTable GetAllStudentParents() => clsDAStudentParent.GetAllStudentParents();
        public static bool IsStudentParentExist(int StudentParentID) => clsDAStudentParent.IsStudentParentExist(StudentParentID);
        public static bool DeleteStudentParent(int StudentParentID) => clsDAStudentParent.DeleteStudentParent(StudentParentID);
        public static DataTable GetParentsByStudentID(int studentID) => clsDAStudentParent.GetParentsByStudentID(studentID);
        public static DataTable GetStudentsByParentID(int parentID) => clsDAStudentParent.GetStudentsByParentID(parentID);
        public bool IsThisStudentAlreadyLinkedToThisParent()
        {
            return clsDAStudentParent.IsThisStudentAlreadyLinkedToThisParent(this.StudentID,this.ParentID);
        }


    }
}
