namespace SchoolManagementSystem.Courses
{
    partial class frmCourseList
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
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddCourse = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlBottom = new Panel();
            lblTotalCount = new Label();
            pnlGridWrapper = new Panel();
            dgvCourses = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
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
            pnlHeader.Size = new Size(1029, 93);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(339, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(427, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Courses && Academic Curriculum";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.White;
            pnlFilter.Controls.Add(btnRefresh);
            pnlFilter.Controls.Add(btnDelete);
            pnlFilter.Controls.Add(btnEdit);
            pnlFilter.Controls.Add(btnAddCourse);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 93);
            pnlFilter.Margin = new Padding(3, 4, 3, 4);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(23, 20, 23, 13);
            pnlFilter.Size = new Size(1029, 87);
            pnlFilter.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.Location = new Point(960, 32);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(46, 43);
            btnRefresh.TabIndex = 5;
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
            btnDelete.Location = new Point(857, 32);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 43);
            btnDelete.TabIndex = 4;
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
            btnEdit.Location = new Point(754, 32);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(91, 43);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddCourse.BackColor = Color.FromArgb(39, 174, 96);
            btnAddCourse.Cursor = Cursors.Hand;
            btnAddCourse.FlatAppearance.BorderSize = 0;
            btnAddCourse.FlatStyle = FlatStyle.Flat;
            btnAddCourse.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddCourse.ForeColor = Color.White;
            btnAddCourse.Location = new Point(594, 32);
            btnAddCourse.Margin = new Padding(3, 4, 3, 4);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(149, 43);
            btnAddCourse.TabIndex = 2;
            btnAddCourse.Text = "+ New Course";
            btnAddCourse.UseVisualStyleBackColor = false;
            btnAddCourse.Click += BtnAddCourse_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(23, 43);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(297, 29);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(33, 37, 41);
            lblSearch.Location = new Point(23, 16);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(175, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Course Name :";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotalCount);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 748);
            pnlBottom.Margin = new Padding(3, 4, 3, 4);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(23, 13, 23, 13);
            pnlBottom.Size = new Size(1029, 53);
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
            lblTotalCount.Size = new Size(128, 21);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "Total Courses: 0";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvCourses);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 180);
            pnlGridWrapper.Margin = new Padding(3, 4, 3, 4);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(23, 27, 23, 27);
            pnlGridWrapper.Size = new Size(1029, 568);
            pnlGridWrapper.TabIndex = 3;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AllowUserToOrderColumns = true;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.BackgroundColor = Color.White;
            dgvCourses.BorderStyle = BorderStyle.None;
            dgvCourses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCourses.ColumnHeadersHeight = 29;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCourses.Dock = DockStyle.Fill;
            dgvCourses.Location = new Point(23, 27);
            dgvCourses.Margin = new Padding(3, 4, 3, 4);
            dgvCourses.MultiSelect = false;
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.RowHeadersVisible = false;
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(983, 514);
            dgvCourses.TabIndex = 0;
            dgvCourses.DoubleClick += DgvCourses_DoubleClick;
            // 
            // frmCourseList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1029, 801);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlBottom);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCourseList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Courses";
            Load += FrmCourseList_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Panel pnlGridWrapper;
        private System.Windows.Forms.DataGridView dgvCourses;
    }
}
