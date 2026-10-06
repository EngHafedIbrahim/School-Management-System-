using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsRoom
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int RoomID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }


        public clsRoom()
        {
            this.RoomID = -1;
            this.Name = "";
            this.Capacity = -1;
            this.Description = "";
            Mode = enMode.AddNew;
        }

        private clsRoom(int RoomID, string Name, int Capacity, string Description)
        {
            this.RoomID = RoomID;
            this.Name = Name;
            this.Capacity = Capacity;
            this.Description = Description;
            Mode = enMode.Update;
        }

        public static clsRoom Find(int RoomID)
        {
            string Name = "";
            int Capacity = -1;
            string Description = "";
            if (clsDARoom.Find(RoomID, ref Name, ref Capacity, ref Description))
                return new clsRoom(RoomID, Name, Capacity, Description);
            return null;
        }

        private bool _AddNewRoom()
        {
            this.RoomID = clsDARoom.AddNewRoom(this.Name, this.Capacity, this.Description);
            return (this.RoomID != -1);
        }

        private bool _UpdateRoom()
        {
            return clsDARoom.UpdateRoom(this.RoomID, this.Name, this.Capacity, this.Description);
        }

        
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            if (Capacity <= 0)
            {
                errorMessage = "Capacity must be a positive number.";
                return false;
            }

            System.Data.DataTable dt = GetAllRooms();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["RoomID"] != this.RoomID)
                {
                    if (row["Name"].ToString() == this.Name)
                    {
                        errorMessage = "Room Name already exists.";
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
                    if (_AddNewRoom())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateRoom();
            }
            return false;
        }

        public static DataTable GetAllRooms() => clsDARoom.GetAllRooms();
        public static bool IsRoomExist(int RoomID) => clsDARoom.IsRoomExist(RoomID);
        public static bool DeleteRoom(int RoomID) => clsDARoom.DeleteRoom(RoomID);
    }
}
