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
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(23, 13, 23, 13);
            pnlHeader.Size = new Size(1170, 93);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(526, 9);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(180, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Teachers List";
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
            pnlFilter.Location = new Point(0, 93);
            pnlFilter.Margin = new Padding(3, 4, 3, 4);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(23, 20, 23, 13);
            pnlFilter.Size = new Size(1170, 87);
            pnlFilter.TabIndex = 1;
            // 
            // cbFilterStatus
            // 
            cbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterStatus.Font = new Font("Segoe UI", 9.5F);
            cbFilterStatus.FormattingEnabled = true;
            cbFilterStatus.Items.AddRange(new object[] { "All", "Active", "On Leave", "Resigned" });
            cbFilterStatus.Location = new Point(434, 37);
            cbFilterStatus.Margin = new Padding(3, 4, 3, 4);
            cbFilterStatus.Name = "cbFilterStatus";
            cbFilterStatus.Size = new Size(125, 29);
            cbFilterStatus.TabIndex = 5;
            cbFilterStatus.SelectedIndexChanged += CbFilterStatus_SelectedIndexChanged;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFilterStatus.ForeColor = Color.FromArgb(33, 37, 41);
            lblFilterStatus.Location = new Point(434, 11);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(61, 21);
            lblFilterStatus.TabIndex = 4;
            lblFilterStatus.Text = "Status:";
            // 
            // cbFilterGender
            // 
            cbFilterGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterGender.Font = new Font("Segoe UI", 9.5F);
            cbFilterGender.FormattingEnabled = true;
            cbFilterGender.Items.AddRange(new object[] { "All", "Male", "Female" });
            cbFilterGender.Location = new Point(297, 37);
            cbFilterGender.Margin = new Padding(3, 4, 3, 4);
            cbFilterGender.Name = "cbFilterGender";
            cbFilterGender.Size = new Size(119, 29);
            cbFilterGender.TabIndex = 3;
            cbFilterGender.SelectedIndexChanged += CbFilterGender_SelectedIndexChanged;
            // 
            // lblFilterGender
            // 
            lblFilterGender.AutoSize = true;
            lblFilterGender.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFilterGender.ForeColor = Color.FromArgb(33, 37, 41);
            lblFilterGender.Location = new Point(297, 11);
            lblFilterGender.Name = "lblFilterGender";
            lblFilterGender.Size = new Size(70, 21);
            lblFilterGender.TabIndex = 2;
            lblFilterGender.Text = "Gender:";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.Location = new Point(1102, 32);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(46, 43);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "↻";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(192, 57, 43);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(999, 32);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 43);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.5F);
            btnEdit.Location = new Point(896, 32);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(91, 43);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnViewProfile
            // 
            btnViewProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewProfile.BackColor = Color.FromArgb(41, 128, 185);
            btnViewProfile.Cursor = Cursors.Hand;
            btnViewProfile.FlatAppearance.BorderSize = 0;
            btnViewProfile.FlatStyle = FlatStyle.Flat;
            btnViewProfile.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewProfile.ForeColor = Color.White;
            btnViewProfile.Location = new Point(747, 32);
            btnViewProfile.Margin = new Padding(3, 4, 3, 4);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(137, 43);
            btnViewProfile.TabIndex = 7;
            btnViewProfile.Text = "Teacher Profile";
            btnViewProfile.UseVisualStyleBackColor = false;
            btnViewProfile.Click += BtnViewProfile_Click;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddTeacher.BackColor = Color.FromArgb(39, 174, 96);
            btnAddTeacher.Cursor = Cursors.Hand;
            btnAddTeacher.FlatAppearance.BorderSize = 0;
            btnAddTeacher.FlatStyle = FlatStyle.Flat;
            btnAddTeacher.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddTeacher.ForeColor = Color.White;
            btnAddTeacher.Location = new Point(587, 32);
            btnAddTeacher.Margin = new Padding(3, 4, 3, 4);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(149, 43);
            btnAddTeacher.TabIndex = 6;
            btnAddTeacher.Text = "+ New Teacher";
            btnAddTeacher.UseVisualStyleBackColor = false;
            btnAddTeacher.Click += BtnAddTeacher_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(23, 37);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(251, 29);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(33, 37, 41);
            lblSearch.Location = new Point(23, 11);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(249, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Name / Email / Subject :";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotalCount);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 775);
            pnlBottom.Margin = new Padding(3, 4, 3, 4);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(23, 13, 23, 13);
            pnlBottom.Size = new Size(1170, 53);
            pnlBottom.TabIndex = 2;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Dock = DockStyle.Left;
            lblTotalCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(120, 130, 140);
            lblTotalCount.Location = new Point(23, 13);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(135, 21);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "Total Teachers: 0";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvTeachers);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 180);
            pnlGridWrapper.Margin = new Padding(3, 4, 3, 4);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(23, 27, 23, 27);
            pnlGridWrapper.Size = new Size(1170, 595);
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
            dgvTeachers.ColumnHeadersHeight = 29;
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTeachers.Dock = DockStyle.Fill;
            dgvTeachers.Location = new Point(23, 27);
            dgvTeachers.Margin = new Padding(3, 4, 3, 4);
            dgvTeachers.MultiSelect = false;
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.ReadOnly = true;
            dgvTeachers.RowHeadersVisible = false;
            dgvTeachers.RowHeadersWidth = 51;
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.Size = new Size(1124, 541);
            dgvTeachers.TabIndex = 0;
            dgvTeachers.DoubleClick += DgvTeachers_DoubleClick;
            // 
            // frmTeacherList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1170, 828);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlBottom);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTeacherList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Teachers Directory";
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
