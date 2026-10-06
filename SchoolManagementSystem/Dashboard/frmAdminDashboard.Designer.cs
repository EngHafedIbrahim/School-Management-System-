namespace SchoolManagementSystem.Dashboard
{
    partial class frmAdminDashboard
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblKpiTitle = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.FlowLayoutPanel();
            this.cardStudents = new System.Windows.Forms.Panel();
            this.lblTitleStudents = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.cardTeachers = new System.Windows.Forms.Panel();
            this.lblTitleTeachers = new System.Windows.Forms.Label();
            this.lblTotalTeachers = new System.Windows.Forms.Label();
            this.cardClasses = new System.Windows.Forms.Panel();
            this.lblTitleClasses = new System.Windows.Forms.Label();
            this.lblTotalClasses = new System.Windows.Forms.Label();
            this.cardParents = new System.Windows.Forms.Panel();
            this.lblTitleParents = new System.Windows.Forms.Label();
            this.lblTotalParents = new System.Windows.Forms.Label();
            this.cardYear = new System.Windows.Forms.Panel();
            this.lblTitleYear = new System.Windows.Forms.Label();
            this.lblAcademicYear = new System.Windows.Forms.Label();
            this.lblModulesTitle = new System.Windows.Forms.Label();
            this.pnlModules = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNavStudents = new System.Windows.Forms.Button();
            this.btnNavParents = new System.Windows.Forms.Button();
            this.btnNavAcademic = new System.Windows.Forms.Button();
            this.btnNavTeachers = new System.Windows.Forms.Button();
            this.btnNavCourses = new System.Windows.Forms.Button();
            this.btnNavTimetable = new System.Windows.Forms.Button();
            this.btnNavAttendance = new System.Windows.Forms.Button();
            this.btnNavGrades = new System.Windows.Forms.Button();
            this.btnNavFinance = new System.Windows.Forms.Button();
            this.btnNavUsers = new System.Windows.Forms.Button();
            this.btnNavReports = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.cardStudents.SuspendLayout();
            this.cardTeachers.SuspendLayout();
            this.cardClasses.SuspendLayout();
            this.cardParents.SuspendLayout();
            this.cardYear.SuspendLayout();
            this.pnlModules.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlHeader.Size = new System.Drawing.Size(1150, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(325, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Administrative Control Center";
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(22, 40);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(543, 19);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Monitor system metrics, academic progress, and manage school directory records.";
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.pnlModules);
            this.pnlContent.Controls.Add(this.lblModulesTitle);
            this.pnlContent.Controls.Add(this.pnlCards);
            this.pnlContent.Controls.Add(this.lblKpiTitle);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30);
            this.pnlContent.Size = new System.Drawing.Size(1150, 630);
            this.pnlContent.TabIndex = 1;
            // 
            // lblKpiTitle
            // 
            this.lblKpiTitle.AutoSize = true;
            this.lblKpiTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblKpiTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblKpiTitle.Location = new System.Drawing.Point(30, 20);
            this.lblKpiTitle.Name = "lblKpiTitle";
            this.lblKpiTitle.Size = new System.Drawing.Size(288, 21);
            this.lblKpiTitle.TabIndex = 0;
            this.lblKpiTitle.Text = "Institution Overview & Key Indicators";
            // 
            // pnlCards
            // 
            this.pnlCards.Controls.Add(this.cardStudents);
            this.pnlCards.Controls.Add(this.cardTeachers);
            this.pnlCards.Controls.Add(this.cardClasses);
            this.pnlCards.Controls.Add(this.cardParents);
            this.pnlCards.Controls.Add(this.cardYear);
            this.pnlCards.Location = new System.Drawing.Point(30, 50);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(1090, 110);
            this.pnlCards.TabIndex = 1;
            // 
            // cardStudents
            // 
            this.cardStudents.BackColor = System.Drawing.Color.White;
            this.cardStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardStudents.Controls.Add(this.lblTotalStudents);
            this.cardStudents.Controls.Add(this.lblTitleStudents);
            this.cardStudents.Location = new System.Drawing.Point(3, 3);
            this.cardStudents.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            this.cardStudents.Name = "cardStudents";
            this.cardStudents.Size = new System.Drawing.Size(200, 95);
            this.cardStudents.TabIndex = 0;
            // 
            // lblTitleStudents
            // 
            this.lblTitleStudents.AutoSize = true;
            this.lblTitleStudents.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTitleStudents.Location = new System.Drawing.Point(15, 12);
            this.lblTitleStudents.Name = "lblTitleStudents";
            this.lblTitleStudents.Size = new System.Drawing.Size(89, 15);
            this.lblTitleStudents.TabIndex = 0;
            this.lblTitleStudents.Text = "Active Students";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTotalStudents.Location = new System.Drawing.Point(15, 38);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(31, 30);
            this.lblTotalStudents.TabIndex = 1;
            this.lblTotalStudents.Text = "...";
            // 
            // cardTeachers
            // 
            this.cardTeachers.BackColor = System.Drawing.Color.White;
            this.cardTeachers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTeachers.Controls.Add(this.lblTotalTeachers);
            this.cardTeachers.Controls.Add(this.lblTitleTeachers);
            this.cardTeachers.Location = new System.Drawing.Point(218, 3);
            this.cardTeachers.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            this.cardTeachers.Name = "cardTeachers";
            this.cardTeachers.Size = new System.Drawing.Size(200, 95);
            this.cardTeachers.TabIndex = 1;
            // 
            // lblTitleTeachers
            // 
            this.lblTitleTeachers.AutoSize = true;
            this.lblTitleTeachers.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTitleTeachers.Location = new System.Drawing.Point(15, 12);
            this.lblTitleTeachers.Name = "lblTitleTeachers";
            this.lblTitleTeachers.Size = new System.Drawing.Size(85, 15);
            this.lblTitleTeachers.TabIndex = 0;
            this.lblTitleTeachers.Text = "Teaching Staff";
            // 
            // lblTotalTeachers
            // 
            this.lblTotalTeachers.AutoSize = true;
            this.lblTotalTeachers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.lblTotalTeachers.Location = new System.Drawing.Point(15, 38);
            this.lblTotalTeachers.Name = "lblTotalTeachers";
            this.lblTotalTeachers.Size = new System.Drawing.Size(31, 30);
            this.lblTotalTeachers.TabIndex = 1;
            this.lblTotalTeachers.Text = "...";
            // 
            // cardClasses
            // 
            this.cardClasses.BackColor = System.Drawing.Color.White;
            this.cardClasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardClasses.Controls.Add(this.lblTotalClasses);
            this.cardClasses.Controls.Add(this.lblTitleClasses);
            this.cardClasses.Location = new System.Drawing.Point(433, 3);
            this.cardClasses.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            this.cardClasses.Name = "cardClasses";
            this.cardClasses.Size = new System.Drawing.Size(200, 95);
            this.cardClasses.TabIndex = 2;
            // 
            // lblTitleClasses
            // 
            this.lblTitleClasses.AutoSize = true;
            this.lblTitleClasses.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTitleClasses.Location = new System.Drawing.Point(15, 12);
            this.lblTitleClasses.Name = "lblTitleClasses";
            this.lblTitleClasses.Size = new System.Drawing.Size(95, 15);
            this.lblTitleClasses.TabIndex = 0;
            this.lblTitleClasses.Text = "Classes / Groups";
            // 
            // lblTotalClasses
            // 
            this.lblTotalClasses.AutoSize = true;
            this.lblTotalClasses.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.lblTotalClasses.Location = new System.Drawing.Point(15, 38);
            this.lblTotalClasses.Name = "lblTotalClasses";
            this.lblTotalClasses.Size = new System.Drawing.Size(31, 30);
            this.lblTotalClasses.TabIndex = 1;
            this.lblTotalClasses.Text = "...";
            // 
            // cardParents
            // 
            this.cardParents.BackColor = System.Drawing.Color.White;
            this.cardParents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardParents.Controls.Add(this.lblTotalParents);
            this.cardParents.Controls.Add(this.lblTitleParents);
            this.cardParents.Location = new System.Drawing.Point(648, 3);
            this.cardParents.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            this.cardParents.Name = "cardParents";
            this.cardParents.Size = new System.Drawing.Size(200, 95);
            this.cardParents.TabIndex = 3;
            // 
            // lblTitleParents
            // 
            this.lblTitleParents.AutoSize = true;
            this.lblTitleParents.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleParents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTitleParents.Location = new System.Drawing.Point(15, 12);
            this.lblTitleParents.Name = "lblTitleParents";
            this.lblTitleParents.Size = new System.Drawing.Size(107, 15);
            this.lblTitleParents.TabIndex = 0;
            this.lblTitleParents.Text = "Registered Parents";
            // 
            // lblTotalParents
            // 
            this.lblTotalParents.AutoSize = true;
            this.lblTotalParents.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalParents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotalParents.Location = new System.Drawing.Point(15, 38);
            this.lblTotalParents.Name = "lblTotalParents";
            this.lblTotalParents.Size = new System.Drawing.Size(31, 30);
            this.lblTotalParents.TabIndex = 1;
            this.lblTotalParents.Text = "...";
            // 
            // cardYear
            // 
            this.cardYear.BackColor = System.Drawing.Color.White;
            this.cardYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardYear.Controls.Add(this.lblAcademicYear);
            this.cardYear.Controls.Add(this.lblTitleYear);
            this.cardYear.Location = new System.Drawing.Point(863, 3);
            this.cardYear.Name = "cardYear";
            this.cardYear.Size = new System.Drawing.Size(200, 95);
            this.cardYear.TabIndex = 4;
            // 
            // lblTitleYear
            // 
            this.lblTitleYear.AutoSize = true;
            this.lblTitleYear.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTitleYear.Location = new System.Drawing.Point(15, 12);
            this.lblTitleYear.Name = "lblTitleYear";
            this.lblTitleYear.Size = new System.Drawing.Size(132, 15);
            this.lblTitleYear.TabIndex = 0;
            this.lblTitleYear.Text = "Current Academic Year";
            // 
            // lblAcademicYear
            // 
            this.lblAcademicYear.AutoSize = true;
            this.lblAcademicYear.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblAcademicYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblAcademicYear.Location = new System.Drawing.Point(15, 42);
            this.lblAcademicYear.Name = "lblAcademicYear";
            this.lblAcademicYear.Size = new System.Drawing.Size(26, 25);
            this.lblAcademicYear.TabIndex = 1;
            this.lblAcademicYear.Text = "...";
            // 
            // lblModulesTitle
            // 
            this.lblModulesTitle.AutoSize = true;
            this.lblModulesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblModulesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblModulesTitle.Location = new System.Drawing.Point(30, 180);
            this.lblModulesTitle.Name = "lblModulesTitle";
            this.lblModulesTitle.Size = new System.Drawing.Size(183, 21);
            this.lblModulesTitle.TabIndex = 2;
            this.lblModulesTitle.Text = "Management Modules";
            // 
            // pnlModules
            // 
            this.pnlModules.Controls.Add(this.btnNavStudents);
            this.pnlModules.Controls.Add(this.btnNavParents);
            this.pnlModules.Controls.Add(this.btnNavAcademic);
            this.pnlModules.Controls.Add(this.btnNavTeachers);
            this.pnlModules.Controls.Add(this.btnNavCourses);
            this.pnlModules.Controls.Add(this.btnNavTimetable);
            this.pnlModules.Controls.Add(this.btnNavAttendance);
            this.pnlModules.Controls.Add(this.btnNavGrades);
            this.pnlModules.Controls.Add(this.btnNavFinance);
            this.pnlModules.Controls.Add(this.btnNavUsers);
            this.pnlModules.Controls.Add(this.btnNavReports);
            this.pnlModules.Location = new System.Drawing.Point(30, 215);
            this.pnlModules.Name = "pnlModules";
            this.pnlModules.Size = new System.Drawing.Size(1090, 380);
            this.pnlModules.TabIndex = 3;
            // 
            // btnNavStudents
            // 
            this.btnNavStudents.BackColor = System.Drawing.Color.White;
            this.btnNavStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavStudents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavStudents.Location = new System.Drawing.Point(3, 3);
            this.btnNavStudents.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.btnNavStudents.Name = "btnNavStudents";
            this.btnNavStudents.Size = new System.Drawing.Size(250, 100);
            this.btnNavStudents.TabIndex = 0;
            this.btnNavStudents.Text = "Students\r\n\r\nDirectory & Profiles";
            this.btnNavStudents.UseVisualStyleBackColor = false;
            this.btnNavStudents.Click += new System.EventHandler(this.BtnNavStudents_Click);
            // 
            // btnNavParents
            // 
            this.btnNavParents.BackColor = System.Drawing.Color.White;
            this.btnNavParents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavParents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavParents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavParents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavParents.Location = new System.Drawing.Point(271, 3);
            this.btnNavParents.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.btnNavParents.Name = "btnNavParents";
            this.btnNavParents.Size = new System.Drawing.Size(250, 100);
            this.btnNavParents.TabIndex = 1;
            this.btnNavParents.Text = "Parents\r\n\r\nGuardians & Linkages";
            this.btnNavParents.UseVisualStyleBackColor = false;
            this.btnNavParents.Click += new System.EventHandler(this.BtnNavParents_Click);
            // 
            // btnNavAcademic
            // 
            this.btnNavAcademic.BackColor = System.Drawing.Color.White;
            this.btnNavAcademic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAcademic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAcademic.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavAcademic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavAcademic.Location = new System.Drawing.Point(539, 3);
            this.btnNavAcademic.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.btnNavAcademic.Name = "btnNavAcademic";
            this.btnNavAcademic.Size = new System.Drawing.Size(250, 100);
            this.btnNavAcademic.TabIndex = 2;
            this.btnNavAcademic.Text = "Academic Years\r\n\r\nCalendar Sessions";
            this.btnNavAcademic.UseVisualStyleBackColor = false;
            this.btnNavAcademic.Click += new System.EventHandler(this.BtnNavAcademic_Click);
            // 
            // btnNavTeachers
            // 
            this.btnNavTeachers.BackColor = System.Drawing.Color.White;
            this.btnNavTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTeachers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNavTeachers.Location = new System.Drawing.Point(807, 3);
            this.btnNavTeachers.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.btnNavTeachers.Name = "btnNavTeachers";
            this.btnNavTeachers.Size = new System.Drawing.Size(250, 100);
            this.btnNavTeachers.TabIndex = 3;
            this.btnNavTeachers.Text = "Teachers & Staff\r\n\r\nFaculty Directory";
            this.btnNavTeachers.UseVisualStyleBackColor = false;
            this.btnNavTeachers.Click += new System.EventHandler(this.BtnNavTeachers_Click);
            // 
            // btnNavCourses
            // 
            this.btnNavCourses.BackColor = System.Drawing.Color.White;
            this.btnNavCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCourses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNavCourses.Location = new System.Drawing.Point(3, 121);
            this.btnNavCourses.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.btnNavCourses.Name = "btnNavCourses";
            this.btnNavCourses.Size = new System.Drawing.Size(250, 100);
            this.btnNavCourses.TabIndex = 4;
            this.btnNavCourses.Text = "Courses & Subjects\r\n\r\nCurriculum Management";
            this.btnNavCourses.UseVisualStyleBackColor = false;
            this.btnNavCourses.Click += new System.EventHandler(this.BtnNavCourses_Click);
            // 
            // btnNavTimetable
            // 
            this.btnNavTimetable.BackColor = System.Drawing.Color.White;
            this.btnNavTimetable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTimetable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavTimetable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNavTimetable.Location = new System.Drawing.Point(271, 121);
            this.btnNavTimetable.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.btnNavTimetable.Name = "btnNavTimetable";
            this.btnNavTimetable.Size = new System.Drawing.Size(250, 100);
            this.btnNavTimetable.TabIndex = 5;
            this.btnNavTimetable.Text = "Timetable & Schedules\r\n\r\nClass Weekly Scheduling";
            this.btnNavTimetable.UseVisualStyleBackColor = false;
            this.btnNavTimetable.Click += new System.EventHandler(this.BtnNavTimetable_Click);
            // 
            // btnNavAttendance
            // 
            this.btnNavAttendance.BackColor = System.Drawing.Color.White;
            this.btnNavAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAttendance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNavAttendance.Location = new System.Drawing.Point(539, 121);
            this.btnNavAttendance.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.btnNavAttendance.Name = "btnNavAttendance";
            this.btnNavAttendance.Size = new System.Drawing.Size(250, 100);
            this.btnNavAttendance.TabIndex = 6;
            this.btnNavAttendance.Text = "Attendance\r\n\r\nStudent Attendance Registers";
            this.btnNavAttendance.UseVisualStyleBackColor = false;
            this.btnNavAttendance.Click += new System.EventHandler(this.BtnNavAttendance_Click);
            // 
            // btnNavGrades
            // 
            this.btnNavGrades.BackColor = System.Drawing.Color.White;
            this.btnNavGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavGrades.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNavGrades.Location = new System.Drawing.Point(807, 121);
            this.btnNavGrades.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.btnNavGrades.Name = "btnNavGrades";
            this.btnNavGrades.Size = new System.Drawing.Size(250, 100);
            this.btnNavGrades.TabIndex = 7;
            this.btnNavGrades.Text = "Grades & Exams\r\n\r\nMarks & Evaluations";
            this.btnNavGrades.UseVisualStyleBackColor = false;
            this.btnNavGrades.Click += new System.EventHandler(this.BtnNavGrades_Click);
            // 
            // btnNavFinance
            // 
            this.btnNavFinance.BackColor = System.Drawing.Color.White;
            this.btnNavFinance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavFinance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavFinance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNavFinance.Location = new System.Drawing.Point(3, 239);
            this.btnNavFinance.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.btnNavFinance.Name = "btnNavFinance";
            this.btnNavFinance.Size = new System.Drawing.Size(250, 100);
            this.btnNavFinance.TabIndex = 8;
            this.btnNavFinance.Text = "Finance & Invoices\r\n\r\nTuition Fees & Payments";
            this.btnNavFinance.UseVisualStyleBackColor = false;
            this.btnNavFinance.Click += new System.EventHandler(this.BtnNavFinance_Click);
            // 
            // btnNavUsers
            // 
            this.btnNavUsers.BackColor = System.Drawing.Color.White;
            this.btnNavUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNavUsers.Location = new System.Drawing.Point(271, 239);
            this.btnNavUsers.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.btnNavUsers.Name = "btnNavUsers";
            this.btnNavUsers.Size = new System.Drawing.Size(250, 100);
            this.btnNavUsers.TabIndex = 9;
            this.btnNavUsers.Text = "System Users\r\n\r\nAccounts & Roles";
            this.btnNavUsers.UseVisualStyleBackColor = false;
            this.btnNavUsers.Click += new System.EventHandler(this.BtnNavUsers_Click);
            // 
            // btnNavReports
            // 
            this.btnNavReports.BackColor = System.Drawing.Color.White;
            this.btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReports.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNavReports.Location = new System.Drawing.Point(539, 239);
            this.btnNavReports.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.btnNavReports.Name = "btnNavReports";
            this.btnNavReports.Size = new System.Drawing.Size(250, 100);
            this.btnNavReports.TabIndex = 10;
            this.btnNavReports.Text = "Reports & Analytics\r\n\r\nAcademic Reports";
            this.btnNavReports.UseVisualStyleBackColor = false;
            this.btnNavReports.Click += new System.EventHandler(this.BtnNavReports_Click);
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminDashboard";
            this.Text = "Admin Dashboard";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.cardStudents.ResumeLayout(false);
            this.cardStudents.PerformLayout();
            this.cardTeachers.ResumeLayout(false);
            this.cardTeachers.PerformLayout();
            this.cardClasses.ResumeLayout(false);
            this.cardClasses.PerformLayout();
            this.cardParents.ResumeLayout(false);
            this.cardParents.PerformLayout();
            this.cardYear.ResumeLayout(false);
            this.cardYear.PerformLayout();
            this.pnlModules.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblKpiTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlCards;
        private System.Windows.Forms.Panel cardStudents;
        private System.Windows.Forms.Label lblTitleStudents;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Panel cardTeachers;
        private System.Windows.Forms.Label lblTitleTeachers;
        private System.Windows.Forms.Label lblTotalTeachers;
        private System.Windows.Forms.Panel cardClasses;
        private System.Windows.Forms.Label lblTitleClasses;
        private System.Windows.Forms.Label lblTotalClasses;
        private System.Windows.Forms.Panel cardParents;
        private System.Windows.Forms.Label lblTitleParents;
        private System.Windows.Forms.Label lblTotalParents;
        private System.Windows.Forms.Panel cardYear;
        private System.Windows.Forms.Label lblTitleYear;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.Label lblModulesTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlModules;
        private System.Windows.Forms.Button btnNavStudents;
        private System.Windows.Forms.Button btnNavParents;
        private System.Windows.Forms.Button btnNavAcademic;
        private System.Windows.Forms.Button btnNavTeachers;
        private System.Windows.Forms.Button btnNavCourses;
        private System.Windows.Forms.Button btnNavTimetable;
        private System.Windows.Forms.Button btnNavAttendance;
        private System.Windows.Forms.Button btnNavGrades;
        private System.Windows.Forms.Button btnNavFinance;
        private System.Windows.Forms.Button btnNavUsers;
        private System.Windows.Forms.Button btnNavReports;
    }
}
