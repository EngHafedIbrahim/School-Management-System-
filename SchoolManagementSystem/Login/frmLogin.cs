using System;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "يرجى إدخال اسم المستخدم وكلمة المرور.";
                return;
            }

            try
            {
                clsUser user = clsUser.Login(username, password);

                if (user != null)
                {
                    clsGloble.CurrentUser = user;
                    
                    this.Hide();
                    frmMainScreen frm = new frmMainScreen(this);

                    frm.ShowDialog();
                }
                else
                {
                    lblError.Text = "اسم المستخدم أو كلمة المرور غير صحيحة.";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
