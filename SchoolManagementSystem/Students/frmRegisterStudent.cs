using SchoolManagementSystem.Globle_Classes;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Enrollment;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UtilityLib;

namespace SchoolManagementSystem.Students
{
    public partial class frmRegisterStudent : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        private int _StudentID = -1;
        private clsStudent _Student;
        string _PathImage;
        string _DestenationImage;

        public int StudentID => _StudentID;

        public frmRegisterStudent(int studentID = -1)
        {
            InitializeComponent();

            _PathImage = "";
            _DestenationImage = @"C:\SchoolManagementImages\";

            _StudentID = studentID;
            _Mode = (_StudentID == -1) ? enMode.AddNew : enMode.Update;

            this.Text = _Mode == enMode.AddNew ? "تسجيل وقيد طالب جديد" : "تعديل بيانات الطالب";
            lblHeaderTitle.Text = _Mode == enMode.AddNew ? "تسجيل وقيد طالب جديد" : "تعديل بيانات الطالب";

            clsUITheme.AddHeaderBottomLine(pnlHeader);
            clsUITheme.AddHoverEffect(btnSave);
            clsUITheme.AddHoverEffectOutline(btnCancel);
            clsUITheme.StyleFormControls(this);

            cbGender.SelectedIndex = 0;

            LoadData();
        }

        private void LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                _Student = new clsStudent();
                dtpDOB.Value = DateTime.Now.AddYears(-6);

