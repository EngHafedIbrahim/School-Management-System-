using System;

namespace SchoolManagementSystem.Globle_Classes
{
    public class clsCheckRights
    {
        public static bool HasPermission(int UserPermissions, int Required)
        {
            return (UserPermissions & Required) == Required;
        }
    }
}
