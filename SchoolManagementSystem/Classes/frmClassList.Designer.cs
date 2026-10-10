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
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(23, 13, 23, 13);
            pnlHeader.Size = new Size(1102, 93);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(394, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(358, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Classes & Sections Directory";
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
            pnlFilter.Location = new Point(0, 93);
            pnlFilter.Margin = new Padding(3, 4, 3, 4);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(23, 20, 23, 13);
            pnlFilter.Size = new Size(1102, 87);
            pnlFilter.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.Location = new Point(1033, 32);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(46, 43);
            btnRefresh.TabIndex = 8;
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
            btnDelete.Location = new Point(930, 32);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 43);
            btnDelete.TabIndex = 7;
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
            btnEdit.Location = new Point(827, 32);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(91, 43);
            btnEdit.TabIndex = 6;
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
            btnViewProfile.Location = new Point(690, 32);
            btnViewProfile.Margin = new Padding(3, 4, 3, 4);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(126, 43);
            btnViewProfile.TabIndex = 5;
            btnViewProfile.Text = "Class Profile";
            btnViewProfile.UseVisualStyleBackColor = false;
            btnViewProfile.Click += BtnViewProfile_Click;
            // 
            // btnAddClass
            // 
            btnAddClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddClass.BackColor = Color.FromArgb(39, 174, 96);
            btnAddClass.Cursor = Cursors.Hand;
            btnAddClass.FlatAppearance.BorderSize = 0;
            btnAddClass.FlatStyle = FlatStyle.Flat;
            btnAddClass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddClass.ForeColor = Color.White;
            btnAddClass.Location = new Point(542, 32);
            btnAddClass.Margin = new Padding(3, 4, 3, 4);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(137, 43);
            btnAddClass.TabIndex = 4;
            btnAddClass.Text = "+ New Class";
            btnAddClass.UseVisualStyleBackColor = false;
            btnAddClass.Click += BtnAddClass_Click;
            // 
            // cbFilterGrade
            // 
            cbFilterGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterGrade.Font = new Font("Segoe UI", 9.5F);
            cbFilterGrade.FormattingEnabled = true;
            cbFilterGrade.Location = new Point(297, 37);
            cbFilterGrade.Margin = new Padding(3, 4, 3, 4);
            cbFilterGrade.Name = "cbFilterGrade";
            cbFilterGrade.Size = new Size(205, 29);
            cbFilterGrade.TabIndex = 3;
            cbFilterGrade.SelectedIndexChanged += CbFilterGrade_SelectedIndexChanged;
            // 
            // lblFilterGrade
            // 
            lblFilterGrade.AutoSize = true;
            lblFilterGrade.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFilterGrade.ForeColor = Color.FromArgb(33, 37, 41);
            lblFilterGrade.Location = new Point(297, 11);
            lblFilterGrade.Name = "lblFilterGrade";
            lblFilterGrade.Size = new Size(146, 21);
            lblFilterGrade.TabIndex = 2;
            lblFilterGrade.Text = "Filter Grade Level:";
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
            lblSearch.Size = new Size(157, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Class Name:";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotalCount);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 762);
            pnlBottom.Margin = new Padding(3, 4, 3, 4);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(23, 13, 23, 13);
            pnlBottom.Size = new Size(1102, 53);
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
            lblTotalCount.Size = new Size(123, 21);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "Total Classes: 0";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvClasses);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 180);
            pnlGridWrapper.Margin = new Padding(3, 4, 3, 4);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(23, 27, 23, 27);
            pnlGridWrapper.Size = new Size(1102, 582);
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
            dgvClasses.ColumnHeadersHeight = 29;
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClasses.Dock = DockStyle.Fill;
            dgvClasses.Location = new Point(23, 27);
            dgvClasses.Margin = new Padding(3, 4, 3, 4);
            dgvClasses.MultiSelect = false;
            dgvClasses.Name = "dgvClasses";
            dgvClasses.ReadOnly = true;
            dgvClasses.RowHeadersVisible = false;
            dgvClasses.RowHeadersWidth = 51;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasses.Size = new Size(1056, 528);
            dgvClasses.TabIndex = 0;
            dgvClasses.DoubleClick += DgvClasses_DoubleClick;
            // 
            // frmClassList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1102, 815);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlBottom);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmClassList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Classes";
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
