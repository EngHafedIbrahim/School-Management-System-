namespace SchoolManagementSystem.Finance
{
    partial class frmRecordPayment
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
            lblTitle = new Label();
            gbInvoiceInfo = new GroupBox();
            lblRemainingVal = new Label();
            lblRemaining = new Label();
            lblPaidVal = new Label();
            lblPaid = new Label();
            lblTotalVal = new Label();
            lblTotal = new Label();
            lblStudentNameVal = new Label();
            lblStudentName = new Label();
            lblInvoiceNoVal = new Label();
            lblInvoiceNo = new Label();
            gbPaymentDetails = new GroupBox();
            txtNotes = new TextBox();
            lblNotes = new Label();
            txtReceiptNo = new TextBox();
            lblReceiptNo = new Label();
            cbPaymentType = new ComboBox();
            lblPaymentType = new Label();
            dtpPaymentDate = new DateTimePicker();
            lblPaymentDate = new Label();
            numAmount = new NumericUpDown();
            lblAmount = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            gbInvoiceInfo.SuspendLayout();
            gbPaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(24, 15, 24, 15);
            pnlHeader.Size = new Size(620, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(178, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(275, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "تسجيل دفعة مالية لطالب";
            // 
            // gbInvoiceInfo
            // 
            gbInvoiceInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbInvoiceInfo.Controls.Add(lblRemainingVal);
            gbInvoiceInfo.Controls.Add(lblRemaining);
            gbInvoiceInfo.Controls.Add(lblPaidVal);
            gbInvoiceInfo.Controls.Add(lblPaid);
            gbInvoiceInfo.Controls.Add(lblTotalVal);
            gbInvoiceInfo.Controls.Add(lblTotal);
            gbInvoiceInfo.Controls.Add(lblStudentNameVal);
            gbInvoiceInfo.Controls.Add(lblStudentName);
            gbInvoiceInfo.Controls.Add(lblInvoiceNoVal);
            gbInvoiceInfo.Controls.Add(lblInvoiceNo);
            gbInvoiceInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbInvoiceInfo.ForeColor = Color.FromArgb(44, 62, 80);
            gbInvoiceInfo.Location = new Point(24, 75);
            gbInvoiceInfo.Name = "gbInvoiceInfo";
            gbInvoiceInfo.Size = new Size(572, 140);
            gbInvoiceInfo.TabIndex = 1;
            gbInvoiceInfo.TabStop = false;
            gbInvoiceInfo.Text = "بيانات الفاتورة المستحقة";
            // 
            // lblRemainingVal
            // 
            lblRemainingVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRemainingVal.AutoSize = true;
            lblRemainingVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRemainingVal.ForeColor = Color.FromArgb(220, 53, 69);
            lblRemainingVal.Location = new Point(25, 95);
            lblRemainingVal.Name = "lblRemainingVal";
            lblRemainingVal.Size = new Size(75, 25);
            lblRemainingVal.TabIndex = 9;
            lblRemainingVal.Text = "0.00 د.أ";
            // 
            // lblRemaining
            // 
            lblRemaining.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 9.5F);
            lblRemaining.ForeColor = Color.FromArgb(120, 130, 140);
            lblRemaining.Location = new Point(115, 97);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(103, 21);
            lblRemaining.TabIndex = 8;
            lblRemaining.Text = "المبلغ المتبقي:";
            // 
            // lblPaidVal
            // 
            lblPaidVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPaidVal.AutoSize = true;
            lblPaidVal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblPaidVal.ForeColor = Color.FromArgb(46, 204, 113);
            lblPaidVal.Location = new Point(225, 95);
            lblPaidVal.Name = "lblPaidVal";
            lblPaidVal.Size = new Size(71, 25);
            lblPaidVal.TabIndex = 7;
            lblPaidVal.Text = "0.00 د.أ";
            // 
            // lblPaid
            // 
            lblPaid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPaid.AutoSize = true;
            lblPaid.Font = new Font("Segoe UI", 9.5F);
            lblPaid.ForeColor = Color.FromArgb(120, 130, 140);
            lblPaid.Location = new Point(305, 97);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(60, 21);
            lblPaid.TabIndex = 6;
            lblPaid.Text = "المسدد:";
            // 
            // lblTotalVal
            // 
            lblTotalVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalVal.AutoSize = true;
            lblTotalVal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTotalVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotalVal.Location = new Point(380, 95);
            lblTotalVal.Name = "lblTotalVal";
            lblTotalVal.Size = new Size(71, 25);
            lblTotalVal.TabIndex = 5;
            lblTotalVal.Text = "0.00 د.أ";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5F);
            lblTotal.ForeColor = Color.FromArgb(120, 130, 140);
            lblTotal.Location = new Point(460, 97);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(109, 21);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "إجمالي الفاتورة:";
            // 
            // lblStudentNameVal
            // 
            lblStudentNameVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStudentNameVal.AutoSize = true;
            lblStudentNameVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudentNameVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblStudentNameVal.Location = new Point(25, 40);
            lblStudentNameVal.Name = "lblStudentNameVal";
            lblStudentNameVal.Size = new Size(31, 23);
            lblStudentNameVal.TabIndex = 3;
            lblStudentNameVal.Text = "---";
            // 
            // lblStudentName
            // 
            lblStudentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 9.5F);
            lblStudentName.ForeColor = Color.FromArgb(120, 130, 140);
            lblStudentName.Location = new Point(200, 40);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(89, 21);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "اسم الطالب:";
            // 
            // lblInvoiceNoVal
            // 
            lblInvoiceNoVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInvoiceNoVal.AutoSize = true;
            lblInvoiceNoVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInvoiceNoVal.ForeColor = Color.FromArgb(41, 128, 185);
            lblInvoiceNoVal.Location = new Point(320, 40);
            lblInvoiceNoVal.Name = "lblInvoiceNoVal";
            lblInvoiceNoVal.Size = new Size(31, 23);
            lblInvoiceNoVal.TabIndex = 1;
            lblInvoiceNoVal.Text = "---";
            // 
            // lblInvoiceNo
            // 
            lblInvoiceNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInvoiceNo.AutoSize = true;
            lblInvoiceNo.Font = new Font("Segoe UI", 9.5F);
            lblInvoiceNo.ForeColor = Color.FromArgb(120, 130, 140);
            lblInvoiceNo.Location = new Point(470, 40);
            lblInvoiceNo.Name = "lblInvoiceNo";
            lblInvoiceNo.Size = new Size(88, 21);
            lblInvoiceNo.TabIndex = 0;
            lblInvoiceNo.Text = "رقم الفاتورة:";
            // 
            // gbPaymentDetails
            // 
            gbPaymentDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPaymentDetails.Controls.Add(txtNotes);
            gbPaymentDetails.Controls.Add(lblNotes);
            gbPaymentDetails.Controls.Add(txtReceiptNo);
            gbPaymentDetails.Controls.Add(lblReceiptNo);
            gbPaymentDetails.Controls.Add(cbPaymentType);
            gbPaymentDetails.Controls.Add(lblPaymentType);
            gbPaymentDetails.Controls.Add(dtpPaymentDate);
            gbPaymentDetails.Controls.Add(lblPaymentDate);
            gbPaymentDetails.Controls.Add(numAmount);
            gbPaymentDetails.Controls.Add(lblAmount);
            gbPaymentDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbPaymentDetails.ForeColor = Color.FromArgb(44, 62, 80);
            gbPaymentDetails.Location = new Point(24, 225);
            gbPaymentDetails.Name = "gbPaymentDetails";
            gbPaymentDetails.Size = new Size(572, 235);
            gbPaymentDetails.TabIndex = 2;
            gbPaymentDetails.TabStop = false;
            gbPaymentDetails.Text = "تفاصيل الدفعة المالية";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNotes.Font = new Font("Segoe UI", 9.5F);
            txtNotes.Location = new Point(25, 175);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(375, 48);
            txtNotes.TabIndex = 9;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 9.5F);
            lblNotes.ForeColor = Color.FromArgb(44, 62, 80);
            lblNotes.Location = new Point(415, 178);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(121, 21);
            lblNotes.TabIndex = 8;
            lblNotes.Text = "ملاحظات إضافية:";
            // 
            // txtReceiptNo
            // 
            txtReceiptNo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtReceiptNo.Font = new Font("Segoe UI", 9.5F);
            txtReceiptNo.Location = new Point(25, 138);
            txtReceiptNo.Name = "txtReceiptNo";
            txtReceiptNo.Size = new Size(375, 29);
            txtReceiptNo.TabIndex = 7;
            // 
            // lblReceiptNo
            // 
            lblReceiptNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblReceiptNo.AutoSize = true;
            lblReceiptNo.Font = new Font("Segoe UI", 9.5F);
            lblReceiptNo.ForeColor = Color.FromArgb(44, 62, 80);
            lblReceiptNo.Location = new Point(415, 141);
            lblReceiptNo.Name = "lblReceiptNo";
            lblReceiptNo.Size = new Size(127, 21);
            lblReceiptNo.TabIndex = 6;
            lblReceiptNo.Text = "رقم إيصال القبض:";
            // 
            // cbPaymentType
            // 
            cbPaymentType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentType.Font = new Font("Segoe UI", 9.5F);
            cbPaymentType.FormattingEnabled = true;
            cbPaymentType.Location = new Point(25, 101);
            cbPaymentType.Name = "cbPaymentType";
            cbPaymentType.Size = new Size(375, 29);
            cbPaymentType.TabIndex = 5;
            // 
            // lblPaymentType
            // 
            lblPaymentType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPaymentType.AutoSize = true;
            lblPaymentType.Font = new Font("Segoe UI", 9.5F);
            lblPaymentType.ForeColor = Color.FromArgb(44, 62, 80);
            lblPaymentType.Location = new Point(415, 104);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new Size(93, 21);
            lblPaymentType.TabIndex = 4;
            lblPaymentType.Text = "طريقة الدفع:";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpPaymentDate.Font = new Font("Segoe UI", 9.5F);
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(25, 65);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(375, 29);
            dtpPaymentDate.TabIndex = 3;
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Font = new Font("Segoe UI", 9.5F);
            lblPaymentDate.ForeColor = Color.FromArgb(44, 62, 80);
            lblPaymentDate.Location = new Point(415, 68);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(90, 21);
            lblPaymentDate.TabIndex = 2;
            lblPaymentDate.Text = "تاريخ السداد:";
            // 
            // numAmount
            // 
            numAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numAmount.DecimalPlaces = 2;
            numAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            numAmount.Location = new Point(25, 28);
            numAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(375, 30);
            numAmount.TabIndex = 1;
            numAmount.ThousandsSeparator = true;
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 9.5F);
            lblAmount.ForeColor = Color.FromArgb(44, 62, 80);
            lblAmount.Location = new Point(415, 31);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(145, 21);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "المبلغ المدفوع (د.أ): *";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.Location = new Point(145, 472);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 36);
            btnSave.TabIndex = 3;
            btnSave.Text = "💾 حفظ الدفعة";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.Location = new Point(24, 472);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 36);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // frmRecordPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(620, 524);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(gbPaymentDetails);
            Controls.Add(gbInvoiceInfo);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRecordPayment";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تسجيل دفعة طالب";
            Load += FrmRecordPayment_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            gbInvoiceInfo.ResumeLayout(false);
            gbInvoiceInfo.PerformLayout();
            gbPaymentDetails.ResumeLayout(false);
            gbPaymentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbInvoiceInfo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNoVal;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentNameVal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblPaidVal;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblRemainingVal;
        private System.Windows.Forms.GroupBox gbPaymentDetails;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.Label lblReceiptNo;
        private System.Windows.Forms.TextBox txtReceiptNo;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
