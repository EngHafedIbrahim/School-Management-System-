using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Classes
{
    partial class frmAddEditClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditClass));
            pnlHeader = new Panel();
            lblHeaderTitle = new Label();
            pnlCard = new Panel();
            txtDetails = new TextBox();
            lblDetails = new Label();
            cbGradeLevels = new ComboBox();
            lblGradeLevel = new Label();
            txtName = new TextBox();
            lblName = new Label();
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
            resources.ApplyResources(pnlHeader, "pnlHeader");
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblHeaderTitle);
            errorProvider1.SetError(pnlHeader, resources.GetString("pnlHeader.Error"));
            errorProvider1.SetIconAlignment(pnlHeader, (ErrorIconAlignment)resources.GetObject("pnlHeader.IconAlignment"));
            errorProvider1.SetIconPadding(pnlHeader, (int)resources.GetObject("pnlHeader.IconPadding"));
            pnlHeader.Name = "pnlHeader";
            // 
            // lblHeaderTitle
            // 
            resources.ApplyResources(lblHeaderTitle, "lblHeaderTitle");
            errorProvider1.SetError(lblHeaderTitle, resources.GetString("lblHeaderTitle.Error"));
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            errorProvider1.SetIconAlignment(lblHeaderTitle, (ErrorIconAlignment)resources.GetObject("lblHeaderTitle.IconAlignment"));
            errorProvider1.SetIconPadding(lblHeaderTitle, (int)resources.GetObject("lblHeaderTitle.IconPadding"));
            lblHeaderTitle.Name = "lblHeaderTitle";
            // 
            // pnlCard
            // 
            resources.ApplyResources(pnlCard, "pnlCard");
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(txtDetails);
            pnlCard.Controls.Add(lblDetails);
            pnlCard.Controls.Add(cbGradeLevels);
            pnlCard.Controls.Add(lblGradeLevel);
            pnlCard.Controls.Add(txtName);
            pnlCard.Controls.Add(lblName);
            errorProvider1.SetError(pnlCard, resources.GetString("pnlCard.Error"));
            errorProvider1.SetIconAlignment(pnlCard, (ErrorIconAlignment)resources.GetObject("pnlCard.IconAlignment"));
            errorProvider1.SetIconPadding(pnlCard, (int)resources.GetObject("pnlCard.IconPadding"));
            pnlCard.Name = "pnlCard";
            // 
            // txtDetails
            // 
            resources.ApplyResources(txtDetails, "txtDetails");
            errorProvider1.SetError(txtDetails, resources.GetString("txtDetails.Error"));
            errorProvider1.SetIconAlignment(txtDetails, (ErrorIconAlignment)resources.GetObject("txtDetails.IconAlignment"));
            errorProvider1.SetIconPadding(txtDetails, (int)resources.GetObject("txtDetails.IconPadding"));
            txtDetails.Name = "txtDetails";
            // 
            // lblDetails
            // 
            resources.ApplyResources(lblDetails, "lblDetails");
            errorProvider1.SetError(lblDetails, resources.GetString("lblDetails.Error"));
            lblDetails.ForeColor = Color.FromArgb(33, 37, 41);
            errorProvider1.SetIconAlignment(lblDetails, (ErrorIconAlignment)resources.GetObject("lblDetails.IconAlignment"));
            errorProvider1.SetIconPadding(lblDetails, (int)resources.GetObject("lblDetails.IconPadding"));
            lblDetails.Name = "lblDetails";
            // 
            // cbGradeLevels
            // 
            resources.ApplyResources(cbGradeLevels, "cbGradeLevels");
            cbGradeLevels.DropDownStyle = ComboBoxStyle.DropDownList;
            errorProvider1.SetError(cbGradeLevels, resources.GetString("cbGradeLevels.Error"));
            cbGradeLevels.FormattingEnabled = true;
            errorProvider1.SetIconAlignment(cbGradeLevels, (ErrorIconAlignment)resources.GetObject("cbGradeLevels.IconAlignment"));
            errorProvider1.SetIconPadding(cbGradeLevels, (int)resources.GetObject("cbGradeLevels.IconPadding"));
            cbGradeLevels.Name = "cbGradeLevels";
            // 
            // lblGradeLevel
            // 
            resources.ApplyResources(lblGradeLevel, "lblGradeLevel");
            errorProvider1.SetError(lblGradeLevel, resources.GetString("lblGradeLevel.Error"));
            lblGradeLevel.ForeColor = Color.FromArgb(33, 37, 41);
            errorProvider1.SetIconAlignment(lblGradeLevel, (ErrorIconAlignment)resources.GetObject("lblGradeLevel.IconAlignment"));
            errorProvider1.SetIconPadding(lblGradeLevel, (int)resources.GetObject("lblGradeLevel.IconPadding"));
            lblGradeLevel.Name = "lblGradeLevel";
            // 
            // txtName
            // 
            resources.ApplyResources(txtName, "txtName");
            errorProvider1.SetError(txtName, resources.GetString("txtName.Error"));
            errorProvider1.SetIconAlignment(txtName, (ErrorIconAlignment)resources.GetObject("txtName.IconAlignment"));
            errorProvider1.SetIconPadding(txtName, (int)resources.GetObject("txtName.IconPadding"));
            txtName.Name = "txtName";
            // 
            // lblName
            // 
            resources.ApplyResources(lblName, "lblName");
            errorProvider1.SetError(lblName, resources.GetString("lblName.Error"));
            lblName.ForeColor = Color.FromArgb(33, 37, 41);
            errorProvider1.SetIconAlignment(lblName, (ErrorIconAlignment)resources.GetObject("lblName.IconAlignment"));
            errorProvider1.SetIconPadding(lblName, (int)resources.GetObject("lblName.IconPadding"));
            lblName.Name = "lblName";
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.Cursor = Cursors.Hand;
            errorProvider1.SetError(btnSave, resources.GetString("btnSave.Error"));
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.ForeColor = Color.White;
            errorProvider1.SetIconAlignment(btnSave, (ErrorIconAlignment)resources.GetObject("btnSave.IconAlignment"));
            errorProvider1.SetIconPadding(btnSave, (int)resources.GetObject("btnSave.IconPadding"));
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Cursor = Cursors.Hand;
            errorProvider1.SetError(btnCancel, resources.GetString("btnCancel.Error"));
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            errorProvider1.SetIconAlignment(btnCancel, (ErrorIconAlignment)resources.GetObject("btnCancel.IconAlignment"));
            errorProvider1.SetIconPadding(btnCancel, (int)resources.GetObject("btnCancel.IconPadding"));
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            resources.ApplyResources(errorProvider1, "errorProvider1");
            // 
            // frmAddEditClass
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditClass";
            Load += FrmAddEditClass_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGradeLevel;
        private System.Windows.Forms.ComboBox cbGradeLevels;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
