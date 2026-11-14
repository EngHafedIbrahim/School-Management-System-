namespace SchoolManagementSystem.Attendance
{
    partial class frmAttendanceManagement
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
            lblSubtitle = new Label();
            pnlHeaderLine = new Panel();
            gbSelection = new GroupBox();
            btnLoad = new Button();
            cbSession = new ComboBox();
            lblSession = new Label();
            dtpDate = new DateTimePicker();
            lblDate = new Label();
            cbClass = new ComboBox();
            lblClass = new Label();
            dgvAttendance = new DataGridView();
            pnlQuickActions = new Panel();
            lblStats = new Label();
            btnMarkAllExcused = new Button();
            btnMarkAllLate = new Button();
            btnMarkAllAbsent = new Button();
            btnMarkAllPresent = new Button();
            btnSave = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            gbSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            pnlQuickActions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(pnlHeaderLine);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(24, 12, 24, 0);
            pnlHeader.Size = new Size(1119, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(740, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "إدارة ومتابعة الحضور والغياب";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblSubtitle.Location = new Point(790, 47);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(300, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "تسجيل ورصد الحضور والغياب اليومي للطلاب";
            // 
            // pnlHeaderLine
            // 
            pnlHeaderLine.BackColor = Color.FromArgb(220, 224, 230);
            pnlHeaderLine.Dock = DockStyle.Bottom;
            pnlHeaderLine.Location = new Point(24, 74);
            pnlHeaderLine.Name = "pnlHeaderLine";
            pnlHeaderLine.Size = new Size(1071, 1);
            pnlHeaderLine.TabIndex = 2;
            // 
            // gbSelection
            // 
            gbSelection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbSelection.Controls.Add(btnLoad);
            gbSelection.Controls.Add(cbSession);
            gbSelection.Controls.Add(lblSession);
            gbSelection.Controls.Add(dtpDate);
            gbSelection.Controls.Add(lblDate);
            gbSelection.Controls.Add(cbClass);
            gbSelection.Controls.Add(lblClass);
            gbSelection.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbSelection.ForeColor = Color.FromArgb(44, 62, 80);
            gbSelection.Location = new Point(24, 85);
            gbSelection.Name = "gbSelection";
            gbSelection.Size = new Size(1071, 95);
            gbSelection.TabIndex = 1;
            gbSelection.TabStop = false;
            gbSelection.Text = "تحديد الشعبة والجلسة الدراسية";
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnLoad.Cursor = Cursors.Hand;
            btnLoad.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLoad.Location = new Point(16, 35);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(160, 42);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "تحميل قائمة الطلاب";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += BtnLoad_Click;
            // 
            // cbSession
            // 
            cbSession.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbSession.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSession.Font = new Font("Segoe UI", 9.5F);
            cbSession.FormattingEnabled = true;
            cbSession.Items.AddRange(new object[] { "الحصة 1 (08:00 - 08:45)", "الحصة 2 (08:45 - 09:30)", "الحصة 3 (09:45 - 10:30)", "الحصة 4 (10:30 - 11:15)", "الحصة 5 (11:30 - 12:15)", "الحصة 6 (12:15 - 01:00)", "الحصة 7 (01:15 - 02:00)" });
            cbSession.Location = new Point(200, 42);
            cbSession.Name = "cbSession";
            cbSession.Size = new Size(250, 29);
            cbSession.TabIndex = 5;
            // 
            // lblSession
            // 
            lblSession.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSession.AutoSize = true;
            lblSession.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSession.Location = new Point(455, 46);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(109, 21);
            lblSession.TabIndex = 4;
            lblSession.Text = "الحصة / الجلسة:";
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDate.Font = new Font("Segoe UI", 9.5F);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(580, 42);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(150, 29);
            dtpDate.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDate.Location = new Point(735, 46);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(54, 21);
            lblDate.TabIndex = 2;
            lblDate.Text = "التاريخ:";
            // 
            // cbClass
            // 
            cbClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.Font = new Font("Segoe UI", 9.5F);
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(810, 42);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(150, 29);
            cbClass.TabIndex = 1;
            // 
            // lblClass
            // 
            lblClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblClass.Location = new Point(965, 46);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(95, 21);
            lblClass.TabIndex = 0;
            lblClass.Text = "الشعبة / الفصل:";
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(24, 245);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(1071, 475);
            dgvAttendance.TabIndex = 3;
            dgvAttendance.CellFormatting += DgvAttendance_CellFormatting;
            dgvAttendance.CellValueChanged += DgvAttendance_CellValueChanged;
            dgvAttendance.CurrentCellDirtyStateChanged += DgvAttendance_CurrentCellDirtyStateChanged;
            // 
            // pnlQuickActions
            // 
            pnlQuickActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlQuickActions.BackColor = Color.FromArgb(241, 245, 249);
            pnlQuickActions.Controls.Add(lblStats);
            pnlQuickActions.Controls.Add(btnMarkAllExcused);
            pnlQuickActions.Controls.Add(btnMarkAllLate);
            pnlQuickActions.Controls.Add(btnMarkAllAbsent);
            pnlQuickActions.Controls.Add(btnMarkAllPresent);
            pnlQuickActions.Location = new Point(24, 188);
            pnlQuickActions.Name = "pnlQuickActions";
            pnlQuickActions.Size = new Size(1071, 48);
            pnlQuickActions.TabIndex = 2;
            // 
            // lblStats
            // 
            lblStats.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStats.AutoSize = true;
            lblStats.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStats.ForeColor = Color.FromArgb(71, 85, 105);
            lblStats.Location = new Point(600, 13);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(450, 21);
            lblStats.TabIndex = 0;
            lblStats.Text = "الإجمالي: 0  |  حضور: 0  |  غياب: 0  |  تأخر: 0  |  بعذر: 0";
            // 
            // btnMarkAllExcused
            // 
            btnMarkAllExcused.Cursor = Cursors.Hand;
            btnMarkAllExcused.Font = new Font("Segoe UI", 8.5F);
            btnMarkAllExcused.Location = new Point(16, 7);
            btnMarkAllExcused.Name = "btnMarkAllExcused";
            btnMarkAllExcused.Size = new Size(110, 35);
            btnMarkAllExcused.TabIndex = 4;
            btnMarkAllExcused.Text = "الكل بعذر";
            btnMarkAllExcused.UseVisualStyleBackColor = true;
            btnMarkAllExcused.Click += BtnMarkAllExcused_Click;
            // 
            // btnMarkAllLate
            // 
            btnMarkAllLate.Cursor = Cursors.Hand;
            btnMarkAllLate.Font = new Font("Segoe UI", 8.5F);
            btnMarkAllLate.Location = new Point(135, 7);
            btnMarkAllLate.Name = "btnMarkAllLate";
            btnMarkAllLate.Size = new Size(110, 35);
            btnMarkAllLate.TabIndex = 3;
            btnMarkAllLate.Text = "الكل متأخر";
            btnMarkAllLate.UseVisualStyleBackColor = true;
            btnMarkAllLate.Click += BtnMarkAllLate_Click;
            // 
            // btnMarkAllAbsent
            // 
            btnMarkAllAbsent.Cursor = Cursors.Hand;
            btnMarkAllAbsent.Font = new Font("Segoe UI", 8.5F);
            btnMarkAllAbsent.Location = new Point(255, 7);
            btnMarkAllAbsent.Name = "btnMarkAllAbsent";
            btnMarkAllAbsent.Size = new Size(110, 35);
            btnMarkAllAbsent.TabIndex = 2;
            btnMarkAllAbsent.Text = "الكل غائب";
            btnMarkAllAbsent.UseVisualStyleBackColor = true;
            btnMarkAllAbsent.Click += BtnMarkAllAbsent_Click;
            // 
            // btnMarkAllPresent
            // 
            btnMarkAllPresent.Cursor = Cursors.Hand;
            btnMarkAllPresent.Font = new Font("Segoe UI", 8.5F);
            btnMarkAllPresent.Location = new Point(375, 7);
            btnMarkAllPresent.Name = "btnMarkAllPresent";
            btnMarkAllPresent.Size = new Size(110, 35);
            btnMarkAllPresent.TabIndex = 1;
            btnMarkAllPresent.Text = "الكل حاضر";
            btnMarkAllPresent.UseVisualStyleBackColor = true;
            btnMarkAllPresent.Click += BtnMarkAllPresent_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(140, 733);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 45);
            btnSave.TabIndex = 4;
            btnSave.Text = "حفظ الحضور";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.Location = new Point(24, 733);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(105, 45);
            btnClose.TabIndex = 5;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // frmAttendanceManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1119, 793);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(dgvAttendance);
            Controls.Add(pnlQuickActions);
            Controls.Add(gbSelection);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1003, 651);
            Name = "frmAttendanceManagement";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة وتسجيل الحضور والغياب";
            Load += FrmAttendanceManagement_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            gbSelection.ResumeLayout(false);
            gbSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            pnlQuickActions.ResumeLayout(false);
            pnlQuickActions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.GroupBox gbSelection;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.ComboBox cbSession;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Button btnMarkAllPresent;
        private System.Windows.Forms.Button btnMarkAllAbsent;
        private System.Windows.Forms.Button btnMarkAllLate;
        private System.Windows.Forms.Button btnMarkAllExcused;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}
