using SchoolManagementSystem.Academic;
using SchoolManagementSystem.Classes;
using SchoolManagementSystem.Courses;
using SchoolManagementSystem.Login;
using SchoolManagementSystem.Parents;
using SchoolManagementSystem.Students;
using SchoolManagementSystem.Teachers;
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
            //Application.Run(new frmLogin ());
            //Application.Run(new frmTeacherList());
            //application.run(new frmcourselist());
            //Application.Run(new frmGradeLevels());
            Application.Run(new frmClassList());

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