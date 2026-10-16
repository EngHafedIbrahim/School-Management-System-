namespace SchoolManagementSystem.Reports
{
    partial class frmStudentPerformance
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.gbStudentSummary = new System.Windows.Forms.GroupBox();
            this.lblClassVal = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblAcademicYearVal = new System.Windows.Forms.Label();
            this.lblAcademicYear = new System.Windows.Forms.Label();
            this.lblAdmissionNoVal = new System.Windows.Forms.Label();
            this.lblAdmissionNo = new System.Windows.Forms.Label();
            this.lblStudentNameVal = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGrades = new System.Windows.Forms.TabPage();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.gbAttendanceMetrics = new System.Windows.Forms.GroupBox();
            this.lblAttendanceRateVal = new System.Windows.Forms.Label();
            this.lblAttendanceRate = new System.Windows.Forms.Label();
            this.lblLateVal = new System.Windows.Forms.Label();
            this.lblLate = new System.Windows.Forms.Label();
            this.lblAbsentVal = new System.Windows.Forms.Label();
            this.lblAbsent = new System.Windows.Forms.Label();
            this.lblPresentVal = new System.Windows.Forms.Label();
            this.lblPresent = new System.Windows.Forms.Label();
            this.lblTotalSessionsVal = new System.Windows.Forms.Label();
            this.lblTotalSessions = new System.Windows.Forms.Label();
            this.tabEnrollment = new System.Windows.Forms.TabPage();
            this.dgvEnrollments = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbFilter.SuspendLayout();
            this.gbStudentSummary.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.tabAttendance.SuspendLayout();
            this.gbAttendanceMetrics.SuspendLayout();
            this.tabEnrollment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Performance Report";
            // 
            // gbFilter
            // 
            this.gbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilter.Controls.Add(this.btnGenerate);
            this.gbFilter.Controls.Add(this.cbYear);
            this.gbFilter.Controls.Add(this.lblYear);
            this.gbFilter.Controls.Add(this.cbStudent);
            this.gbFilter.Controls.Add(this.lblStudent);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.gbFilter.Location = new System.Drawing.Point(29, 60);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(910, 75);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Select Target Student & Academic Period";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Location = new System.Drawing.Point(760, 27);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(130, 34);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Load Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(520, 32);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(210, 24);
            this.cbYear.TabIndex = 3;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblYear.Location = new System.Drawing.Point(415, 35);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(96, 17);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Academic Year:";
            // 
            // cbStudent
            // 
            this.cbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(115, 32);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(280, 24);
            this.cbStudent.TabIndex = 1;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStudent.Location = new System.Drawing.Point(20, 35);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(92, 17);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Target Student:";
            // 
            // gbStudentSummary
            // 
            this.gbStudentSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStudentSummary.Controls.Add(this.lblClassVal);
            this.gbStudentSummary.Controls.Add(this.lblClass);
            this.gbStudentSummary.Controls.Add(this.lblAcademicYearVal);
            this.gbStudentSummary.Controls.Add(this.lblAcademicYear);
            this.gbStudentSummary.Controls.Add(this.lblAdmissionNoVal);
            this.gbStudentSummary.Controls.Add(this.lblAdmissionNo);
            this.gbStudentSummary.Controls.Add(this.lblStudentNameVal);
            this.gbStudentSummary.Controls.Add(this.lblStudentName);
            this.gbStudentSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbStudentSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.gbStudentSummary.Location = new System.Drawing.Point(29, 145);
            this.gbStudentSummary.Name = "gbStudentSummary";
            this.gbStudentSummary.Size = new System.Drawing.Size(910, 75);
            this.gbStudentSummary.TabIndex = 2;
            this.gbStudentSummary.TabStop = false;
            this.gbStudentSummary.Text = "Student Profile Overview";
            // 
            // lblClassVal
            // 
            this.lblClassVal.AutoSize = true;
            this.lblClassVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblClassVal.Location = new System.Drawing.Point(745, 35);
            this.lblClassVal.Name = "lblClassVal";
            this.lblClassVal.Size = new System.Drawing.Size(23, 17);
            this.lblClassVal.TabIndex = 7;
            this.lblClassVal.Text = "---";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblClass.Location = new System.Drawing.Point(695, 35);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(41, 17);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "Class:";
            // 
            // lblAcademicYearVal
            // 
            this.lblAcademicYearVal.AutoSize = true;
            this.lblAcademicYearVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAcademicYearVal.Location = new System.Drawing.Point(545, 35);
            this.lblAcademicYearVal.Name = "lblAcademicYearVal";
            this.lblAcademicYearVal.Size = new System.Drawing.Size(23, 17);
            this.lblAcademicYearVal.TabIndex = 5;
            this.lblAcademicYearVal.Text = "---";
            // 
            // lblAcademicYear
            // 
            this.lblAcademicYear.AutoSize = true;
            this.lblAcademicYear.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAcademicYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAcademicYear.Location = new System.Drawing.Point(440, 35);
            this.lblAcademicYear.Name = "lblAcademicYear";
            this.lblAcademicYear.Size = new System.Drawing.Size(96, 17);
            this.lblAcademicYear.TabIndex = 4;
            this.lblAcademicYear.Text = "Academic Year:";
            // 
            // lblAdmissionNoVal
            // 
            this.lblAdmissionNoVal.AutoSize = true;
            this.lblAdmissionNoVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAdmissionNoVal.Location = new System.Drawing.Point(335, 35);
            this.lblAdmissionNoVal.Name = "lblAdmissionNoVal";
            this.lblAdmissionNoVal.Size = new System.Drawing.Size(23, 17);
            this.lblAdmissionNoVal.TabIndex = 3;
            this.lblAdmissionNoVal.Text = "---";
            // 
            // lblAdmissionNo
            // 
            this.lblAdmissionNo.AutoSize = true;
            this.lblAdmissionNo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAdmissionNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAdmissionNo.Location = new System.Drawing.Point(235, 35);
            this.lblAdmissionNo.Name = "lblAdmissionNo";
            this.lblAdmissionNo.Size = new System.Drawing.Size(91, 17);
            this.lblAdmissionNo.TabIndex = 2;
            this.lblAdmissionNo.Text = "Admission No:";
            // 
            // lblStudentNameVal
            // 
            this.lblStudentNameVal.AutoSize = true;
            this.lblStudentNameVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStudentNameVal.Location = new System.Drawing.Point(75, 35);
            this.lblStudentNameVal.Name = "lblStudentNameVal";
            this.lblStudentNameVal.Size = new System.Drawing.Size(23, 17);
            this.lblStudentNameVal.TabIndex = 1;
            this.lblStudentNameVal.Text = "---";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblStudentName.Location = new System.Drawing.Point(20, 35);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(46, 17);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabGrades);
            this.tabControl1.Controls.Add(this.tabAttendance);
            this.tabControl1.Controls.Add(this.tabEnrollment);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(29, 230);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 320);
            this.tabControl1.TabIndex = 3;
            // 
            // tabGrades
            // 
            this.tabGrades.Controls.Add(this.dgvGrades);
            this.tabGrades.Location = new System.Drawing.Point(4, 26);
            this.tabGrades.Name = "tabGrades";
            this.tabGrades.Padding = new System.Windows.Forms.Padding(10);
            this.tabGrades.Size = new System.Drawing.Size(902, 290);
            this.tabGrades.TabIndex = 0;
            this.tabGrades.Text = "  Academic Grades  ";
            this.tabGrades.UseVisualStyleBackColor = true;
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrades.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrades.Location = new System.Drawing.Point(10, 10);
            this.dgvGrades.MultiSelect = false;
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.ReadOnly = true;
            this.dgvGrades.RowHeadersWidth = 51;
            this.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrades.Size = new System.Drawing.Size(882, 270);
            this.dgvGrades.TabIndex = 0;
            // 
            // tabAttendance
            // 
            this.tabAttendance.Controls.Add(this.gbAttendanceMetrics);
            this.tabAttendance.Location = new System.Drawing.Point(4, 26);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Padding = new System.Windows.Forms.Padding(10);
            this.tabAttendance.Size = new System.Drawing.Size(902, 290);
            this.tabAttendance.TabIndex = 1;
            this.tabAttendance.Text = "  Attendance Summary  ";
            this.tabAttendance.UseVisualStyleBackColor = true;
            // 
            // gbAttendanceMetrics
            // 
            this.gbAttendanceMetrics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAttendanceMetrics.Controls.Add(this.lblAttendanceRateVal);
            this.gbAttendanceMetrics.Controls.Add(this.lblAttendanceRate);
            this.gbAttendanceMetrics.Controls.Add(this.lblLateVal);
            this.gbAttendanceMetrics.Controls.Add(this.lblLate);
            this.gbAttendanceMetrics.Controls.Add(this.lblAbsentVal);
            this.gbAttendanceMetrics.Controls.Add(this.lblAbsent);
            this.gbAttendanceMetrics.Controls.Add(this.lblPresentVal);
            this.gbAttendanceMetrics.Controls.Add(this.lblPresent);
            this.gbAttendanceMetrics.Controls.Add(this.lblTotalSessionsVal);
            this.gbAttendanceMetrics.Controls.Add(this.lblTotalSessions);
            this.gbAttendanceMetrics.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbAttendanceMetrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.gbAttendanceMetrics.Location = new System.Drawing.Point(20, 20);
            this.gbAttendanceMetrics.Name = "gbAttendanceMetrics";
            this.gbAttendanceMetrics.Size = new System.Drawing.Size(860, 160);
            this.gbAttendanceMetrics.TabIndex = 0;
            this.gbAttendanceMetrics.TabStop = false;
            this.gbAttendanceMetrics.Text = "Attendance Metrics for the Academic Year";
            // 
            // lblAttendanceRateVal
            // 
            this.lblAttendanceRateVal.AutoSize = true;
            this.lblAttendanceRateVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAttendanceRateVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblAttendanceRateVal.Location = new System.Drawing.Point(680, 75);
            this.lblAttendanceRateVal.Name = "lblAttendanceRateVal";
            this.lblAttendanceRateVal.Size = new System.Drawing.Size(73, 30);
            this.lblAttendanceRateVal.TabIndex = 9;
            this.lblAttendanceRateVal.Text = "0.0 %";
            // 
            // lblAttendanceRate
            // 
            this.lblAttendanceRate.AutoSize = true;
            this.lblAttendanceRate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAttendanceRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAttendanceRate.Location = new System.Drawing.Point(680, 45);
            this.lblAttendanceRate.Name = "lblAttendanceRate";
            this.lblAttendanceRate.Size = new System.Drawing.Size(105, 17);
            this.lblAttendanceRate.TabIndex = 8;
            this.lblAttendanceRate.Text = "Attendance Rate:";
            // 
            // lblLateVal
            // 
            this.lblLateVal.AutoSize = true;
            this.lblLateVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLateVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblLateVal.Location = new System.Drawing.Point(520, 75);
            this.lblLateVal.Name = "lblLateVal";
            this.lblLateVal.Size = new System.Drawing.Size(26, 30);
            this.lblLateVal.TabIndex = 7;
            this.lblLateVal.Text = "0";
            // 
            // lblLate
            // 
            this.lblLate.AutoSize = true;
            this.lblLate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblLate.Location = new System.Drawing.Point(520, 45);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(84, 17);
            this.lblLate.TabIndex = 6;
            this.lblLate.Text = "Late Arrivals:";
            // 
            // lblAbsentVal
            // 
            this.lblAbsentVal.AutoSize = true;
            this.lblAbsentVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAbsentVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblAbsentVal.Location = new System.Drawing.Point(360, 75);
            this.lblAbsentVal.Name = "lblAbsentVal";
            this.lblAbsentVal.Size = new System.Drawing.Size(26, 30);
            this.lblAbsentVal.TabIndex = 5;
            this.lblAbsentVal.Text = "0";
            // 
            // lblAbsent
            // 
            this.lblAbsent.AutoSize = true;
            this.lblAbsent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAbsent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAbsent.Location = new System.Drawing.Point(360, 45);
            this.lblAbsent.Name = "lblAbsent";
            this.lblAbsent.Size = new System.Drawing.Size(107, 17);
            this.lblAbsent.TabIndex = 4;
            this.lblAbsent.Text = "Absent Sessions:";
            // 
            // lblPresentVal
            // 
            this.lblPresentVal.AutoSize = true;
            this.lblPresentVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPresentVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblPresentVal.Location = new System.Drawing.Point(200, 75);
            this.lblPresentVal.Name = "lblPresentVal";
            this.lblPresentVal.Size = new System.Drawing.Size(26, 30);
            this.lblPresentVal.TabIndex = 3;
            this.lblPresentVal.Text = "0";
            // 
            // lblPresent
            // 
            this.lblPresent.AutoSize = true;
            this.lblPresent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPresent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPresent.Location = new System.Drawing.Point(200, 45);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(109, 17);
            this.lblPresent.TabIndex = 2;
            this.lblPresent.Text = "Present Sessions:";
            // 
            // lblTotalSessionsVal
            // 
            this.lblTotalSessionsVal.AutoSize = true;
            this.lblTotalSessionsVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalSessionsVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTotalSessionsVal.Location = new System.Drawing.Point(40, 75);
            this.lblTotalSessionsVal.Name = "lblTotalSessionsVal";
            this.lblTotalSessionsVal.Size = new System.Drawing.Size(26, 30);
            this.lblTotalSessionsVal.TabIndex = 1;
            this.lblTotalSessionsVal.Text = "0";
            // 
            // lblTotalSessions
            // 
            this.lblTotalSessions.AutoSize = true;
            this.lblTotalSessions.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTotalSessions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotalSessions.Location = new System.Drawing.Point(40, 45);
            this.lblTotalSessions.Name = "lblTotalSessions";
            this.lblTotalSessions.Size = new System.Drawing.Size(92, 17);
            this.lblTotalSessions.TabIndex = 0;
            this.lblTotalSessions.Text = "Total Sessions:";
            // 
            // tabEnrollment
            // 
            this.tabEnrollment.Controls.Add(this.dgvEnrollments);
            this.tabEnrollment.Location = new System.Drawing.Point(4, 26);
            this.tabEnrollment.Name = "tabEnrollment";
            this.tabEnrollment.Padding = new System.Windows.Forms.Padding(10);
            this.tabEnrollment.Size = new System.Drawing.Size(902, 290);
            this.tabEnrollment.TabIndex = 2;
            this.tabEnrollment.Text = "  Enrollment History  ";
            this.tabEnrollment.UseVisualStyleBackColor = true;
            // 
            // dgvEnrollments
            // 
            this.dgvEnrollments.AllowUserToAddRows = false;
            this.dgvEnrollments.AllowUserToDeleteRows = false;
            this.dgvEnrollments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnrollments.BackgroundColor = System.Drawing.Color.White;
            this.dgvEnrollments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnrollments.Location = new System.Drawing.Point(10, 10);
            this.dgvEnrollments.MultiSelect = false;
            this.dgvEnrollments.Name = "dgvEnrollments";
            this.dgvEnrollments.ReadOnly = true;
            this.dgvEnrollments.RowHeadersWidth = 51;
            this.dgvEnrollments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrollments.Size = new System.Drawing.Size(882, 270);
            this.dgvEnrollments.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnPrint.Location = new System.Drawing.Point(725, 565);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 34);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print / Export";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnClose.Location = new System.Drawing.Point(855, 565);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmStudentPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(969, 615);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbStudentSummary);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(880, 560);
            this.Name = "frmStudentPerformance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Performance Report";
            this.Load += new System.EventHandler(this.FrmStudentPerformance_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gbStudentSummary.ResumeLayout(false);
            this.gbStudentSummary.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabGrades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.tabAttendance.ResumeLayout(false);
            this.gbAttendanceMetrics.ResumeLayout(false);
            this.gbAttendanceMetrics.PerformLayout();
            this.tabEnrollment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox gbStudentSummary;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentNameVal;
        private System.Windows.Forms.Label lblAdmissionNo;
        private System.Windows.Forms.Label lblAdmissionNoVal;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.Label lblAcademicYearVal;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblClassVal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGrades;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.TabPage tabEnrollment;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.DataGridView dgvEnrollments;
        private System.Windows.Forms.GroupBox gbAttendanceMetrics;
        private System.Windows.Forms.Label lblTotalSessions;
        private System.Windows.Forms.Label lblTotalSessionsVal;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.Label lblPresentVal;
        private System.Windows.Forms.Label lblAbsent;
        private System.Windows.Forms.Label lblAbsentVal;
        private System.Windows.Forms.Label lblLate;
        private System.Windows.Forms.Label lblLateVal;
        private System.Windows.Forms.Label lblAttendanceRate;
        private System.Windows.Forms.Label lblAttendanceRateVal;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
    }
}
