using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Finance
{
    public partial class frmFeeStructures : Form
    {
        private DataTable _dtFeeStructures;
        private int _editingFeeStructureID = -1;

        public frmFeeStructures()
        {
            InitializeComponent();
            _ApplyTheme();
        }

        private void _ApplyTheme()
        {
            clsUITheme.StyleDataGridView(dgvFeeStructures);
            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StylePrimaryButton(btnAddNew);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnClear);
            clsUITheme.StyleSecondaryButton(btnClose);

            dgvFeeStructures.DataError += (s, args) => { args.ThrowException = false; };
        }

        private void FrmFeeStructures_Load(object sender, EventArgs e)
        {
            _LoadGradeLevels();
            _LoadAcademicYears();
            LoadFeeStructuresData();
            _ResetForm();
        }

        private void _LoadGradeLevels()
        {
            DataTable dtGrades = clsGradeLevel.GetAllGradeLevels();
            if (dtGrades != null)
            {
                cbGradeLevel.DisplayMember = "Name";
                cbGradeLevel.ValueMember = "GradeLevelID";
                cbGradeLevel.DataSource = dtGrades;
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

                // Select current year by default
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

        public void LoadFeeStructuresData()
        {
            _dtFeeStructures = clsFeeStructure.GetAllFeeStructuresDetailed();

            if (_dtFeeStructures != null)
            {
                _BuildGrid();
                lblSummary.Text = $"إجمالي الهياكل: {_dtFeeStructures.Rows.Count}";
            }
        }

        private void _BuildGrid()
        {
            dgvFeeStructures.DataSource = null;
            dgvFeeStructures.Columns.Clear();
            dgvFeeStructures.AutoGenerateColumns = false;

            // Hidden ID
            dgvFeeStructures.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FeeStructureID",
                Name = "FeeStructureID",
                Visible = false
            });

            // Name
            dgvFeeStructures.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "اسم هيكل الرسوم",
                Width = 170,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = clsUITheme.BoldFont,
                    ForeColor = clsUITheme.PrimaryColor
                }
            });

            // Grade Level
            dgvFeeStructures.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GradeLevelName",
                HeaderText = "المرحلة / الصف",
                Width = 120
            });

            // Academic Year
            dgvFeeStructures.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AcademicYear",
                HeaderText = "السنة الدراسية",
                Width = 110
            });

            // Tuition Fee
            dgvFeeStructures.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TuitionFee",
                HeaderText = "التعليم ($)",
                Width = 95,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            // Transport Fee
            dgvFeeStructures.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TransportFee",
                HeaderText = "النقل ($)",
                Width = 95,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            // Book Fee
            dgvFeeStructures.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BookFee",
                HeaderText = "الكتب ($)",
                Width = 85,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            // Other Fees
            dgvFeeStructures.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OtherFees",
                HeaderText = "أخرى ($)",
                Width = 85,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            // Total Fees
            dgvFeeStructures.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalFees",
                HeaderText = "الإجمالي ($)",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Font = clsUITheme.BoldFont,
                    ForeColor = clsUITheme.SuccessColor
                }
            });

            dgvFeeStructures.DataSource = _dtFeeStructures;
        }

        private void DgvFeeStructures_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFeeStructures.CurrentRow != null && dgvFeeStructures.CurrentRow.Index >= 0)
            {
                DataRowView drv = dgvFeeStructures.CurrentRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    _PopulateFormFromRow(drv.Row);
                }
            }
        }

        private void _PopulateFormFromRow(DataRow row)
        {
            _editingFeeStructureID = Convert.ToInt32(row["FeeStructureID"]);
            txtName.Text = row["Name"].ToString();

            if (row["GradeLevelID"] != DBNull.Value)
                cbGradeLevel.SelectedValue = Convert.ToInt32(row["GradeLevelID"]);

            if (row["AcademicYearID"] != DBNull.Value)
                cbAcademicYear.SelectedValue = Convert.ToInt32(row["AcademicYearID"]);

            numTuitionFee.Value = Convert.ToDecimal(row["TuitionFee"]);
            numTransportFee.Value = Convert.ToDecimal(row["TransportFee"]);
            numBookFee.Value = Convert.ToDecimal(row["BookFee"]);
            numOtherFees.Value = Convert.ToDecimal(row["OtherFees"]);

            gbFeeStructureDetails.Text = $"تعديل هيكل الرسوم (رقم: {_editingFeeStructureID})";
            btnSave.Text = "💾 تحديث الهيكل";
            _UpdateLiveTotal();
        }

        private void _ResetForm()
        {
            _editingFeeStructureID = -1;
            txtName.Clear();
            numTuitionFee.Value = 0;
            numTransportFee.Value = 0;
            numBookFee.Value = 0;
            numOtherFees.Value = 0;

            gbFeeStructureDetails.Text = "إضافة هيكل رسوم جديد";
            btnSave.Text = "💾 حفظ الهيكل";
            errorProvider1.Clear();
            _UpdateLiveTotal();

            if (cbGradeLevel.Items.Count > 0) cbGradeLevel.SelectedIndex = 0;
            AutoGenerateName(null, null);
        }

        private void AutoGenerateName(object sender, EventArgs e)
        {
            if (_editingFeeStructureID <= 0) // Only auto-generate in Add mode
            {
                string grade = cbGradeLevel.Text;
                string year = cbAcademicYear.Text;
                if (!string.IsNullOrEmpty(grade) && !string.IsNullOrEmpty(year))
                {
                    txtName.Text = $"{grade} - رسوم {year}";
                }
            }
        }

        private void FeeAmountChanged(object sender, EventArgs e)
        {
            _UpdateLiveTotal();
        }

        private void _UpdateLiveTotal()
        {
            decimal total = numTuitionFee.Value + numTransportFee.Value + numBookFee.Value + numOtherFees.Value;
            lblLiveTotalVal.Text = $"${total:N2}";
        }

        private bool _ValidateInputs()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "يرجى إدخال اسم هيكل الرسوم.");
                isValid = false;
            }

            if (cbGradeLevel.SelectedValue == null)
            {
                errorProvider1.SetError(cbGradeLevel, "يرجى تحديد المرحلة الدراسية.");
                isValid = false;
            }

            if (cbAcademicYear.SelectedValue == null)
            {
                errorProvider1.SetError(cbAcademicYear, "يرجى تحديد السنة الدراسية.");
                isValid = false;
            }

            decimal total = numTuitionFee.Value + numTransportFee.Value + numBookFee.Value + numOtherFees.Value;
            if (total <= 0)
            {
                errorProvider1.SetError(numTuitionFee, "يجب أن يكون مبلغ واحد على الأقل من الرسوم أكبر من الصفر.");
                isValid = false;
            }

            // Duplicate check: Cannot define multiple fee structures for the same level and year
            int gradeID = Convert.ToInt32(cbGradeLevel.SelectedValue);
            int yearID = Convert.ToInt32(cbAcademicYear.SelectedValue);

            if (_dtFeeStructures != null)
            {
                foreach (DataRow row in _dtFeeStructures.Rows)
                {
                    int rowID = Convert.ToInt32(row["FeeStructureID"]);
                    if (rowID != _editingFeeStructureID)
                    {
                        int rowGradeID = Convert.ToInt32(row["GradeLevelID"]);
                        int rowYearID = Convert.ToInt32(row["AcademicYearID"]);

                        if (rowGradeID == gradeID && rowYearID == yearID)
                        {
                            errorProvider1.SetError(cbGradeLevel, "يوجد هيكل رسوم مسجل بالفعل لهذه المرحلة والسنة الدراسية مسبقاً.");
                            isValid = false;
                            break;
                        }
                    }
                }
            }

            return isValid;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateInputs())
                return;

            clsFeeStructure fs;
            if (_editingFeeStructureID > 0)
            {
                fs = clsFeeStructure.Find(_editingFeeStructureID);
                if (fs == null)
                {
                    clsUITheme.ShowArabicMessage("لم يتم العثور على سجل هيكل الرسوم المطلوب.", "خطأ", MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                fs = new clsFeeStructure();
            }

            fs.Name = txtName.Text.Trim();
            fs.GradeLevelID = Convert.ToInt32(cbGradeLevel.SelectedValue);
            fs.AcademicYearID = Convert.ToInt32(cbAcademicYear.SelectedValue);
            fs.TuitionFee = numTuitionFee.Value;
            fs.TransportFee = numTransportFee.Value;
            fs.BookFee = numBookFee.Value;
            fs.OtherFees = numOtherFees.Value;
            fs.UpdatedAt = DateTime.Now;

            try
            {
                if (fs.Save())
                {
                    clsUITheme.ShowArabicMessage(
                        $"تم حفظ هيكل الرسوم [{fs.Name}] بنجاح!",
                        "تم الحفظ", MessageBoxIcon.Information);

                    LoadFeeStructuresData();
                    _ResetForm();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ هيكل الرسوم.", "خطأ", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage($"خطأ أثناء الحفظ: {ex.Message}", "خطأ", MessageBoxIcon.Error);
            }
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            _ResetForm();
            txtName.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvFeeStructures.CurrentRow != null)
            {
                DataRowView drv = dgvFeeStructures.CurrentRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    _PopulateFormFromRow(drv.Row);
                    txtName.Focus();
                }
            }
            else
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد هيكل رسوم من القائمة لتعديله.", "تحديد مطلوب", MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFeeStructures.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد هيكل رسوم من القائمة لحذفه.", "تحديد مطلوب", MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvFeeStructures.CurrentRow.Cells["FeeStructureID"].Value);
            string name = dgvFeeStructures.CurrentRow.Cells["Name"].Value?.ToString() ?? "";

            // Guard: Referential integrity check (SRS / DB constraint)
            if (clsFeeStructure.IsFeeStructureUsed(id))
            {
                clsUITheme.ShowArabicMessage(
                    $"لا يمكن حذف هيكل الرسوم [{name}] لأنه مخصص ومستخدم حالياً في فواتير طلاب قائمة.\n\n" +
                    "للحفاظ على سلامة التدقيق المالي، لا يمكن حذف هياكل الرسوم المرتبطة بفواتير صادرة.",
                    "قيد التكامل المالي المرجعي", MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"هل أنت متأكد من رغبتك في حذف هيكل الرسوم [{name}]؟",
                "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

            if (confirm == DialogResult.Yes)
            {
                if (clsFeeStructure.DeleteFeeStructure(id))
                {
                    clsUITheme.ShowArabicMessage($"تم حذف هيكل الرسوم [{name}] بنجاح.", "تم الحذف", MessageBoxIcon.Information);
                    LoadFeeStructuresData();
                    _ResetForm();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حذف هيكل الرسوم.", "خطأ", MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _ResetForm();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
