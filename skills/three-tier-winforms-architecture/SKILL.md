---
name: three-tier-winforms-architecture
description: >-
  Use this skill when the user asks to build a new desktop management system
  (Windows Forms) using C# with a 3-Tier Architecture (Data Access Layer,
  Business Layer, Presentation Layer) connected to SQL Server. This skill
  defines the exact coding methodology, naming conventions, class structures,
  CRUD patterns, and UI design patterns to follow, and is tailored for the
  School Management System (School ERP). Activate this skill for
  any request involving: creating a new management system, adding new entities
  to an existing system, or building CRUD forms with DataGridView.
---

# Three-Tier Windows Forms Architecture Skill (School ERP)

This skill defines a complete methodology for building **C# Windows Forms
management systems** using a **3-Tier Architecture** with **SQL Server**, 
specifically adapted for the **School Management System (ERP)**.

Every new system or entity added to an existing system MUST follow the patterns
described below. For detailed code templates and examples, refer to the
[references/](./references/) directory.

### Project Resources (School ERP System)

The `references/school_erp_documents/` directory contains the essential requirements and design documents for the School Management System (ERP):
- **`Final SRS V.1.pdf` / `Final SRS .docx`**: Software Requirements Specification for the school ERP system.
- **`DB Desgin School.pdf`**: The database design and schema details.
- **`Requerments of school system With DBTables.pdf`**: System requirements mapped to database tables.
- **`Use_Case_Specificat.pdf`**: Detailed use case specifications.
- **`School_ERP_Requirements_Technical_v2.xlsx`**: Technical requirements and tracking.

> [!IMPORTANT]
> A summarized extraction of all system use cases and business rules is available at:
> **[Use Cases Reference](./references/use-cases.md)**. Always refer to this document when implementing Business Logic Layer (BLL) validations.

When building the system, always refer to these documents to understand the business logic, database tables, and user interfaces required.

---

## Architecture Overview

```
┌──────────────────────────────────────────────────┐
│              Presentation Layer                   │
│  (Windows Forms + User Controls)                  │
│  Forms: frm<Action><Entity>                       │
│  Controls: ctrl<Entity>                           │
├──────────────────────────────────────────────────┤
│              Business Layer                       │
│  (Entity Classes with Mode Pattern)               │
│  Classes: cls<Entity>                             │
│  Pattern: Find → Set Properties → Save()          │
├──────────────────────────────────────────────────┤
│              Data Access Layer                    │
│  (Static ADO.NET Classes)                         │
│  Classes: clsDA<Entity> or clsDAL<Entity>         │
│  Uses: Stored Procedures + SqlConnection          │
├──────────────────────────────────────────────────┤
│              SQL Server Database                  │
│  Stored Procedures: SP_<Action><Entity>            │
│  Tables + Views                                   │
└──────────────────────────────────────────────────┘
```

---

## Solution Structure

```
<ProjectName>.sln
├── <ProjectName>DataAccessLayer/     # Class Library (.NET Framework)
│   ├── clsDataAccessSettings.cs      # Connection string
│   └── clsDA<Entity>.cs              # One file per entity
├── <ProjectName>BusinessLayer/       # Class Library (.NET Framework)
│   └── cls<Entity>.cs                # One file per entity
├── <ProjectName>/                    # Windows Forms Application
│   ├── Program.cs                    # Entry point
│   ├── frmMainScreen.cs              # MDI Parent
│   ├── Login/                        # Login forms
│   ├── <Entity>/                     # Folder per entity
│   │   ├── frmAddUpdate<Entity>.cs   # Add/Update form
│   │   ├── frmList<Entity>.cs        # List form with DataGridView
│   │   ├── frmShow<Entity>.cs        # Read-only details form
│   │   └── ctrl<Entity>Card.cs       # User Control for entity display
│   └── Globle Classes/               # Global utilities
│       ├── clsGloble.cs              # Current user, shared settings
│       └── clsCheckRights.cs         # Permission checking
└── UtilityLib/                       # Class Library (shared utilities)
    └── Globles/
        └── clsLogger.cs              # Windows Event Log logger
```

---

## Layer 1: Data Access Layer (DAL)

### Connection Settings

```csharp
static class clsDataAccessSettings
{
    public static string ConnectionString =
        "Server=.;Database=<DBName>;User Id=sa;Password=<pwd>;";
}
```

### DAL Class Pattern

Each entity gets a **static class** with **all static methods**. The class name
follows: `clsDA<EntityName>`.

