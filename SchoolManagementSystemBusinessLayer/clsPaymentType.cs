using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsPaymentType
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int PaymentTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public clsPaymentType()
        {
            this.PaymentTypeID = -1;
            this.Name = "";
            this.Description = "";
            Mode = enMode.AddNew;
        }

        private clsPaymentType(int PaymentTypeID, string Name, string Description)
        {
            this.PaymentTypeID = PaymentTypeID;
            this.Name = Name;
            this.Description = Description;
            Mode = enMode.Update;
        }

        public static clsPaymentType Find(int PaymentTypeID)
        {
            string Name = "";
            string Description = "";
            if (clsDAPaymentType.Find(PaymentTypeID, ref Name, ref Description))
                return new clsPaymentType(PaymentTypeID, Name, Description);
            return null;
        }

        private bool _AddNewPaymentType()
        {
            this.PaymentTypeID = clsDAPaymentType.AddNewPaymentType(this.Name, this.Description);
            return (this.PaymentTypeID != -1);
        }

        private bool _UpdatePaymentType()
        {
            return clsDAPaymentType.UpdatePaymentType(this.PaymentTypeID, this.Name, this.Description);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPaymentType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdatePaymentType();
            }
            return false;
        }

        public static DataTable GetAllPaymentTypes() => clsDAPaymentType.GetAllPaymentTypes();
        public static bool IsPaymentTypeExist(int PaymentTypeID) => clsDAPaymentType.IsPaymentTypeExist(PaymentTypeID);
        public static bool DeletePaymentType(int PaymentTypeID) => clsDAPaymentType.DeletePaymentType(PaymentTypeID);
    
        public static bool IsPaymentTypeUsed(int paymentTypeID) => clsDAPaymentType.IsPaymentTypeUsed(paymentTypeID);

}
}