                txtAdmissionNo.Text = "STU-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
                cbBloodType.SelectedIndex = 0;
                cbHealthStatus.SelectedIndex = 0;
                return;
            }

            _Student = clsStudent.Find(_StudentID);
            if (_Student == null)
            {
                clsUITheme.ShowArabicMessage($"لم يتم العثور على الطالب برقم المعرف {_StudentID}.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtFirstName.Text = _Student.FirstName;
            txtLastName.Text = _Student.LastName;
            txtNationalID.Text = _Student.NationalID;
            txtAdmissionNo.Text = _Student.AdmissionNo;
            dtpDOB.Value = _Student.DateOfBirth;
            cbGender.SelectedIndex = (_Student.GenderID == 1) ? 0 : 1;
            txtNationality.Text = string.IsNullOrEmpty(_Student.Nationality) ? "يمني" : _Student.Nationality;
            cbBloodType.Text = _Student.BloodType;
            txtAddress.Text = _Student.Address;
            txtPhoneNumber.Text = _Student.PhoneNumber;
            txtEmail.Text = _Student.Email;
            dtpAdmissionDate.Value = _Student.AdmissionDate;
            txtPreviousSchool.Text = _Student.PreviousSchool;
            cbHealthStatus.Text = string.IsNullOrEmpty(_Student.HealthStatus) ? "سليم / لائق صحياً" : _Student.HealthStatus;

            if (!string.IsNullOrEmpty(_Student.ProfileImageURL) && File.Exists(_Student.ProfileImageURL))
            {
                try
                {
                    pbxStudentImage.ImageLocation = _Student.ProfileImageURL;
                }
                catch
                {
                    pbxStudentImage.Image = null;
                }
            }
        }

        private bool ValidateForm()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "الاسم الأول مطلوب.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "اسم العائلة / اللقب مطلوب.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtAdmissionNo.Text))
            {
                errorProvider1.SetError(txtAdmissionNo, "رقم القبول مطلوب.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtNationalID.Text))
            {
                errorProvider1.SetError(txtNationalID, "الرقم الوطني مطلوب.");
                isValid = false;
            }
            if (cbGender.SelectedIndex < 0)
            {
                errorProvider1.SetError(cbGender, "يرجى تحديد الجنس.");
                isValid = false;
            }
            if (dtpDOB.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtpDOB, "تاريخ الميلاد لا يمكن أن يكون في المستقبل.");
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(txtEmail, "صيغة البريد الإلكتروني غير صحيحة.");
                isValid = false;
            }

            return isValid;
        }

        private bool _HandelWithImage()
        {
            if (pbxStudentImage.ImageLocation != _Student.ProfileImageURL)
            {
                if (!string.IsNullOrEmpty(_Student.ProfileImageURL))
                {
                    try
                    {
                        if (File.Exists(_Student.ProfileImageURL))
                            File.Delete(_Student.ProfileImageURL);
                    }
                    catch
                    {
                    }
                }

                if (pbxStudentImage.ImageLocation != null)
                {
                    string Source = pbxStudentImage.ImageLocation;

                    if (clsUtility.CopyFileToNewDiroctory(ref Source))
                    {
                        pbxStudentImage.ImageLocation = Source;
                        return true;
                    }
                    else
                    {
                        clsUITheme.ShowArabicMessage("حدث خطأ أثناء نسخ ملف الصورة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        async private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateForm())
                return;

            if (!_HandelWithImage())
                return;

            btnSave.Enabled = false;
            btnSave.Text = "جاري الحفظ...";

            _Student.FirstName = txtFirstName.Text.Trim();
            _Student.LastName = txtLastName.Text.Trim();
            _Student.NationalID = txtNationalID.Text.Trim();
            _Student.AdmissionNo = txtAdmissionNo.Text.Trim();
            _Student.DateOfBirth = dtpDOB.Value;
            _Student.GenderID = (cbGender.Text == "ذكر" || cbGender.Text == "Male") ? 1 : 2;
            _Student.Nationality = txtNationality.Text.Trim();
            _Student.BloodType = cbBloodType.Text;
            _Student.Address = txtAddress.Text.Trim();
            _Student.PhoneNumber = txtPhoneNumber.Text.Trim();
            _Student.Email = txtEmail.Text.Trim();
            _Student.AdmissionDate = dtpAdmissionDate.Value;
            _Student.PreviousSchool = txtPreviousSchool.Text.Trim();
            _Student.HealthStatus = cbHealthStatus.Text;

            if (pbxStudentImage.ImageLocation != null)
                _Student.ProfileImageURL = pbxStudentImage.ImageLocation;
            else
                _Student.ProfileImageURL = "";

            _Student.CreatedBy = clsGloble.UserID;
            _Student.UpdatedBy = clsGloble.UserID;

            try
            {
                bool isNew = (_Mode == enMode.AddNew);
                bool isSaved = await _Student.Save();
                if (isSaved)
                {
                    _StudentID = _Student.StudentID;
                    _Mode = enMode.Update;

                    if (isNew && _StudentID > 0)
                    {
                        var result = clsUITheme.ShowArabicMessage(
                            "تم حفظ بيانات الطالب بنجاح.\n\nهل تريد قيد الطالب في صف دراسي الآن؟",
                            "تسجيل ناجح",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Hide();

                            frmEnrollStudent frmEnroll = new frmEnrollStudent();
                            frmEnroll.PreSelectStudent(_StudentID,this);
                            frmEnroll.ShowDialog();

                            frmEnroll.Close();

                            btnSave.Enabled = false;

                            //this.Close();
                            return;
                        }
                    }

                    clsUITheme.ShowArabicMessage("تم حفظ بيانات الطالب بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ بيانات الطالب.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage("خطأ في التحقق من صحة البيانات:\n" + ex.Message, "فشل الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnSave.Enabled = true;
                btnSave.Text = _Mode == enMode.AddNew ? "حفظ البيانات" : "تحديث البيانات";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LlblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            opfImage.Filter = "Image Files|*.jpg;*.png;*.bmf;*.bmp;*.gif|All Files |*.*";

            if (opfImage.ShowDialog() == DialogResult.OK)
            {
                string sourcePathImage = opfImage.FileName;
                _PathImage = Path.GetFileName(sourcePathImage);

                pbxStudentImage.Load(sourcePathImage);

                if (File.Exists(sourcePathImage) && !File.Exists(_DestenationImage))
                {
                    if (!Directory.Exists(_DestenationImage))
                        Directory.CreateDirectory(_DestenationImage);

                    File.Copy(sourcePathImage, _DestenationImage + _PathImage, true);
                    _PathImage = _DestenationImage + _PathImage;
                }
            }
        }
    }
}
