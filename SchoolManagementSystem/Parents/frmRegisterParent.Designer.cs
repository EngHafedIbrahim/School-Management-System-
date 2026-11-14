namespace SchoolManagementSystem.Parents
{
    partial class frmRegisterParent
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
            pnlCard = new Panel();
            lblID = new Label();
            label1 = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlCard.SuspendLayout();
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
            pnlHeader.Size = new Size(677, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Fill;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(23, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(631, 49);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "تسجيل بيانات ولي أمر جديد";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(lblID);
            pnlCard.Controls.Add(label1);
            pnlCard.Controls.Add(txtAddress);
            pnlCard.Controls.Add(lblAddress);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(lblEmail);
            pnlCard.Controls.Add(txtPhoneNumber);
            pnlCard.Controls.Add(lblPhoneNumber);
            pnlCard.Controls.Add(txtLastName);
            pnlCard.Controls.Add(lblLastName);
            pnlCard.Controls.Add(txtFirstName);
            pnlCard.Controls.Add(lblFirstName);
            pnlCard.Location = new Point(29, 95);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(23, 27, 23, 27);
            pnlCard.Size = new Size(620, 390);
            pnlCard.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(100, 116, 139);
            label1.Location = new Point(480, 25);
            label1.Name = "label1";
            label1.Size = new Size(110, 27);
            label1.TabIndex = 10;
            label1.Text = "رقم المعرف:";
            // 
            // lblID
            // 
            lblID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblID.ForeColor = Color.FromArgb(41, 128, 185);
            lblID.Location = new Point(360, 25);
            lblID.Name = "lblID";
            lblID.Size = new Size(110, 27);
            lblID.TabIndex = 11;
            lblID.Text = "-----";
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.FromArgb(33, 37, 41);
            lblFirstName.Location = new Point(470, 75);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(125, 27);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "الاسم الأول: *";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(40, 73);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(420, 30);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextAlign = HorizontalAlignment.Right;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLastName.ForeColor = Color.FromArgb(33, 37, 41);
            lblLastName.Location = new Point(470, 135);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(125, 27);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "اسم العائلة / اللقب: *";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(40, 133);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(420, 30);
            txtLastName.TabIndex = 3;
            txtLastName.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.FromArgb(33, 37, 41);
            lblPhoneNumber.Location = new Point(470, 195);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(125, 27);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "رقم الهاتف: *";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 10F);
            txtPhoneNumber.Location = new Point(40, 193);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(420, 30);
            txtPhoneNumber.TabIndex = 5;
            txtPhoneNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(33, 37, 41);
            lblEmail.Location = new Point(470, 255);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(125, 27);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "البريد الإلكتروني: *";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(40, 253);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(420, 30);
            txtEmail.TabIndex = 7;
            txtEmail.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(33, 37, 41);
            lblAddress.Location = new Point(470, 315);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(125, 27);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "العنوان السكني:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(40, 313);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(420, 30);
            txtAddress.TabIndex = 9;
            txtAddress.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(175, 505);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 44);
            btnSave.TabIndex = 2;
            btnSave.Text = "💾 حفظ البيانات";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.Location = new Point(29, 505);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 44);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // frmRegisterParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(677, 570);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegisterParent";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تسجيل بيانات ولي أمر";
            pnlHeader.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Label lblID;
        private Label label1;
    }
}
