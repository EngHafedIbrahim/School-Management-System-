namespace SchoolManagementSystem.Enrollment
{
    partial class frmStudentEnrollmentList
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            gbFilter = new GroupBox();
            btnRefresh = new Button();
            cbFilterStatus = new ComboBox();
            lblFilterStatus = new Label();
            cbFilterClass = new ComboBox();
            lblFilterClass = new Label();
            cbFilterYear = new ComboBox();
            lblFilterYear = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvEnrollments = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cmsEdit = new ToolStripMenuItem();
            cmsChangeStatus = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            cmsViewStudentProfile = new ToolStripMenuItem();
            lblTotalCount = new Label();
            btnEnrollStudent = new Button();
            btnEditEnrollment = new Button();
            btnChangeStatus = new Button();
            btnViewProfile = new Button();
            btnClose = new Button();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnrollments).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(38, 42, 51);
            lblTitle.Location = new Point(430, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "دليل تسجيل وقيد الطلاب";
            // 
            // gbFilter
            // 
            gbFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFilter.Controls.Add(btnRefresh);
            gbFilter.Controls.Add(cbFilterStatus);
            gbFilter.Controls.Add(lblFilterStatus);
            gbFilter.Controls.Add(cbFilterClass);
            gbFilter.Controls.Add(lblFilterClass);
            gbFilter.Controls.Add(cbFilterYear);
            gbFilter.Controls.Add(lblFilterYear);
            gbFilter.Controls.Add(txtSearch);
            gbFilter.Controls.Add(lblSearch);
            gbFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbFilter.ForeColor = Color.FromArgb(55, 71, 133);
            gbFilter.Location = new Point(33, 75);
            gbFilter.Margin = new Padding(3, 4, 3, 4);
            gbFilter.Name = "gbFilter";
            gbFilter.Padding = new Padding(3, 4, 3, 4);
            gbFilter.Size = new Size(1086, 105);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "البحث وتصفية السجلات";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F);
            btnRefresh.ForeColor = Color.FromArgb(31, 41, 55);
            btnRefresh.Location = new Point(18, 38);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(95, 38);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "تحديث";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // cbFilterStatus
            // 
            cbFilterStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterStatus.Font = new Font("Segoe UI", 9.5F);
            cbFilterStatus.FormattingEnabled = true;
            cbFilterStatus.Items.AddRange(new object[] { "الكل", "نشط", "منقول", "متخرج", "منسحب" });
            cbFilterStatus.Location = new Point(130, 43);
            cbFilterStatus.Margin = new Padding(3, 4, 3, 4);
            cbFilterStatus.Name = "cbFilterStatus";
            cbFilterStatus.Size = new Size(130, 29);
            cbFilterStatus.TabIndex = 7;
            cbFilterStatus.SelectedIndexChanged += Filter_Changed;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Font = new Font("Segoe UI", 9.5F);
            lblFilterStatus.Location = new Point(266, 47);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(52, 21);
            lblFilterStatus.TabIndex = 6;
            lblFilterStatus.Text = "الحالة:";
            // 
            // cbFilterClass
            // 
            cbFilterClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFilterClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterClass.Font = new Font("Segoe UI", 9.5F);
            cbFilterClass.FormattingEnabled = true;
            cbFilterClass.Location = new Point(340, 43);
            cbFilterClass.Margin = new Padding(3, 4, 3, 4);
            cbFilterClass.Name = "cbFilterClass";
            cbFilterClass.Size = new Size(150, 29);
            cbFilterClass.TabIndex = 5;
            cbFilterClass.SelectedIndexChanged += Filter_Changed;
            // 
            // lblFilterClass
            // 
            lblFilterClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFilterClass.AutoSize = true;
            lblFilterClass.Font = new Font("Segoe UI", 9.5F);
            lblFilterClass.Location = new Point(496, 47);
            lblFilterClass.Name = "lblFilterClass";
            lblFilterClass.Size = new Size(61, 21);
            lblFilterClass.TabIndex = 4;
            lblFilterClass.Text = "الشعبة:";
            // 
            // cbFilterYear
            // 
            cbFilterYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFilterYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterYear.Font = new Font("Segoe UI", 9.5F);
            cbFilterYear.FormattingEnabled = true;
            cbFilterYear.Location = new Point(570, 43);
            cbFilterYear.Margin = new Padding(3, 4, 3, 4);
            cbFilterYear.Name = "cbFilterYear";
            cbFilterYear.Size = new Size(140, 29);
            cbFilterYear.TabIndex = 3;
            cbFilterYear.SelectedIndexChanged += Filter_Changed;
            // 
            // lblFilterYear
            // 
            lblFilterYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFilterYear.AutoSize = true;
            lblFilterYear.Font = new Font("Segoe UI", 9.5F);
            lblFilterYear.Location = new Point(716, 47);
            lblFilterYear.Name = "lblFilterYear";
            lblFilterYear.Size = new Size(106, 21);
            lblFilterYear.TabIndex = 2;
            lblFilterYear.Text = "السنة الدراسية:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(830, 43);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(195, 29);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += Filter_Changed;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F);
            lblSearch.Location = new Point(1031, 47);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "بحث:";
            // 
            // dgvEnrollments
            // 
            dgvEnrollments.AllowUserToAddRows = false;
            dgvEnrollments.AllowUserToDeleteRows = false;
            dgvEnrollments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEnrollments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEnrollments.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEnrollments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEnrollments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnrollments.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEnrollments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEnrollments.Location = new Point(33, 195);
            dgvEnrollments.Margin = new Padding(3, 4, 3, 4);
            dgvEnrollments.MultiSelect = false;
            dgvEnrollments.Name = "dgvEnrollments";
            dgvEnrollments.ReadOnly = true;
            dgvEnrollments.RowHeadersWidth = 51;
            dgvEnrollments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnrollments.Size = new Size(1086, 485);
            dgvEnrollments.TabIndex = 2;
            dgvEnrollments.DoubleClick += DgvEnrollments_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cmsEdit, cmsChangeStatus, toolStripSeparator1, cmsViewStudentProfile });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(200, 88);
            // 
            // cmsEdit
            // 
            cmsEdit.Name = "cmsEdit";
            cmsEdit.Size = new Size(199, 24);
            cmsEdit.Text = "تعديل القيد";
            cmsEdit.Click += BtnEditEnrollment_Click;
            // 
            // cmsChangeStatus
            // 
            cmsChangeStatus.Name = "cmsChangeStatus";
            cmsChangeStatus.Size = new Size(199, 24);
            cmsChangeStatus.Text = "تغيير حالة القيد";
            cmsChangeStatus.Click += BtnChangeStatus_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(196, 6);
            // 
            // cmsViewStudentProfile
            // 
            cmsViewStudentProfile.Name = "cmsViewStudentProfile";
            cmsViewStudentProfile.Size = new Size(199, 24);
            cmsViewStudentProfile.Text = "عرض ملف الطالب";
            cmsViewStudentProfile.Click += BtnViewProfile_Click;
            // 
            // lblTotalCount
            // 
            lblTotalCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotalCount.Location = new Point(960, 704);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(159, 21);
            lblTotalCount.TabIndex = 3;
            lblTotalCount.Text = "إجمالي القيود: 0";
            // 
            // btnEnrollStudent
            // 
            btnEnrollStudent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEnrollStudent.BackColor = Color.FromArgb(16, 122, 87);
            btnEnrollStudent.Cursor = Cursors.Hand;
            btnEnrollStudent.FlatAppearance.BorderSize = 0;
            btnEnrollStudent.FlatStyle = FlatStyle.Flat;
            btnEnrollStudent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEnrollStudent.ForeColor = Color.White;
            btnEnrollStudent.Location = new Point(570, 693);
            btnEnrollStudent.Margin = new Padding(3, 4, 3, 4);
            btnEnrollStudent.Name = "btnEnrollStudent";
            btnEnrollStudent.Size = new Size(160, 43);
            btnEnrollStudent.TabIndex = 4;
            btnEnrollStudent.Text = "تسجيل قيد طالب";
            btnEnrollStudent.UseVisualStyleBackColor = false;
            btnEnrollStudent.Click += BtnEnrollStudent_Click;
            // 
            // btnEditEnrollment
            // 
            btnEditEnrollment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditEnrollment.BackColor = Color.White;
            btnEditEnrollment.Cursor = Cursors.Hand;
            btnEditEnrollment.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnEditEnrollment.FlatStyle = FlatStyle.Flat;
            btnEditEnrollment.Font = new Font("Segoe UI", 9.5F);
            btnEditEnrollment.ForeColor = Color.FromArgb(31, 41, 55);
            btnEditEnrollment.Location = new Point(430, 693);
            btnEditEnrollment.Margin = new Padding(3, 4, 3, 4);
            btnEditEnrollment.Name = "btnEditEnrollment";
            btnEditEnrollment.Size = new Size(130, 43);
            btnEditEnrollment.TabIndex = 5;
            btnEditEnrollment.Text = "تعديل القيد";
            btnEditEnrollment.UseVisualStyleBackColor = false;
            btnEditEnrollment.Click += BtnEditEnrollment_Click;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnChangeStatus.BackColor = Color.White;
            btnChangeStatus.Cursor = Cursors.Hand;
            btnChangeStatus.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnChangeStatus.FlatStyle = FlatStyle.Flat;
            btnChangeStatus.Font = new Font("Segoe UI", 9.5F);
            btnChangeStatus.ForeColor = Color.FromArgb(31, 41, 55);
            btnChangeStatus.Location = new Point(290, 693);
            btnChangeStatus.Margin = new Padding(3, 4, 3, 4);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(130, 43);
            btnChangeStatus.TabIndex = 6;
            btnChangeStatus.Text = "تغيير الحالة";
            btnChangeStatus.UseVisualStyleBackColor = false;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            // 
            // btnViewProfile
            // 
            btnViewProfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewProfile.BackColor = Color.FromArgb(55, 71, 133);
            btnViewProfile.Cursor = Cursors.Hand;
            btnViewProfile.FlatAppearance.BorderSize = 0;
            btnViewProfile.FlatStyle = FlatStyle.Flat;
            btnViewProfile.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewProfile.ForeColor = Color.White;
            btnViewProfile.Location = new Point(145, 693);
            btnViewProfile.Margin = new Padding(3, 4, 3, 4);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(135, 43);
            btnViewProfile.TabIndex = 7;
            btnViewProfile.Text = "عرض الملف";
            btnViewProfile.UseVisualStyleBackColor = false;
            btnViewProfile.Click += BtnViewProfile_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.ForeColor = Color.FromArgb(31, 41, 55);
            btnClose.Location = new Point(33, 693);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 43);
            btnClose.TabIndex = 8;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // frmStudentEnrollmentList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1153, 753);
            Controls.Add(btnClose);
            Controls.Add(btnViewProfile);
            Controls.Add(btnChangeStatus);
            Controls.Add(btnEditEnrollment);
            Controls.Add(btnEnrollStudent);
            Controls.Add(lblTotalCount);
            Controls.Add(dgvEnrollments);
            Controls.Add(gbFilter);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1049, 651);
            Name = "frmStudentEnrollmentList";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة قيود الطلاب وتسكينهم";
            Load += FrmStudentEnrollmentList_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnrollments).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterYear;
        private System.Windows.Forms.ComboBox cbFilterYear;
        private System.Windows.Forms.Label lblFilterClass;
        private System.Windows.Forms.ComboBox cbFilterClass;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cbFilterStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvEnrollments;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Button btnEnrollStudent;
        private System.Windows.Forms.Button btnEditEnrollment;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsChangeStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsViewStudentProfile;
    }
}
