# Presentation Layer (UI) — Code Templates & Patterns

This reference document provides the complete, copy-paste-ready code templates
for the Windows Forms Presentation Layer. Every form and control MUST follow
these exact patterns.

---

## Program Entry Point

```csharp
using System;
using System.Windows.Forms;

namespace <ProjectName>
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin loginForm = new frmLogin();
            loginForm.ShowDialog();

            if (loginForm.IsAuthenticated)
            {
                Application.Run(new frmMainScreen());
            }
        }
    }
}
```

---

## Main Screen (MDI Parent)

```csharp
public partial class frmMainScreen : Form
{
    public frmMainScreen()
    {
        InitializeComponent();
        this.IsMdiContainer = true;
    }

    // ─────── Menu Item → Open List Form ───────
    private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmList<Entities> frm = new frmList<Entities>();
        frm.MdiParent = this;
        frm.Show();
    }

    // ─────── Menu Item → Open Add Form ────────
    private void addNew<Entity>ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmAddUpdate<Entity> frm = new frmAddUpdate<Entity>();
        frm.ShowDialog();
    }
}
```

---

## Login Form

```csharp
public partial class frmLogin : Form
{
    public bool IsAuthenticated { get; private set; } = false;

    public frmLogin()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        // Validate inputs
        if (string.IsNullOrWhiteSpace(txtUsername.Text))
        {
            MessageBox.Show("Username is required.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtUsername.Focus();
            return;
        }

        // Authenticate via Business Layer
        clsUsers user = clsUsers.FindByUsernameAndPassword(
            txtUsername.Text.Trim(), txtPassword.Text.Trim());

        if (user != null)
        {
            if (!user.IsActive)
            {
                MessageBox.Show("Your account is inactive.",
                    "Inactive Account",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set global user
            clsGloble.CurrentUser = user;
            IsAuthenticated = true;
            this.Close();
        }
        else
        {
            MessageBox.Show("Invalid Username or Password.",
                "Login Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
```

---

## List Form Template (with DataGridView + Filter + ContextMenu)

```csharp
public partial class frmList<Entities> : Form
{
    // ═══════════ CONSTRUCTOR ═══════════
    public frmList<Entities>()
    {
        InitializeComponent();
    }

    // ═══════════ FORM LOAD ═══════════
    private void frmList<Entities>_Load(object sender, EventArgs e)
    {
        _FillDataGridView();
        cbFilterBy.SelectedIndex = 0;
    }

    // ═══════════ FILL DATAGRIDVIEW ═══════════
    private void _FillDataGridView()
    {
        dgvList.DataSource = cls<Entity>.GetAll<Entities>();
        lblRecords.Text = dgvList.RowCount.ToString();

        // Optional: customize column headers
        if (dgvList.Columns.Count > 0)
        {
            dgvList.Columns[0].HeaderText = "<Entity> ID";
            dgvList.Columns[0].Width = 100;
        }
    }

    // ═══════════ SEARCH / FILTER ═══════════
    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        string FilterColumn = cbFilterBy.Text;
        string FilterValue = txtSearch.Text.Trim();

        if (string.IsNullOrEmpty(FilterValue))
        {
            _FillDataGridView();
            return;
        }

        if (dgvList.DataSource is DataTable dt)
        {
            // Numeric columns → exact match
            if (FilterColumn == "<Entity>ID")
                dt.DefaultView.RowFilter = $"{FilterColumn} = {FilterValue}";
            // Text columns → LIKE pattern
            else
                dt.DefaultView.RowFilter =
                    $"{FilterColumn} LIKE '%{FilterValue}%'";

            lblRecords.Text = dgvList.RowCount.ToString();
        }
    }

    // ═══════════ ADD NEW BUTTON ═══════════
    private void btnAddNew_Click(object sender, EventArgs e)
    {
        frmAddUpdate<Entity> frm = new frmAddUpdate<Entity>();
        frm.ShowDialog();
        _FillDataGridView(); // Refresh after dialog closes
    }

    // ═══════════ CONTEXT MENU → EDIT ═══════════
    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int ID = (int)dgvList.CurrentRow.Cells[0].Value;
        frmAddUpdate<Entity> frm = new frmAddUpdate<Entity>(ID);
        frm.ShowDialog();
        _FillDataGridView();
    }

    // ═══════════ CONTEXT MENU → DELETE ═══════════
    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int ID = (int)dgvList.CurrentRow.Cells[0].Value;

        if (MessageBox.Show(
            "Are you sure you want to delete this record?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            if (cls<Entity>.Delete<Entity>(ID))
            {
                MessageBox.Show("Record deleted successfully.",
                    "Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _FillDataGridView();
            }
            else
            {
                MessageBox.Show(
                    "Could not delete. Record may have dependencies.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

    // ═══════════ CONTEXT MENU → SHOW DETAILS ═══════════
    private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int ID = (int)dgvList.CurrentRow.Cells[0].Value;
        frmShow<Entity>Info frm = new frmShow<Entity>Info(ID);
        frm.ShowDialog();
    }

    // ═══════════ DOUBLE CLICK ON ROW ═══════════
    private void dgvList_CellDoubleClick(object sender,
        DataGridViewCellEventArgs e)
    {
        int ID = (int)dgvList.CurrentRow.Cells[0].Value;
        frmShow<Entity>Info frm = new frmShow<Entity>Info(ID);
        frm.ShowDialog();
    }
}
```

