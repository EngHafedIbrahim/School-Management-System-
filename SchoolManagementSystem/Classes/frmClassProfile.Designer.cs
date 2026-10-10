namespace SchoolManagementSystem.Classes
{
    partial class frmClassProfile
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblHeaderTitle = new Label();
            tabControl = new TabControl();
            tabOverview = new TabPage();
            pnlOverview = new Panel();
            lblValTotalCourses = new Label();
            lblTTotalCourses = new Label();
            lblValTotalStudents = new Label();
            lblTTotalStudents = new Label();
            lblValDetails = new Label();
            lblTDetails = new Label();
            lblValGradeLevel = new Label();
            lblTGradeLevel = new Label();
            lblValClassName = new Label();
            lblTClassName = new Label();
            tabStudents = new TabPage();
            dgvStudents = new DataGridView();
            tabCourses = new TabPage();
            dgvCourses = new DataGridView();
            tabTimetable = new TabPage();
            dgvTimetable = new DataGridView();
            tabAttendance = new TabPage();
            dgvAttendance = new DataGridView();
            tabGrades = new TabPage();
            dgvGrades = new DataGridView();
            btnEditClass = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            tabControl.SuspendLayout();
            tabOverview.SuspendLayout();
            pnlOverview.SuspendLayout();
            tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            tabCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            tabTimetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimetable).BeginInit();
            tabAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            tabGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(23, 13, 23, 13);
            pnlHeader.Size = new Size(1021, 93);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(331, 9);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(320, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Class Management Hub";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabOverview);
            tabControl.Controls.Add(tabStudents);
            tabControl.Controls.Add(tabCourses);
            tabControl.Controls.Add(tabTimetable);
            tabControl.Controls.Add(tabAttendance);
            tabControl.Controls.Add(tabGrades);
            tabControl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            tabControl.Location = new Point(23, 107);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(983, 613);
            tabControl.TabIndex = 1;
            // 
            // tabOverview
            // 
            tabOverview.BackColor = Color.White;
            tabOverview.Controls.Add(pnlOverview);
            tabOverview.Location = new Point(4, 30);
            tabOverview.Margin = new Padding(3, 4, 3, 4);
            tabOverview.Name = "tabOverview";
            tabOverview.Padding = new Padding(3, 4, 3, 4);
            tabOverview.Size = new Size(975, 579);
            tabOverview.TabIndex = 0;
            tabOverview.Text = "Overview";
            // 
            // pnlOverview
            // 
            pnlOverview.Controls.Add(lblValTotalCourses);
            pnlOverview.Controls.Add(lblTTotalCourses);
            pnlOverview.Controls.Add(lblValTotalStudents);
            pnlOverview.Controls.Add(lblTTotalStudents);
            pnlOverview.Controls.Add(lblValDetails);
            pnlOverview.Controls.Add(lblTDetails);
            pnlOverview.Controls.Add(lblValGradeLevel);
            pnlOverview.Controls.Add(lblTGradeLevel);
            pnlOverview.Controls.Add(lblValClassName);
            pnlOverview.Controls.Add(lblTClassName);
            pnlOverview.Dock = DockStyle.Fill;
            pnlOverview.Location = new Point(3, 4);
            pnlOverview.Margin = new Padding(3, 4, 3, 4);
            pnlOverview.Name = "pnlOverview";
            pnlOverview.Padding = new Padding(29, 33, 29, 33);
            pnlOverview.Size = new Size(969, 571);
            pnlOverview.TabIndex = 0;
            // 
            // lblValTotalCourses
            // 
            lblValTotalCourses.AutoSize = true;
            lblValTotalCourses.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValTotalCourses.ForeColor = Color.FromArgb(41, 128, 185);
            lblValTotalCourses.Location = new Point(251, 273);
            lblValTotalCourses.Name = "lblValTotalCourses";
            lblValTotalCourses.Size = new Size(24, 28);
            lblValTotalCourses.TabIndex = 9;
            lblValTotalCourses.Text = "0";
            // 
            // lblTTotalCourses
            // 
            lblTTotalCourses.AutoSize = true;
            lblTTotalCourses.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTTotalCourses.ForeColor = Color.FromArgb(120, 130, 140);
            lblTTotalCourses.Location = new Point(34, 276);
            lblTTotalCourses.Name = "lblTTotalCourses";
            lblTTotalCourses.Size = new Size(151, 21);
            lblTTotalCourses.TabIndex = 8;
            lblTTotalCourses.Text = "Assigned Subjects:";
            // 
            // lblValTotalStudents
            // 
            lblValTotalStudents.AutoSize = true;
            lblValTotalStudents.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValTotalStudents.ForeColor = Color.FromArgb(39, 174, 96);
            lblValTotalStudents.Location = new Point(251, 213);
            lblValTotalStudents.Name = "lblValTotalStudents";
            lblValTotalStudents.Size = new Size(24, 28);
            lblValTotalStudents.TabIndex = 7;
            lblValTotalStudents.Text = "0";
            // 
            // lblTTotalStudents
            // 
            lblTTotalStudents.AutoSize = true;
            lblTTotalStudents.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTTotalStudents.ForeColor = Color.FromArgb(120, 130, 140);
            lblTTotalStudents.Location = new Point(34, 216);
            lblTTotalStudents.Name = "lblTTotalStudents";
            lblTTotalStudents.Size = new Size(149, 21);
            lblTTotalStudents.TabIndex = 6;
            lblTTotalStudents.Text = "Enrolled Students:";
            // 
            // lblValDetails
            // 
            lblValDetails.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValDetails.ForeColor = Color.FromArgb(33, 37, 41);
            lblValDetails.Location = new Point(251, 153);
            lblValDetails.Name = "lblValDetails";
            lblValDetails.Size = new Size(629, 53);
            lblValDetails.TabIndex = 5;
            lblValDetails.Text = "---";
            // 
            // lblTDetails
            // 
            lblTDetails.AutoSize = true;
            lblTDetails.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTDetails.ForeColor = Color.FromArgb(120, 130, 140);
            lblTDetails.Location = new Point(34, 153);
            lblTDetails.Name = "lblTDetails";
            lblTDetails.Size = new Size(119, 21);
            lblTDetails.TabIndex = 4;
            lblTDetails.Text = "Notes / Room:";
            // 
            // lblValGradeLevel
            // 
            lblValGradeLevel.AutoSize = true;
            lblValGradeLevel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValGradeLevel.ForeColor = Color.FromArgb(33, 37, 41);
            lblValGradeLevel.Location = new Point(251, 93);
            lblValGradeLevel.Name = "lblValGradeLevel";
            lblValGradeLevel.Size = new Size(28, 21);
            lblValGradeLevel.TabIndex = 3;
            lblValGradeLevel.Text = "---";
            // 
            // lblTGradeLevel
            // 
            lblTGradeLevel.AutoSize = true;
            lblTGradeLevel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTGradeLevel.ForeColor = Color.FromArgb(120, 130, 140);
            lblTGradeLevel.Location = new Point(34, 93);
            lblTGradeLevel.Name = "lblTGradeLevel";
            lblTGradeLevel.Size = new Size(103, 21);
            lblTGradeLevel.TabIndex = 2;
            lblTGradeLevel.Text = "Grade Level:";
            // 
            // lblValClassName
            // 
            lblValClassName.AutoSize = true;
            lblValClassName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValClassName.ForeColor = Color.FromArgb(44, 62, 80);
            lblValClassName.Location = new Point(251, 33);
            lblValClassName.Name = "lblValClassName";
            lblValClassName.Size = new Size(36, 28);
            lblValClassName.TabIndex = 1;
            lblValClassName.Text = "---";
            // 
            // lblTClassName
            // 
            lblTClassName.AutoSize = true;
            lblTClassName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTClassName.ForeColor = Color.FromArgb(120, 130, 140);
            lblTClassName.Location = new Point(34, 36);
            lblTClassName.Name = "lblTClassName";
            lblTClassName.Size = new Size(102, 21);
            lblTClassName.TabIndex = 0;
            lblTClassName.Text = "Class Name:";
            // 
            // tabStudents
            // 
            tabStudents.BackColor = Color.White;
            tabStudents.Controls.Add(dgvStudents);
            tabStudents.Location = new Point(4, 30);
            tabStudents.Margin = new Padding(3, 4, 3, 4);
            tabStudents.Name = "tabStudents";
            tabStudents.Padding = new Padding(3, 4, 3, 4);
            tabStudents.Size = new Size(975, 579);
            tabStudents.TabIndex = 1;
            tabStudents.Text = "Enrolled Students";
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStudents.ColumnHeadersHeight = 29;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.Location = new Point(3, 4);
            dgvStudents.Margin = new Padding(3, 4, 3, 4);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(969, 571);
            dgvStudents.TabIndex = 0;
            // 
            // tabCourses
            // 
            tabCourses.BackColor = Color.White;
            tabCourses.Controls.Add(dgvCourses);
            tabCourses.Location = new Point(4, 30);
            tabCourses.Margin = new Padding(3, 4, 3, 4);
            tabCourses.Name = "tabCourses";
            tabCourses.Padding = new Padding(3, 4, 3, 4);
            tabCourses.Size = new Size(975, 579);
            tabCourses.TabIndex = 2;
            tabCourses.Text = "Courses & Instructors";
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.BackgroundColor = Color.White;
            dgvCourses.BorderStyle = BorderStyle.None;
            dgvCourses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCourses.ColumnHeadersHeight = 29;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCourses.Dock = DockStyle.Fill;
            dgvCourses.Location = new Point(3, 4);
            dgvCourses.Margin = new Padding(3, 4, 3, 4);
            dgvCourses.MultiSelect = false;
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.RowHeadersVisible = false;
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(969, 571);
            dgvCourses.TabIndex = 0;
            // 
            // tabTimetable
            // 
            tabTimetable.BackColor = Color.White;
            tabTimetable.Controls.Add(dgvTimetable);
            tabTimetable.Location = new Point(4, 30);
            tabTimetable.Margin = new Padding(3, 4, 3, 4);
            tabTimetable.Name = "tabTimetable";
            tabTimetable.Padding = new Padding(3, 4, 3, 4);
            tabTimetable.Size = new Size(975, 579);
            tabTimetable.TabIndex = 3;
            tabTimetable.Text = "Timetable";
            // 
            // dgvTimetable
            // 
            dgvTimetable.AllowUserToAddRows = false;
            dgvTimetable.AllowUserToDeleteRows = false;
            dgvTimetable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTimetable.BackgroundColor = Color.White;
            dgvTimetable.BorderStyle = BorderStyle.None;
            dgvTimetable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTimetable.ColumnHeadersHeight = 29;
            dgvTimetable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTimetable.Dock = DockStyle.Fill;
            dgvTimetable.Location = new Point(3, 4);
            dgvTimetable.Margin = new Padding(3, 4, 3, 4);
            dgvTimetable.MultiSelect = false;
            dgvTimetable.Name = "dgvTimetable";
            dgvTimetable.ReadOnly = true;
            dgvTimetable.RowHeadersVisible = false;
            dgvTimetable.RowHeadersWidth = 51;
            dgvTimetable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTimetable.Size = new Size(969, 571);
            dgvTimetable.TabIndex = 0;
            // 
            // tabAttendance
            // 
            tabAttendance.BackColor = Color.White;
            tabAttendance.Controls.Add(dgvAttendance);
            tabAttendance.Location = new Point(4, 30);
            tabAttendance.Margin = new Padding(3, 4, 3, 4);
            tabAttendance.Name = "tabAttendance";
            tabAttendance.Padding = new Padding(3, 4, 3, 4);
            tabAttendance.Size = new Size(975, 579);
            tabAttendance.TabIndex = 4;
            tabAttendance.Text = "Attendance";
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.BorderStyle = BorderStyle.None;
            dgvAttendance.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAttendance.ColumnHeadersHeight = 29;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAttendance.Dock = DockStyle.Fill;
            dgvAttendance.Location = new Point(3, 4);
            dgvAttendance.Margin = new Padding(3, 4, 3, 4);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(969, 571);
            dgvAttendance.TabIndex = 0;
            // 
            // tabGrades
            // 
            tabGrades.BackColor = Color.White;
            tabGrades.Controls.Add(dgvGrades);
            tabGrades.Location = new Point(4, 30);
            tabGrades.Margin = new Padding(3, 4, 3, 4);
            tabGrades.Name = "tabGrades";
            tabGrades.Padding = new Padding(3, 4, 3, 4);
            tabGrades.Size = new Size(975, 579);
            tabGrades.TabIndex = 5;
            tabGrades.Text = "Grades & Evaluations";
            // 
            // dgvGrades
            // 
            dgvGrades.AllowUserToAddRows = false;
            dgvGrades.AllowUserToDeleteRows = false;
            dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrades.BackgroundColor = Color.White;
            dgvGrades.BorderStyle = BorderStyle.None;
            dgvGrades.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGrades.ColumnHeadersHeight = 29;
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGrades.Dock = DockStyle.Fill;
            dgvGrades.Location = new Point(3, 4);
            dgvGrades.Margin = new Padding(3, 4, 3, 4);
            dgvGrades.MultiSelect = false;
            dgvGrades.Name = "dgvGrades";
            dgvGrades.ReadOnly = true;
            dgvGrades.RowHeadersVisible = false;
            dgvGrades.RowHeadersWidth = 51;
            dgvGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrades.Size = new Size(969, 571);
            dgvGrades.TabIndex = 0;
            // 
            // btnEditClass
            // 
            btnEditClass.BackColor = Color.FromArgb(41, 128, 185);
            btnEditClass.Cursor = Cursors.Hand;
            btnEditClass.FlatAppearance.BorderSize = 0;
            btnEditClass.FlatStyle = FlatStyle.Flat;
            btnEditClass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditClass.ForeColor = Color.White;
            btnEditClass.Location = new Point(720, 740);
            btnEditClass.Margin = new Padding(3, 4, 3, 4);
            btnEditClass.Name = "btnEditClass";
            btnEditClass.Size = new Size(149, 48);
            btnEditClass.TabIndex = 2;
            btnEditClass.Text = "Edit Class Info";
            btnEditClass.UseVisualStyleBackColor = false;
            btnEditClass.Click += BtnEditClass_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.Location = new Point(880, 740);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 48);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // frmClassProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1021, 807);
            Controls.Add(btnClose);
            Controls.Add(btnEditClass);
            Controls.Add(tabControl);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmClassProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Class Profile Hub";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabControl.ResumeLayout(false);
            tabOverview.ResumeLayout(false);
            pnlOverview.ResumeLayout(false);
            pnlOverview.PerformLayout();
            tabStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            tabCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            tabTimetable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTimetable).EndInit();
            tabAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            tabGrades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Label lblTClassName;
        private System.Windows.Forms.Label lblValClassName;
        private System.Windows.Forms.Label lblTGradeLevel;
        private System.Windows.Forms.Label lblValGradeLevel;
        private System.Windows.Forms.Label lblTDetails;
        private System.Windows.Forms.Label lblValDetails;
        private System.Windows.Forms.Label lblTTotalStudents;
        private System.Windows.Forms.Label lblValTotalStudents;
        private System.Windows.Forms.Label lblTTotalCourses;
        private System.Windows.Forms.Label lblValTotalCourses;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TabPage tabCourses;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.TabPage tabTimetable;
        private System.Windows.Forms.DataGridView dgvTimetable;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.TabPage tabGrades;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnClose;
    }
}
