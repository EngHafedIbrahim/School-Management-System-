import os
import re

bll_dir = r"C:\Users\Eng.Hafed\Desktop\School Management System\SchoolManagementSystemBusinessLayer"
user_path = os.path.join(bll_dir, "clsUser.cs")

user_fix = """        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (UserType != "Admin" && UserType != "Teacher" && UserType != "Parent" && UserType != "Student")
            {
                errorMessage = "UserType must be Admin, Teacher, Parent, or Student.";
                return false;
            }

            // Reference Integrity Check
            if (this.ReferenceID.HasValue)
            {
                if (UserType == "Student" && !clsStudent.IsStudentExist(this.ReferenceID.Value))
                {
                    errorMessage = "Linked Student does not exist.";
                    return false;
                }
                if (UserType == "Teacher" && !clsTeacher.IsTeacherExist(this.ReferenceID.Value))
                {
                    errorMessage = "Linked Teacher does not exist.";
                    return false;
                }
                if (UserType == "Parent" && !clsParent.IsParentExist(this.ReferenceID.Value))
                {
                    errorMessage = "Linked Parent does not exist.";
                    return false;
                }
            }

            System.Data.DataTable dt = GetAllUsers();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["UserID"] != this.UserID)
                {
                    if (row["Username"].ToString() == this.Username)
                    {
                        errorMessage = "Username already exists.";
                        return false;
                    }
                    if (row["Email"].ToString() == this.Email)
                    {
                        errorMessage = "Email already exists.";
                        return false;
                    }
                }
            }
            return true;
        }"""

with open(user_path, "r", encoding="utf-8") as f:
    content = f.read()

content = re.sub(r'public bool Validate\(out string errorMessage\).*?return true;\s*\}', user_fix, content, flags=re.DOTALL)

with open(user_path, "w", encoding="utf-8") as f:
    f.write(content)
    print("Fixed clsUser.cs validation")