Read the full DAL reference:
[DAL Code Templates](./references/dal-patterns.md)

### Method Signatures Summary

| Operation    | Signature                                               | Returns        |
| ------------ | ------------------------------------------------------- | -------------- |
| **Find**     | `static bool Find(int ID, ref string F1, ref int F2…)`  | `bool`         |
| **AddNew**   | `static int AddNew<Entity>(string F1, int F2…)`         | `int` (new ID) |
| **Update**   | `static bool Update<Entity>(int ID, string F1…)`        | `bool`         |
| **Delete**   | `static bool Delete<Entity>(int ID)`                    | `bool`         |
| **GetAll**   | `static DataTable GetAll<Entities>()`                   | `DataTable`    |
| **IsExist**  | `static bool Is<Entity>Exist(int ID)`                   | `bool`         |

### Key DAL Rules

1. **Every method** creates its own `SqlConnection` inside a `using` block.
2. **All database calls** use Stored Procedures with `CommandType.StoredProcedure`.
3. **Stored Procedure naming**: `SP_<Action><Entity>` (e.g., `SP_AddNewPerson`,
   `SP_FindPersonByPersonID`, `SP_GetAllPeople`).
4. **Parameters** use `command.Parameters.AddWithValue("@ParamName", value)`.
5. **Nullable fields** → write: `(object)value ?? DBNull.Value`;
   read: `(reader["Col"] != DBNull.Value) ? (T)reader["Col"] : default`.
6. **Error handling**: `try-catch` with `clsEventLogger.LogEvent(ex.Message, EventLogEntryType.Error)`.
7. **Find methods** return `bool` and populate `ref` parameters.
8. **AddNew methods** use `ExecuteScalar()` to get `SCOPE_IDENTITY()`.
9. **Update/Delete** use `ExecuteNonQuery()` and return `RowsAffected > 0`.
10. **GetAll** returns `DataTable` via `dt.Load(reader)`.

---

## Layer 2: Business Layer (BLL)

### Business Class Pattern

Each entity gets a class `cls<EntityName>` that follows the **Mode-Based Active
Record** pattern. The class manages its own persistence state.

Read the full BLL reference:
[Business Layer Code Templates](./references/bll-patterns.md)

### Core Structure

```csharp
public class cls<Entity>
{
    // 1. Mode Enum
    enum enMode { AddNew = 0, Update = 1 }
    enMode Mode = enMode.AddNew;

    // 2. Properties (one per DB column)
    public int <Entity>ID { get; set; }
    public string <Field> { get; set; }
    // ... all fields

    // 3. Navigation Properties (related entities)
    public cls<Related> <Related>Info
    {
        get { return cls<Related>.Find(this.<RelatedID>); }
    }

    // 4. Default Constructor (AddNew mode)
    public cls<Entity>()
    {
        this.<Entity>ID = -1;
        // ... set defaults
        Mode = enMode.AddNew;
    }

    // 5. Parameterized Constructor (Update mode) — PRIVATE
    private cls<Entity>(int ID, string Field1, ...)
    {
        this.<Entity>ID = ID;
        this.<Field1> = Field1;
        // ... assign all
        Mode = enMode.Update;
    }

    // 6. Static Find (Factory Method)
    public static cls<Entity> Find(int ID)
    {
        // Declare ref variables
        string Field1 = ""; int Field2 = -1;
        if (clsDA<Entity>.Find(ID, ref Field1, ref Field2, ...))
            return new cls<Entity>(ID, Field1, Field2, ...);
        return null;
    }

    // 7. Private _AddNew
    private bool _AddNew<Entity>()
    {
        this.<Entity>ID = clsDA<Entity>.AddNew<Entity>(this.<Field1>, ...);
        return (this.<Entity>ID != -1);
    }

    // 8. Private _Update
    private bool _Update<Entity>()
    {
        return clsDA<Entity>.Update<Entity>(this.<Entity>ID, this.<Field1>, ...);
    }

    // 9. Public Save (unified entry point)
    public bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNew<Entity>())
                {
                    Mode = enMode.Update; // Flip to Update after insert
                    return true;
                }
                return false;
            case enMode.Update:
                return _Update<Entity>();
        }
        return false;
    }

    // 10. Static Helpers (delegate to DAL)
    public static DataTable GetAll<Entities>() => clsDA<Entity>.GetAll<Entities>();
    public static bool Is<Entity>Exist(int ID) => clsDA<Entity>.Is<Entity>Exist(ID);
    public static bool Delete<Entity>(int ID) => clsDA<Entity>.Delete<Entity>(ID);
}
```

