using SchoolManagementSystem.Enrollment;
using SchoolManagementSystem.Login;
using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // ── Production: Login → Main Screen ──
            
            Application.Run(new frmLogin());
               
            //Application.Run(new frmStudentEnrollmentList());
            //frmLogin login = new frmLogin();
            //if (login.ShowDialog() == DialogResult.OK)
            //{
            //}

            // ── Development: Skip login (uncomment to use) ──
            // Application.Run(new frmMainScreen());
        }
    }
}