### DataGridView Configuration (Designer or Code)
- `SelectionMode = FullRowSelect`
- `ReadOnly = true`
- `AllowUserToAddRows = false`
- `AllowUserToDeleteRows = false`
- `MultiSelect = false`
- `AlternatingRowsDefaultCellStyle.BackColor = LightGray`
- Attach `ContextMenuStrip` with items: Edit, Delete, Show Details

---

## Add/Update Form Template

```csharp
public partial class frmAddUpdate<Entity> : Form
{
    // ═══════════ MODE TRACKING ═══════════
    public enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;
    private cls<Entity> _Entity;
    private int _EntityID = -1;

    // ═══════════ CONSTRUCTOR — ADD NEW ═══════════
    public frmAddUpdate<Entity>()
    {
        InitializeComponent();
        _Mode = enMode.AddNew;
    }

    // ═══════════ CONSTRUCTOR — UPDATE ═══════════
    public frmAddUpdate<Entity>(int EntityID)
    {
        InitializeComponent();
        _Mode = enMode.Update;
        _EntityID = EntityID;
    }

    // ═══════════ FORM LOAD ═══════════
    private void frmAddUpdate<Entity>_Load(object sender, EventArgs e)
    {
        _ResetDefaultValues();

        if (_Mode == enMode.Update)
        {
            lblTitle.Text = "Update <Entity>";
            _LoadEntityData();
        }
        else
        {
            lblTitle.Text = "Add New <Entity>";
        }
    }

    // ═══════════ RESET DEFAULTS ═══════════
    private void _ResetDefaultValues()
    {
        // Initialize entity object
        if (_Mode == enMode.AddNew)
        {
            _Entity = new cls<Entity>();
            txtField1.Text = "";
            txtField2.Text = "";
            dtpDate.Value = DateTime.Now;
        }

        // Fill ComboBoxes
        _FillComboBoxes();
    }

    // ═══════════ FILL COMBOS ═══════════
    private void _FillComboBoxes()
    {
        DataTable dt = cls<Related>.GetAll<Related>();
        foreach (DataRow row in dt.Rows)
        {
            cb<Related>.Items.Add(row["<RelatedName>"]);
        }
    }

    // ═══════════ LOAD DATA (Update Mode) ═══════════
    private void _LoadEntityData()
    {
        _Entity = cls<Entity>.Find(_EntityID);

        if (_Entity == null)
        {
            MessageBox.Show("No record found with ID = " + _EntityID,
                "Not Found",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
            return;
        }

        // Map business object properties to UI controls
        lblID.Text = _Entity.<Entity>ID.ToString();
        txtField1.Text = _Entity.Field1;
        txtField2.Text = _Entity.Field2.ToString();
        dtpDate.Value = _Entity.Field3;
        cb<Related>.SelectedItem = _Entity.<Related>Info?.Name;
    }

    // ═══════════ SAVE BUTTON ═══════════
    private void btnSave_Click(object sender, EventArgs e)
    {
        // ── Step 1: Validate ──
        if (string.IsNullOrWhiteSpace(txtField1.Text))
        {
            MessageBox.Show("Field1 is required.", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtField1.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtField2.Text))
        {
            MessageBox.Show("Field2 is required.", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtField2.Focus();
            return;
        }

        // ── Step 2: Map controls to business object ──
        _Entity.Field1 = txtField1.Text.Trim();
        _Entity.Field2 = int.Parse(txtField2.Text.Trim());
        _Entity.Field3 = dtpDate.Value;
        _Entity.NullableField = txtNullable.Text.Trim();
        _Entity.Related<Entity>ID = cb<Related>.SelectedIndex + 1;

        // ── Step 3: Save ──
        if (_Entity.Save())
        {
            lblID.Text = _Entity.<Entity>ID.ToString();

            MessageBox.Show("Data saved successfully.", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Flip to Update mode
            _Mode = enMode.Update;
            lblTitle.Text = "Update <Entity>";
        }
        else
        {
            MessageBox.Show("Error: Data was not saved.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ═══════════ CLOSE BUTTON ═══════════
    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
```

