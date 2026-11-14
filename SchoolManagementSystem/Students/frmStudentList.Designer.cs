namespace SchoolManagementSystem.Students
{
    partial class frmStudentList
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
            pnlHeader = new Panel();
            lblHeaderTitle = new Label();
            pnlStats = new Panel();
            pnlFilter = new Panel();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnViewProfile = new Button();
            btnAddStudent = new Button();
            btnShowUnEnrolled = new Button();
            cbFilterGender = new ComboBox();
            lblGender = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlBottom = new Panel();
            lblTotalCount = new Label();
            pnlGridWrapper = new Panel();
            dgvStudents = new DataGridView();
            cmsStudentActions = new ContextMenuStrip(components);
            cmsViewProfile = new ToolStripMenuItem();
            cmsEditStudent = new ToolStripMenuItem();
            cmsSeparator1 = new ToolStripSeparator();
            cmsEnrollStudent = new ToolStripMenuItem();
            cmsSeparator2 = new ToolStripSeparator();
            cmsDeleteStudent = new ToolStripMenuItem();
            pnlHeader.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            cmsStudentActions.SuspendLayout();
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
            pnlHeader.Size = new Size(1287, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Fill;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(38, 42, 51);
            lblHeaderTitle.Location = new Point(23, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(1241, 54);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "سجل وبيانات الطلاب";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlStats
            // 
            pnlStats.BackColor = Color.FromArgb(243, 244, 246);
            pnlStats.Dock = DockStyle.Top;
            pnlStats.Location = new Point(0, 80);
            pnlStats.Name = "pnlStats";
            pnlStats.Padding = new Padding(20, 8, 20, 8);
            pnlStats.Size = new Size(1287, 90);
            pnlStats.TabIndex = 4;
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.White;
            pnlFilter.Controls.Add(btnRefresh);
            pnlFilter.Controls.Add(btnDelete);
            pnlFilter.Controls.Add(btnEdit);
            pnlFilter.Controls.Add(btnViewProfile);
            pnlFilter.Controls.Add(btnAddStudent);
            pnlFilter.Controls.Add(btnShowUnEnrolled);
            pnlFilter.Controls.Add(cbFilterGender);
            pnlFilter.Controls.Add(lblGender);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 170);
            pnlFilter.Margin = new Padding(3, 4, 3, 4);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(23, 15, 23, 13);
            pnlFilter.Size = new Size(1287, 108);
            pnlFilter.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F);
            btnRefresh.ForeColor = Color.FromArgb(31, 41, 55);
            btnRefresh.Location = new Point(16, 33);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 42);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "تحديث";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(185, 28, 28);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(101, 33);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 42);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.5F);
            btnEdit.ForeColor = Color.FromArgb(31, 41, 55);
            btnEdit.Location = new Point(191, 33);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(80, 42);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "تعديل";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnViewProfile
            // 
            btnViewProfile.BackColor = Color.FromArgb(55, 71, 133);
            btnViewProfile.Cursor = Cursors.Hand;
            btnViewProfile.FlatAppearance.BorderSize = 0;
            btnViewProfile.FlatStyle = FlatStyle.Flat;
            btnViewProfile.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewProfile.ForeColor = Color.White;
            btnViewProfile.Location = new Point(281, 33);
            btnViewProfile.Margin = new Padding(3, 4, 3, 4);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(110, 42);
            btnViewProfile.TabIndex = 5;
            btnViewProfile.Text = "عرض الملف";
            btnViewProfile.UseVisualStyleBackColor = false;
            btnViewProfile.Click += BtnViewProfile_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(16, 122, 87);
            btnAddStudent.Cursor = Cursors.Hand;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Location = new Point(401, 33);
            btnAddStudent.Margin = new Padding(3, 4, 3, 4);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(140, 42);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "تسجيل طالب جديد";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += BtnAddStudent_Click;
            // 
            // btnShowUnEnrolled
            // 
            btnShowUnEnrolled.BackColor = Color.White;
            btnShowUnEnrolled.Cursor = Cursors.Hand;
            btnShowUnEnrolled.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnShowUnEnrolled.FlatStyle = FlatStyle.Flat;
            btnShowUnEnrolled.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnShowUnEnrolled.ForeColor = Color.FromArgb(185, 28, 28);
            btnShowUnEnrolled.Location = new Point(675, 39);
            btnShowUnEnrolled.Margin = new Padding(3, 4, 3, 4);
            btnShowUnEnrolled.Name = "btnShowUnEnrolled";
            btnShowUnEnrolled.Size = new Size(120, 42);
            btnShowUnEnrolled.TabIndex = 9;
            btnShowUnEnrolled.Text = "غير المقيدين";
            btnShowUnEnrolled.UseVisualStyleBackColor = false;
            btnShowUnEnrolled.Click += BtnShowUnEnrolled_Click;
            // 
            // cbFilterGender
            // 
            cbFilterGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFilterGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterGender.Font = new Font("Segoe UI", 9.5F);
            cbFilterGender.FormattingEnabled = true;
            cbFilterGender.Items.AddRange(new object[] { "الكل", "ذكر", "أنثى" });
            cbFilterGender.Location = new Point(820, 52);
            cbFilterGender.Margin = new Padding(3, 4, 3, 4);
            cbFilterGender.Name = "cbFilterGender";
            cbFilterGender.Size = new Size(135, 29);
            cbFilterGender.TabIndex = 3;
            cbFilterGender.SelectedIndexChanged += CbFilterGender_SelectedIndexChanged;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(31, 41, 55);
            lblGender.Location = new Point(820, 23);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(143, 21);
            lblGender.TabIndex = 2;
            lblGender.Text = "تصفية حسب الجنس:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(964, 52);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 30);
            txtSearch.TabIndex = 1;
            txtSearch.TextAlign = HorizontalAlignment.Right;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(31, 41, 55);
            lblSearch.Location = new Point(990, 23);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(269, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "بحث بالاسم / رقم القبول / الرقم الوطني:";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotalCount);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 631);
            pnlBottom.Margin = new Padding(3, 4, 3, 4);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(23, 13, 23, 13);
            pnlBottom.Size = new Size(1287, 53);
            pnlBottom.TabIndex = 2;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Dock = DockStyle.Right;
            lblTotalCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(107, 114, 128);
            lblTotalCount.Location = new Point(1066, 13);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(198, 21);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "إجمالي الطلاب المعروضين: 0";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvStudents);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 278);
            pnlGridWrapper.Margin = new Padding(3, 4, 3, 4);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(23, 20, 23, 20);
            pnlGridWrapper.Size = new Size(1287, 353);
            pnlGridWrapper.TabIndex = 3;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.ContextMenuStrip = cmsStudentActions;
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.Location = new Point(23, 20);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(1241, 313);
            dgvStudents.TabIndex = 0;
            dgvStudents.DoubleClick += DgvStudents_DoubleClick;
            // 
            // cmsStudentActions
            // 
            cmsStudentActions.BackColor = Color.White;
            cmsStudentActions.Font = new Font("Segoe UI", 9.5F);
            cmsStudentActions.ImageScalingSize = new Size(20, 20);
            cmsStudentActions.Items.AddRange(new ToolStripItem[] { cmsViewProfile, cmsEditStudent, cmsSeparator1, cmsEnrollStudent, cmsSeparator2, cmsDeleteStudent });
            cmsStudentActions.Name = "cmsStudentActions";
            cmsStudentActions.RightToLeft = RightToLeft.Yes;
            cmsStudentActions.Size = new Size(221, 120);
            // 
            // cmsViewProfile
            // 
            cmsViewProfile.Name = "cmsViewProfile";
            cmsViewProfile.Size = new Size(220, 26);
            cmsViewProfile.Text = "عرض الملف الشخصي";
            cmsViewProfile.Click += BtnViewProfile_Click;
            // 
            // cmsEditStudent
            // 
            cmsEditStudent.Name = "cmsEditStudent";
            cmsEditStudent.Size = new Size(220, 26);
            cmsEditStudent.Text = "تعديل البيانات";
            cmsEditStudent.Click += BtnEdit_Click;
            // 
            // cmsSeparator1
            // 
            cmsSeparator1.Name = "cmsSeparator1";
            cmsSeparator1.Size = new Size(217, 6);
            // 
            // cmsEnrollStudent
            // 
            cmsEnrollStudent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            cmsEnrollStudent.ForeColor = Color.FromArgb(16, 122, 87);
            cmsEnrollStudent.Name = "cmsEnrollStudent";
            cmsEnrollStudent.Size = new Size(220, 26);
            cmsEnrollStudent.Text = "قيد في صف";
            cmsEnrollStudent.Click += CmsEnrollStudent_Click;
            // 
            // cmsSeparator2
            // 
            cmsSeparator2.Name = "cmsSeparator2";
            cmsSeparator2.Size = new Size(217, 6);
            // 
            // cmsDeleteStudent
            // 
            cmsDeleteStudent.ForeColor = Color.FromArgb(185, 28, 28);
            cmsDeleteStudent.Name = "cmsDeleteStudent";
            cmsDeleteStudent.Size = new Size(220, 26);
            cmsDeleteStudent.Text = "حذف الطالب";
            cmsDeleteStudent.Click += BtnDelete_Click;
            // 
            // frmStudentList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1287, 684);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlBottom);
            Controls.Add(pnlFilter);
            Controls.Add(pnlStats);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStudentList";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "إدارة سجلات الطلاب";
            Load += FrmStudentList_Load;
            pnlHeader.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            cmsStudentActions.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbFilterGender;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnShowUnEnrolled;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Panel pnlGridWrapper;
        private DataGridView dgvStudents;
        private System.Windows.Forms.ContextMenuStrip cmsStudentActions;
        private System.Windows.Forms.ToolStripMenuItem cmsViewProfile;
        private System.Windows.Forms.ToolStripMenuItem cmsEditStudent;
        private System.Windows.Forms.ToolStripSeparator cmsSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsEnrollStudent;
        private System.Windows.Forms.ToolStripSeparator cmsSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteStudent;
    }
}
