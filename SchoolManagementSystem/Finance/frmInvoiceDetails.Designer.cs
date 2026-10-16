namespace SchoolManagementSystem.Finance
{
    partial class frmInvoiceDetails
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbInvoiceHeader = new System.Windows.Forms.GroupBox();
            this.lblStatusBadge = new System.Windows.Forms.Label();
            this.lblDueDateVal = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblIssueDateVal = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblAcademicYearVal = new System.Windows.Forms.Label();
            this.lblAcademicYear = new System.Windows.Forms.Label();
            this.lblAdmissionNoVal = new System.Windows.Forms.Label();
            this.lblAdmissionNo = new System.Windows.Forms.Label();
            this.lblStudentNameVal = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblInvoiceNoVal = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.gbFinancialSummary = new System.Windows.Forms.GroupBox();
            this.lblRemainingVal = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblPaidVal = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTaxVal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDiscountVal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubtotalVal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.gbPayments = new System.Windows.Forms.GroupBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.btnRecordPayment = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbInvoiceHeader.SuspendLayout();
            this.gbFinancialSummary.SuspendLayout();
            this.gbPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Invoice Details";
            // 
            // gbInvoiceHeader
            // 
            this.gbInvoiceHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInvoiceHeader.Controls.Add(this.lblStatusBadge);
            this.gbInvoiceHeader.Controls.Add(this.lblDueDateVal);
            this.gbInvoiceHeader.Controls.Add(this.lblDueDate);
            this.gbInvoiceHeader.Controls.Add(this.lblIssueDateVal);
            this.gbInvoiceHeader.Controls.Add(this.lblIssueDate);
            this.gbInvoiceHeader.Controls.Add(this.lblAcademicYearVal);
            this.gbInvoiceHeader.Controls.Add(this.lblAcademicYear);
            this.gbInvoiceHeader.Controls.Add(this.lblAdmissionNoVal);
            this.gbInvoiceHeader.Controls.Add(this.lblAdmissionNo);
            this.gbInvoiceHeader.Controls.Add(this.lblStudentNameVal);
            this.gbInvoiceHeader.Controls.Add(this.lblStudentName);
            this.gbInvoiceHeader.Controls.Add(this.lblInvoiceNoVal);
            this.gbInvoiceHeader.Controls.Add(this.lblInvoiceNo);
            this.gbInvoiceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbInvoiceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.gbInvoiceHeader.Location = new System.Drawing.Point(29, 60);
            this.gbInvoiceHeader.Name = "gbInvoiceHeader";
            this.gbInvoiceHeader.Size = new System.Drawing.Size(890, 110);
            this.gbInvoiceHeader.TabIndex = 1;
            this.gbInvoiceHeader.TabStop = false;
            this.gbInvoiceHeader.Text = "Student & Invoice Info";
            // 
            // lblStatusBadge
            // 
            this.lblStatusBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.lblStatusBadge.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatusBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblStatusBadge.Location = new System.Drawing.Point(740, 30);
            this.lblStatusBadge.Name = "lblStatusBadge";
            this.lblStatusBadge.Size = new System.Drawing.Size(130, 32);
            this.lblStatusBadge.TabIndex = 12;
            this.lblStatusBadge.Text = "UNPAID";
            this.lblStatusBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDueDateVal
            // 
            this.lblDueDateVal.AutoSize = true;
            this.lblDueDateVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDueDateVal.Location = new System.Drawing.Point(620, 70);
            this.lblDueDateVal.Name = "lblDueDateVal";
            this.lblDueDateVal.Size = new System.Drawing.Size(23, 17);
            this.lblDueDateVal.TabIndex = 11;
            this.lblDueDateVal.Text = "---";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDueDate.Location = new System.Drawing.Point(545, 70);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(65, 17);
            this.lblDueDate.TabIndex = 10;
            this.lblDueDate.Text = "Due Date:";
            // 
            // lblIssueDateVal
            // 
            this.lblIssueDateVal.AutoSize = true;
            this.lblIssueDateVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIssueDateVal.Location = new System.Drawing.Point(620, 35);
            this.lblIssueDateVal.Name = "lblIssueDateVal";
            this.lblIssueDateVal.Size = new System.Drawing.Size(23, 17);
            this.lblIssueDateVal.TabIndex = 9;
            this.lblIssueDateVal.Text = "---";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblIssueDate.Location = new System.Drawing.Point(545, 35);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(71, 17);
            this.lblIssueDate.TabIndex = 8;
            this.lblIssueDate.Text = "Issue Date:";
            // 
            // lblAcademicYearVal
            // 
            this.lblAcademicYearVal.AutoSize = true;
            this.lblAcademicYearVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAcademicYearVal.Location = new System.Drawing.Point(380, 70);
            this.lblAcademicYearVal.Name = "lblAcademicYearVal";
            this.lblAcademicYearVal.Size = new System.Drawing.Size(23, 17);
            this.lblAcademicYearVal.TabIndex = 7;
            this.lblAcademicYearVal.Text = "---";
            // 
            // lblAcademicYear
            // 
            this.lblAcademicYear.AutoSize = true;
            this.lblAcademicYear.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAcademicYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAcademicYear.Location = new System.Drawing.Point(280, 70);
            this.lblAcademicYear.Name = "lblAcademicYear";
            this.lblAcademicYear.Size = new System.Drawing.Size(96, 17);
            this.lblAcademicYear.TabIndex = 6;
            this.lblAcademicYear.Text = "Academic Year:";
            // 
            // lblAdmissionNoVal
            // 
            this.lblAdmissionNoVal.AutoSize = true;
            this.lblAdmissionNoVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAdmissionNoVal.Location = new System.Drawing.Point(380, 35);
            this.lblAdmissionNoVal.Name = "lblAdmissionNoVal";
            this.lblAdmissionNoVal.Size = new System.Drawing.Size(23, 17);
            this.lblAdmissionNoVal.TabIndex = 5;
            this.lblAdmissionNoVal.Text = "---";
            // 
            // lblAdmissionNo
            // 
            this.lblAdmissionNo.AutoSize = true;
            this.lblAdmissionNo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAdmissionNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAdmissionNo.Location = new System.Drawing.Point(280, 35);
            this.lblAdmissionNo.Name = "lblAdmissionNo";
            this.lblAdmissionNo.Size = new System.Drawing.Size(91, 17);
            this.lblAdmissionNo.TabIndex = 4;
            this.lblAdmissionNo.Text = "Admission No:";
            // 
            // lblStudentNameVal
            // 
            this.lblStudentNameVal.AutoSize = true;
            this.lblStudentNameVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStudentNameVal.Location = new System.Drawing.Point(100, 70);
            this.lblStudentNameVal.Name = "lblStudentNameVal";
            this.lblStudentNameVal.Size = new System.Drawing.Size(23, 17);
            this.lblStudentNameVal.TabIndex = 3;
            this.lblStudentNameVal.Text = "---";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblStudentName.Location = new System.Drawing.Point(20, 70);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(56, 17);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Student:";
            // 
            // lblInvoiceNoVal
            // 
            this.lblInvoiceNoVal.AutoSize = true;
            this.lblInvoiceNoVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceNoVal.Location = new System.Drawing.Point(100, 35);
            this.lblInvoiceNoVal.Name = "lblInvoiceNoVal";
            this.lblInvoiceNoVal.Size = new System.Drawing.Size(23, 17);
            this.lblInvoiceNoVal.TabIndex = 1;
            this.lblInvoiceNoVal.Text = "---";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblInvoiceNo.Location = new System.Drawing.Point(20, 35);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(65, 17);
            this.lblInvoiceNo.TabIndex = 0;
            this.lblInvoiceNo.Text = "Invoice #:";
            // 
            // gbFinancialSummary
            // 
            this.gbFinancialSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFinancialSummary.Controls.Add(this.lblRemainingVal);
            this.gbFinancialSummary.Controls.Add(this.lblRemaining);
            this.gbFinancialSummary.Controls.Add(this.lblPaidVal);
            this.gbFinancialSummary.Controls.Add(this.lblPaid);
            this.gbFinancialSummary.Controls.Add(this.lblTotalVal);
            this.gbFinancialSummary.Controls.Add(this.lblTotal);
            this.gbFinancialSummary.Controls.Add(this.lblTaxVal);
            this.gbFinancialSummary.Controls.Add(this.lblTax);
            this.gbFinancialSummary.Controls.Add(this.lblDiscountVal);
            this.gbFinancialSummary.Controls.Add(this.lblDiscount);
            this.gbFinancialSummary.Controls.Add(this.lblSubtotalVal);
            this.gbFinancialSummary.Controls.Add(this.lblSubtotal);
            this.gbFinancialSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbFinancialSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.gbFinancialSummary.Location = new System.Drawing.Point(29, 180);
            this.gbFinancialSummary.Name = "gbFinancialSummary";
            this.gbFinancialSummary.Size = new System.Drawing.Size(890, 95);
            this.gbFinancialSummary.TabIndex = 2;
            this.gbFinancialSummary.TabStop = false;
            this.gbFinancialSummary.Text = "Financial Breakdown";
            // 
            // lblRemainingVal
            // 
            this.lblRemainingVal.AutoSize = true;
            this.lblRemainingVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRemainingVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRemainingVal.Location = new System.Drawing.Point(750, 52);
            this.lblRemainingVal.Name = "lblRemainingVal";
            this.lblRemainingVal.Size = new System.Drawing.Size(55, 21);
            this.lblRemainingVal.TabIndex = 11;
            this.lblRemainingVal.Text = "$ 0.00";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRemaining.Location = new System.Drawing.Point(750, 30);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(72, 17);
            this.lblRemaining.TabIndex = 10;
            this.lblRemaining.Text = "Remaining:";
            // 
            // lblPaidVal
            // 
            this.lblPaidVal.AutoSize = true;
            this.lblPaidVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPaidVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblPaidVal.Location = new System.Drawing.Point(600, 53);
            this.lblPaidVal.Name = "lblPaidVal";
            this.lblPaidVal.Size = new System.Drawing.Size(50, 20);
            this.lblPaidVal.TabIndex = 9;
            this.lblPaidVal.Text = "$ 0.00";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPaid.Location = new System.Drawing.Point(600, 30);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(70, 17);
            this.lblPaid.TabIndex = 8;
            this.lblPaid.Text = "Total Paid:";
            // 
            // lblTotalVal
            // 
            this.lblTotalVal.AutoSize = true;
            this.lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTotalVal.Location = new System.Drawing.Point(450, 53);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(50, 20);
            this.lblTotalVal.TabIndex = 7;
            this.lblTotalVal.Text = "$ 0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotal.Location = new System.Drawing.Point(450, 30);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 17);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total Due: *";
            // 
            // lblTaxVal
            // 
            this.lblTaxVal.AutoSize = true;
            this.lblTaxVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTaxVal.Location = new System.Drawing.Point(310, 55);
            this.lblTaxVal.Name = "lblTaxVal";
            this.lblTaxVal.Size = new System.Drawing.Size(43, 17);
            this.lblTaxVal.TabIndex = 5;
            this.lblTaxVal.Text = "$ 0.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTax.Location = new System.Drawing.Point(310, 30);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(30, 17);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax:";
            // 
            // lblDiscountVal
            // 
            this.lblDiscountVal.AutoSize = true;
            this.lblDiscountVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiscountVal.Location = new System.Drawing.Point(160, 55);
            this.lblDiscountVal.Name = "lblDiscountVal";
            this.lblDiscountVal.Size = new System.Drawing.Size(43, 17);
            this.lblDiscountVal.TabIndex = 3;
            this.lblDiscountVal.Text = "$ 0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDiscount.Location = new System.Drawing.Point(160, 30);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(61, 17);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblSubtotalVal
            // 
            this.lblSubtotalVal.AutoSize = true;
            this.lblSubtotalVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtotalVal.Location = new System.Drawing.Point(20, 55);
            this.lblSubtotalVal.Name = "lblSubtotalVal";
            this.lblSubtotalVal.Size = new System.Drawing.Size(43, 17);
            this.lblSubtotalVal.TabIndex = 1;
            this.lblSubtotalVal.Text = "$ 0.00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubtotal.Location = new System.Drawing.Point(20, 30);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(59, 17);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // gbPayments
            // 
            this.gbPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPayments.Controls.Add(this.dgvPayments);
            this.gbPayments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbPayments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.gbPayments.Location = new System.Drawing.Point(29, 285);
            this.gbPayments.Name = "gbPayments";
            this.gbPayments.Size = new System.Drawing.Size(890, 260);
            this.gbPayments.TabIndex = 3;
            this.gbPayments.TabStop = false;
            this.gbPayments.Text = "Recorded Payments History";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(15, 30);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(860, 215);
            this.dgvPayments.TabIndex = 0;
            // 
            // btnRecordPayment
            // 
            this.btnRecordPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecordPayment.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRecordPayment.Location = new System.Drawing.Point(540, 560);
            this.btnRecordPayment.Name = "btnRecordPayment";
            this.btnRecordPayment.Size = new System.Drawing.Size(150, 36);
            this.btnRecordPayment.TabIndex = 4;
            this.btnRecordPayment.Text = "Record Payment";
            this.btnRecordPayment.UseVisualStyleBackColor = true;
            this.btnRecordPayment.Click += new System.EventHandler(this.BtnRecordPayment_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnPrint.Location = new System.Drawing.Point(700, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 36);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print / Export";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnClose.Location = new System.Drawing.Point(820, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(949, 610);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRecordPayment);
            this.Controls.Add(this.gbPayments);
            this.Controls.Add(this.gbFinancialSummary);
            this.Controls.Add(this.gbInvoiceHeader);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "frmInvoiceDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Details & Payment Hub";
            this.Load += new System.EventHandler(this.FrmInvoiceDetails_Load);
            this.gbInvoiceHeader.ResumeLayout(false);
            this.gbInvoiceHeader.PerformLayout();
            this.gbFinancialSummary.ResumeLayout(false);
            this.gbFinancialSummary.PerformLayout();
            this.gbPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbInvoiceHeader;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNoVal;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentNameVal;
        private System.Windows.Forms.Label lblAdmissionNo;
        private System.Windows.Forms.Label lblAdmissionNoVal;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.Label lblAcademicYearVal;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblIssueDateVal;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblDueDateVal;
        private System.Windows.Forms.Label lblStatusBadge;
        private System.Windows.Forms.GroupBox gbFinancialSummary;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalVal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountVal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxVal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblPaidVal;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblRemainingVal;
        private System.Windows.Forms.GroupBox gbPayments;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnRecordPayment;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
    }
}