---

## User Control — Entity Card

```csharp
public partial class ctrl<Entity>Card : UserControl
{
    // ═══════════ FIELDS ═══════════
    private int _EntityID = -1;
    private cls<Entity> _Entity;

    // ═══════════ PUBLIC PROPERTIES ═══════════
    public int EntityID => _EntityID;
    public cls<Entity> EntityInfo => _Entity;

    // ═══════════ CONSTRUCTOR ═══════════
    public ctrl<Entity>Card()
    {
        InitializeComponent();
    }

    // ═══════════ LOAD BY ID ═══════════
    public void LoadData(int EntityID)
    {
        _EntityID = EntityID;
        _Entity = cls<Entity>.Find(EntityID);

        if (_Entity != null)
        {
            _DisplayData();
        }
        else
        {
            _ResetCard();
        }
    }

    // ═══════════ LOAD BY OBJECT ═══════════
    public void LoadData(cls<Entity> Entity)
    {
        _Entity = Entity;
        _EntityID = Entity.<Entity>ID;
        _DisplayData();
    }

    // ═══════════ DISPLAY ═══════════
    private void _DisplayData()
    {
        lblID.Text = _Entity.<Entity>ID.ToString();
        lblField1.Text = _Entity.Field1;
        lblField2.Text = _Entity.Field2.ToString();
        lblDate.Text = _Entity.Field3.ToShortDateString();
    }

    // ═══════════ RESET ═══════════
    private void _ResetCard()
    {
        lblID.Text = "[????]";
        lblField1.Text = "";
        lblField2.Text = "";
        lblDate.Text = "";
    }
}
```

---

## User Control — Entity Card with Filter (Composite)

```csharp
public partial class ctrl<Entity>CardWithFilter : UserControl
{
    // ═══════════ EVENTS ═══════════
    public event Action<int> On<Entity>Selected;

    // ═══════════ FIELDS ═══════════
    private int _EntityID = -1;
    private bool _FilterEnabled = true;

    // ═══════════ PROPERTIES ═══════════
    public int EntityID => _EntityID;
    public cls<Entity> SelectedEntityInfo =>
        ctrl<Entity>Card1.EntityInfo;

    public bool FilterEnabled
    {
        get { return _FilterEnabled; }
        set
        {
            _FilterEnabled = value;
            gbFilter.Enabled = _FilterEnabled;
        }
    }

    // ═══════════ CONSTRUCTOR ═══════════
    public ctrl<Entity>CardWithFilter()
    {
        InitializeComponent();
    }

    // ═══════════ FIND BUTTON ═══════════
    private void btnFind_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
            return;

        int ID;
        if (!int.TryParse(txtFilterValue.Text, out ID))
        {
            MessageBox.Show("Invalid ID.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        cls<Entity> entity = cls<Entity>.Find(ID);

        if (entity != null)
        {
            _EntityID = ID;
            ctrl<Entity>Card1.LoadData(entity);

            // Raise event to notify parent
            On<Entity>Selected?.Invoke(ID);
        }
        else
        {
            MessageBox.Show("No record found with this ID.",
                "Not Found",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // ═══════════ PUBLIC LOAD (from parent) ═══════════
    public void LoadEntityInfo(int EntityID)
    {
        txtFilterValue.Text = EntityID.ToString();
        ctrl<Entity>Card1.LoadData(EntityID);
        _EntityID = EntityID;
    }
}
```

---

## Custom Event Communication Pattern

Forms and controls communicate via custom delegates and events:

