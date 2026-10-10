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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.cbFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cbFilterGender = new System.Windows.Forms.ComboBox();
            this.lblFilterGender = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.pnlGridWrapper = new System.Windows.Forms.Panel();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1024, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(22, 40);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(526, 19);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Manage teaching faculty, instructor assignments, professional records, and timetables.";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(320, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Teaching Faculty & Instructors";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.cbFilterStatus);
            this.pnlFilter.Controls.Add(this.lblFilterStatus);
            this.pnlFilter.Controls.Add(this.cbFilterGender);
            this.pnlFilter.Controls.Add(this.lblFilterGender);
            this.pnlFilter.Controls.Add(this.btnRefresh);
            this.pnlFilter.Controls.Add(this.btnDelete);
            this.pnlFilter.Controls.Add(this.btnEdit);
            this.pnlFilter.Controls.Add(this.btnViewProfile);
            this.pnlFilter.Controls.Add(this.btnAddTeacher);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.lblSearch);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 70);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(20, 15, 20, 10);
            this.pnlFilter.Size = new System.Drawing.Size(1024, 65);
            this.pnlFilter.TabIndex = 1;
            // 
            // cbFilterStatus
            // 
            this.cbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbFilterStatus.FormattingEnabled = true;
            this.cbFilterStatus.Items.AddRange(new object[] {
            "All",
            "Active",
            "On Leave",
            "Resigned"});
            this.cbFilterStatus.Location = new System.Drawing.Point(380, 28);
            this.cbFilterStatus.Name = "cbFilterStatus";
            this.cbFilterStatus.Size = new System.Drawing.Size(110, 24);
            this.cbFilterStatus.TabIndex = 5;
            this.cbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.CbFilterStatus_SelectedIndexChanged);
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblFilterStatus.Location = new System.Drawing.Point(380, 8);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(50, 17);
            this.lblFilterStatus.TabIndex = 4;
            this.lblFilterStatus.Text = "Status:";
            // 
            // cbFilterGender
            // 
            this.cbFilterGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterGender.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbFilterGender.FormattingEnabled = true;
            this.cbFilterGender.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.cbFilterGender.Location = new System.Drawing.Point(260, 28);
            this.cbFilterGender.Name = "cbFilterGender";
            this.cbFilterGender.Size = new System.Drawing.Size(105, 24);
            this.cbFilterGender.TabIndex = 3;
            this.cbFilterGender.SelectedIndexChanged += new System.EventHandler(this.CbFilterGender_SelectedIndexChanged);
            // 
            // lblFilterGender
            // 
            this.lblFilterGender.AutoSize = true;
            this.lblFilterGender.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblFilterGender.Location = new System.Drawing.Point(260, 8);
            this.lblFilterGender.Name = "lblFilterGender";
            this.lblFilterGender.Size = new System.Drawing.Size(56, 17);
            this.lblFilterGender.TabIndex = 2;
            this.lblFilterGender.Text = "Gender:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(964, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 32);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "↻";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(874, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 32);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnEdit.Location = new System.Drawing.Point(784, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 32);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnViewProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewProfile.FlatAppearance.BorderSize = 0;
            this.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProfile.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnViewProfile.ForeColor = System.Drawing.Color.White;
            this.btnViewProfile.Location = new System.Drawing.Point(654, 24);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(120, 32);
            this.btnViewProfile.TabIndex = 7;
            this.btnViewProfile.Text = "Teacher Profile";
            this.btnViewProfile.UseVisualStyleBackColor = false;
            this.btnViewProfile.Click += new System.EventHandler(this.BtnViewProfile_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTeacher.FlatAppearance.BorderSize = 0;
            this.btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddTeacher.ForeColor = System.Drawing.Color.White;
            this.btnAddTeacher.Location = new System.Drawing.Point(514, 24);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(130, 32);
            this.btnAddTeacher.TabIndex = 6;
            this.btnAddTeacher.Text = "+ New Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.BtnAddTeacher_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(20, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblSearch.Location = new System.Drawing.Point(20, 8);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(206, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search Name / Email / Subject:";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.lblTotalCount);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 581);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlBottom.Size = new System.Drawing.Size(1024, 40);
            this.pnlBottom.TabIndex = 2;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTotalCount.Location = new System.Drawing.Point(20, 10);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(110, 17);
            this.lblTotalCount.TabIndex = 0;
            this.lblTotalCount.Text = "Total Teachers: 0";
            // 
            // pnlGridWrapper
            // 
            this.pnlGridWrapper.Controls.Add(this.dgvTeachers);
            this.pnlGridWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridWrapper.Location = new System.Drawing.Point(0, 135);
            this.pnlGridWrapper.Name = "pnlGridWrapper";
            this.pnlGridWrapper.Padding = new System.Windows.Forms.Padding(20);
            this.pnlGridWrapper.Size = new System.Drawing.Size(1024, 446);
            this.pnlGridWrapper.TabIndex = 3;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            this.dgvTeachers.AllowUserToOrderColumns = true;
            this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeachers.BackgroundColor = System.Drawing.Color.White;
            this.dgvTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTeachers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeachers.Location = new System.Drawing.Point(20, 20);
            this.dgvTeachers.MultiSelect = false;
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.RowHeadersVisible = false;
            this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeachers.Size = new System.Drawing.Size(984, 406);
            this.dgvTeachers.TabIndex = 0;
            this.dgvTeachers.DoubleClick += new System.EventHandler(this.DgvTeachers_DoubleClick);
            // 
            // frmTeacherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1024, 621);
            this.Controls.Add(this.pnlGridWrapper);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmTeacherList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teachers Directory";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
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
