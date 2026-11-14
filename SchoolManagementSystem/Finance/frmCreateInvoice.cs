using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Finance
{
    public partial class frmCreateInvoice : Form
    {
        // Fee structure data (auto-detected)
        private int _detectedFeeStructureID = -1;
        private decimal _tuitionFee = 0;
        private decimal _transportFee = 0;
        private decimal _bookFee = 0;
        private decimal _otherFees = 0;
        private decimal _subtotal = 0;
        private decimal _finalTotal = 0;
        private int _detectedGradeLevelID = -1;

        public int CreatedInvoiceID { get; private set; } = -1;

        public frmCreateInvoice(int preselectedStudentID = -1)
        {
            InitializeComponent();
            _ApplyTheme();
            _PreselectedStudentID = preselectedStudentID;
        }

        private int _PreselectedStudentID = -1;

        private void _ApplyTheme()
        {
            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancel);
        }

        private void FrmCreateInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                dtpIssueDate.Value = DateTime.Today;
                dtpDueDate.Value = DateTime.Today.AddDays(30);

                _LoadStudents();
                _LoadAcademicYears();
                _GenerateInvoiceNumber();

                if (_PreselectedStudentID > 0)
                {
                    cbStudent.SelectedValue = _PreselectedStudentID;
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage(ex.Message, "خطأ", MessageBoxIcon.Error);
            }
        }

        private void _LoadStudents()
        {
            DataTable dtStudents = clsStudent.GetAllStudents();
            if (dtStudents != null)
            {
                DataTable dtCombo = dtStudents;
                if (!dtCombo.Columns.Contains("DisplayName"))
                    dtCombo.Columns.Add("DisplayName", typeof(string), "AdmissionNo + ' - ' + FullName");

                cbStudent.DisplayMember = "DisplayName";
                cbStudent.ValueMember = "StudentID";
                cbStudent.DataSource = dtCombo;
            }
        }

        private void _LoadAcademicYears()
        {
            DataTable dtYears = clsAcademicYear.GetAllAcademicYears();
            if (dtYears != null)
            {
                cbAcademicYear.DisplayMember = "YearName";
                cbAcademicYear.ValueMember = "AcademicYearID";
                cbAcademicYear.DataSource = dtYears;

                // Select current academic year if available
                foreach (DataRow row in dtYears.Rows)
                {
                    if (row["IsCurrent"] != DBNull.Value && Convert.ToBoolean(row["IsCurrent"]))
                    {
                        cbAcademicYear.SelectedValue = Convert.ToInt32(row["AcademicYearID"]);
                        break;
                    }
                }
            }
        }

        private void _GenerateInvoiceNumber()
        {
            // Use sequential generation from DB (concurrency-safe)
            txtInvoiceNumber.Text = clsInvoice.GetNextInvoiceNumber();
        }

        private void CbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            _AutoDetectFeeStructure();
        }

        private void CbAcademicYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            _AutoDetectFeeStructure();
        }

        private void _AutoDetectFeeStructure()
        {
            // Reset fee display
            _ResetFeeDisplay();

            if (cbStudent.SelectedValue == null || cbAcademicYear.SelectedValue == null)
                return;

            if (!int.TryParse(cbStudent.SelectedValue.ToString(), out int studentID) ||
                !int.TryParse(cbAcademicYear.SelectedValue.ToString(), out int academicYearID))
                return;

            // Step 1: Find student's enrollment for this academic year
            DataTable dtEnrollment = clsInvoice.GetStudentEnrollmentInfo(studentID, academicYearID);

            if (dtEnrollment == null || dtEnrollment.Rows.Count == 0)
            {
                lblEnrollmentInfo.Text = "⚠ الطالب غير مقيد في أي فصل دراسي لهذه السنة الأكاديمية.";
                lblEnrollmentInfo.ForeColor = Color.FromArgb(220, 38, 38);
                lblFeeStructureStatus.Text = "لا يمكن إصدار فاتورة — يجب تسجيل وقيد الطالب أولاً.";
                lblFeeStructureStatus.ForeColor = Color.FromArgb(220, 38, 38);
                return;
            }

            DataRow enrollRow = dtEnrollment.Rows[0];
            string className = enrollRow["ClassName"].ToString();
            string gradeLevelName = enrollRow["GradeLevelName"].ToString();
            _detectedGradeLevelID = Convert.ToInt32(enrollRow["GradeLevelID"]);

            lblEnrollmentInfo.Text = $"✅ مقيد في: {className} ({gradeLevelName})";
            lblEnrollmentInfo.ForeColor = Color.FromArgb(22, 163, 74);

            // Step 2: Find fee structure for this grade level + academic year
            DataTable dtFee = clsFeeStructure.GetFeeStructureByGradeLevelAndYear(_detectedGradeLevelID, academicYearID);

            if (dtFee == null || dtFee.Rows.Count == 0)
            {
                lblFeeStructureStatus.Text = $"⚠ لا يوجد هيكل رسوم محدد للمرحلة ({gradeLevelName}) في هذه السنة الأكاديمية.";
                lblFeeStructureStatus.ForeColor = Color.FromArgb(220, 38, 38);
                return;
            }

            DataRow feeRow = dtFee.Rows[0];
            _detectedFeeStructureID = Convert.ToInt32(feeRow["FeeStructureID"]);
            _tuitionFee = Convert.ToDecimal(feeRow["TuitionFee"]);
            _transportFee = Convert.ToDecimal(feeRow["TransportFee"]);
            _bookFee = Convert.ToDecimal(feeRow["BookFee"]);
            _otherFees = Convert.ToDecimal(feeRow["OtherFees"]);

            string feeName = feeRow["Name"].ToString();
            lblFeeStructureStatus.Text = $"✅ هيكل الرسوم: {feeName} — {gradeLevelName}";
            lblFeeStructureStatus.ForeColor = Color.FromArgb(22, 163, 74);

            // Step 3: Display fee items with checkboxes
            lblTuitionFeeVal.Text = $"${_tuitionFee:N2}";
            lblTransportFeeVal.Text = $"${_transportFee:N2}";
            lblBookFeeVal.Text = $"${_bookFee:N2}";
            lblOtherFeeVal.Text = $"${_otherFees:N2}";

            // Auto-uncheck items with zero value
            chkTuitionFee.Checked = _tuitionFee > 0;
            chkTransportFee.Checked = _transportFee > 0;
            chkBookFee.Checked = _bookFee > 0;
            chkOtherFees.Checked = _otherFees > 0;

            pnlFeeItems.Visible = true;
            _RecalculateSubtotal();

            // Step 4: Check for duplicate invoice warning
            if (clsInvoice.HasActiveInvoiceForStudentAndYear(studentID, academicYearID, _detectedFeeStructureID))
            {
                clsUITheme.ShowArabicMessage(
                    "⚠ تنبيه: يوجد لدى هذا الطالب فاتورة نشطة بالفعل لنفس هيكل الرسوم والسنة الدراسية.\n\n" +
                    "يمكنك المتابعة في إصدار فاتورة جديدة، لكن يرجى التأكد من أن ذلك مقصود.",
                    "تنبيه فاتورة مكررة", MessageBoxIcon.Warning);
            }
        }

        private void _ResetFeeDisplay()
        {
            _detectedFeeStructureID = -1;
            _detectedGradeLevelID = -1;
            _tuitionFee = 0; _transportFee = 0; _bookFee = 0; _otherFees = 0;
            _subtotal = 0; _finalTotal = 0;

            pnlFeeItems.Visible = false;
            lblFeeStructureStatus.Text = "في انتظار تحديد الطالب والسنة الدراسية للتحقق...";
            lblFeeStructureStatus.ForeColor = Color.FromArgb(100, 116, 139);
            lblEnrollmentInfo.Text = "اختر طالباً لتحديد القيد والمرحلة الدراسية...";
            lblEnrollmentInfo.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtotalVal.Text = "$0.00";
            lblTotalAmountVal.Text = "$0.00";
        }

        // ===== Fee item checkboxes: recalculate when toggled =====
        private void FeeItemChanged(object sender, EventArgs e)
        {
            _RecalculateSubtotal();
        }

        private void _RecalculateSubtotal()
        {
            _subtotal = 0;
            if (chkTuitionFee.Checked) _subtotal += _tuitionFee;
            if (chkTransportFee.Checked) _subtotal += _transportFee;
            if (chkBookFee.Checked) _subtotal += _bookFee;
            if (chkOtherFees.Checked) _subtotal += _otherFees;

            lblSubtotalVal.Text = $"${_subtotal:N2}";
            _RecalculateTotal();
        }

        private void CalculationChanged(object sender, EventArgs e)
        {
            _RecalculateTotal();
        }

        private void _RecalculateTotal()
        {
            decimal discount = numDiscount.Value;
            decimal tax = numTax.Value;

            _finalTotal = _subtotal - discount + tax;
            if (_finalTotal < 0) _finalTotal = 0;

            lblTotalAmountVal.Text = $"${_finalTotal:N2}";

            // Color feedback: red if discount exceeds subtotal
            if (discount > _subtotal)
            {
                lblTotalAmountVal.ForeColor = Color.FromArgb(220, 38, 38);
            }
            else
            {
                lblTotalAmountVal.ForeColor = Color.FromArgb(39, 174, 96);
            }
        }

        bool Validation(out string message)
        {
            message = "";

            if (cbStudent.SelectedValue == null)
            {
                message = "يرجى اختيار الطالب أولاً.";
                return false;
            }

            if (cbAcademicYear.SelectedValue == null)
            {
                message = "يرجى اختيار السنة الدراسية.";
                return false;
            }

            if (_detectedFeeStructureID <= 0)
            {
                message = "لم يتم العثور على هيكل رسوم لهذا الطالب.\nيرجى التأكد من تسجيل وقيد الطالب ووجود هيكل رسوم محدد لمرحلته الدراسية.";
                return false;
            }

            if (_subtotal <= 0)
            {
                message = "يجب تحديد بند رسوم واحد على الأقل لإصدار الفاتورة.";
                return false;
            }

            if (numDiscount.Value > _subtotal)
            {
                message = "لا يمكن أن يتجاوز مبلغ الخصم المجموع الفرعي للرسوم.";
                return false;
            }

            if (dtpIssueDate.Value.Date > dtpDueDate.Value.Date)
            {
                message = "تاريخ الإصدار لا يمكن أن يكون بعد تاريخ الاستحقاق.";
                return false;
            }

            return true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!Validation(out string message))
            {
                clsUITheme.ShowArabicMessage(message, "خطأ في التحقق", MessageBoxIcon.Error);
                return;
            }

            int studentID = Convert.ToInt32(cbStudent.SelectedValue);
            int academicYearID = Convert.ToInt32(cbAcademicYear.SelectedValue);

            clsInvoice invoice = new clsInvoice
            {
                InvoiceNumber = txtInvoiceNumber.Text.Trim(),
                StudentID = studentID,
                AcademicYearID = academicYearID,
                FeeStructureID = _detectedFeeStructureID,
                IssueDate = dtpIssueDate.Value.Date,
                DueDate = dtpDueDate.Value.Date,
                Subtotal = _subtotal,
                DiscountAmount = numDiscount.Value,
                TaxAmount = numTax.Value,
                TotalAmount = _finalTotal,
                Status = "Unpaid",
                CreatedBy = clsGloble.UserID
            };

            try
            {
                if (invoice.Save())
                {
                    this.CreatedInvoiceID = invoice.InvoiceID;

                    DialogResult payNow = MessageBox.Show(
                        $"تم إصدار الفاتورة [{invoice.InvoiceNumber}] بنجاح بإجمالي مبلغ ${invoice.TotalAmount:N2}.\n\n" +
                        "هل ترغب في تسجيل دفعة فورية لهذه الفاتورة الآن؟",
                        "تم إصدار الفاتورة",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                    if (payNow == DialogResult.Yes)
                    {
                        frmRecordPayment frmPay = new frmRecordPayment(invoice.InvoiceID);
                        frmPay.ShowDialog();
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ الفاتورة. يرجى التحقق من صحة البيانات المدخلة.", "خطأ",
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage($"خطأ أثناء إصدار الفاتورة: {ex.Message}", "خطأ",
                    MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
