namespace SchoolManagementSystem.Finance
{
    partial class frmCreateInvoice
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
            lblTitle = new Label();
            pnlHeaderLine = new Panel();
            gbStudentSelection = new GroupBox();
            lblEnrollmentInfo = new Label();
            txtInvoiceNumber = new TextBox();
            lblInvoiceNum = new Label();
            cbAcademicYear = new ComboBox();
            lblAcademicYear = new Label();
            cbStudent = new ComboBox();
            lblStudent = new Label();
            gbFeeStructure = new GroupBox();
            lblFeeStructureStatus = new Label();
            pnlFeeItems = new Panel();
            chkTuitionFee = new CheckBox();
            lblTuitionFeeVal = new Label();
            chkTransportFee = new CheckBox();
            lblTransportFeeVal = new Label();
            chkBookFee = new CheckBox();
            lblBookFeeVal = new Label();
            chkOtherFees = new CheckBox();
            lblOtherFeeVal = new Label();
            lblSubtotalTitle = new Label();
            lblSubtotalVal = new Label();
            gbBillingCalculation = new GroupBox();
            lblTotalAmountVal = new Label();
            lblTotalAmountTitle = new Label();
            numTax = new NumericUpDown();
            lblTax = new Label();
            numDiscount = new NumericUpDown();
            lblDiscount = new Label();
            dtpDueDate = new DateTimePicker();
            lblDueDate = new Label();
            dtpIssueDate = new DateTimePicker();
            lblIssueDate = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            pnlHeader.SuspendLayout();
            gbStudentSelection.SuspendLayout();
            gbFeeStructure.SuspendLayout();
            pnlFeeItems.SuspendLayout();
            gbBillingCalculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
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
            pnlHeader.Size = new Size(903, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(252, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(443, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📄 إصدار فاتورة رسوم دراسية للطالب";
            // 
            // pnlHeaderLine
            // 
            pnlHeaderLine.BackColor = Color.FromArgb(59, 130, 246);
            pnlHeaderLine.Dock = DockStyle.Bottom;
            pnlHeaderLine.Location = new Point(0, 72);
            pnlHeaderLine.Name = "pnlHeaderLine";
            pnlHeaderLine.Size = new Size(903, 3);
            pnlHeaderLine.TabIndex = 2;
            // 
            // gbStudentSelection
            // 
            gbStudentSelection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbStudentSelection.Controls.Add(lblEnrollmentInfo);
            gbStudentSelection.Controls.Add(txtInvoiceNumber);
            gbStudentSelection.Controls.Add(lblInvoiceNum);
            gbStudentSelection.Controls.Add(cbAcademicYear);
            gbStudentSelection.Controls.Add(lblAcademicYear);
            gbStudentSelection.Controls.Add(cbStudent);
            gbStudentSelection.Controls.Add(lblStudent);
            gbStudentSelection.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbStudentSelection.ForeColor = Color.FromArgb(44, 62, 80);
            gbStudentSelection.Location = new Point(24, 90);
            gbStudentSelection.Name = "gbStudentSelection";
            gbStudentSelection.Size = new Size(855, 120);
            gbStudentSelection.TabIndex = 1;
            gbStudentSelection.TabStop = false;
            gbStudentSelection.Text = "بيانات الطالب ورقم الفاتورة";
            // 
            // lblEnrollmentInfo
            // 
            lblEnrollmentInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEnrollmentInfo.AutoSize = true;
            lblEnrollmentInfo.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblEnrollmentInfo.ForeColor = Color.FromArgb(100, 116, 139);
            lblEnrollmentInfo.Location = new Point(540, 92);
            lblEnrollmentInfo.Name = "lblEnrollmentInfo";
            lblEnrollmentInfo.Size = new Size(219, 20);
            lblEnrollmentInfo.TabIndex = 6;
            lblEnrollmentInfo.Text = "اختر طالباً لتحديد القيد والمرحلة الدراسية...";
            // 
            // txtInvoiceNumber
            // 
            txtInvoiceNumber.BackColor = Color.FromArgb(245, 247, 250);
            txtInvoiceNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtInvoiceNumber.ForeColor = Color.FromArgb(41, 128, 185);
            txtInvoiceNumber.Location = new Point(25, 55);
            txtInvoiceNumber.Name = "txtInvoiceNumber";
            txtInvoiceNumber.ReadOnly = true;
            txtInvoiceNumber.Size = new Size(220, 29);
            txtInvoiceNumber.TabIndex = 5;
            // 
            // lblInvoiceNum
            // 
            lblInvoiceNum.AutoSize = true;
            lblInvoiceNum.Font = new Font("Segoe UI", 9.5F);
            lblInvoiceNum.Location = new Point(160, 30);
            lblInvoiceNum.Name = "lblInvoiceNum";
            lblInvoiceNum.Size = new Size(88, 21);
            lblInvoiceNum.TabIndex = 4;
            lblInvoiceNum.Text = "رقم الفاتورة:";
            // 
            // cbAcademicYear
            // 
            cbAcademicYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbAcademicYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAcademicYear.Font = new Font("Segoe UI", 9.5F);
            cbAcademicYear.FormattingEnabled = true;
            cbAcademicYear.Location = new Point(285, 55);
            cbAcademicYear.Name = "cbAcademicYear";
            cbAcademicYear.Size = new Size(224, 29);
            cbAcademicYear.TabIndex = 3;
            cbAcademicYear.SelectedIndexChanged += CbAcademicYear_SelectedIndexChanged;
            // 
            // lblAcademicYear
            // 
            lblAcademicYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAcademicYear.AutoSize = true;
            lblAcademicYear.Font = new Font("Segoe UI", 9.5F);
            lblAcademicYear.Location = new Point(395, 30);
            lblAcademicYear.Name = "lblAcademicYear";
            lblAcademicYear.Size = new Size(105, 21);
            lblAcademicYear.TabIndex = 2;
            lblAcademicYear.Text = "السنة الدراسية:";
            // 
            // cbStudent
            // 
            cbStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.Font = new Font("Segoe UI", 9.5F);
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(530, 55);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(300, 29);
            cbStudent.TabIndex = 1;
            cbStudent.SelectedIndexChanged += CbStudent_SelectedIndexChanged;
            // 
            // lblStudent
            // 
            lblStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 9.5F);
            lblStudent.Location = new Point(745, 30);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(88, 21);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "اختر الطالب:";
            // 
            // gbFeeStructure
            // 
            gbFeeStructure.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFeeStructure.Controls.Add(lblFeeStructureStatus);
            gbFeeStructure.Controls.Add(pnlFeeItems);
            gbFeeStructure.Controls.Add(lblSubtotalTitle);
            gbFeeStructure.Controls.Add(lblSubtotalVal);
            gbFeeStructure.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbFeeStructure.ForeColor = Color.FromArgb(44, 62, 80);
            gbFeeStructure.Location = new Point(24, 225);
            gbFeeStructure.Name = "gbFeeStructure";
            gbFeeStructure.Size = new Size(855, 175);
            gbFeeStructure.TabIndex = 2;
            gbFeeStructure.TabStop = false;
            gbFeeStructure.Text = "هيكل الرسوم الدراسية (كشف تلقائي)";
            // 
            // lblFeeStructureStatus
            // 
            lblFeeStructureStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFeeStructureStatus.AutoSize = true;
            lblFeeStructureStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblFeeStructureStatus.ForeColor = Color.FromArgb(100, 116, 139);
            lblFeeStructureStatus.Location = new Point(520, 25);
            lblFeeStructureStatus.Name = "lblFeeStructureStatus";
            lblFeeStructureStatus.Size = new Size(252, 20);
            lblFeeStructureStatus.TabIndex = 0;
            lblFeeStructureStatus.Text = "في انتظار تحديد الطالب والسنة الدراسية للتحقق...";
            // 
            // pnlFeeItems
            // 
            pnlFeeItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFeeItems.BackColor = Color.FromArgb(248, 250, 252);
            pnlFeeItems.BorderStyle = BorderStyle.FixedSingle;
            pnlFeeItems.Controls.Add(chkTuitionFee);
            pnlFeeItems.Controls.Add(lblTuitionFeeVal);
            pnlFeeItems.Controls.Add(chkTransportFee);
            pnlFeeItems.Controls.Add(lblTransportFeeVal);
            pnlFeeItems.Controls.Add(chkBookFee);
            pnlFeeItems.Controls.Add(lblBookFeeVal);
            pnlFeeItems.Controls.Add(chkOtherFees);
            pnlFeeItems.Controls.Add(lblOtherFeeVal);
            pnlFeeItems.Location = new Point(175, 50);
            pnlFeeItems.Name = "pnlFeeItems";
            pnlFeeItems.Size = new Size(662, 105);
            pnlFeeItems.TabIndex = 1;
            pnlFeeItems.Visible = false;
            // 
            // chkTuitionFee
            // 
            chkTuitionFee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkTuitionFee.AutoSize = true;
            chkTuitionFee.Checked = true;
            chkTuitionFee.CheckState = CheckState.Checked;
            chkTuitionFee.Enabled = false;
            chkTuitionFee.Font = new Font("Segoe UI", 9.5F);
            chkTuitionFee.Location = new Point(500, 12);
            chkTuitionFee.Name = "chkTuitionFee";
            chkTuitionFee.Size = new Size(143, 25);
            chkTuitionFee.TabIndex = 0;
            chkTuitionFee.Text = "🎓 رسوم التعليم:";
            chkTuitionFee.CheckedChanged += FeeItemChanged;
            // 
            // lblTuitionFeeVal
            // 
            lblTuitionFeeVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTuitionFeeVal.AutoSize = true;
            lblTuitionFeeVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTuitionFeeVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblTuitionFeeVal.Location = new Point(440, 12);
            lblTuitionFeeVal.Name = "lblTuitionFeeVal";
            lblTuitionFeeVal.Size = new Size(55, 23);
            lblTuitionFeeVal.TabIndex = 1;
            lblTuitionFeeVal.Text = "$0.00";
            // 
            // chkTransportFee
            // 
            chkTransportFee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkTransportFee.AutoSize = true;
            chkTransportFee.Checked = true;
            chkTransportFee.CheckState = CheckState.Checked;
            chkTransportFee.Font = new Font("Segoe UI", 9.5F);
            chkTransportFee.Location = new Point(505, 42);
            chkTransportFee.Name = "chkTransportFee";
            chkTransportFee.Size = new Size(134, 25);
            chkTransportFee.TabIndex = 2;
            chkTransportFee.Text = "🚌 رسوم النقل:";
            chkTransportFee.CheckedChanged += FeeItemChanged;
            // 
            // lblTransportFeeVal
            // 
            lblTransportFeeVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTransportFeeVal.AutoSize = true;
            lblTransportFeeVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTransportFeeVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblTransportFeeVal.Location = new Point(440, 42);
            lblTransportFeeVal.Name = "lblTransportFeeVal";
            lblTransportFeeVal.Size = new Size(55, 23);
            lblTransportFeeVal.TabIndex = 3;
            lblTransportFeeVal.Text = "$0.00";
            // 
            // chkBookFee
            // 
            chkBookFee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkBookFee.AutoSize = true;
            chkBookFee.Checked = true;
            chkBookFee.CheckState = CheckState.Checked;
            chkBookFee.Font = new Font("Segoe UI", 9.5F);
            chkBookFee.Location = new Point(502, 72);
            chkBookFee.Name = "chkBookFee";
            chkBookFee.Size = new Size(138, 25);
            chkBookFee.TabIndex = 4;
            chkBookFee.Text = "📚 رسوم الكتب:";
            chkBookFee.CheckedChanged += FeeItemChanged;
            // 
            // lblBookFeeVal
            // 
            lblBookFeeVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBookFeeVal.AutoSize = true;
            lblBookFeeVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBookFeeVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblBookFeeVal.Location = new Point(440, 72);
            lblBookFeeVal.Name = "lblBookFeeVal";
            lblBookFeeVal.Size = new Size(55, 23);
            lblBookFeeVal.TabIndex = 5;
            lblBookFeeVal.Text = "$0.00";
            // 
            // chkOtherFees
            // 
            chkOtherFees.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkOtherFees.AutoSize = true;
            chkOtherFees.Checked = true;
            chkOtherFees.CheckState = CheckState.Checked;
            chkOtherFees.Font = new Font("Segoe UI", 9.5F);
            chkOtherFees.Location = new Point(183, 12);
            chkOtherFees.Name = "chkOtherFees";
            chkOtherFees.Size = new Size(132, 25);
            chkOtherFees.TabIndex = 6;
            chkOtherFees.Text = "📋 رسوم أخرى:";
            chkOtherFees.CheckedChanged += FeeItemChanged;
            // 
            // lblOtherFeeVal
            // 
            lblOtherFeeVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOtherFeeVal.AutoSize = true;
            lblOtherFeeVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOtherFeeVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblOtherFeeVal.Location = new Point(120, 12);
            lblOtherFeeVal.Name = "lblOtherFeeVal";
            lblOtherFeeVal.Size = new Size(55, 23);
            lblOtherFeeVal.TabIndex = 7;
            lblOtherFeeVal.Text = "$0.00";
            // 
            // lblSubtotalTitle
            // 
            lblSubtotalTitle.AutoSize = true;
            lblSubtotalTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSubtotalTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblSubtotalTitle.Location = new Point(40, 60);
            lblSubtotalTitle.Name = "lblSubtotalTitle";
            lblSubtotalTitle.Size = new Size(116, 21);
            lblSubtotalTitle.TabIndex = 8;
            lblSubtotalTitle.Text = "المجموع الفرعي:";
            // 
            // lblSubtotalVal
            // 
            lblSubtotalVal.AutoSize = true;
            lblSubtotalVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSubtotalVal.ForeColor = Color.FromArgb(41, 128, 185);
            lblSubtotalVal.Location = new Point(40, 88);
            lblSubtotalVal.Name = "lblSubtotalVal";
            lblSubtotalVal.Size = new Size(77, 32);
            lblSubtotalVal.TabIndex = 9;
            lblSubtotalVal.Text = "$0.00";
            // 
            // gbBillingCalculation
            // 
            gbBillingCalculation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbBillingCalculation.Controls.Add(lblTotalAmountVal);
            gbBillingCalculation.Controls.Add(lblTotalAmountTitle);
            gbBillingCalculation.Controls.Add(numTax);
            gbBillingCalculation.Controls.Add(lblTax);
            gbBillingCalculation.Controls.Add(numDiscount);
            gbBillingCalculation.Controls.Add(lblDiscount);
            gbBillingCalculation.Controls.Add(dtpDueDate);
            gbBillingCalculation.Controls.Add(lblDueDate);
            gbBillingCalculation.Controls.Add(dtpIssueDate);
            gbBillingCalculation.Controls.Add(lblIssueDate);
            gbBillingCalculation.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbBillingCalculation.ForeColor = Color.FromArgb(44, 62, 80);
            gbBillingCalculation.Location = new Point(24, 415);
            gbBillingCalculation.Name = "gbBillingCalculation";
            gbBillingCalculation.Size = new Size(855, 175);
            gbBillingCalculation.TabIndex = 3;
            gbBillingCalculation.TabStop = false;
            gbBillingCalculation.Text = "تواريخ الاستحقاق وحساب الإجمالي النهائي";
            // 
            // lblTotalAmountVal
            // 
            lblTotalAmountVal.AutoSize = true;
            lblTotalAmountVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalAmountVal.ForeColor = Color.FromArgb(39, 174, 96);
            lblTotalAmountVal.Location = new Point(40, 95);
            lblTotalAmountVal.Name = "lblTotalAmountVal";
            lblTotalAmountVal.Size = new Size(94, 41);
            lblTotalAmountVal.TabIndex = 9;
            lblTotalAmountVal.Text = "$0.00";
            // 
            // lblTotalAmountTitle
            // 
            lblTotalAmountTitle.AutoSize = true;
            lblTotalAmountTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTotalAmountTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblTotalAmountTitle.Location = new Point(40, 68);
            lblTotalAmountTitle.Name = "lblTotalAmountTitle";
            lblTotalAmountTitle.Size = new Size(130, 25);
            lblTotalAmountTitle.TabIndex = 8;
            lblTotalAmountTitle.Text = "إجمالي الفاتورة:";
            // 
            // numTax
            // 
            numTax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numTax.DecimalPlaces = 2;
            numTax.Font = new Font("Segoe UI", 9.5F);
            numTax.Location = new Point(430, 125);
            numTax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numTax.Name = "numTax";
            numTax.Size = new Size(185, 29);
            numTax.TabIndex = 7;
            numTax.ValueChanged += CalculationChanged;
            // 
            // lblTax
            // 
            lblTax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 9.5F);
            lblTax.Location = new Point(500, 100);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(118, 21);
            lblTax.TabIndex = 6;
            lblTax.Text = "مبلغ الضريبة ($):";
            // 
            // numDiscount
            // 
            numDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numDiscount.DecimalPlaces = 2;
            numDiscount.Font = new Font("Segoe UI", 9.5F);
            numDiscount.Location = new Point(645, 125);
            numDiscount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(185, 29);
            numDiscount.TabIndex = 5;
            numDiscount.ValueChanged += CalculationChanged;
            // 
            // lblDiscount
            // 
            lblDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 9.5F);
            lblDiscount.Location = new Point(720, 100);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(111, 21);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "مبلغ الخصم ($):";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDueDate.Font = new Font("Segoe UI", 9.5F);
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(430, 55);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(185, 29);
            dtpDueDate.TabIndex = 3;
            // 
            // lblDueDate
            // 
            lblDueDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 9.5F);
            lblDueDate.Location = new Point(505, 30);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(112, 21);
            lblDueDate.TabIndex = 2;
            lblDueDate.Text = "تاريخ الاستحقاق:";
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpIssueDate.Font = new Font("Segoe UI", 9.5F);
            dtpIssueDate.Format = DateTimePickerFormat.Short;
            dtpIssueDate.Location = new Point(645, 55);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(185, 29);
            dtpIssueDate.TabIndex = 1;
            // 
            // lblIssueDate
            // 
            lblIssueDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIssueDate.AutoSize = true;
            lblIssueDate.Font = new Font("Segoe UI", 9.5F);
            lblIssueDate.Location = new Point(740, 30);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(96, 21);
            lblIssueDate.TabIndex = 0;
            lblIssueDate.Text = "تاريخ الإصدار:";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(145, 608);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 44);
            btnSave.TabIndex = 4;
            btnSave.Text = "💾 إصدار الفاتورة";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.Location = new Point(25, 608);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 44);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // frmCreateInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(903, 668);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(gbBillingCalculation);
            Controls.Add(gbFeeStructure);
            Controls.Add(gbStudentSelection);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCreateInvoice";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إصدار فاتورة رسوم دراسية للطالب";
            Load += FrmCreateInvoice_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            gbStudentSelection.ResumeLayout(false);
            gbStudentSelection.PerformLayout();
            gbFeeStructure.ResumeLayout(false);
            gbFeeStructure.PerformLayout();
            pnlFeeItems.ResumeLayout(false);
            pnlFeeItems.PerformLayout();
            gbBillingCalculation.ResumeLayout(false);
            gbBillingCalculation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.GroupBox gbStudentSelection;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.ComboBox cbAcademicYear;
        private System.Windows.Forms.Label lblInvoiceNum;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Label lblEnrollmentInfo;
        private System.Windows.Forms.GroupBox gbFeeStructure;
        private System.Windows.Forms.Label lblFeeStructureStatus;
        private System.Windows.Forms.Panel pnlFeeItems;
        private System.Windows.Forms.CheckBox chkTuitionFee;
        private System.Windows.Forms.Label lblTuitionFeeVal;
        private System.Windows.Forms.CheckBox chkTransportFee;
        private System.Windows.Forms.Label lblTransportFeeVal;
        private System.Windows.Forms.CheckBox chkBookFee;
        private System.Windows.Forms.Label lblBookFeeVal;
        private System.Windows.Forms.CheckBox chkOtherFees;
        private System.Windows.Forms.Label lblOtherFeeVal;
        private System.Windows.Forms.Label lblSubtotalTitle;
        private System.Windows.Forms.Label lblSubtotalVal;
        private System.Windows.Forms.GroupBox gbBillingCalculation;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.NumericUpDown numTax;
        private System.Windows.Forms.Label lblTotalAmountTitle;
        private System.Windows.Forms.Label lblTotalAmountVal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
