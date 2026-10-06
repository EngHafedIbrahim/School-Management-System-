# Business Layer (BLL) — Code Templates & Patterns

This reference document provides the complete, copy-paste-ready code templates
for the Business Layer. Every BLL class MUST follow these exact patterns.

---

## Complete Business Class Template

```csharp
using System;
using System.Data;
using <ProjectName>_DataAccessLayer;

namespace <ProjectName>_BusinessLayer
{
    public class cls<Entity>
    {
        // ═══════════════════════════════════════════════════
        // 1. MODE ENUM
        // ═══════════════════════════════════════════════════
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        // ═══════════════════════════════════════════════════
        // 2. PROPERTIES (one per database column)
        // ═══════════════════════════════════════════════════

        // Primary Key
        public int <Entity>ID { get; set; }

        // Required fields
        public string Field1 { get; set; }
        public int Field2 { get; set; }
        public DateTime Field3 { get; set; }

        // Nullable fields
        public string NullableField { get; set; }

        // Foreign Keys
        public int Related<Entity>ID { get; set; }

        // ═══════════════════════════════════════════════════
        // 3. NAVIGATION PROPERTIES (lazy-loaded)
        // ═══════════════════════════════════════════════════
        // Related entities loaded on-demand via their Find method
        public cls<Related> <Related>Info
        {
            get { return cls<Related>.Find(this.Related<Entity>ID); }
        }

        // Computed properties
        public string FullName
        {
            get { return Field1 + " " + Field2; }
        }

        // ═══════════════════════════════════════════════════
        // 4. DEFAULT CONSTRUCTOR (AddNew mode) — PUBLIC
        // ═══════════════════════════════════════════════════
        public cls<Entity>()
        {
            this.<Entity>ID = -1;
            this.Field1 = "";
            this.Field2 = -1;
            this.Field3 = DateTime.Now;
            this.NullableField = "";
            this.Related<Entity>ID = -1;
            Mode = enMode.AddNew;
        }

        // ═══════════════════════════════════════════════════
        // 5. PARAMETERIZED CONSTRUCTOR (Update mode) — PRIVATE
        // ═══════════════════════════════════════════════════
        // Only accessible through Find() factory methods.
        // This ensures objects loaded from DB are always in Update mode.
        private cls<Entity>(int <Entity>ID, string Field1, int Field2,
            DateTime Field3, string NullableField, int Related<Entity>ID)
        {
            this.<Entity>ID = <Entity>ID;
            this.Field1 = Field1;
            this.Field2 = Field2;
            this.Field3 = Field3;
            this.NullableField = NullableField;
            this.Related<Entity>ID = Related<Entity>ID;
            Mode = enMode.Update;
        }

        // ═══════════════════════════════════════════════════
        // 6. STATIC FIND (Factory Method) — by Primary Key
        // ═══════════════════════════════════════════════════
        public static cls<Entity> Find(int <Entity>ID)
        {
            // Declare local variables matching all ref params in DAL
            string Field1 = "";
            int Field2 = -1;
            DateTime Field3 = DateTime.Now;
            string NullableField = "";
            int Related<Entity>ID = -1;

            // Call DAL with ref parameters
            if (clsDA<Entity>.Find(<Entity>ID,
                ref Field1, ref Field2, ref Field3,
                ref NullableField, ref Related<Entity>ID))
            {
                // Construct using private constructor → Update mode
                return new cls<Entity>(<Entity>ID, Field1, Field2,
                    Field3, NullableField, Related<Entity>ID);
            }

            // Not found → return null
            return null;
        }

        // ═══════════════════════════════════════════════════
        // 7. STATIC FIND — by Unique Field (overload)
        // ═══════════════════════════════════════════════════
        public static cls<Entity> Find(string UniqueField)
        {
            int <Entity>ID = -1;
            string Field1 = "";
            int Field2 = -1;

            if (clsDA<Entity>.Find(UniqueField,
                ref <Entity>ID, ref Field1, ref Field2))
            {
                return new cls<Entity>(<Entity>ID, Field1, Field2,
                    DateTime.Now, "", -1);
            }

            return null;
        }

        // ═══════════════════════════════════════════════════
        // 8. PRIVATE _AddNew — calls DAL AddNew
        // ═══════════════════════════════════════════════════
        private bool _AddNew<Entity>()
        {
            // Pass all properties (except ID) to DAL
            this.<Entity>ID = clsDA<Entity>.AddNew<Entity>(
                this.Field1,
                this.Field2,
                this.Field3,
                this.NullableField);

            // DAL returns -1 on failure
            return (this.<Entity>ID != -1);
        }

        // ═══════════════════════════════════════════════════
        // 9. PRIVATE _Update — calls DAL Update
        // ═══════════════════════════════════════════════════
        private bool _Update<Entity>()
        {
            // Pass ID + all properties to DAL
            return clsDA<Entity>.Update<Entity>(
                this.<Entity>ID,
                this.Field1,
                this.Field2,
                this.Field3,
                this.NullableField);
        }

        // ═══════════════════════════════════════════════════
        // 10. PUBLIC SAVE — unified entry point
        // ═══════════════════════════════════════════════════
        // The caller never needs to know if it's an INSERT or UPDATE.
        // The Mode enum handles this automatically.
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew<Entity>())
                    {
                        // IMPORTANT: Flip to Update after successful insert.
                        // Subsequent Save() calls will perform updates.
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _Update<Entity>();
            }
            return false;
        }

        // ═══════════════════════════════════════════════════
        // 11. STATIC HELPERS — delegate directly to DAL
        // ═══════════════════════════════════════════════════

        public static DataTable GetAll<Entities>()
        {
            return clsDA<Entity>.GetAll<Entities>();
        }

        public static bool Is<Entity>Exist(int <Entity>ID)
        {
            return clsDA<Entity>.Is<Entity>Exist(<Entity>ID);
        }

        public static bool Is<Entity>Exist(string UniqueField)
        {
            return clsDA<Entity>.Is<Entity>Exist(UniqueField);
        }

        public static bool Delete<Entity>(int <Entity>ID)
        {
            return clsDA<Entity>.Delete<Entity>(<Entity>ID);
        }
    }
}
```

