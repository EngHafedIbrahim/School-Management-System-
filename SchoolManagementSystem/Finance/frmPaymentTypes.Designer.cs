namespace SchoolManagementSystem.Finance
{
    partial class frmPaymentTypes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            dgvPaymentTypes = new DataGridView();
            gbPaymentType = new GroupBox();
            btnCancelEdit = new Button();
            btnSave = new Button();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtName = new TextBox();
            lblName = new Label();
            lblTotalCount = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPaymentTypes).BeginInit();
            gbPaymentType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitle.Location = new Point(307, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(268, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "إدارة طرق وأنواع الدفع";
            // 
            // dgvPaymentTypes
            // 
            dgvPaymentTypes.AllowUserToAddRows = false;
            dgvPaymentTypes.AllowUserToDeleteRows = false;
            dgvPaymentTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPaymentTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaymentTypes.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPaymentTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPaymentTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPaymentTypes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPaymentTypes.Location = new Point(370, 77);
            dgvPaymentTypes.MultiSelect = false;
            dgvPaymentTypes.Name = "dgvPaymentTypes";
            dgvPaymentTypes.ReadOnly = true;
            dgvPaymentTypes.RowHeadersWidth = 51;
            dgvPaymentTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaymentTypes.Size = new Size(501, 401);
            dgvPaymentTypes.TabIndex = 1;
            dgvPaymentTypes.DoubleClick += DgvPaymentTypes_DoubleClick;
            // 
            // gbPaymentType
            // 
            gbPaymentType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gbPaymentType.Controls.Add(btnCancelEdit);
            gbPaymentType.Controls.Add(btnSave);
            gbPaymentType.Controls.Add(txtDescription);
            gbPaymentType.Controls.Add(lblDescription);
            gbPaymentType.Controls.Add(txtName);
            gbPaymentType.Controls.Add(lblName);
            gbPaymentType.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbPaymentType.ForeColor = Color.FromArgb(30, 41, 59);
            gbPaymentType.Location = new Point(24, 69);
            gbPaymentType.Name = "gbPaymentType";
            gbPaymentType.Size = new Size(330, 409);
            gbPaymentType.TabIndex = 2;
            gbPaymentType.TabStop = false;
            gbPaymentType.Text = "إضافة / تعديل نوع الدفع";
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Cursor = Cursors.Hand;
            btnCancelEdit.Font = new Font("Segoe UI", 9F);
            btnCancelEdit.Location = new Point(20, 310);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(130, 36);
            btnCancelEdit.TabIndex = 5;
            btnCancelEdit.Text = "إلغاء التعديل";
            btnCancelEdit.UseVisualStyleBackColor = true;
            btnCancelEdit.Visible = false;
            btnCancelEdit.Click += BtnCancelEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(165, 310);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 36);
            btnSave.TabIndex = 4;
            btnSave.Text = "حفظ نوع الدفع";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 9.5F);
            txtDescription.Location = new Point(20, 130);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(290, 160);
            txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F);
            lblDescription.Location = new Point(220, 107);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(97, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "الوصف / بيان:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Location = new Point(20, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 29);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F);
            lblName.Location = new Point(205, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 20);
            lblName.TabIndex = 0;
            lblName.Text = "اسم طريقة الدفع:";
            // 
            // lblTotalCount
            // 
            lblTotalCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotalCount.Location = new Point(751, 500);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(112, 20);
            lblTotalCount.TabIndex = 3;
            lblTotalCount.Text = "إجمالي الأنواع: 0";
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 9F);
            btnEdit.Location = new Point(135, 492);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 34);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "تعديل المحدد";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.Location = new Point(255, 492);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "حذف المحدد";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.Location = new Point(375, 492);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(95, 34);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "تحديث";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.Location = new Point(24, 492);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 34);
            btnClose.TabIndex = 7;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // frmPaymentTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(895, 536);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lblTotalCount);
            Controls.Add(gbPaymentType);
            Controls.Add(dgvPaymentTypes);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(800, 450);
            Name = "frmPaymentTypes";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة طرق وأنواع الدفع";
            Load += FrmPaymentTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPaymentTypes).EndInit();
            gbPaymentType.ResumeLayout(false);
            gbPaymentType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPaymentTypes;
        private System.Windows.Forms.GroupBox gbPaymentType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
