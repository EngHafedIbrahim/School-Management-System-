using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Academic
{
    public partial class frmAcademicYears : Form
    {
        private int _EditingYearID = -1;

        public frmAcademicYears()
        {
            InitializeComponent();

            clsUITheme.ApplyRTL(this);
            clsUITheme.StyleDataGridView(dgvYears);
            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancelEdit);
            clsUITheme.StyleSuccessButton(btnSetCurrent);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);

            LoadYears();
        }

        private void LoadYears()
        {
            DataTable dt = clsAcademicYear.GetAllAcademicYears();
            dgvYears.DataSource = dt;

            if (dgvYears.Columns.Contains("AcademicYearID"))
            {
                dgvYears.Columns["AcademicYearID"].HeaderText = "الرقم";
                dgvYears.Columns["AcademicYearID"].Width = 80;
            }
            if (dgvYears.Columns.Contains("YearName"))
            {
                dgvYears.Columns["YearName"].HeaderText = "اسم السنة الأكاديمية";
                dgvYears.Columns["YearName"].Width = 200;
            }
            if (dgvYears.Columns.Contains("StartDate"))
            {
                dgvYears.Columns["StartDate"].HeaderText = "تاريخ البداية";
                dgvYears.Columns["StartDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
            if (dgvYears.Columns.Contains("EndDate"))
            {
                dgvYears.Columns["EndDate"].HeaderText = "تاريخ الانتهاء";
                dgvYears.Columns["EndDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
            if (dgvYears.Columns.Contains("IsCurrent"))
            {
                dgvYears.Columns["IsCurrent"].HeaderText = "السنة الحالية؟";
                dgvYears.Columns["IsCurrent"].Width = 110;
            }
            if (dgvYears.Columns.Contains("CreatedAt"))
                dgvYears.Columns["CreatedAt"].Visible = false;
            if (dgvYears.Columns.Contains("UpdatedAt"))
                dgvYears.Columns["UpdatedAt"].Visible = false;
        }

        private void ResetEditor()
        {
            _EditingYearID = -1;
            lblFormTitle.Text = "إضافة سنة أكاديمية جديدة";
            txtYearName.Text = "";
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddMonths(9);
            chkIsCurrent.Checked = false;
            btnCancelEdit.Visible = false;
            btnSave.Text = "حفظ السنة الأكاديمية";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYearName.Text))
            {
                clsUITheme.ShowArabicMessage("اسم السنة الأكاديمية مطلوب.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                clsUITheme.ShowArabicMessage("يجب أن يكون تاريخ البداية قبل تاريخ الانتهاء.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsAcademicYear year;
            if (_EditingYearID == -1)
            {
                year = new clsAcademicYear();
            }
            else
            {
                year = clsAcademicYear.Find(_EditingYearID);
                if (year == null)
                {
                    clsUITheme.ShowArabicMessage("لم يتم العثور على السنة الأكاديمية.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetEditor();
                    return;
                }
            }

            year.YearName = txtYearName.Text.Trim();
            year.StartDate = dtpStartDate.Value;
            year.EndDate = dtpEndDate.Value;
            year.IsCurrent = chkIsCurrent.Checked;

            try
            {
                if (year.Save())
                {
                    if (chkIsCurrent.Checked)
                    {
                        clsAcademicYear.SetCurrentAcademicYear(year.AcademicYearID);
                    }

                    clsUITheme.ShowArabicMessage("تم حفظ بيانات السنة الأكاديمية بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetEditor();
                    LoadYears();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ السنة الأكاديمية.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage("خطأ في التحقق:\n" + ex.Message, "مخالفة قواعد النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            ResetEditor();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvYears.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد سنة أكاديمية للتعديل أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _EditingYearID = Convert.ToInt32(dgvYears.CurrentRow.Cells["AcademicYearID"].Value);
            clsAcademicYear year = clsAcademicYear.Find(_EditingYearID);
            if (year != null)
            {
                lblFormTitle.Text = $"تعديل السنة الأكاديمية [رقم: {_EditingYearID}]";
                txtYearName.Text = year.YearName;
                dtpStartDate.Value = year.StartDate;
                dtpEndDate.Value = year.EndDate;
                chkIsCurrent.Checked = year.IsCurrent;
                btnCancelEdit.Visible = true;
                btnSave.Text = "تحديث البيانات";
            }
        }

        private void BtnSetCurrent_Click(object sender, EventArgs e)
        {
            if (dgvYears.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد سنة أكاديمية أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int yearID = Convert.ToInt32(dgvYears.CurrentRow.Cells["AcademicYearID"].Value);
            string yearName = dgvYears.CurrentRow.Cells["YearName"].Value.ToString();

            if (clsUITheme.ShowArabicMessage(
                $"هل أنت متأكد من رغبتك في تعيين السنة '{yearName}' كسنة أكاديمية حالية؟\nسيتم تعطيل جميع السنوات الأخرى تلقائياً.",
                "تأكيد التعيين",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (clsAcademicYear.SetCurrentAcademicYear(yearID))
                    {
                        clsUITheme.ShowArabicMessage($"تم تعيين السنة '{yearName}' كسنة أكاديمية حالية نشطة بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadYears();
                    }
                }
                catch (Exception ex)
                {
                    clsUITheme.ShowArabicMessage("فشلت العملية: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvYears.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد سنة أكاديمية للحذف أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int yearID = Convert.ToInt32(dgvYears.CurrentRow.Cells["AcademicYearID"].Value);
            string yearName = dgvYears.CurrentRow.Cells["YearName"].Value.ToString();

            if (clsUITheme.ShowArabicMessage(
                $"هل أنت متأكد من رغبتك في حذف السنة الأكاديمية '{yearName}' (رقم: {yearID})؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsAcademicYear.DeleteAcademicYear(yearID))
                    {
                        clsUITheme.ShowArabicMessage("تم حذف السنة الأكاديمية بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadYears();
                    }
                    else
                    {
                        clsUITheme.ShowArabicMessage("لا يمكن حذف هذه السنة الأكاديمية لأنها مرتبطة بقيود طلاب أو جداول دراسية أو درجات أو هياكل رسوم.", "قيد تكامل البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsUITheme.ShowArabicMessage("خطأ أثناء حذف السنة الأكاديمية: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadYears();
        }
    }
}
