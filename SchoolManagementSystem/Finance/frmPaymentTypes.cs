using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Finance
{
    public partial class frmPaymentTypes : Form
    {
        private DataTable _dtPaymentTypes;
        private int _editingPaymentTypeID = -1;

        public frmPaymentTypes()
        {
            InitializeComponent();

            clsUITheme.StyleDataGridView(dgvPaymentTypes);
            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancelEdit);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);
            clsUITheme.StyleSecondaryButton(btnClose);
        }

        private void FrmPaymentTypes_Load(object sender, EventArgs e)
        {
            LoadPaymentTypes();
            ResetForm();
        }

        private void LoadPaymentTypes()
        {
            _dtPaymentTypes = clsPaymentType.GetAllPaymentTypes();
            dgvPaymentTypes.DataSource = _dtPaymentTypes;

            if (dgvPaymentTypes.Columns.Contains("PaymentTypeID"))
            {
                dgvPaymentTypes.Columns["PaymentTypeID"].HeaderText = "ID";
                dgvPaymentTypes.Columns["PaymentTypeID"].Width = 60;
            }
            if (dgvPaymentTypes.Columns.Contains("Name"))
            {
                dgvPaymentTypes.Columns["Name"].HeaderText = "Payment Type";
                dgvPaymentTypes.Columns["Name"].Width = 150;
            }
            if (dgvPaymentTypes.Columns.Contains("Description"))
            {
                dgvPaymentTypes.Columns["Description"].HeaderText = "Description";
            }

            lblTotalCount.Text = $"Total Types: {dgvPaymentTypes.Rows.Count}";
        }

        private void ResetForm()
        {
            _editingPaymentTypeID = -1;
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            gbPaymentType.Text = "Add New Payment Type";
            btnSave.Text = "Save Type";
            btnCancelEdit.Visible = false;
            errorProvider1.Clear();
            txtName.Focus();
        }

        private bool ValidateInputs()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Payment Type Name is required.");
                isValid = false;
            }
            else
            {
                // Uniqueness check
                string name = txtName.Text.Trim();
                if (_dtPaymentTypes != null)
                {
                    foreach (DataRow row in _dtPaymentTypes.Rows)
                    {
                        int id = Convert.ToInt32(row["PaymentTypeID"]);
                        if (id != _editingPaymentTypeID && row["Name"].ToString().Equals(name, StringComparison.OrdinalIgnoreCase))
                        {
                            errorProvider1.SetError(txtName, "A payment type with this name already exists.");
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
            if (!ValidateInputs())
                return;

            clsPaymentType paymentType;
            if (_editingPaymentTypeID == -1)
            {
                paymentType = new clsPaymentType();
            }
            else
            {
                paymentType = clsPaymentType.Find(_editingPaymentTypeID);
                if (paymentType == null)
                {
                    MessageBox.Show("Payment type record was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetForm();
                    return;
                }
            }

            paymentType.Name = txtName.Text.Trim();
            paymentType.Description = txtDescription.Text.Trim();

            try
            {
                if (paymentType.Save())
                {
                    MessageBox.Show("Payment type saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                    LoadPaymentTypes();
                }
                else
                {
                    MessageBox.Show("Failed to save payment type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payment type: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPaymentTypes.CurrentRow == null)
            {
                MessageBox.Show("Please select a payment type to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvPaymentTypes.CurrentRow.Cells["PaymentTypeID"].Value);
            clsPaymentType pt = clsPaymentType.Find(id);
            if (pt != null)
            {
                _editingPaymentTypeID = pt.PaymentTypeID;
                txtName.Text = pt.Name;
                txtDescription.Text = pt.Description;
                gbPaymentType.Text = $"Edit Payment Type [ID: {pt.PaymentTypeID}]";
                btnSave.Text = "Update Type";
                btnCancelEdit.Visible = true;
                errorProvider1.Clear();
                txtName.Focus();
            }
        }

        private void DgvPaymentTypes_DoubleClick(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPaymentTypes.CurrentRow == null)
            {
                MessageBox.Show("Please select a payment type to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvPaymentTypes.CurrentRow.Cells["PaymentTypeID"].Value);
            string name = dgvPaymentTypes.CurrentRow.Cells["Name"].Value.ToString();

            // Business Rule: Check if PaymentType is used in Payments
            if (clsPaymentType.IsPaymentTypeUsed(id))
            {
                MessageBox.Show($"Cannot delete payment type '{name}' because it is linked to existing student payment records.\nTo preserve financial data integrity, deletion is prevented.",
                    "Referential Integrity Restriction", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete payment type '{name}' (ID: {id})?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsPaymentType.DeletePaymentType(id))
                {
                    MessageBox.Show("Payment type deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_editingPaymentTypeID == id)
                        ResetForm();
                    LoadPaymentTypes();
                }
                else
                {
                    MessageBox.Show("Failed to delete payment type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadPaymentTypes();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
