namespace SchoolManagementSystem.Classes
{
    partial class frmClassList
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
            btnViewProfile = new Button();
            btnAddClass = new Button();
            cbFilterGrade = new ComboBox();
            lblFilterGrade = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlBottom = new Panel();
            lblTotalCount = new Label();
            pnlGridWrapper = new Panel();
            dgvClasses = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1060, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Anchor = AnchorStyles.Top;
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblHeaderTitle.Location = new Point(360, 18);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(340, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "دليل وإدارة الشُعب والفصول الدراسية";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.White;
            pnlFilter.Controls.Add(btnRefresh);
            pnlFilter.Controls.Add(btnDelete);
            pnlFilter.Controls.Add(btnEdit);
            pnlFilter.Controls.Add(btnViewProfile);
            pnlFilter.Controls.Add(btnAddClass);
            pnlFilter.Controls.Add(cbFilterGrade);
            pnlFilter.Controls.Add(lblFilterGrade);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 75);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1060, 75);
            pnlFilter.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.Location = new Point(15, 18);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 38);
            btnRefresh.TabIndex = 8;
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
            btnDelete.Location = new Point(96, 18);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 38);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 9F);
            btnEdit.Location = new Point(177, 18);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 38);
            btnEdit.TabIndex = 6;
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
            btnViewProfile.Location = new Point(258, 18);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(110, 38);
            btnViewProfile.TabIndex = 5;
            btnViewProfile.Text = "ملف الشعبة";
            btnViewProfile.UseVisualStyleBackColor = false;
            btnViewProfile.Click += BtnViewProfile_Click;
            // 
            // btnAddClass
            // 
            btnAddClass.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnAddClass.BackColor = Color.FromArgb(16, 185, 129);
            btnAddClass.Cursor = Cursors.Hand;
            btnAddClass.FlatAppearance.BorderSize = 0;
            btnAddClass.FlatStyle = FlatStyle.Flat;
            btnAddClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddClass.ForeColor = Color.White;
            btnAddClass.Location = new Point(374, 18);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(120, 38);
            btnAddClass.TabIndex = 4;
            btnAddClass.Text = "+ إضافة شعبة";
            btnAddClass.UseVisualStyleBackColor = false;
            btnAddClass.Click += BtnAddClass_Click;
            // 
            // cbFilterGrade
            // 
            cbFilterGrade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFilterGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterGrade.Font = new Font("Segoe UI", 9.5F);
            cbFilterGrade.FormattingEnabled = true;
            cbFilterGrade.Location = new Point(515, 23);
            cbFilterGrade.Name = "cbFilterGrade";
            cbFilterGrade.Size = new Size(160, 29);
            cbFilterGrade.TabIndex = 3;
            cbFilterGrade.SelectedIndexChanged += CbFilterGrade_SelectedIndexChanged;
            // 
            // lblFilterGrade
            // 
            lblFilterGrade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFilterGrade.AutoSize = true;
            lblFilterGrade.Font = new Font("Segoe UI", 9.5F);
            lblFilterGrade.ForeColor = Color.FromArgb(30, 41, 59);
            lblFilterGrade.Location = new Point(681, 26);
            lblFilterGrade.Name = "lblFilterGrade";
            lblFilterGrade.Size = new Size(113, 21);
            lblFilterGrade.TabIndex = 2;
            lblFilterGrade.Text = "المرحلة / الصف:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(810, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 29);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F);
            lblSearch.ForeColor = Color.FromArgb(30, 41, 59);
            lblSearch.Location = new Point(996, 26);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "بحث:";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotalCount);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 615);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1060, 45);
            pnlBottom.TabIndex = 2;
            // 
            // lblTotalCount
            // 
            lblTotalCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotalCount.Location = new Point(860, 12);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(185, 21);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "إجمالي الشُعب المعروضة: 0";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvClasses);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 150);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(20);
            pnlGridWrapper.Size = new Size(1060, 465);
            pnlGridWrapper.TabIndex = 3;
            // 
            // dgvClasses
            // 
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AllowUserToDeleteRows = false;
            dgvClasses.AllowUserToOrderColumns = true;
            dgvClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClasses.BackgroundColor = Color.White;
            dgvClasses.BorderStyle = BorderStyle.None;
            dgvClasses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasses.Dock = DockStyle.Fill;
            dgvClasses.MultiSelect = false;
            dgvClasses.Name = "dgvClasses";
            dgvClasses.ReadOnly = true;
            dgvClasses.RowHeadersVisible = false;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasses.Size = new Size(1020, 425);
            dgvClasses.TabIndex = 0;
            dgvClasses.DoubleClick += DgvClasses_DoubleClick;
            // 
            // frmClassList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1060, 660);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlBottom);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(950, 550);
            Name = "frmClassList";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "دليل إدارة الشُعب والفصول الدراسية";
            Load += FrmClassList_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterGrade;
        private System.Windows.Forms.ComboBox cbFilterGrade;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Panel pnlGridWrapper;
        private System.Windows.Forms.DataGridView dgvClasses;
    }
}
