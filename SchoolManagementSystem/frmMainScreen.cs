using System;
using System.Windows.Forms;
using SchoolManagementSystem.Globle_Classes;
using SchoolManagementSystem.Dashboard;

namespace SchoolManagementSystem
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void MenuLogout_Click(object sender, EventArgs e)
        {
            clsGloble.CurrentUser = null;
            Application.Restart();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMainScreen_Load(object sender, EventArgs e)
        {
            if (clsGloble.CurrentUser != null)
            {
                menuUser.Text = $"User: {clsGloble.CurrentUser.Username} ({clsGloble.CurrentUser.UserType})";
                
                if (clsGloble.CurrentUser.UserType == "Admin")
                {
                    frmAdminDashboard dashboard = new frmAdminDashboard();
                    dashboard.MdiParent = this;
                    dashboard.Show();
                }
            }
        }
    }
}