### Key BLL Rules

1. **Parameterized constructor is PRIVATE** — objects in Update mode can only be
   created through `Find()` factory methods.
2. **Default constructor is PUBLIC** — used for creating new entities.
3. **`Save()` is the single entry point** for persistence. It checks `Mode` to
   decide between `_AddNew()` and `_Update()`.
4. **After successful `_AddNew()`**, mode flips to `Update`. Subsequent `Save()`
   calls perform updates.
5. **Navigation properties** lazily load related entities:
   `public clsPeople PersonInfo => clsPeople.Find(PersonID);`
6. **Static methods** for queries: `Find()`, `GetAll()`, `IsExist()`, `Delete()`.
7. **Instance methods** for mutations: `Save()`, `_AddNew()`, `_Update()`.
8. **Inheritance** is used when an entity specializes another (e.g.,
   `clsLocalDrivingLicenseApplication : clsApplicationData`).

---

## Layer 3: Presentation Layer (UI)

### Form Types & Naming

| Form Type     | Naming Pattern            | Purpose                       |
| ------------- | ------------------------- | ----------------------------- |
| List Form     | `frmList<Entities>`       | DataGridView + search/filter  |
| Add/Update    | `frmAddUpdate<Entity>`    | Form with TextBoxes for CRUD  |
| Show Details  | `frmShow<Entity>Info`     | Read-only entity display      |
| User Control  | `ctrl<Entity>Card`        | Reusable entity card display  |
| Filter+Card   | `ctrl<Entity>WithFilter`  | Search box + entity card      |

Read the full UI reference:
[Presentation Layer Code Templates](./references/ui-patterns.md)

### Form Mode Pattern

Forms mirror the BLL mode pattern:

```csharp
public enum enMode { AddNew = 0, Update = 1 }
private enMode _Mode;
private cls<Entity> _Entity;

// Constructor for AddNew
public frmAddUpdate<Entity>()
{
    InitializeComponent();
    _Mode = enMode.AddNew;
    _Entity = new cls<Entity>();
}

// Constructor for Update
public frmAddUpdate<Entity>(int EntityID)
{
    InitializeComponent();
    _Mode = enMode.Update;
    _Entity = cls<Entity>.Find(EntityID);
}
```

### Save Button Pattern

```csharp
private void btnSave_Click(object sender, EventArgs e)
{
    // 1. Validate inputs
    if (string.IsNullOrWhiteSpace(txtName.Text))
    {
        MessageBox.Show("Name is required.", "Validation Error",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtName.Focus();
        return;
    }

    // 2. Map controls to business object
    _Entity.Name = txtName.Text.Trim();
    _Entity.Date = dtpDate.Value;
    // ... all fields

    // 3. Call Save()
    if (_Entity.Save())
    {
        MessageBox.Show("Data Saved Successfully.", "Saved",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        _Mode = enMode.Update;
    }
    else
    {
        MessageBox.Show("Error: Data was not saved.", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
```

### List Form Pattern

```csharp
public partial class frmList<Entities> : Form
{
    private void _FillDataGridView()
    {
        dgvList.DataSource = cls<Entity>.GetAll<Entities>();
        lblRecords.Text = dgvList.RowCount.ToString();
    }

    // Search/Filter
    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        string col = cbFilterBy.Text;
        string val = txtSearch.Text.Trim();
        if (string.IsNullOrEmpty(val))
        {
            _FillDataGridView();
            return;
        }
        if (dgvList.DataSource is DataTable dt)
        {
            if (col == "<Entity>ID")
                dt.DefaultView.RowFilter = $"{col} = {val}";
            else
                dt.DefaultView.RowFilter = $"{col} LIKE '%{val}%'";
            lblRecords.Text = dgvList.RowCount.ToString();
        }
    }

    // Context Menu → Edit
    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int ID = (int)dgvList.CurrentRow.Cells[0].Value;
        frmAddUpdate<Entity> frm = new frmAddUpdate<Entity>(ID);
        frm.ShowDialog();
        _FillDataGridView(); // Refresh
    }

    // Context Menu → Delete
    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int ID = (int)dgvList.CurrentRow.Cells[0].Value;
        if (MessageBox.Show("Are you sure?", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            if (cls<Entity>.Delete<Entity>(ID))
            {
                MessageBox.Show("Deleted.", "Done");
                _FillDataGridView();
            }
        }
    }
}
```

### Navigation Pattern