---

## Inheritance Pattern (Specialized Entity)

When an entity is a specialization of another (e.g., LocalDrivingLicenseApp
extends Application), use inheritance:

```csharp
public class cls<SpecializedEntity> : cls<BaseEntity>
{
    // Additional properties for the specialized entity
    public int SpecializedID { get; set; }
    public int ExtraField { get; set; }

    // Navigation property for specialized lookup
    public string ExtraFieldName
    {
        get { return cls<Lookup>.Find(ExtraField)?.Name ?? ""; }
    }

    // Default Constructor
    public cls<SpecializedEntity>()
    {
        this.SpecializedID = -1;
        this.ExtraField = -1;
        Mode = enMode.AddNew;
    }

    // Private Parameterized Constructor
    private cls<SpecializedEntity>(int SpecializedID,
        int BaseEntityID, int ApplicantID, DateTime Date,
        int TypeID, byte Status, DateTime LastStatusDate,
        decimal PaidFees, int CreatedByUserID,
        int ExtraField)
        : base(BaseEntityID, ApplicantID, Date, TypeID,
               Status, LastStatusDate, PaidFees, CreatedByUserID)
    {
        this.SpecializedID = SpecializedID;
        this.ExtraField = ExtraField;
        Mode = enMode.Update;
    }

    // Find — creates full object with base + specialized data
    public new static cls<SpecializedEntity> Find(int SpecializedID)
    {
        // Declare all ref vars for both base and specialized
        int BaseEntityID = -1, ApplicantID = -1, TypeID = -1;
        // ...

        if (clsDA<SpecializedEntity>.Find(SpecializedID,
            ref BaseEntityID, ref ApplicantID, ...))
        {
            return new cls<SpecializedEntity>(SpecializedID,
                BaseEntityID, ApplicantID, ...);
        }
        return null;
    }

    // _AddNew — saves base first, then specialized
    private bool _AddNew()
    {
        // First save the base entity
        if (base.Save())
        {
            // Use base.ApplicationID as foreign key
            this.SpecializedID =
                clsDA<SpecializedEntity>.AddNew(
                    base.ApplicationID,
                    this.ExtraField);
            return (this.SpecializedID != -1);
        }
        return false;
    }

    // Save — overrides base
    public new bool Save()
    {
        switch (Mode)
        {
            case enMode.AddNew:
                if (_AddNew())
                {
                    Mode = enMode.Update;
                    return true;
                }
                return false;
            case enMode.Update:
                return _Update();
        }
        return false;
    }
}
```

