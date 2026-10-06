import os

filepath = r'SchoolManagementSystemBusinessLayer\clsUser.cs'
with open(filepath, 'r', encoding='utf-8') as f:
    content = f.read()

login_method = """
        public static clsUser Login(string username, string passwordHash)
        {
            System.Data.DataTable dt = GetAllUsers();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if (row["Username"].ToString() == username && row["PasswordHash"].ToString() == passwordHash)
                {
                    if (row["Status"].ToString() != "Active")
                    {
                        throw new Exception("Account is inactive.");
                    }
                    return Find((int)row["UserID"]);
                }
            }
            return null;
        }
"""

if 'public static clsUser Login' not in content:
    content = content.replace('public static bool DeleteUser', login_method + '\n        public static bool DeleteUser')
    with open(filepath, 'w', encoding='utf-8') as f:
        f.write(content)
    print('Login method injected')
else:
    print('Already has Login')
