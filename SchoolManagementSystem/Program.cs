using SchoolManagementSystem.Academic;
using SchoolManagementSystem.Login;
using SchoolManagementSystem.Parents;
using SchoolManagementSystem.Students;
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

            //Application.Run(new frmStudentList()); 
            //Application.Run(new frmAcademicYears());
            Application.Run(new frmLogin ());
            
            //frmLogin login = new frmLogin();

            //if (login.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new frmMainScreen());
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }    
    }
}