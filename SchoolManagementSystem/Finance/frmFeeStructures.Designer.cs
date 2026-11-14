namespace SchoolManagementSystem.Finance
{
    partial class frmFeeStructures
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlHeaderLine = new Panel();
            dgvFeeStructures = new DataGridView();
            gbFeeStructureDetails = new GroupBox();
            lblLiveTotalVal = new Label();
            lblLiveTotalTitle = new Label();
            btnSave = new Button();
            btnClear = new Button();
            numOtherFees = new NumericUpDown();
            lblOtherFees = new Label();
            numBookFee = new NumericUpDown();
            lblBookFee = new Label();
            numTransportFee = new NumericUpDown();
            lblTransportFee = new Label();
            numTuitionFee = new NumericUpDown();
            lblTuitionFee = new Label();
            txtName = new TextBox();
            lblName = new Label();
            cbAcademicYear = new ComboBox();
            lblAcademicYear = new Label();
            cbGradeLevel = new ComboBox();
            lblGradeLevel = new Label();
            pnlActions = new Panel();
            lblSummary = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFeeStructures).BeginInit();
            gbFeeStructureDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOtherFees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBookFee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTransportFee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTuitionFee).BeginInit();
            pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 41, 59);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(pnlHeaderLine);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1080, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(365, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(370, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🏷️ إدارة هياكل الرسوم الدراسية";
            // 
            // pnlHeaderLine
            // 
            pnlHeaderLine.BackColor = Color.FromArgb(59, 130, 246);
            pnlHeaderLine.Dock = DockStyle.Bottom;
            pnlHeaderLine.Location = new Point(0, 72);
            pnlHeaderLine.Name = "pnlHeaderLine";
            pnlHeaderLine.Size = new Size(1080, 3);
            pnlHeaderLine.TabIndex = 2;
            // 
            // dgvFeeStructures
            // 
            dgvFeeStructures.AllowUserToAddRows = false;
            dgvFeeStructures.AllowUserToDeleteRows = false;
            dgvFeeStructures.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFeeStructures.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFeeStructures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFeeStructures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFeeStructures.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFeeStructures.Location = new Point(20, 90);
            dgvFeeStructures.MultiSelect = false;
            dgvFeeStructures.Name = "dgvFeeStructures";
            dgvFeeStructures.ReadOnly = true;
            dgvFeeStructures.RowHeadersWidth = 51;
            dgvFeeStructures.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFeeStructures.Size = new Size(650, 480);
            dgvFeeStructures.TabIndex = 1;
            dgvFeeStructures.SelectionChanged += DgvFeeStructures_SelectionChanged;
            // 
            // gbFeeStructureDetails
            // 
            gbFeeStructureDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbFeeStructureDetails.Controls.Add(lblLiveTotalVal);
            gbFeeStructureDetails.Controls.Add(lblLiveTotalTitle);
            gbFeeStructureDetails.Controls.Add(btnSave);
            gbFeeStructureDetails.Controls.Add(btnClear);
            gbFeeStructureDetails.Controls.Add(numOtherFees);
            gbFeeStructureDetails.Controls.Add(lblOtherFees);
            gbFeeStructureDetails.Controls.Add(numBookFee);
            gbFeeStructureDetails.Controls.Add(lblBookFee);
            gbFeeStructureDetails.Controls.Add(numTransportFee);
            gbFeeStructureDetails.Controls.Add(lblTransportFee);
            gbFeeStructureDetails.Controls.Add(numTuitionFee);
            gbFeeStructureDetails.Controls.Add(lblTuitionFee);
            gbFeeStructureDetails.Controls.Add(txtName);
            gbFeeStructureDetails.Controls.Add(lblName);
            gbFeeStructureDetails.Controls.Add(cbAcademicYear);
            gbFeeStructureDetails.Controls.Add(lblAcademicYear);
            gbFeeStructureDetails.Controls.Add(cbGradeLevel);
            gbFeeStructureDetails.Controls.Add(lblGradeLevel);
            gbFeeStructureDetails.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbFeeStructureDetails.ForeColor = Color.FromArgb(44, 62, 80);
            gbFeeStructureDetails.Location = new Point(685, 90);
            gbFeeStructureDetails.Name = "gbFeeStructureDetails";
            gbFeeStructureDetails.Size = new Size(375, 480);
            gbFeeStructureDetails.TabIndex = 2;
            gbFeeStructureDetails.TabStop = false;
            gbFeeStructureDetails.Text = "تفاصيل هيكل الرسوم";
            // 
            // lblLiveTotalVal
            // 
            lblLiveTotalVal.AutoSize = true;
            lblLiveTotalVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLiveTotalVal.ForeColor = Color.FromArgb(39, 174, 96);
            lblLiveTotalVal.Location = new Point(50, 324);
            lblLiveTotalVal.Name = "lblLiveTotalVal";
            lblLiveTotalVal.Size = new Size(88, 37);
            lblLiveTotalVal.TabIndex = 15;
            lblLiveTotalVal.Text = "$0.00";
            // 
            // lblLiveTotalTitle
            // 
            lblLiveTotalTitle.AutoSize = true;
            lblLiveTotalTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblLiveTotalTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblLiveTotalTitle.Location = new Point(245, 332);
            lblLiveTotalTitle.Name = "lblLiveTotalTitle";
            lblLiveTotalTitle.Size = new Size(127, 25);
            lblLiveTotalTitle.TabIndex = 14;
            lblLiveTotalTitle.Text = "إجمالي الرسوم:";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(190, 420);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 42);
            btnSave.TabIndex = 16;
            btnSave.Text = "💾 حفظ الهيكل";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI", 9.5F);
            btnClear.Location = new Point(20, 420);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(155, 42);
            btnClear.TabIndex = 17;
            btnClear.Text = "تفريغ / جديد";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // numOtherFees
            // 
            numOtherFees.DecimalPlaces = 2;
            numOtherFees.Font = new Font("Segoe UI", 9.5F);
            numOtherFees.Location = new Point(20, 282);
            numOtherFees.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numOtherFees.Name = "numOtherFees";
            numOtherFees.Size = new Size(155, 29);
            numOtherFees.TabIndex = 13;
            numOtherFees.ValueChanged += FeeAmountChanged;
            // 
            // lblOtherFees
            // 
            lblOtherFees.AutoSize = true;
            lblOtherFees.Font = new Font("Segoe UI", 9F);
            lblOtherFees.Location = new Point(70, 260);
            lblOtherFees.Name = "lblOtherFees";
            lblOtherFees.Size = new Size(117, 20);
            lblOtherFees.TabIndex = 12;
            lblOtherFees.Text = "رسوم إضافية ($):";
            // 
            // numBookFee
            // 
            numBookFee.DecimalPlaces = 2;
            numBookFee.Font = new Font("Segoe UI", 9.5F);
            numBookFee.Location = new Point(200, 282);
            numBookFee.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numBookFee.Name = "numBookFee";
            numBookFee.Size = new Size(155, 29);
            numBookFee.TabIndex = 11;
            numBookFee.ValueChanged += FeeAmountChanged;
            // 
            // lblBookFee
            // 
            lblBookFee.AutoSize = true;
            lblBookFee.Font = new Font("Segoe UI", 9F);
            lblBookFee.Location = new Point(255, 260);
            lblBookFee.Name = "lblBookFee";
            lblBookFee.Size = new Size(109, 20);
            lblBookFee.TabIndex = 10;
            lblBookFee.Text = "رسوم الكتب ($):";
            // 
            // numTransportFee
            // 
            numTransportFee.DecimalPlaces = 2;
            numTransportFee.Font = new Font("Segoe UI", 9.5F);
            numTransportFee.Location = new Point(20, 222);
            numTransportFee.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numTransportFee.Name = "numTransportFee";
            numTransportFee.Size = new Size(155, 29);
            numTransportFee.TabIndex = 9;
            numTransportFee.ValueChanged += FeeAmountChanged;
            // 
            // lblTransportFee
            // 
            lblTransportFee.AutoSize = true;
            lblTransportFee.Font = new Font("Segoe UI", 9F);
            lblTransportFee.Location = new Point(80, 200);
            lblTransportFee.Name = "lblTransportFee";
            lblTransportFee.Size = new Size(105, 20);
            lblTransportFee.TabIndex = 8;
            lblTransportFee.Text = "رسوم النقل ($):";
            // 
            // numTuitionFee
            // 
            numTuitionFee.DecimalPlaces = 2;
            numTuitionFee.Font = new Font("Segoe UI", 9.5F);
            numTuitionFee.Location = new Point(200, 222);
            numTuitionFee.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numTuitionFee.Name = "numTuitionFee";
            numTuitionFee.Size = new Size(155, 29);
            numTuitionFee.TabIndex = 7;
            numTuitionFee.ValueChanged += FeeAmountChanged;
            // 
            // lblTuitionFee
            // 
            lblTuitionFee.AutoSize = true;
            lblTuitionFee.Font = new Font("Segoe UI", 9F);
            lblTuitionFee.Location = new Point(250, 200);
            lblTuitionFee.Name = "lblTuitionFee";
            lblTuitionFee.Size = new Size(115, 20);
            lblTuitionFee.TabIndex = 6;
            lblTuitionFee.Text = "رسوم التعليم ($):";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Location = new Point(20, 164);
            txtName.Name = "txtName";
            txtName.Size = new Size(335, 29);
            txtName.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F);
            lblName.Location = new Point(225, 142);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 20);
            lblName.TabIndex = 4;
            lblName.Text = "اسم / مسمى الهيكل:";
            // 
            // cbAcademicYear
            // 
            cbAcademicYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAcademicYear.Font = new Font("Segoe UI", 9.5F);
            cbAcademicYear.FormattingEnabled = true;
            cbAcademicYear.Location = new Point(20, 107);
            cbAcademicYear.Name = "cbAcademicYear";
            cbAcademicYear.Size = new Size(335, 29);
            cbAcademicYear.TabIndex = 3;
            cbAcademicYear.SelectedIndexChanged += AutoGenerateName;
            // 
            // lblAcademicYear
            // 
            lblAcademicYear.AutoSize = true;
            lblAcademicYear.Font = new Font("Segoe UI", 9F);
            lblAcademicYear.Location = new Point(265, 85);
            lblAcademicYear.Name = "lblAcademicYear";
            lblAcademicYear.Size = new Size(103, 20);
            lblAcademicYear.TabIndex = 2;
            lblAcademicYear.Text = "السنة الدراسية:";
            // 
            // cbGradeLevel
            // 
            cbGradeLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGradeLevel.Font = new Font("Segoe UI", 9.5F);
            cbGradeLevel.FormattingEnabled = true;
            cbGradeLevel.Location = new Point(20, 50);
            cbGradeLevel.Name = "cbGradeLevel";
            cbGradeLevel.Size = new Size(335, 29);
            cbGradeLevel.TabIndex = 1;
            cbGradeLevel.SelectedIndexChanged += AutoGenerateName;
            // 
            // lblGradeLevel
            // 
            lblGradeLevel.AutoSize = true;
            lblGradeLevel.Font = new Font("Segoe UI", 9F);
            lblGradeLevel.Location = new Point(230, 28);
            lblGradeLevel.Name = "lblGradeLevel";
            lblGradeLevel.Size = new Size(162, 20);
            lblGradeLevel.TabIndex = 0;
            lblGradeLevel.Text = "المرحلة / الصف الدراسي:";
            // 
            // pnlActions
            // 
            pnlActions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlActions.BackColor = Color.FromArgb(245, 247, 250);
            pnlActions.Controls.Add(lblSummary);
            pnlActions.Controls.Add(btnDelete);
            pnlActions.Controls.Add(btnEdit);
            pnlActions.Controls.Add(btnAddNew);
            pnlActions.Controls.Add(btnClose);
            pnlActions.Location = new Point(20, 580);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(1040, 55);
            pnlActions.TabIndex = 3;
            // 
            // lblSummary
            // 
            lblSummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSummary.ForeColor = Color.FromArgb(71, 85, 105);
            lblSummary.Location = new Point(870, 16);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(120, 21);
            lblSummary.TabIndex = 0;
            lblSummary.Text = "إجمالي الهياكل: 0";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 9.5F);
            btnDelete.Location = new Point(140, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "🗑️ حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 9.5F);
            btnEdit.Location = new Point(265, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 40);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "✏️ تعديل";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddNew.Cursor = Cursors.Hand;
            btnAddNew.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddNew.Location = new Point(390, 8);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(130, 40);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "➕ إضافة جديد";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += BtnAddNew_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.Location = new Point(15, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 40);
            btnClose.TabIndex = 4;
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
            // frmFeeStructures
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1080, 645);
            Controls.Add(pnlActions);
            Controls.Add(gbFeeStructureDetails);
            Controls.Add(dgvFeeStructures);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(950, 550);
            Name = "frmFeeStructures";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة هياكل الرسوم الدراسية";
            Load += FrmFeeStructures_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFeeStructures).EndInit();
            gbFeeStructureDetails.ResumeLayout(false);
            gbFeeStructureDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOtherFees).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBookFee).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTransportFee).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTuitionFee).EndInit();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.DataGridView dgvFeeStructures;
        private System.Windows.Forms.GroupBox gbFeeStructureDetails;
        private System.Windows.Forms.Label lblGradeLevel;
        private System.Windows.Forms.ComboBox cbGradeLevel;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.ComboBox cbAcademicYear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTuitionFee;
        private System.Windows.Forms.NumericUpDown numTuitionFee;
        private System.Windows.Forms.Label lblTransportFee;
        private System.Windows.Forms.NumericUpDown numTransportFee;
        private System.Windows.Forms.Label lblBookFee;
        private System.Windows.Forms.NumericUpDown numBookFee;
        private System.Windows.Forms.Label lblOtherFees;
        private System.Windows.Forms.NumericUpDown numOtherFees;
        private System.Windows.Forms.Label lblLiveTotalTitle;
        private System.Windows.Forms.Label lblLiveTotalVal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
