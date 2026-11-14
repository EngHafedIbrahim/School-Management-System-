namespace SchoolManagementSystem
{
    partial class frmMainScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Name = "frmMainScreen";
            this.Text = "نظام إدارة المدارس - Modern School Management System";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.MinimumSize = new System.Drawing.Size(1024, 600);

            this.Load += FrmMainScreen_Load;

            this.ResumeLayout(false);
        }
    }
}
