namespace SchoolManagementSystem.Academic
{
    partial class frmGradeLevels
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
            pnlEditor = new Panel();
            btnCancelEdit = new Button();
            btnSave = new Button();
            txtDescription = new TextBox();
            lblDescription = new Label();
            numOrderNo = new NumericUpDown();
            lblOrderNo = new Label();
            txtName = new TextBox();
            lblName = new Label();
            lblFormTitle = new Label();
            pnlToolbar = new Panel();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlBottom = new Panel();
            lblTotalCount = new Label();
            pnlGridWrapper = new Panel();
            dgvGradeLevels = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderNo).BeginInit();
            pnlToolbar.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGradeLevels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            lblHeaderTitle.Location = new Point(345, 8);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(358, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Grade Levels Management";
            // 
            // pnlEditor
            // 
            pnlEditor.BackColor = Color.White;
            pnlEditor.BorderStyle = BorderStyle.FixedSingle;
            pnlEditor.Controls.Add(btnCancelEdit);
            pnlEditor.Controls.Add(btnSave);
            pnlEditor.Controls.Add(txtDescription);
            pnlEditor.Controls.Add(lblDescription);
            pnlEditor.Controls.Add(numOrderNo);
            pnlEditor.Controls.Add(lblOrderNo);
            pnlEditor.Controls.Add(txtName);
            pnlEditor.Controls.Add(lblName);
            pnlEditor.Controls.Add(lblFormTitle);
            pnlEditor.Dock = DockStyle.Top;
            pnlEditor.Location = new Point(0, 93);
            pnlEditor.Margin = new Padding(3, 4, 3, 4);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Padding = new Padding(23, 20, 23, 20);
            pnlEditor.Size = new Size(1029, 173);
            pnlEditor.TabIndex = 1;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Cursor = Cursors.Hand;
            btnCancelEdit.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.Font = new Font("Segoe UI", 9.5F);
            btnCancelEdit.Location = new Point(846, 113);
            btnCancelEdit.Margin = new Padding(3, 4, 3, 4);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(149, 37);
            btnCancelEdit.TabIndex = 8;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = true;
            btnCancelEdit.Visible = false;
            btnCancelEdit.Click += BtnCancelEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(846, 64);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 43);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Level";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 9.5F);
            txtDescription.Location = new Point(411, 69);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(399, 79);
            txtDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(33, 37, 41);
            lblDescription.Location = new Point(411, 43);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 21);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description:";
            // 
            // numOrderNo
            // 
            numOrderNo.Font = new Font("Segoe UI", 9.5F);
            numOrderNo.Location = new Point(263, 69);
            numOrderNo.Margin = new Padding(3, 4, 3, 4);
            numOrderNo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numOrderNo.Name = "numOrderNo";
            numOrderNo.Size = new Size(114, 29);
            numOrderNo.TabIndex = 4;
            numOrderNo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblOrderNo
            // 
            lblOrderNo.AutoSize = true;
            lblOrderNo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblOrderNo.ForeColor = Color.FromArgb(33, 37, 41);
            lblOrderNo.Location = new Point(263, 43);
            lblOrderNo.Name = "lblOrderNo";
            lblOrderNo.Size = new Size(95, 21);
            lblOrderNo.TabIndex = 3;
            lblOrderNo.Text = "Order No *:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Location = new Point(23, 69);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 29);
            txtName.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(33, 37, 41);
            lblName.Location = new Point(23, 43);
            lblName.Name = "lblName";
            lblName.Size = new Size(115, 21);
            lblName.TabIndex = 1;
            lblName.Text = "Level Name *:";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblFormTitle.Location = new Point(23, 11);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(203, 25);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Add New Grade Level";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Controls.Add(btnDelete);
            pnlToolbar.Controls.Add(btnEdit);
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(lblSearch);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 266);
            pnlToolbar.Margin = new Padding(3, 4, 3, 4);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(23, 11, 23, 11);
            pnlToolbar.Size = new Size(1029, 67);
            pnlToolbar.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.Location = new Point(960, 12);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(46, 43);
            btnRefresh.TabIndex = 4;
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
            btnDelete.Location = new Point(846, 12);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 43);
            btnDelete.TabIndex = 3;
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
            btnEdit.Location = new Point(709, 12);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 43);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Selected";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(137, 17);
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
            lblSearch.Location = new Point(23, 21);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(111, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Filter/Search:";
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
            pnlBottom.TabIndex = 3;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Dock = DockStyle.Left;
            lblTotalCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(120, 130, 140);
            lblTotalCount.Location = new Point(23, 13);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(165, 21);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "Total Grade Levels: 0";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvGradeLevels);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 333);
            pnlGridWrapper.Margin = new Padding(3, 4, 3, 4);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(23, 27, 23, 27);
            pnlGridWrapper.Size = new Size(1029, 415);
            pnlGridWrapper.TabIndex = 4;
            // 
            // dgvGradeLevels
            // 
            dgvGradeLevels.AllowUserToAddRows = false;
            dgvGradeLevels.AllowUserToDeleteRows = false;
            dgvGradeLevels.AllowUserToOrderColumns = true;
            dgvGradeLevels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGradeLevels.BackgroundColor = Color.White;
            dgvGradeLevels.BorderStyle = BorderStyle.None;
            dgvGradeLevels.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGradeLevels.ColumnHeadersHeight = 29;
            dgvGradeLevels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGradeLevels.Dock = DockStyle.Fill;
            dgvGradeLevels.Location = new Point(23, 27);
            dgvGradeLevels.Margin = new Padding(3, 4, 3, 4);
            dgvGradeLevels.MultiSelect = false;
            dgvGradeLevels.Name = "dgvGradeLevels";
            dgvGradeLevels.ReadOnly = true;
            dgvGradeLevels.RowHeadersVisible = false;
            dgvGradeLevels.RowHeadersWidth = 51;
            dgvGradeLevels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradeLevels.Size = new Size(983, 361);
            dgvGradeLevels.TabIndex = 0;
            dgvGradeLevels.DoubleClick += DgvGradeLevels_DoubleClick;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // frmGradeLevels
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1029, 801);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlBottom);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlEditor);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmGradeLevels";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Grade Levels Management";
            Load += FrmGradeLevels_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlEditor.ResumeLayout(false);
            pnlEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderNo).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGradeLevels).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.NumericUpDown numOrderNo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Panel pnlGridWrapper;
        private System.Windows.Forms.DataGridView dgvGradeLevels;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
