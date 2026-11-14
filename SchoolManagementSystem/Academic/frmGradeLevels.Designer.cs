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
            lblHeaderTitle.Location = new Point(381, 18);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(375, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "إدارة المراحل والصفوف الدراسية";
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
            pnlEditor.Location = new Point(0, 75);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Padding = new Padding(20);
            pnlEditor.Size = new Size(1060, 175);
            pnlEditor.TabIndex = 1;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Cursor = Cursors.Hand;
            btnCancelEdit.Font = new Font("Segoe UI", 9F);
            btnCancelEdit.Location = new Point(30, 112);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(140, 38);
            btnCancelEdit.TabIndex = 8;
            btnCancelEdit.Text = "إلغاء التعديل";
            btnCancelEdit.UseVisualStyleBackColor = true;
            btnCancelEdit.Visible = false;
            btnCancelEdit.Click += BtnCancelEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(30, 65);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 42);
            btnSave.TabIndex = 7;
            btnSave.Text = "حفظ المرحلة";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Font = new Font("Segoe UI", 9.5F);
            txtDescription.Location = new Point(190, 72);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(471, 78);
            txtDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(30, 41, 59);
            lblDescription.Location = new Point(536, 45);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(143, 21);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "الوصف والملاحظات:";
            // 
            // numOrderNo
            // 
            numOrderNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numOrderNo.Font = new Font("Segoe UI", 9.5F);
            numOrderNo.Location = new Point(681, 72);
            numOrderNo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numOrderNo.Name = "numOrderNo";
            numOrderNo.Size = new Size(110, 29);
            numOrderNo.TabIndex = 4;
            numOrderNo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblOrderNo
            // 
            lblOrderNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOrderNo.AutoSize = true;
            lblOrderNo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblOrderNo.ForeColor = Color.FromArgb(30, 41, 59);
            lblOrderNo.Location = new Point(691, 45);
            lblOrderNo.Name = "lblOrderNo";
            lblOrderNo.Size = new Size(97, 21);
            lblOrderNo.TabIndex = 3;
            lblOrderNo.Text = "رقم الترتيب *:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Location = new Point(811, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(225, 29);
            txtName.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(30, 41, 59);
            lblName.Location = new Point(896, 45);
            lblName.Name = "lblName";
            lblName.Size = new Size(158, 21);
            lblName.TabIndex = 1;
            lblName.Text = "اسم المرحلة / الصف *:";
            // 
            // lblFormTitle
            // 
            lblFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblFormTitle.Location = new Point(811, 10);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(263, 25);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "إضافة مرحلة / صف دراسي جديد";
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
            pnlToolbar.Location = new Point(0, 250);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(20, 10, 20, 10);
            pnlToolbar.Size = new Size(1060, 65);
            pnlToolbar.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.Location = new Point(20, 14);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(80, 38);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "تحديث";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 38, 38);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(106, 14);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 38);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 9F);
            btnEdit.Location = new Point(197, 14);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 38);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "تعديل المحدد";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(691, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 29);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(30, 41, 59);
            lblSearch.Location = new Point(946, 21);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(97, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "بحث وتصفية:";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotalCount);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 755);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(20, 12, 20, 12);
            pnlBottom.Size = new Size(1060, 46);
            pnlBottom.TabIndex = 3;
            // 
            // lblTotalCount
            // 
            lblTotalCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotalCount.Location = new Point(841, 13);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(189, 21);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "إجمالي الصفوف الدراسية: 0";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvGradeLevels);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 315);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(20);
            pnlGridWrapper.Size = new Size(1060, 440);
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
            dgvGradeLevels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradeLevels.Dock = DockStyle.Fill;
            dgvGradeLevels.Location = new Point(20, 20);
            dgvGradeLevels.MultiSelect = false;
            dgvGradeLevels.Name = "dgvGradeLevels";
            dgvGradeLevels.ReadOnly = true;
            dgvGradeLevels.RowHeadersVisible = false;
            dgvGradeLevels.RowHeadersWidth = 51;
            dgvGradeLevels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradeLevels.Size = new Size(1020, 400);
            dgvGradeLevels.TabIndex = 0;
            dgvGradeLevels.DoubleClick += DgvGradeLevels_DoubleClick;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // frmGradeLevels
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1060, 801);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlBottom);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlEditor);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(950, 600);
            Name = "frmGradeLevels";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "إدارة المراحل والصفوف الدراسية";
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
