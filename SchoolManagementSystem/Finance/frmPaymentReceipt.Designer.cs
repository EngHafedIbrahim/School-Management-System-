namespace SchoolManagementSystem.Finance
{
    partial class frmPaymentReceipt
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
            pnlReceiptCard = new Panel();
            pnlSignatures = new Panel();
            lblAccountantSign = new Label();
            lblParentSign = new Label();
            gbPaymentDetails = new GroupBox();
            lblNotes = new Label();
            lblNotesTitle = new Label();
            lblReceivedBy = new Label();
            lblReceivedByTitle = new Label();
            lblTransactionID = new Label();
            lblTransactionTitle = new Label();
            lblMethod = new Label();
            lblMethodTitle = new Label();
            lblAmount = new Label();
            lblAmountTitle = new Label();
            gbInvoiceSummary = new GroupBox();
            lblRemaining = new Label();
            lblRemainingTitle = new Label();
            lblTotalPaid = new Label();
            lblTotalPaidTitle = new Label();
            lblInvoiceTotal = new Label();
            lblInvoiceTotalTitle = new Label();
            lblInvoiceNum = new Label();
            lblInvoiceNumTitle = new Label();
            gbStudentInfo = new GroupBox();
            lblYear = new Label();
            lblYearTitle = new Label();
            lblAdmNo = new Label();
            lblAdmNoTitle = new Label();
            lblStudentName = new Label();
            lblStudentNameTitle = new Label();
            pnlReceiptHeader = new Panel();
            lblReceiptDate = new Label();
            lblReceiptNumber = new Label();
            lblSchoolSubtitle = new Label();
            lblSchoolTitle = new Label();
            btnPrint = new Button();
            btnClose = new Button();
            pnlReceiptCard.SuspendLayout();
            pnlSignatures.SuspendLayout();
            gbPaymentDetails.SuspendLayout();
            gbInvoiceSummary.SuspendLayout();
            gbStudentInfo.SuspendLayout();
            pnlReceiptHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlReceiptCard
            // 
            pnlReceiptCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlReceiptCard.BackColor = Color.White;
            pnlReceiptCard.BorderStyle = BorderStyle.FixedSingle;
            pnlReceiptCard.Controls.Add(pnlSignatures);
            pnlReceiptCard.Controls.Add(gbPaymentDetails);
            pnlReceiptCard.Controls.Add(gbInvoiceSummary);
            pnlReceiptCard.Controls.Add(gbStudentInfo);
            pnlReceiptCard.Controls.Add(pnlReceiptHeader);
            pnlReceiptCard.Location = new Point(24, 20);
            pnlReceiptCard.Name = "pnlReceiptCard";
            pnlReceiptCard.Size = new Size(686, 680);
            pnlReceiptCard.TabIndex = 0;
            // 
            // pnlSignatures
            // 
            pnlSignatures.Controls.Add(lblAccountantSign);
            pnlSignatures.Controls.Add(lblParentSign);
            pnlSignatures.Dock = DockStyle.Bottom;
            pnlSignatures.Location = new Point(0, 608);
            pnlSignatures.Name = "pnlSignatures";
            pnlSignatures.Size = new Size(684, 70);
            pnlSignatures.TabIndex = 4;
            // 
            // lblAccountantSign
            // 
            lblAccountantSign.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAccountantSign.AutoSize = true;
            lblAccountantSign.Font = new Font("Segoe UI", 9F);
            lblAccountantSign.ForeColor = Color.FromArgb(71, 85, 105);
            lblAccountantSign.Location = new Point(440, 15);
            lblAccountantSign.Name = "lblAccountantSign";
            lblAccountantSign.Size = new Size(205, 40);
            lblAccountantSign.TabIndex = 1;
            lblAccountantSign.Text = "_________________________\r\nتوقيع المحاسب / الختم الرسمي";
            lblAccountantSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblParentSign
            // 
            lblParentSign.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblParentSign.AutoSize = true;
            lblParentSign.Font = new Font("Segoe UI", 9F);
            lblParentSign.ForeColor = Color.FromArgb(71, 85, 105);
            lblParentSign.Location = new Point(35, 15);
            lblParentSign.Name = "lblParentSign";
            lblParentSign.Size = new Size(185, 40);
            lblParentSign.TabIndex = 0;
            lblParentSign.Text = "_________________________\r\nتوقيع المستلم / ولي الأمر";
            lblParentSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbPaymentDetails
            // 
            gbPaymentDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbPaymentDetails.Controls.Add(lblNotes);
            gbPaymentDetails.Controls.Add(lblNotesTitle);
            gbPaymentDetails.Controls.Add(lblReceivedBy);
            gbPaymentDetails.Controls.Add(lblReceivedByTitle);
            gbPaymentDetails.Controls.Add(lblTransactionID);
            gbPaymentDetails.Controls.Add(lblTransactionTitle);
            gbPaymentDetails.Controls.Add(lblMethod);
            gbPaymentDetails.Controls.Add(lblMethodTitle);
            gbPaymentDetails.Controls.Add(lblAmount);
            gbPaymentDetails.Controls.Add(lblAmountTitle);
            gbPaymentDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbPaymentDetails.ForeColor = Color.FromArgb(44, 62, 80);
            gbPaymentDetails.Location = new Point(25, 395);
            gbPaymentDetails.Name = "gbPaymentDetails";
            gbPaymentDetails.Size = new Size(634, 195);
            gbPaymentDetails.TabIndex = 3;
            gbPaymentDetails.TabStop = false;
            gbPaymentDetails.Text = "تفاصيل الدفعة المستلمة";
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 9.5F);
            lblNotes.ForeColor = Color.FromArgb(44, 62, 80);
            lblNotes.Location = new Point(50, 155);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(16, 21);
            lblNotes.TabIndex = 9;
            lblNotes.Text = "-";
            // 
            // lblNotesTitle
            // 
            lblNotesTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNotesTitle.AutoSize = true;
            lblNotesTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNotesTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblNotesTitle.Location = new Point(485, 155);
            lblNotesTitle.Name = "lblNotesTitle";
            lblNotesTitle.Size = new Size(106, 21);
            lblNotesTitle.TabIndex = 8;
            lblNotesTitle.Text = "ملاحظات السند:";
            // 
            // lblReceivedBy
            // 
            lblReceivedBy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblReceivedBy.AutoSize = true;
            lblReceivedBy.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblReceivedBy.ForeColor = Color.FromArgb(44, 62, 80);
            lblReceivedBy.Location = new Point(50, 118);
            lblReceivedBy.Name = "lblReceivedBy";
            lblReceivedBy.Size = new Size(16, 21);
            lblReceivedBy.TabIndex = 7;
            lblReceivedBy.Text = "-";
            // 
            // lblReceivedByTitle
            // 
            lblReceivedByTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblReceivedByTitle.AutoSize = true;
            lblReceivedByTitle.Font = new Font("Segoe UI", 9.5F);
            lblReceivedByTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblReceivedByTitle.Location = new Point(160, 118);
            lblReceivedByTitle.Name = "lblReceivedByTitle";
            lblReceivedByTitle.Size = new Size(111, 21);
            lblReceivedByTitle.TabIndex = 6;
            lblReceivedByTitle.Text = "المستلم بواسطة:";
            // 
            // lblTransactionID
            // 
            lblTransactionID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTransactionID.AutoSize = true;
            lblTransactionID.Font = new Font("Segoe UI", 9.5F);
            lblTransactionID.ForeColor = Color.FromArgb(44, 62, 80);
            lblTransactionID.Location = new Point(310, 118);
            lblTransactionID.Name = "lblTransactionID";
            lblTransactionID.Size = new Size(16, 21);
            lblTransactionID.TabIndex = 5;
            lblTransactionID.Text = "-";
            // 
            // lblTransactionTitle
            // 
            lblTransactionTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTransactionTitle.AutoSize = true;
            lblTransactionTitle.Font = new Font("Segoe UI", 9.5F);
            lblTransactionTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblTransactionTitle.Location = new Point(485, 118);
            lblTransactionTitle.Name = "lblTransactionTitle";
            lblTransactionTitle.Size = new Size(137, 21);
            lblTransactionTitle.TabIndex = 4;
            lblTransactionTitle.Text = "رقم العملية / الحوالة:";
            // 
            // lblMethod
            // 
            lblMethod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMethod.AutoSize = true;
            lblMethod.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMethod.ForeColor = Color.FromArgb(41, 128, 185);
            lblMethod.Location = new Point(310, 80);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(41, 23);
            lblMethod.TabIndex = 3;
            lblMethod.Text = "نقداً";
            // 
            // lblMethodTitle
            // 
            lblMethodTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMethodTitle.AutoSize = true;
            lblMethodTitle.Font = new Font("Segoe UI", 9.5F);
            lblMethodTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblMethodTitle.Location = new Point(485, 80);
            lblMethodTitle.Name = "lblMethodTitle";
            lblMethodTitle.Size = new Size(84, 21);
            lblMethodTitle.TabIndex = 2;
            lblMethodTitle.Text = "طريقة الدفع:";
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(39, 174, 96);
            lblAmount.Location = new Point(250, 26);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(106, 41);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "0.00 د.أ";
            // 
            // lblAmountTitle
            // 
            lblAmountTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAmountTitle.AutoSize = true;
            lblAmountTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAmountTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblAmountTitle.Location = new Point(485, 38);
            lblAmountTitle.Name = "lblAmountTitle";
            lblAmountTitle.Size = new Size(119, 23);
            lblAmountTitle.TabIndex = 0;
            lblAmountTitle.Text = "المبلغ المقبوض:";
            // 
            // gbInvoiceSummary
            // 
            gbInvoiceSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbInvoiceSummary.Controls.Add(lblRemaining);
            gbInvoiceSummary.Controls.Add(lblRemainingTitle);
            gbInvoiceSummary.Controls.Add(lblTotalPaid);
            gbInvoiceSummary.Controls.Add(lblTotalPaidTitle);
            gbInvoiceSummary.Controls.Add(lblInvoiceTotal);
            gbInvoiceSummary.Controls.Add(lblInvoiceTotalTitle);
            gbInvoiceSummary.Controls.Add(lblInvoiceNum);
            gbInvoiceSummary.Controls.Add(lblInvoiceNumTitle);
            gbInvoiceSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbInvoiceSummary.ForeColor = Color.FromArgb(44, 62, 80);
            gbInvoiceSummary.Location = new Point(25, 255);
            gbInvoiceSummary.Name = "gbInvoiceSummary";
            gbInvoiceSummary.Size = new Size(634, 125);
            gbInvoiceSummary.TabIndex = 2;
            gbInvoiceSummary.TabStop = false;
            gbInvoiceSummary.Text = "ملخص رصيد الفاتورة";
            // 
            // lblRemaining
            // 
            lblRemaining.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRemaining.ForeColor = Color.FromArgb(192, 57, 43);
            lblRemaining.Location = new Point(50, 78);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(76, 25);
            lblRemaining.TabIndex = 7;
            lblRemaining.Text = "0.00 د.أ";
            // 
            // lblRemainingTitle
            // 
            lblRemainingTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRemainingTitle.AutoSize = true;
            lblRemainingTitle.Font = new Font("Segoe UI", 9.5F);
            lblRemainingTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblRemainingTitle.Location = new Point(160, 80);
            lblRemainingTitle.Name = "lblRemainingTitle";
            lblRemainingTitle.Size = new Size(106, 21);
            lblRemainingTitle.TabIndex = 6;
            lblRemainingTitle.Text = "الرصيد المتبقي:";
            // 
            // lblTotalPaid
            // 
            lblTotalPaid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalPaid.AutoSize = true;
            lblTotalPaid.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalPaid.ForeColor = Color.FromArgb(39, 174, 96);
            lblTotalPaid.Location = new Point(320, 80);
            lblTotalPaid.Name = "lblTotalPaid";
            lblTotalPaid.Size = new Size(70, 23);
            lblTotalPaid.TabIndex = 5;
            lblTotalPaid.Text = "0.00 د.أ";
            // 
            // lblTotalPaidTitle
            // 
            lblTotalPaidTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalPaidTitle.AutoSize = true;
            lblTotalPaidTitle.Font = new Font("Segoe UI", 9.5F);
            lblTotalPaidTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblTotalPaidTitle.Location = new Point(485, 80);
            lblTotalPaidTitle.Name = "lblTotalPaidTitle";
            lblTotalPaidTitle.Size = new Size(111, 21);
            lblTotalPaidTitle.TabIndex = 4;
            lblTotalPaidTitle.Text = "إجمالي المسدد:";
            // 
            // lblInvoiceTotal
            // 
            lblInvoiceTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInvoiceTotal.AutoSize = true;
            lblInvoiceTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInvoiceTotal.ForeColor = Color.FromArgb(44, 62, 80);
            lblInvoiceTotal.Location = new Point(50, 36);
            lblInvoiceTotal.Name = "lblInvoiceTotal";
            lblInvoiceTotal.Size = new Size(70, 23);
            lblInvoiceTotal.TabIndex = 3;
            lblInvoiceTotal.Text = "0.00 د.أ";
            // 
            // lblInvoiceTotalTitle
            // 
            lblInvoiceTotalTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInvoiceTotalTitle.AutoSize = true;
            lblInvoiceTotalTitle.Font = new Font("Segoe UI", 9.5F);
            lblInvoiceTotalTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblInvoiceTotalTitle.Location = new Point(160, 36);
            lblInvoiceTotalTitle.Name = "lblInvoiceTotalTitle";
            lblInvoiceTotalTitle.Size = new Size(99, 21);
            lblInvoiceTotalTitle.TabIndex = 2;
            lblInvoiceTotalTitle.Text = "إجمالي الفاتورة:";
            // 
            // lblInvoiceNum
            // 
            lblInvoiceNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInvoiceNum.AutoSize = true;
            lblInvoiceNum.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInvoiceNum.ForeColor = Color.FromArgb(41, 128, 185);
            lblInvoiceNum.Location = new Point(320, 36);
            lblInvoiceNum.Name = "lblInvoiceNum";
            lblInvoiceNum.Size = new Size(17, 23);
            lblInvoiceNum.TabIndex = 1;
            lblInvoiceNum.Text = "-";
            // 
            // lblInvoiceNumTitle
            // 
            lblInvoiceNumTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInvoiceNumTitle.AutoSize = true;
            lblInvoiceNumTitle.Font = new Font("Segoe UI", 9.5F);
            lblInvoiceNumTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblInvoiceNumTitle.Location = new Point(485, 36);
            lblInvoiceNumTitle.Name = "lblInvoiceNumTitle";
            lblInvoiceNumTitle.Size = new Size(89, 21);
            lblInvoiceNumTitle.TabIndex = 0;
            lblInvoiceNumTitle.Text = "رقم الفاتورة:";
            // 
            // gbStudentInfo
            // 
            gbStudentInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbStudentInfo.Controls.Add(lblYear);
            gbStudentInfo.Controls.Add(lblYearTitle);
            gbStudentInfo.Controls.Add(lblAdmNo);
            gbStudentInfo.Controls.Add(lblAdmNoTitle);
            gbStudentInfo.Controls.Add(lblStudentName);
            gbStudentInfo.Controls.Add(lblStudentNameTitle);
            gbStudentInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbStudentInfo.ForeColor = Color.FromArgb(44, 62, 80);
            gbStudentInfo.Location = new Point(25, 125);
            gbStudentInfo.Name = "gbStudentInfo";
            gbStudentInfo.Size = new Size(634, 115);
            gbStudentInfo.TabIndex = 1;
            gbStudentInfo.TabStop = false;
            gbStudentInfo.Text = "بيانات الطالب المقيد";
            // 
            // lblYear
            // 
            lblYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9.5F);
            lblYear.ForeColor = Color.FromArgb(44, 62, 80);
            lblYear.Location = new Point(50, 72);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(16, 21);
            lblYear.TabIndex = 5;
            lblYear.Text = "-";
            // 
            // lblYearTitle
            // 
            lblYearTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblYearTitle.AutoSize = true;
            lblYearTitle.Font = new Font("Segoe UI", 9.5F);
            lblYearTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblYearTitle.Location = new Point(160, 72);
            lblYearTitle.Name = "lblYearTitle";
            lblYearTitle.Size = new Size(106, 21);
            lblYearTitle.TabIndex = 4;
            lblYearTitle.Text = "العام الدراسي:";
            // 
            // lblAdmNo
            // 
            lblAdmNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdmNo.AutoSize = true;
            lblAdmNo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAdmNo.ForeColor = Color.FromArgb(44, 62, 80);
            lblAdmNo.Location = new Point(320, 72);
            lblAdmNo.Name = "lblAdmNo";
            lblAdmNo.Size = new Size(16, 21);
            lblAdmNo.TabIndex = 3;
            lblAdmNo.Text = "-";
            // 
            // lblAdmNoTitle
            // 
            lblAdmNoTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdmNoTitle.AutoSize = true;
            lblAdmNoTitle.Font = new Font("Segoe UI", 9.5F);
            lblAdmNoTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblAdmNoTitle.Location = new Point(485, 72);
            lblAdmNoTitle.Name = "lblAdmNoTitle";
            lblAdmNoTitle.Size = new Size(81, 21);
            lblAdmNoTitle.TabIndex = 2;
            lblAdmNoTitle.Text = "رقم القبول:";
            // 
            // lblStudentName
            // 
            lblStudentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStudentName.ForeColor = Color.FromArgb(44, 62, 80);
            lblStudentName.Location = new Point(250, 32);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(111, 25);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "اسم الطالب";
            // 
            // lblStudentNameTitle
            // 
            lblStudentNameTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStudentNameTitle.AutoSize = true;
            lblStudentNameTitle.Font = new Font("Segoe UI", 9.5F);
            lblStudentNameTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblStudentNameTitle.Location = new Point(485, 34);
            lblStudentNameTitle.Name = "lblStudentNameTitle";
            lblStudentNameTitle.Size = new Size(82, 21);
            lblStudentNameTitle.TabIndex = 0;
            lblStudentNameTitle.Text = "اسم الطالب:";
            // 
            // pnlReceiptHeader
            // 
            pnlReceiptHeader.BackColor = Color.FromArgb(245, 247, 250);
            pnlReceiptHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlReceiptHeader.Controls.Add(lblReceiptDate);
            pnlReceiptHeader.Controls.Add(lblReceiptNumber);
            pnlReceiptHeader.Controls.Add(lblSchoolSubtitle);
            pnlReceiptHeader.Controls.Add(lblSchoolTitle);
            pnlReceiptHeader.Dock = DockStyle.Top;
            pnlReceiptHeader.Location = new Point(0, 0);
            pnlReceiptHeader.Name = "pnlReceiptHeader";
            pnlReceiptHeader.Size = new Size(684, 105);
            pnlReceiptHeader.TabIndex = 0;
            // 
            // lblReceiptDate
            // 
            lblReceiptDate.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblReceiptDate.AutoSize = true;
            lblReceiptDate.Font = new Font("Segoe UI", 9.5F);
            lblReceiptDate.ForeColor = Color.FromArgb(71, 85, 105);
            lblReceiptDate.Location = new Point(24, 56);
            lblReceiptDate.Name = "lblReceiptDate";
            lblReceiptDate.Size = new Size(160, 21);
            lblReceiptDate.TabIndex = 3;
            lblReceiptDate.Text = "التاريخ: 01/01/2026";
            // 
            // lblReceiptNumber
            // 
            lblReceiptNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblReceiptNumber.AutoSize = true;
            lblReceiptNumber.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblReceiptNumber.ForeColor = Color.FromArgb(41, 128, 185);
            lblReceiptNumber.Location = new Point(24, 22);
            lblReceiptNumber.Name = "lblReceiptNumber";
            lblReceiptNumber.Size = new Size(161, 25);
            lblReceiptNumber.TabIndex = 2;
            lblReceiptNumber.Text = "REC-2026-00000";
            // 
            // lblSchoolSubtitle
            // 
            lblSchoolSubtitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSchoolSubtitle.AutoSize = true;
            lblSchoolSubtitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSchoolSubtitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblSchoolSubtitle.Location = new Point(390, 56);
            lblSchoolSubtitle.Name = "lblSchoolSubtitle";
            lblSchoolSubtitle.Size = new Size(270, 21);
            lblSchoolSubtitle.TabIndex = 1;
            lblSchoolSubtitle.Text = "سند قبض مالي رسمي - قسم الحسابات";
            // 
            // lblSchoolTitle
            // 
            lblSchoolTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSchoolTitle.AutoSize = true;
            lblSchoolTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSchoolTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblSchoolTitle.Location = new Point(410, 16);
            lblSchoolTitle.Name = "lblSchoolTitle";
            lblSchoolTitle.Size = new Size(250, 35);
            lblSchoolTitle.TabIndex = 0;
            lblSchoolTitle.Text = "نظام إدارة المدارس";
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrint.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrint.Location = new Point(140, 715);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(140, 42);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "🖨 طباعة السند";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += BtnPrint_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.Location = new Point(24, 715);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 42);
            btnClose.TabIndex = 2;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // frmPaymentReceipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(734, 770);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(pnlReceiptCard);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPaymentReceipt";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "سند قبض مالي رسمي";
            Load += FrmPaymentReceipt_Load;
            pnlReceiptCard.ResumeLayout(false);
            pnlSignatures.ResumeLayout(false);
            pnlSignatures.PerformLayout();
            gbPaymentDetails.ResumeLayout(false);
            gbPaymentDetails.PerformLayout();
            gbInvoiceSummary.ResumeLayout(false);
            gbInvoiceSummary.PerformLayout();
            gbStudentInfo.ResumeLayout(false);
            gbStudentInfo.PerformLayout();
            pnlReceiptHeader.ResumeLayout(false);
            pnlReceiptHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlReceiptCard;
        private System.Windows.Forms.Panel pnlReceiptHeader;
        private System.Windows.Forms.Label lblSchoolTitle;
        private System.Windows.Forms.Label lblSchoolSubtitle;
        private System.Windows.Forms.Label lblReceiptNumber;
        private System.Windows.Forms.Label lblReceiptDate;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.Label lblStudentNameTitle;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblAdmNoTitle;
        private System.Windows.Forms.Label lblAdmNo;
        private System.Windows.Forms.Label lblYearTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox gbInvoiceSummary;
        private System.Windows.Forms.Label lblInvoiceNumTitle;
        private System.Windows.Forms.Label lblInvoiceNum;
        private System.Windows.Forms.Label lblInvoiceTotalTitle;
        private System.Windows.Forms.Label lblInvoiceTotal;
        private System.Windows.Forms.Label lblTotalPaidTitle;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label lblRemainingTitle;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.GroupBox gbPaymentDetails;
        private System.Windows.Forms.Label lblAmountTitle;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMethodTitle;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblTransactionTitle;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.Label lblReceivedByTitle;
        private System.Windows.Forms.Label lblReceivedBy;
        private System.Windows.Forms.Label lblNotesTitle;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Panel pnlSignatures;
        private System.Windows.Forms.Label lblParentSign;
        private System.Windows.Forms.Label lblAccountantSign;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
    }
}
