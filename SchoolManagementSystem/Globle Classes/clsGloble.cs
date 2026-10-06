using System;
using SchoolManagementSystemBusinessLayer;

namespace SchoolManagementSystem.Globle_Classes
{
    public class clsGloble
    {
        public static clsUser CurrentUser;

        public static int UserID
        {
            get
            {
                    return CurrentUser == null ? 1 : CurrentUser.UserID;
            }
        }
    }
}
