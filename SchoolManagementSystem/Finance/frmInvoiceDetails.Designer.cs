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
            lblTitle = new Label();
            gbInvoiceHeader = new GroupBox();
            lblStatusBadge = new Label();
            lblDueDateVal = new Label();
            lblDueDate = new Label();
            lblIssueDateVal = new Label();
            lblIssueDate = new Label();
            lblAcademicYearVal = new Label();
            lblAcademicYear = new Label();
            lblAdmissionNoVal = new Label();
            lblAdmissionNo = new Label();
            lblStudentNameVal = new Label();
            lblStudentName = new Label();
            lblInvoiceNoVal = new Label();
            lblInvoiceNo = new Label();
            gbFinancialSummary = new GroupBox();
            lblRemainingVal = new Label();
            lblRemaining = new Label();
            lblPaidVal = new Label();
            lblPaid = new Label();
            lblTotalVal = new Label();
            lblTotal = new Label();
            lblTaxVal = new Label();
            lblTax = new Label();
            lblDiscountVal = new Label();
            lblDiscount = new Label();
            lblSubtotalVal = new Label();
            lblSubtotal = new Label();
            gbPayments = new GroupBox();
            dgvPayments = new DataGridView();
            btnRecordPayment = new Button();
            btnPrint = new Button();
            btnClose = new Button();
            gbInvoiceHeader.SuspendLayout();
            gbFinancialSummary.SuspendLayout();
            gbPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitle.Location = new Point(341, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "تفاصيل الفاتورة وحركاتها";
            // 
            // gbInvoiceHeader
            // 
            gbInvoiceHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbInvoiceHeader.Controls.Add(lblStatusBadge);
            gbInvoiceHeader.Controls.Add(lblDueDateVal);
            gbInvoiceHeader.Controls.Add(lblDueDate);
            gbInvoiceHeader.Controls.Add(lblIssueDateVal);
            gbInvoiceHeader.Controls.Add(lblIssueDate);
            gbInvoiceHeader.Controls.Add(lblAcademicYearVal);
            gbInvoiceHeader.Controls.Add(lblAcademicYear);
            gbInvoiceHeader.Controls.Add(lblAdmissionNoVal);
            gbInvoiceHeader.Controls.Add(lblAdmissionNo);
            gbInvoiceHeader.Controls.Add(lblStudentNameVal);
            gbInvoiceHeader.Controls.Add(lblStudentName);
            gbInvoiceHeader.Controls.Add(lblInvoiceNoVal);
            gbInvoiceHeader.Controls.Add(lblInvoiceNo);
            gbInvoiceHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbInvoiceHeader.ForeColor = Color.FromArgb(30, 41, 59);
            gbInvoiceHeader.Location = new Point(29, 65);
            gbInvoiceHeader.Name = "gbInvoiceHeader";
            gbInvoiceHeader.Size = new Size(890, 110);
            gbInvoiceHeader.TabIndex = 1;
            gbInvoiceHeader.TabStop = false;
            gbInvoiceHeader.Text = "بيانات الفاتورة والطالب";
            // 
            // lblStatusBadge
            // 
            lblStatusBadge.BackColor = Color.FromArgb(254, 243, 199);
            lblStatusBadge.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatusBadge.ForeColor = Color.FromArgb(180, 83, 9);
            lblStatusBadge.Location = new Point(20, 30);
            lblStatusBadge.Name = "lblStatusBadge";
            lblStatusBadge.Size = new Size(130, 35);
            lblStatusBadge.TabIndex = 12;
            lblStatusBadge.Text = "غير مدفوعة";
            lblStatusBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDueDateVal
            // 
            lblDueDateVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDueDateVal.AutoSize = true;
            lblDueDateVal.Font = new Font("Segoe UI", 9.5F);
            lblDueDateVal.Location = new Point(190, 70);
            lblDueDateVal.Name = "lblDueDateVal";
            lblDueDateVal.Size = new Size(28, 21);
            lblDueDateVal.TabIndex = 11;
            lblDueDateVal.Text = "---";
            // 
            // lblDueDate
            // 
            lblDueDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 9.5F);
            lblDueDate.ForeColor = Color.FromArgb(100, 116, 139);
            lblDueDate.Location = new Point(275, 70);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(112, 21);
            lblDueDate.TabIndex = 10;
            lblDueDate.Text = "تاريخ الاستحقاق:";
            // 
            // lblIssueDateVal
            // 
            lblIssueDateVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIssueDateVal.AutoSize = true;
            lblIssueDateVal.Font = new Font("Segoe UI", 9.5F);
            lblIssueDateVal.Location = new Point(190, 35);
            lblIssueDateVal.Name = "lblIssueDateVal";
            lblIssueDateVal.Size = new Size(28, 21);
            lblIssueDateVal.TabIndex = 9;
            lblIssueDateVal.Text = "---";
            // 
            // lblIssueDate
            // 
            lblIssueDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIssueDate.AutoSize = true;
            lblIssueDate.Font = new Font("Segoe UI", 9.5F);
            lblIssueDate.ForeColor = Color.FromArgb(100, 116, 139);
            lblIssueDate.Location = new Point(290, 35);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(96, 21);
            lblIssueDate.TabIndex = 8;
            lblIssueDate.Text = "تاريخ الإصدار:";
            // 
            // lblAcademicYearVal
            // 
            lblAcademicYearVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAcademicYearVal.AutoSize = true;
            lblAcademicYearVal.Font = new Font("Segoe UI", 9.5F);
            lblAcademicYearVal.Location = new Point(415, 70);
            lblAcademicYearVal.Name = "lblAcademicYearVal";
            lblAcademicYearVal.Size = new Size(28, 21);
            lblAcademicYearVal.TabIndex = 7;
            lblAcademicYearVal.Text = "---";
            // 
            // lblAcademicYear
            // 
            lblAcademicYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAcademicYear.AutoSize = true;
            lblAcademicYear.Font = new Font("Segoe UI", 9.5F);
            lblAcademicYear.ForeColor = Color.FromArgb(100, 116, 139);
            lblAcademicYear.Location = new Point(495, 70);
            lblAcademicYear.Name = "lblAcademicYear";
            lblAcademicYear.Size = new Size(105, 21);
            lblAcademicYear.TabIndex = 6;
            lblAcademicYear.Text = "السنة الدراسية:";
            // 
            // lblAdmissionNoVal
            // 
            lblAdmissionNoVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdmissionNoVal.AutoSize = true;
            lblAdmissionNoVal.Font = new Font("Segoe UI", 9.5F);
            lblAdmissionNoVal.Location = new Point(415, 35);
            lblAdmissionNoVal.Name = "lblAdmissionNoVal";
            lblAdmissionNoVal.Size = new Size(28, 21);
            lblAdmissionNoVal.TabIndex = 5;
            lblAdmissionNoVal.Text = "---";
            // 
            // lblAdmissionNo
            // 
            lblAdmissionNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdmissionNo.AutoSize = true;
            lblAdmissionNo.Font = new Font("Segoe UI", 9.5F);
            lblAdmissionNo.ForeColor = Color.FromArgb(100, 116, 139);
            lblAdmissionNo.Location = new Point(515, 35);
            lblAdmissionNo.Name = "lblAdmissionNo";
            lblAdmissionNo.Size = new Size(81, 21);
            lblAdmissionNo.TabIndex = 4;
            lblAdmissionNo.Text = "رقم القبول:";
            // 
            // lblStudentNameVal
            // 
            lblStudentNameVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStudentNameVal.AutoSize = true;
            lblStudentNameVal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStudentNameVal.Location = new Point(625, 70);
            lblStudentNameVal.Name = "lblStudentNameVal";
            lblStudentNameVal.Size = new Size(28, 21);
            lblStudentNameVal.TabIndex = 3;
            lblStudentNameVal.Text = "---";
            // 
            // lblStudentName
            // 
            lblStudentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 9.5F);
            lblStudentName.ForeColor = Color.FromArgb(100, 116, 139);
            lblStudentName.Location = new Point(780, 70);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(89, 21);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "اسم الطالب:";
            // 
            // lblInvoiceNoVal
            // 
            lblInvoiceNoVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInvoiceNoVal.AutoSize = true;
            lblInvoiceNoVal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblInvoiceNoVal.Location = new Point(625, 35);
            lblInvoiceNoVal.Name = "lblInvoiceNoVal";
            lblInvoiceNoVal.Size = new Size(28, 21);
            lblInvoiceNoVal.TabIndex = 1;
            lblInvoiceNoVal.Text = "---";
            // 
            // lblInvoiceNo
            // 
            lblInvoiceNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInvoiceNo.AutoSize = true;
            lblInvoiceNo.Font = new Font("Segoe UI", 9.5F);
            lblInvoiceNo.ForeColor = Color.FromArgb(100, 116, 139);
            lblInvoiceNo.Location = new Point(780, 35);
            lblInvoiceNo.Name = "lblInvoiceNo";
            lblInvoiceNo.Size = new Size(88, 21);
            lblInvoiceNo.TabIndex = 0;
            lblInvoiceNo.Text = "رقم الفاتورة:";
            // 
            // gbFinancialSummary
            // 
            gbFinancialSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFinancialSummary.Controls.Add(lblRemainingVal);
            gbFinancialSummary.Controls.Add(lblRemaining);
            gbFinancialSummary.Controls.Add(lblPaidVal);
            gbFinancialSummary.Controls.Add(lblPaid);
            gbFinancialSummary.Controls.Add(lblTotalVal);
            gbFinancialSummary.Controls.Add(lblTotal);
            gbFinancialSummary.Controls.Add(lblTaxVal);
            gbFinancialSummary.Controls.Add(lblTax);
            gbFinancialSummary.Controls.Add(lblDiscountVal);
            gbFinancialSummary.Controls.Add(lblDiscount);
            gbFinancialSummary.Controls.Add(lblSubtotalVal);
            gbFinancialSummary.Controls.Add(lblSubtotal);
            gbFinancialSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbFinancialSummary.ForeColor = Color.FromArgb(30, 41, 59);
            gbFinancialSummary.Location = new Point(29, 185);
            gbFinancialSummary.Name = "gbFinancialSummary";
            gbFinancialSummary.Size = new Size(890, 95);
            gbFinancialSummary.TabIndex = 2;
            gbFinancialSummary.TabStop = false;
            gbFinancialSummary.Text = "الملخص والتحليل المالي";
            // 
            // lblRemainingVal
            // 
            lblRemainingVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRemainingVal.AutoSize = true;
            lblRemainingVal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRemainingVal.ForeColor = Color.FromArgb(220, 38, 38);
            lblRemainingVal.Location = new Point(25, 52);
            lblRemainingVal.Name = "lblRemainingVal";
            lblRemainingVal.Size = new Size(71, 28);
            lblRemainingVal.TabIndex = 11;
            lblRemainingVal.Text = "$ 0.00";
            // 
            // lblRemaining
            // 
            lblRemaining.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 9.5F);
            lblRemaining.ForeColor = Color.FromArgb(100, 116, 139);
            lblRemaining.Location = new Point(30, 28);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(62, 21);
            lblRemaining.TabIndex = 10;
            lblRemaining.Text = "المتبقي:";
            // 
            // lblPaidVal
            // 
            lblPaidVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPaidVal.AutoSize = true;
            lblPaidVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPaidVal.ForeColor = Color.FromArgb(22, 163, 74);
            lblPaidVal.Location = new Point(160, 53);
            lblPaidVal.Name = "lblPaidVal";
            lblPaidVal.Size = new Size(66, 25);
            lblPaidVal.TabIndex = 9;
            lblPaidVal.Text = "$ 0.00";
            // 
            // lblPaid
            // 
            lblPaid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPaid.AutoSize = true;
            lblPaid.Font = new Font("Segoe UI", 9.5F);
            lblPaid.ForeColor = Color.FromArgb(100, 116, 139);
            lblPaid.Location = new Point(145, 28);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(112, 21);
            lblPaid.TabIndex = 8;
            lblPaid.Text = "إجمالي المدفوع:";
            // 
            // lblTotalVal
            // 
            lblTotalVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalVal.AutoSize = true;
            lblTotalVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalVal.ForeColor = Color.FromArgb(30, 41, 59);
            lblTotalVal.Location = new Point(310, 53);
            lblTotalVal.Name = "lblTotalVal";
            lblTotalVal.Size = new Size(66, 25);
            lblTotalVal.TabIndex = 7;
            lblTotalVal.Text = "$ 0.00";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5F);
            lblTotal.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotal.Location = new Point(290, 28);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(127, 21);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "الإجمالي المستحق:";
            // 
            // lblTaxVal
            // 
            lblTaxVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTaxVal.AutoSize = true;
            lblTaxVal.Font = new Font("Segoe UI", 9.5F);
            lblTaxVal.Location = new Point(480, 55);
            lblTaxVal.Name = "lblTaxVal";
            lblTaxVal.Size = new Size(53, 21);
            lblTaxVal.TabIndex = 5;
            lblTaxVal.Text = "$ 0.00";
            // 
            // lblTax
            // 
            lblTax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 9.5F);
            lblTax.ForeColor = Color.FromArgb(100, 116, 139);
            lblTax.Location = new Point(475, 28);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(63, 21);
            lblTax.TabIndex = 4;
            lblTax.Text = "الضريبة:";
            // 
            // lblDiscountVal
            // 
            lblDiscountVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDiscountVal.AutoSize = true;
            lblDiscountVal.Font = new Font("Segoe UI", 9.5F);
            lblDiscountVal.Location = new Point(620, 55);
            lblDiscountVal.Name = "lblDiscountVal";
            lblDiscountVal.Size = new Size(53, 21);
            lblDiscountVal.TabIndex = 3;
            lblDiscountVal.Text = "$ 0.00";
            // 
            // lblDiscount
            // 
            lblDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 9.5F);
            lblDiscount.ForeColor = Color.FromArgb(100, 116, 139);
            lblDiscount.Location = new Point(620, 28);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(56, 21);
            lblDiscount.TabIndex = 2;
            lblDiscount.Text = "الخصم:";
            // 
            // lblSubtotalVal
            // 
            lblSubtotalVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubtotalVal.AutoSize = true;
            lblSubtotalVal.Font = new Font("Segoe UI", 9.5F);
            lblSubtotalVal.Location = new Point(740, 55);
            lblSubtotalVal.Name = "lblSubtotalVal";
            lblSubtotalVal.Size = new Size(53, 21);
            lblSubtotalVal.TabIndex = 1;
            lblSubtotalVal.Text = "$ 0.00";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 9.5F);
            lblSubtotal.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtotal.Location = new Point(740, 28);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(115, 21);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "المجموع الفرعي:";
            // 
            // gbPayments
            // 
            gbPayments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPayments.Controls.Add(dgvPayments);
            gbPayments.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbPayments.ForeColor = Color.FromArgb(30, 41, 59);
            gbPayments.Location = new Point(29, 290);
            gbPayments.Name = "gbPayments";
            gbPayments.Size = new Size(890, 278);
            gbPayments.TabIndex = 3;
            gbPayments.TabStop = false;
            gbPayments.Text = "سجل المدفوعات المسجلة للفاتورة";
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Location = new Point(15, 30);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(860, 233);
            dgvPayments.TabIndex = 0;
            // 
            // btnRecordPayment
            // 
            btnRecordPayment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRecordPayment.Cursor = Cursors.Hand;
            btnRecordPayment.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRecordPayment.Location = new Point(265, 583);
            btnRecordPayment.Name = "btnRecordPayment";
            btnRecordPayment.Size = new Size(150, 36);
            btnRecordPayment.TabIndex = 4;
            btnRecordPayment.Text = "تسجيل دفعة";
            btnRecordPayment.UseVisualStyleBackColor = true;
            btnRecordPayment.Click += BtnRecordPayment_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.Font = new Font("Segoe UI", 9.5F);
            btnPrint.Location = new Point(140, 583);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(115, 36);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "طباعة / تصدير";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += BtnPrint_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.Location = new Point(29, 583);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 36);
            btnClose.TabIndex = 6;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // frmInvoiceDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(949, 628);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(btnRecordPayment);
            Controls.Add(gbPayments);
            Controls.Add(gbFinancialSummary);
            Controls.Add(gbInvoiceHeader);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(850, 550);
            Name = "frmInvoiceDetails";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تفاصيل الفاتورة وحركات السداد";
            Load += FrmInvoiceDetails_Load;
            gbInvoiceHeader.ResumeLayout(false);
            gbInvoiceHeader.PerformLayout();
            gbFinancialSummary.ResumeLayout(false);
            gbFinancialSummary.PerformLayout();
            gbPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