```csharp
// ── In Child Form ──
public delegate void DataBackHandler(object sender, int EntityID);
public event DataBackHandler OnDataBack;

// Raise after successful save:
OnDataBack?.Invoke(this, _Entity.<Entity>ID);

// ── In Parent Form ──
private void btnOpenChild_Click(object sender, EventArgs e)
{
    frmAddUpdate<Entity> frm = new frmAddUpdate<Entity>();
    frm.OnDataBack += HandleDataBack;
    frm.ShowDialog();
}

private void HandleDataBack(object sender, int EntityID)
{
    // Use the returned ID
    _LoadData(EntityID);
}
```

---

## Validation with ErrorProvider

```csharp
// ── In Form ──
private ErrorProvider errorProvider1 = new ErrorProvider();

private void txtField_Validating(object sender, CancelEventArgs e)
{
    TextBox tb = (TextBox)sender;
    if (string.IsNullOrWhiteSpace(tb.Text))
    {
        e.Cancel = true;
        errorProvider1.SetError(tb, "This field is required.");
    }
    else
    {
        errorProvider1.SetError(tb, "");
    }
}

private void btnSave_Click(object sender, EventArgs e)
{
    // ValidateChildren triggers all Validating events
    if (!this.ValidateChildren())
    {
        MessageBox.Show("Please fill all required fields.",
            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    // Proceed with save...
}
```

---

## Dynamic Context Menu State

Enable/disable context menu items based on entity state:

```csharp
private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
{
    if (dgvList.CurrentRow == null)
    {
        e.Cancel = true;
        return;
    }

    int ID = (int)dgvList.CurrentRow.Cells[0].Value;
    cls<Entity> entity = cls<Entity>.Find(ID);

    // Example: disable delete if entity has dependencies
    deleteToolStripMenuItem.Enabled = !entity.HasDependencies;

    // Example: show/hide based on status
    completeToolStripMenuItem.Enabled =
        entity.Status != cls<Entity>.enStatus.Completed;
}
```

---

## Global Utility Classes

### clsGloble — Application-Wide State

```csharp
public class clsGloble
{
    // Currently logged-in user
    public static clsUsers CurrentUser;

    // Quick access to current user ID
    public static int UserID =>
        CurrentUser?.UserID ?? -1;

    // Standard DataGridView formatting
    public static void FormatDataGridView(DataGridView dgv)
    {
        dgv.DefaultCellStyle.Font =
            new Font("Microsoft Sans Serif", 9F);
        dgv.ColumnHeadersDefaultCellStyle.Font =
            new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        dgv.AlternatingRowsDefaultCellStyle.BackColor =
            Color.LightGray;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.ReadOnly = true;
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.MultiSelect = false;
    }
}
```

### clsCheckRights — Permission System

```csharp
public class clsCheckRights
{
    // Permission bit flags — define per system
    const int MANAGE_<ENTITY1> = 1;
    const int MANAGE_<ENTITY2> = 2;
    const int MANAGE_<ENTITY3> = 4;
    const int MANAGE_<ENTITY4> = 8;
    // Add more as powers of 2: 16, 32, 64...

    public static bool HasPermission(int UserPermissions,
        int RequiredPermission)
    {
        return (UserPermissions & RequiredPermission)
            == RequiredPermission;
    }

    // Apply to menu items
    public static void ApplyPermissions(ToolStripMenuItem menuItem,
        int UserPermissions, int RequiredPermission)
    {
        menuItem.Enabled =
            HasPermission(UserPermissions, RequiredPermission);
    }
}
```

---

## Key UI Rules Summary

| Rule | Description |
| ---- | ----------- |
| **Form Mode** | `enMode.AddNew` / `enMode.Update` mirrors BLL |
| **ShowDialog for CRUD** | Always use `ShowDialog()` + refresh after close |
| **MdiParent for List** | List forms opened as MDI children |
| **DataTable Binding** | `dgv.DataSource = cls<Entity>.GetAll()` |
| **Filter via RowFilter** | `dt.DefaultView.RowFilter = ...` |
| **Context Menu** | Edit, Delete, Show Details on DataGridView |
| **Validate Before Save** | Check required fields → focus → return |
| **Map → Save → Message** | Controls → Object → Save() → MessageBox |
| **User Controls** | `ctrl<Entity>Card` for reusable display |
| **Custom Events** | Delegate/event for form-to-form data passing |
| **Global State** | `clsGloble.CurrentUser` for session management |
| **Permissions** | Bitwise flags via `clsCheckRights` |
