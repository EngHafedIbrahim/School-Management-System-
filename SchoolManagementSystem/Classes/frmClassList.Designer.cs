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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassList));
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
            resources.ApplyResources(pnlHeader, "pnlHeader");
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Name = "pnlHeader";
            // 
            // lblHeaderTitle
            // 
            resources.ApplyResources(lblHeaderTitle, "lblHeaderTitle");
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Name = "lblHeaderTitle";
            // 
            // pnlFilter
            // 
            resources.ApplyResources(pnlFilter, "pnlFilter");
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
            pnlFilter.Name = "pnlFilter";
            // 
            // btnRefresh
            // 
            resources.ApplyResources(btnRefresh, "btnRefresh");
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnDelete
            // 
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.BackColor = Color.FromArgb(192, 57, 43);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.ForeColor = Color.White;
            btnDelete.Name = "btnDelete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            btnDelete.Text = "حذف";
            // 
            // btnEdit
            // 
            resources.ApplyResources(btnEdit, "btnEdit");
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnEdit.Name = "btnEdit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            btnEdit.Text = "تعديل";
            // 
            // btnViewProfile
            // 
            resources.ApplyResources(btnViewProfile, "btnViewProfile");
            btnViewProfile.BackColor = Color.FromArgb(41, 128, 185);
            btnViewProfile.Cursor = Cursors.Hand;
            btnViewProfile.FlatAppearance.BorderSize = 0;
            btnViewProfile.ForeColor = Color.White;
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.UseVisualStyleBackColor = false;
            btnViewProfile.Click += BtnViewProfile_Click;
            btnViewProfile.Text = "عرض";

            // 
            // btnAddClass
            // 
            resources.ApplyResources(btnAddClass, "btnAddClass");
            btnAddClass.BackColor = Color.FromArgb(39, 174, 96);
            btnAddClass.Cursor = Cursors.Hand;
            btnAddClass.FlatAppearance.BorderSize = 0;
            btnAddClass.ForeColor = Color.White;
            btnAddClass.Name = "btnAddClass";
            btnAddClass.UseVisualStyleBackColor = false;
            btnAddClass.Click += BtnAddClass_Click;
            btnAddClass.Text = "+إضافة شُعبة";

            // 
            // cbFilterGrade
            // 
            resources.ApplyResources(cbFilterGrade, "cbFilterGrade");
            cbFilterGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterGrade.FormattingEnabled = true;
            cbFilterGrade.Name = "cbFilterGrade";
            cbFilterGrade.SelectedIndexChanged += CbFilterGrade_SelectedIndexChanged;

            // 
            // lblFilterGrade
            // 
            resources.ApplyResources(lblFilterGrade, "lblFilterGrade");
            lblFilterGrade.ForeColor = Color.FromArgb(33, 37, 41);
            lblFilterGrade.Name = "lblFilterGrade";
            // 
            // txtSearch
            // 
            resources.ApplyResources(txtSearch, "txtSearch");
            txtSearch.Name = "txtSearch";
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lblSearch
            // 
            resources.ApplyResources(lblSearch, "lblSearch");
            lblSearch.ForeColor = Color.FromArgb(33, 37, 41);
            lblSearch.Name = "lblSearch";
            // 
            // pnlBottom
            // 
            resources.ApplyResources(pnlBottom, "pnlBottom");
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotalCount);
            pnlBottom.Name = "pnlBottom";
            // 
            // lblTotalCount
            // 
            resources.ApplyResources(lblTotalCount, "lblTotalCount");
            lblTotalCount.ForeColor = Color.FromArgb(120, 130, 140);
            lblTotalCount.Name = "lblTotalCount";
            // 
            // pnlGridWrapper
            // 
            resources.ApplyResources(pnlGridWrapper, "pnlGridWrapper");
            pnlGridWrapper.Controls.Add(dgvClasses);
            pnlGridWrapper.Name = "pnlGridWrapper";
            // 
            // dgvClasses
            // 
            resources.ApplyResources(dgvClasses, "dgvClasses");
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AllowUserToDeleteRows = false;
            dgvClasses.AllowUserToOrderColumns = true;
            dgvClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClasses.BackgroundColor = Color.White;
            dgvClasses.BorderStyle = BorderStyle.None;
            dgvClasses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClasses.MultiSelect = false;
            dgvClasses.Name = "dgvClasses";
            dgvClasses.ReadOnly = true;
            dgvClasses.RowHeadersVisible = false;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasses.DoubleClick += DgvClasses_DoubleClick;
            // 
            // frmClassList
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlBottom);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmClassList";
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
