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
            pnlHeader = new Panel();
            lblTitle = new Label();
            gbFilter = new GroupBox();
            btnGenerate = new Button();
            cbYear = new ComboBox();
            lblYear = new Label();
            cbStudent = new ComboBox();
            lblStudent = new Label();
            gbStudentSummary = new GroupBox();
            lblClassVal = new Label();
            lblClass = new Label();
            lblAcademicYearVal = new Label();
            lblAcademicYear = new Label();
            lblAdmissionNoVal = new Label();
            lblAdmissionNo = new Label();
            lblStudentNameVal = new Label();
            lblStudentName = new Label();
            tabControl1 = new TabControl();
            tabGrades = new TabPage();
            dgvGrades = new DataGridView();
            tabAttendance = new TabPage();
            gbAttendanceMetrics = new GroupBox();
            lblAttendanceRateVal = new Label();
            lblAttendanceRate = new Label();
            lblLateVal = new Label();
            lblLate = new Label();
            lblAbsentVal = new Label();
            lblAbsent = new Label();
            lblPresentVal = new Label();
            lblPresent = new Label();
            lblTotalSessionsVal = new Label();
            lblTotalSessions = new Label();
            tabEnrollment = new TabPage();
            dgvEnrollments = new DataGridView();
            btnPrint = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            gbFilter.SuspendLayout();
            gbStudentSummary.SuspendLayout();
            tabControl1.SuspendLayout();
            tabGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            tabAttendance.SuspendLayout();
            gbAttendanceMetrics.SuspendLayout();
            tabEnrollment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnrollments).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(24, 15, 24, 15);
            pnlHeader.Size = new Size(984, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(620, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "تقرير الأداء الأكاديمي الشامل للطالب";
            // 
            // gbFilter
            // 
            gbFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFilter.Controls.Add(btnGenerate);
            gbFilter.Controls.Add(cbYear);
            gbFilter.Controls.Add(lblYear);
            gbFilter.Controls.Add(cbStudent);
            gbFilter.Controls.Add(lblStudent);
            gbFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbFilter.ForeColor = Color.FromArgb(44, 62, 80);
            gbFilter.Location = new Point(24, 72);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(936, 80);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "تحديد الطالب والعام الدراسي";
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerate.Location = new Point(20, 28);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(130, 36);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "🔍 عرض التقرير";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // cbYear
            // 
            cbYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYear.Font = new Font("Segoe UI", 9.5F);
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(190, 32);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(200, 29);
            cbYear.TabIndex = 3;
            // 
            // lblYear
            // 
            lblYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9.5F);
            lblYear.Location = new Point(395, 36);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(99, 21);
            lblYear.TabIndex = 2;
            lblYear.Text = "العام الدراسي:";
            // 
            // cbStudent
            // 
            cbStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.Font = new Font("Segoe UI", 9.5F);
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(510, 32);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(300, 29);
            cbStudent.TabIndex = 1;
            // 
            // lblStudent
            // 
            lblStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 9.5F);
            lblStudent.Location = new Point(815, 36);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(106, 21);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "الطالب المستهدف:";
            // 
            // gbStudentSummary
            // 
            gbStudentSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbStudentSummary.Controls.Add(lblClassVal);
            gbStudentSummary.Controls.Add(lblClass);
            gbStudentSummary.Controls.Add(lblAcademicYearVal);
            gbStudentSummary.Controls.Add(lblAcademicYear);
            gbStudentSummary.Controls.Add(lblAdmissionNoVal);
            gbStudentSummary.Controls.Add(lblAdmissionNo);
            gbStudentSummary.Controls.Add(lblStudentNameVal);
            gbStudentSummary.Controls.Add(lblStudentName);
            gbStudentSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbStudentSummary.ForeColor = Color.FromArgb(44, 62, 80);
            gbStudentSummary.Location = new Point(24, 160);
            gbStudentSummary.Name = "gbStudentSummary";
            gbStudentSummary.Size = new Size(936, 75);
            gbStudentSummary.TabIndex = 2;
            gbStudentSummary.TabStop = false;
            gbStudentSummary.Text = "الملخص التعريفي للطالب";
            // 
            // lblClassVal
            // 
            lblClassVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblClassVal.AutoSize = true;
            lblClassVal.Font = new Font("Segoe UI", 9.5F);
            lblClassVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblClassVal.Location = new Point(30, 35);
            lblClassVal.Name = "lblClassVal";
            lblClassVal.Size = new Size(27, 21);
            lblClassVal.TabIndex = 7;
            lblClassVal.Text = "---";
            // 
            // lblClass
            // 
            lblClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 9.5F);
            lblClass.ForeColor = Color.FromArgb(120, 130, 140);
            lblClass.Location = new Point(160, 35);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(98, 21);
            lblClass.TabIndex = 6;
            lblClass.Text = "الصف والشعبة:";
            // 
            // lblAcademicYearVal
            // 
            lblAcademicYearVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAcademicYearVal.AutoSize = true;
            lblAcademicYearVal.Font = new Font("Segoe UI", 9.5F);
            lblAcademicYearVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblAcademicYearVal.Location = new Point(270, 35);
            lblAcademicYearVal.Name = "lblAcademicYearVal";
            lblAcademicYearVal.Size = new Size(27, 21);
            lblAcademicYearVal.TabIndex = 5;
            lblAcademicYearVal.Text = "---";
            // 
            // lblAcademicYear
            // 
            lblAcademicYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAcademicYear.AutoSize = true;
            lblAcademicYear.Font = new Font("Segoe UI", 9.5F);
            lblAcademicYear.ForeColor = Color.FromArgb(120, 130, 140);
            lblAcademicYear.Location = new Point(390, 35);
            lblAcademicYear.Name = "lblAcademicYear";
            lblAcademicYear.Size = new Size(99, 21);
            lblAcademicYear.TabIndex = 4;
            lblAcademicYear.Text = "العام الدراسي:";
            // 
            // lblAdmissionNoVal
            // 
            lblAdmissionNoVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdmissionNoVal.AutoSize = true;
            lblAdmissionNoVal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAdmissionNoVal.ForeColor = Color.FromArgb(41, 128, 185);
            lblAdmissionNoVal.Location = new Point(500, 35);
            lblAdmissionNoVal.Name = "lblAdmissionNoVal";
            lblAdmissionNoVal.Size = new Size(27, 21);
            lblAdmissionNoVal.TabIndex = 3;
            lblAdmissionNoVal.Text = "---";
            // 
            // lblAdmissionNo
            // 
            lblAdmissionNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdmissionNo.AutoSize = true;
            lblAdmissionNo.Font = new Font("Segoe UI", 9.5F);
            lblAdmissionNo.ForeColor = Color.FromArgb(120, 130, 140);
            lblAdmissionNo.Location = new Point(620, 35);
            lblAdmissionNo.Name = "lblAdmissionNo";
            lblAdmissionNo.Size = new Size(81, 21);
            lblAdmissionNo.TabIndex = 2;
            lblAdmissionNo.Text = "رقم القبول:";
            // 
            // lblStudentNameVal
            // 
            lblStudentNameVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStudentNameVal.AutoSize = true;
            lblStudentNameVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudentNameVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblStudentNameVal.Location = new Point(710, 34);
            lblStudentNameVal.Name = "lblStudentNameVal";
            lblStudentNameVal.Size = new Size(31, 23);
            lblStudentNameVal.TabIndex = 1;
            lblStudentNameVal.Text = "---";
            // 
            // lblStudentName
            // 
            lblStudentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 9.5F);
            lblStudentName.ForeColor = Color.FromArgb(120, 130, 140);
            lblStudentName.Location = new Point(835, 35);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(82, 21);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "اسم الطالب:";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabGrades);
            tabControl1.Controls.Add(tabAttendance);
            tabControl1.Controls.Add(tabEnrollment);
            tabControl1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            tabControl1.Location = new Point(24, 245);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(936, 310);
            tabControl1.TabIndex = 3;
            // 
            // tabGrades
            // 
            tabGrades.Controls.Add(dgvGrades);
            tabGrades.Location = new Point(4, 30);
            tabGrades.Name = "tabGrades";
            tabGrades.Padding = new Padding(10);
            tabGrades.Size = new Size(928, 276);
            tabGrades.TabIndex = 0;
            tabGrades.Text = "  الدرجات والنتائج الأكاديمية  ";
            tabGrades.UseVisualStyleBackColor = true;
            // 
            // dgvGrades
            // 
            dgvGrades.AllowUserToAddRows = false;
            dgvGrades.AllowUserToDeleteRows = false;
            dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrades.BackgroundColor = Color.White;
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrades.Dock = DockStyle.Fill;
            dgvGrades.Location = new Point(10, 10);
            dgvGrades.MultiSelect = false;
            dgvGrades.Name = "dgvGrades";
            dgvGrades.ReadOnly = true;
            dgvGrades.RowHeadersWidth = 51;
            dgvGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrades.Size = new Size(908, 256);
            dgvGrades.TabIndex = 0;
            // 
            // tabAttendance
            // 
            tabAttendance.Controls.Add(gbAttendanceMetrics);
            tabAttendance.Location = new Point(4, 30);
            tabAttendance.Name = "tabAttendance";
            tabAttendance.Padding = new Padding(10);
            tabAttendance.Size = new Size(928, 276);
            tabAttendance.TabIndex = 1;
            tabAttendance.Text = "  ملخص الحضور والغياب  ";
            tabAttendance.UseVisualStyleBackColor = true;
            // 
            // gbAttendanceMetrics
            // 
            gbAttendanceMetrics.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbAttendanceMetrics.Controls.Add(lblAttendanceRateVal);
            gbAttendanceMetrics.Controls.Add(lblAttendanceRate);
            gbAttendanceMetrics.Controls.Add(lblLateVal);
            gbAttendanceMetrics.Controls.Add(lblLate);
            gbAttendanceMetrics.Controls.Add(lblAbsentVal);
            gbAttendanceMetrics.Controls.Add(lblAbsent);
            gbAttendanceMetrics.Controls.Add(lblPresentVal);
            gbAttendanceMetrics.Controls.Add(lblPresent);
            gbAttendanceMetrics.Controls.Add(lblTotalSessionsVal);
            gbAttendanceMetrics.Controls.Add(lblTotalSessions);
            gbAttendanceMetrics.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbAttendanceMetrics.ForeColor = Color.FromArgb(44, 62, 80);
            gbAttendanceMetrics.Location = new Point(15, 20);
            gbAttendanceMetrics.Name = "gbAttendanceMetrics";
            gbAttendanceMetrics.Size = new Size(895, 160);
            gbAttendanceMetrics.TabIndex = 0;
            gbAttendanceMetrics.TabStop = false;
            gbAttendanceMetrics.Text = "مؤشرات الحضور والغياب للعام الدراسي المحدد";
            // 
            // lblAttendanceRateVal
            // 
            lblAttendanceRateVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAttendanceRateVal.AutoSize = true;
            lblAttendanceRateVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAttendanceRateVal.ForeColor = Color.FromArgb(37, 99, 235);
            lblAttendanceRateVal.Location = new Point(40, 75);
            lblAttendanceRateVal.Name = "lblAttendanceRateVal";
            lblAttendanceRateVal.Size = new Size(94, 37);
            lblAttendanceRateVal.TabIndex = 9;
            lblAttendanceRateVal.Text = "0.0 %";
            // 
            // lblAttendanceRate
            // 
            lblAttendanceRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAttendanceRate.AutoSize = true;
            lblAttendanceRate.Font = new Font("Segoe UI", 9.5F);
            lblAttendanceRate.ForeColor = Color.FromArgb(120, 130, 140);
            lblAttendanceRate.Location = new Point(40, 45);
            lblAttendanceRate.Name = "lblAttendanceRate";
            lblAttendanceRate.Size = new Size(137, 21);
            lblAttendanceRate.TabIndex = 8;
            lblAttendanceRate.Text = "نسبة الالتزام بالحضور:";
            // 
            // lblLateVal
            // 
            lblLateVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLateVal.AutoSize = true;
            lblLateVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLateVal.ForeColor = Color.FromArgb(217, 119, 6);
            lblLateVal.Location = new Point(230, 75);
            lblLateVal.Name = "lblLateVal";
            lblLateVal.Size = new Size(32, 37);
            lblLateVal.TabIndex = 7;
            lblLateVal.Text = "0";
            // 
            // lblLate
            // 
            lblLate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLate.AutoSize = true;
            lblLate.Font = new Font("Segoe UI", 9.5F);
            lblLate.ForeColor = Color.FromArgb(120, 130, 140);
            lblLate.Location = new Point(230, 45);
            lblLate.Name = "lblLate";
            lblLate.Size = new Size(99, 21);
            lblLate.TabIndex = 6;
            lblLate.Text = "حالات التأخير:";
            // 
            // lblAbsentVal
            // 
            lblAbsentVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAbsentVal.AutoSize = true;
            lblAbsentVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAbsentVal.ForeColor = Color.FromArgb(220, 38, 38);
            lblAbsentVal.Location = new Point(410, 75);
            lblAbsentVal.Name = "lblAbsentVal";
            lblAbsentVal.Size = new Size(32, 37);
            lblAbsentVal.TabIndex = 5;
            lblAbsentVal.Text = "0";
            // 
            // lblAbsent
            // 
            lblAbsent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAbsent.AutoSize = true;
            lblAbsent.Font = new Font("Segoe UI", 9.5F);
            lblAbsent.ForeColor = Color.FromArgb(120, 130, 140);
            lblAbsent.Location = new Point(410, 45);
            lblAbsent.Name = "lblAbsent";
            lblAbsent.Size = new Size(96, 21);
            lblAbsent.TabIndex = 4;
            lblAbsent.Text = "حصص الغياب:";
            // 
            // lblPresentVal
            // 
            lblPresentVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPresentVal.AutoSize = true;
            lblPresentVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPresentVal.ForeColor = Color.FromArgb(22, 163, 74);
            lblPresentVal.Location = new Point(590, 75);
            lblPresentVal.Name = "lblPresentVal";
            lblPresentVal.Size = new Size(32, 37);
            lblPresentVal.TabIndex = 3;
            lblPresentVal.Text = "0";
            // 
            // lblPresent
            // 
            lblPresent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPresent.AutoSize = true;
            lblPresent.Font = new Font("Segoe UI", 9.5F);
            lblPresent.ForeColor = Color.FromArgb(120, 130, 140);
            lblPresent.Location = new Point(590, 45);
            lblPresent.Name = "lblPresent";
            lblPresent.Size = new Size(103, 21);
            lblPresent.TabIndex = 2;
            lblPresent.Text = "حصص الحضور:";
            // 
            // lblTotalSessionsVal
            // 
            lblTotalSessionsVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalSessionsVal.AutoSize = true;
            lblTotalSessionsVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalSessionsVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotalSessionsVal.Location = new Point(750, 75);
            lblTotalSessionsVal.Name = "lblTotalSessionsVal";
            lblTotalSessionsVal.Size = new Size(32, 37);
            lblTotalSessionsVal.TabIndex = 1;
            lblTotalSessionsVal.Text = "0";
            // 
            // lblTotalSessions
            // 
            lblTotalSessions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalSessions.AutoSize = true;
            lblTotalSessions.Font = new Font("Segoe UI", 9.5F);
            lblTotalSessions.ForeColor = Color.FromArgb(120, 130, 140);
            lblTotalSessions.Location = new Point(750, 45);
            lblTotalSessions.Name = "lblTotalSessions";
            lblTotalSessions.Size = new Size(100, 21);
            lblTotalSessions.TabIndex = 0;
            lblTotalSessions.Text = "إجمالي الحصص:";
            // 
            // tabEnrollment
            // 
            tabEnrollment.Controls.Add(dgvEnrollments);
            tabEnrollment.Location = new Point(4, 30);
            tabEnrollment.Name = "tabEnrollment";
            tabEnrollment.Padding = new Padding(10);
            tabEnrollment.Size = new Size(928, 276);
            tabEnrollment.TabIndex = 2;
            tabEnrollment.Text = "  سجل التسجيل والصفوف  ";
            tabEnrollment.UseVisualStyleBackColor = true;
            // 
            // dgvEnrollments
            // 
            dgvEnrollments.AllowUserToAddRows = false;
            dgvEnrollments.AllowUserToDeleteRows = false;
            dgvEnrollments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEnrollments.BackgroundColor = Color.White;
            dgvEnrollments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnrollments.Dock = DockStyle.Fill;
            dgvEnrollments.Location = new Point(10, 10);
            dgvEnrollments.MultiSelect = false;
            dgvEnrollments.Name = "dgvEnrollments";
            dgvEnrollments.ReadOnly = true;
            dgvEnrollments.RowHeadersWidth = 51;
            dgvEnrollments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnrollments.Size = new Size(908, 256);
            dgvEnrollments.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrint.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnPrint.Location = new Point(135, 568);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(160, 36);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "🖨 طباعة / تصدير التقرير";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += BtnPrint_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.Location = new Point(24, 568);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 36);
            btnClose.TabIndex = 5;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // frmStudentPerformance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(984, 620);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(tabControl1);
            Controls.Add(gbStudentSummary);
            Controls.Add(gbFilter);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(900, 600);
            Name = "frmStudentPerformance";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تقرير الأداء الأكاديمي الشامل للطالب";
            Load += FrmStudentPerformance_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            gbStudentSummary.ResumeLayout(false);
            gbStudentSummary.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabGrades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            tabAttendance.ResumeLayout(false);
            gbAttendanceMetrics.ResumeLayout(false);
            gbAttendanceMetrics.PerformLayout();
            tabEnrollment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEnrollments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
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