- **MDI Parent** (`frmMainScreen`): `this.IsMdiContainer = true;`
- **Child Forms**: Opened via menu items with `frm.MdiParent = this; frm.Show();`
- **Dialog Forms**: `frm.ShowDialog()` for Add/Update and detail views
- **Data Passing**: Via constructor parameters (entity IDs)
- **Refresh**: Call `_FillDataGridView()` after `ShowDialog()` returns

### User Control Pattern

```csharp
public partial class ctrl<Entity>Card : UserControl
{
    private int _EntityID = -1;

    public int EntityID => _EntityID;

    public void LoadData(int EntityID)
    {
        _EntityID = EntityID;
        cls<Entity> entity = cls<Entity>.Find(EntityID);
        if (entity != null)
        {
            lblName.Text = entity.Name;
            lblID.Text = entity.<Entity>ID.ToString();
            // ... populate labels
        }
    }
}
```

---

## Global Classes

### clsGloble (Global State)
```csharp
public class clsGloble
{
    public static clsUsers CurrentUser;
    // ... shared app-wide settings
}
```

### clsCheckRights (Permissions)
```csharp
public class clsCheckRights
{
    public static bool HasPermission(int UserPermissions, int Required)
    {
        return (UserPermissions & Required) == Required;
    }
}
```

### clsLogger (Windows Event Log)
```csharp
public class clsLogger
{
    public static void Error(string msg)
    {
        EventLog.WriteEntry("<AppName>", msg, EventLogEntryType.Error);
    }
    public static void Info(string msg)
    {
        EventLog.WriteEntry("<AppName>", msg, EventLogEntryType.Information);
    }
}
```

---

## Database Conventions

### Stored Procedure Naming

| Operation  | SP Name Pattern                    | Example                       |
| ---------- | ---------------------------------- | ----------------------------- |
| Find by ID | `SP_Find<Entity>By<EntityID>`      | `SP_FindPersonByPersonID`     |
| Find by X  | `SP_Find<Entity>By<Field>`         | `SP_FindUserByUsername`       |
| Add        | `SP_AddNew<Entity>`                | `SP_AddNewPerson`             |
| Update     | `SP_Update<Entity>`                | `SP_UpdatePerson`             |
| Delete     | `SP_Delete<Entity>`                | `SP_DeletePerson`             |
| Get All    | `SP_GetAll<Entities>`              | `SP_GetAllPeople`             |
| Is Exist   | `SP_Is<Entity>Exist`               | `SP_IsPersonExist`            |

### AddNew SP Template

```sql
CREATE PROCEDURE SP_AddNew<Entity>
    @Field1 NVARCHAR(50),
    @Field2 INT,
    ...
AS
BEGIN
    INSERT INTO <Table> (Field1, Field2, ...)
    VALUES (@Field1, @Field2, ...);

    SELECT SCOPE_IDENTITY();
END
```

---

## Step-by-Step: Adding a New Entity

When adding a new entity to the system, follow these steps in order:

### Step 1: Database
1. Create the table in SQL Server.
2. Create all stored procedures: `SP_Find...`, `SP_AddNew...`, `SP_Update...`,
   `SP_Delete...`, `SP_GetAll...`, `SP_Is...Exist`.

### Step 2: Data Access Layer
1. Create `clsDA<Entity>.cs` in the DataAccessLayer project.
2. Implement all static methods: `Find`, `AddNew`, `Update`, `Delete`,
   `GetAll`, `IsExist`.
3. Follow the exact patterns in [dal-patterns.md](./references/dal-patterns.md).

### Step 3: Business Layer
1. Create `cls<Entity>.cs` in the BusinessLayer project.
2. Implement: `enMode`, properties, constructors (default + private param),
   `Find()`, `_AddNew()`, `_Update()`, `Save()`, static helpers.
3. Follow the exact patterns in [bll-patterns.md](./references/bll-patterns.md).

### Step 4: Presentation Layer
1. Create a folder `<Entity>/` in the main project.
2. Create `frmList<Entities>.cs` with DataGridView + filter + context menu.
3. Create `frmAddUpdate<Entity>.cs` with TextBoxes + Save button.
4. Create `ctrl<Entity>Card.cs` if needed for reusable display.
5. Add menu items in `frmMainScreen` to open the new forms.
6. Follow the exact patterns in [ui-patterns.md](./references/ui-patterns.md).

### Step 5: Verify
1. Build the solution — ensure no compilation errors.
2. Test Add, Update, Delete, and List operations.
3. Test search/filter in the list form.
4. Verify navigation properties load correctly.



