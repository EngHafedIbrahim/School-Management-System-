namespace SchoolManagementSystem.Parents
{
    partial class frmParentList
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
            btnAddParent = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlBottom = new Panel();
            lblTotalCount = new Label();
            pnlGridWrapper = new Panel();
            dgvParents = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParents).BeginInit();
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
            pnlHeader.Size = new Size(1128, 72);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Fill;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(23, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(1082, 46);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "سجل وبيانات أولياء الأمور";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.White;
            pnlFilter.Controls.Add(btnRefresh);
            pnlFilter.Controls.Add(btnDelete);
            pnlFilter.Controls.Add(btnEdit);
            pnlFilter.Controls.Add(btnViewProfile);
            pnlFilter.Controls.Add(btnAddParent);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 72);
            pnlFilter.Margin = new Padding(3, 4, 3, 4);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(23, 15, 23, 13);
            pnlFilter.Size = new Size(1128, 102);
            pnlFilter.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.Location = new Point(23, 32);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(55, 42);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "🔄";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 57, 43);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(90, 32);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 42);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "🗑️ حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.5F);
            btnEdit.Location = new Point(205, 32);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(105, 42);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "✏️ تعديل";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnViewProfile
            // 
            btnViewProfile.BackColor = Color.FromArgb(41, 128, 185);
            btnViewProfile.Cursor = Cursors.Hand;
            btnViewProfile.FlatAppearance.BorderSize = 0;
            btnViewProfile.FlatStyle = FlatStyle.Flat;
            btnViewProfile.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewProfile.ForeColor = Color.White;
            btnViewProfile.Location = new Point(320, 32);
            btnViewProfile.Margin = new Padding(3, 4, 3, 4);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(140, 42);
            btnViewProfile.TabIndex = 3;
            btnViewProfile.Text = "👁️ عرض الملف";
            btnViewProfile.UseVisualStyleBackColor = false;
            btnViewProfile.Click += BtnViewProfile_Click;
            // 
            // btnAddParent
            // 
            btnAddParent.BackColor = Color.FromArgb(39, 174, 96);
            btnAddParent.Cursor = Cursors.Hand;
            btnAddParent.FlatAppearance.BorderSize = 0;
            btnAddParent.FlatStyle = FlatStyle.Flat;
            btnAddParent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddParent.ForeColor = Color.White;
            btnAddParent.Location = new Point(470, 32);
            btnAddParent.Margin = new Padding(3, 4, 3, 4);
            btnAddParent.Name = "btnAddParent";
            btnAddParent.Size = new Size(160, 42);
            btnAddParent.TabIndex = 2;
            btnAddParent.Text = "➕ إضافة ولي أمر";
            btnAddParent.UseVisualStyleBackColor = false;
            btnAddParent.Click += BtnAddParent_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(766, 46);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(335, 30);
            txtSearch.TabIndex = 1;
            txtSearch.TextAlign = HorizontalAlignment.Right;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(33, 37, 41);
            lblSearch.Location = new Point(809, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(288, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "بحث بالاسم / رقم الهاتف / البريد الإلكتروني:";
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
            pnlBottom.Size = new Size(1128, 53);
            pnlBottom.TabIndex = 2;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Dock = DockStyle.Right;
            lblTotalCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(120, 130, 140);
            lblTotalCount.Location = new Point(879, 13);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(226, 21);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "إجمالي أولياء الأمور المعروضين: 0";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvParents);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 174);
            pnlGridWrapper.Margin = new Padding(3, 4, 3, 4);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(23, 20, 23, 20);
            pnlGridWrapper.Size = new Size(1128, 588);
            pnlGridWrapper.TabIndex = 3;
            // 
            // dgvParents
            // 
            dgvParents.AllowUserToAddRows = false;
            dgvParents.AllowUserToDeleteRows = false;
            dgvParents.AllowUserToOrderColumns = true;
            dgvParents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParents.BackgroundColor = Color.White;
            dgvParents.BorderStyle = BorderStyle.None;
            dgvParents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvParents.ColumnHeadersHeight = 29;
            dgvParents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvParents.Dock = DockStyle.Fill;
            dgvParents.Location = new Point(23, 20);
            dgvParents.Margin = new Padding(3, 4, 3, 4);
            dgvParents.MultiSelect = false;
            dgvParents.Name = "dgvParents";
            dgvParents.ReadOnly = true;
            dgvParents.RowHeadersVisible = false;
            dgvParents.RowHeadersWidth = 51;
            dgvParents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParents.Size = new Size(1082, 548);
            dgvParents.TabIndex = 0;
            dgvParents.DoubleClick += DgvParents_DoubleClick;
            // 
            // frmParentList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1128, 815);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlBottom);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmParentList";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "إدارة أولياء الأمور";
            Load += FrmParentList_Load;
            pnlHeader.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvParents).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddParent;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Panel pnlGridWrapper;
        private System.Windows.Forms.DataGridView dgvParents;
    }
}