---

## Entity with Enums Pattern

Entities with status or type fields should define enums:

```csharp
public class clsApplication
{
    // Status Enum
    public enum enApplicationStatus
    {
        New = 1,
        Cancelled = 2,
        Completed = 3
    }

    // Type Enum
    public enum enApplicationType
    {
        NewLocalDrivingLicense = 1,
        RenewDrivingLicense = 2,
        ReplacementLost = 3,
        ReplacementDamaged = 4,
        ReleaseDetainedLicense = 5,
        NewInternationalLicense = 6,
        RetakeTest = 7
    }

    // Issue Reason Enum (for Licenses)
    public enum enIssueReason
    {
        FirstTime = 1,
        Renew = 2,
        ReplacementLost = 3,
        ReplacementDamaged = 4
    }

    public enApplicationStatus ApplicationStatus { get; set; }
    public enApplicationType ApplicationType { get; set; }
}
```

---

## Complex Business Operations Pattern

For multi-step business operations (e.g., renewing a license):

```csharp
// In clsLicenses:
public clsLicenses RenewLicense(string Notes, int CreatedByUserID)
{
    // Step 1: Create a renewal application
    clsApplication RenewApplication = new clsApplication();
    RenewApplication.ApplicantPersonID = this.DriverInfo.PersonID;
    RenewApplication.ApplicationDate = DateTime.Now;
    RenewApplication.ApplicationTypeID =
        (int)clsApplication.enApplicationType.RenewDrivingLicense;
    RenewApplication.ApplicationStatus =
        clsApplication.enApplicationStatus.Completed;
    RenewApplication.PaidFees =
        clsApplicationTypes.Find(
            (int)clsApplication.enApplicationType.RenewDrivingLicense).Fees;
    RenewApplication.CreatedByUserID = CreatedByUserID;

    if (!RenewApplication.Save()) return null;

    // Step 2: Deactivate the current license
    clsLicenses.DeActivateLicense(this.LicenseID);

    // Step 3: Create the new license
    clsLicenses NewLicense = new clsLicenses();
    NewLicense.ApplicationID = RenewApplication.ApplicationID;
    NewLicense.DriverID = this.DriverID;
    NewLicense.LicenseClassID = this.LicenseClassID;
    NewLicense.IssueDate = DateTime.Now;
    NewLicense.ExpirationDate = DateTime.Now.AddYears(
        this.LicenseClassInfo.DefaultValidityLength);
    NewLicense.Notes = Notes;
    NewLicense.PaidFees = this.LicenseClassInfo.ClassFees;
    NewLicense.IsActive = true;
    NewLicense.IssueReason = enIssueReason.Renew;

    if (NewLicense.Save())
        return NewLicense;

    return null;
}
```

---

## Key Rules Summary

| Rule | Description |
| ---- | ----------- |
| **Private Parameterized Constructor** | Objects from DB created only via `Find()` |
| **Public Default Constructor** | For creating new entities (`Mode = AddNew`) |
| **Mode Flip on Insert** | After `_AddNew()` succeeds, `Mode = Update` |
| **Null Return on Not Found** | `Find()` returns `null` if DAL returns `false` |
| **Save() is Single Entry Point** | Never expose `_AddNew()` or `_Update()` |
| **Static for Queries** | `Find()`, `GetAll()`, `IsExist()`, `Delete()` |
| **Instance for Mutations** | `Save()`, `_AddNew()`, `_Update()` |
| **Navigation Props are Lazy** | Load related entities via `Find()` in getter |
| **DataTable for Lists** | `GetAll()` returns `DataTable` for UI binding |
| **Inheritance for Specialization** | Base entity saves first, then specialized |
