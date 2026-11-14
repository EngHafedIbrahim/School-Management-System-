namespace SchoolManagementSystem.Teachers
{
    partial class frmTeacherList
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
            pnlFilter = new Panel();
            cbFilterStatus = new ComboBox();
            lblFilterStatus = new Label();
            cbFilterGender = new ComboBox();
            lblFilterGender = new Label();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnViewProfile = new Button();
            btnAddTeacher = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlBottom = new Panel();
            lblTotalCount = new Label();
            pnlGridWrapper = new Panel();
            dgvTeachers = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1170, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Anchor = AnchorStyles.Top;
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblHeaderTitle.Location = new Point(400, 18);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(380, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "دليل وسجل المعلمين والكادر التدريسي";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.White;
            pnlFilter.Controls.Add(cbFilterStatus);
            pnlFilter.Controls.Add(lblFilterStatus);
            pnlFilter.Controls.Add(cbFilterGender);
            pnlFilter.Controls.Add(lblFilterGender);
            pnlFilter.Controls.Add(btnRefresh);
            pnlFilter.Controls.Add(btnDelete);
            pnlFilter.Controls.Add(btnEdit);
            pnlFilter.Controls.Add(btnViewProfile);
            pnlFilter.Controls.Add(btnAddTeacher);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 75);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1170, 80);
            pnlFilter.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.Location = new Point(15, 22);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 40);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "تحديث";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnDelete.BackColor = Color.FromArgb(220, 38, 38);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(96, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 40);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 9F);
            btnEdit.Location = new Point(177, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 40);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "تعديل";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnViewProfile
            // 
            btnViewProfile.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnViewProfile.BackColor = Color.FromArgb(37, 99, 235);
            btnViewProfile.Cursor = Cursors.Hand;
            btnViewProfile.FlatAppearance.BorderSize = 0;
            btnViewProfile.FlatStyle = FlatStyle.Flat;
            btnViewProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewProfile.ForeColor = Color.White;
            btnViewProfile.Location = new Point(258, 22);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(110, 40);
            btnViewProfile.TabIndex = 7;
            btnViewProfile.Text = "ملف المعلم";
            btnViewProfile.UseVisualStyleBackColor = false;
            btnViewProfile.Click += BtnViewProfile_Click;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnAddTeacher.BackColor = Color.FromArgb(16, 185, 129);
            btnAddTeacher.Cursor = Cursors.Hand;
            btnAddTeacher.FlatAppearance.BorderSize = 0;
            btnAddTeacher.FlatStyle = FlatStyle.Flat;
            btnAddTeacher.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddTeacher.ForeColor = Color.White;
            btnAddTeacher.Location = new Point(374, 22);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(140, 40);
            btnAddTeacher.TabIndex = 6;
            btnAddTeacher.Text = "+ إضافة معلم جديد";
            btnAddTeacher.UseVisualStyleBackColor = false;
            btnAddTeacher.Click += BtnAddTeacher_Click;
            // 
            // cbFilterStatus
            // 
            cbFilterStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterStatus.Font = new Font("Segoe UI", 9.5F);
            cbFilterStatus.FormattingEnabled = true;
            cbFilterStatus.Items.AddRange(new object[] { "الكل", "نشط", "في إجازة", "مستقيل" });
            cbFilterStatus.Location = new Point(530, 27);
            cbFilterStatus.Name = "cbFilterStatus";
            cbFilterStatus.Size = new Size(115, 29);
            cbFilterStatus.TabIndex = 5;
            cbFilterStatus.SelectedIndexChanged += CbFilterStatus_SelectedIndexChanged;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFilterStatus.ForeColor = Color.FromArgb(30, 41, 59);
            lblFilterStatus.Location = new Point(648, 30);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(52, 21);
            lblFilterStatus.TabIndex = 4;
            lblFilterStatus.Text = "الحالة:";
            // 
            // cbFilterGender
            // 
            cbFilterGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFilterGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterGender.Font = new Font("Segoe UI", 9.5F);
            cbFilterGender.FormattingEnabled = true;
            cbFilterGender.Items.AddRange(new object[] { "الكل", "ذكر", "أنثى" });
            cbFilterGender.Location = new Point(710, 27);
            cbFilterGender.Name = "cbFilterGender";
            cbFilterGender.Size = new Size(100, 29);
            cbFilterGender.TabIndex = 3;
            cbFilterGender.SelectedIndexChanged += CbFilterGender_SelectedIndexChanged;
            // 
            // lblFilterGender
            // 
            lblFilterGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFilterGender.AutoSize = true;
            lblFilterGender.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFilterGender.ForeColor = Color.FromArgb(30, 41, 59);
            lblFilterGender.Location = new Point(813, 30);
            lblFilterGender.Name = "lblFilterGender";
            lblFilterGender.Size = new Size(56, 21);
            lblFilterGender.TabIndex = 2;
            lblFilterGender.Text = "الجنس:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(880, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 29);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(30, 41, 59);
            lblSearch.Location = new Point(1085, 30);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(69, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "بحث عام:";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotalCount);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 782);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(20, 12, 20, 12);
            pnlBottom.Size = new Size(1170, 46);
            pnlBottom.TabIndex = 2;
            // 
            // lblTotalCount
            // 
            lblTotalCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotalCount.Location = new Point(980, 12);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(167, 21);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "إجمالي المعلمين: 0";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvTeachers);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 155);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(20);
            pnlGridWrapper.Size = new Size(1170, 627);
            pnlGridWrapper.TabIndex = 3;
            // 
            // dgvTeachers
            // 
            dgvTeachers.AllowUserToAddRows = false;
            dgvTeachers.AllowUserToDeleteRows = false;
            dgvTeachers.AllowUserToOrderColumns = true;
            dgvTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeachers.BackgroundColor = Color.White;
            dgvTeachers.BorderStyle = BorderStyle.None;
            dgvTeachers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Dock = DockStyle.Fill;
            dgvTeachers.MultiSelect = false;
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.ReadOnly = true;
            dgvTeachers.RowHeadersVisible = false;
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.Size = new Size(1130, 587);
            dgvTeachers.TabIndex = 0;
            dgvTeachers.DoubleClick += DgvTeachers_DoubleClick;
            // 
            // frmTeacherList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1170, 828);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlBottom);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1000, 600);
            Name = "frmTeacherList";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "دليل المعلمين";
            Load += FrmTeacherList_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterGender;
        private System.Windows.Forms.ComboBox cbFilterGender;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cbFilterStatus;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Panel pnlGridWrapper;
        private System.Windows.Forms.DataGridView dgvTeachers;
    }
}
