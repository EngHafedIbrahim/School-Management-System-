CREATE DATABASE SchoolManagementSystemDB;
GO
USE SchoolManagementSystemDB;
GO

CREATE TABLE AcademicYear (
    AcademicYearID int IDENTITY(1,1) PRIMARY KEY,
    YearName nvarchar(MAX) NOT NULL,
    StartDate datetime NOT NULL,
    EndDate datetime NOT NULL,
    IsCurrent bit NOT NULL,
    CreatedAt datetime NOT NULL,
    UpdatedAt datetime NOT NULL
);
GO

CREATE TABLE Attendance (
    AttendanceID int IDENTITY(1,1) PRIMARY KEY,
    StudentID int NOT NULL,
    ClassID int NOT NULL,
    SessionID int NOT NULL,
    Date datetime NOT NULL,
    Status nvarchar(MAX) NOT NULL,
    Note nvarchar(MAX) NOT NULL,
    CreatedBy int NOT NULL,
    CreatedAt datetime NOT NULL
);
GO

CREATE TABLE ClassCourse (
    ClassCourseID int IDENTITY(1,1) PRIMARY KEY,
    ClassID int NOT NULL,
    CourseID int NOT NULL,
    TeacherID int NOT NULL,
    AcademicYearID int NOT NULL,
    CreatedAt datetime NOT NULL,
    UpdatedAt datetime NOT NULL,
    IsDeleted bit NOT NULL
);
GO

CREATE TABLE Class (
    ClassID int IDENTITY(1,1) PRIMARY KEY,
    Name nvarchar(MAX) NOT NULL,
    GradeLevelID int NOT NULL,
    Details nvarchar(MAX) NOT NULL,
    CreatedBy int NOT NULL,
    UpdatedBy int NOT NULL,
    CreatedAt datetime NOT NULL,
    UpdatedAt datetime NOT NULL,
    IsDeleted bit NOT NULL
);
GO

CREATE TABLE Course (
    CourseID int IDENTITY(1,1) PRIMARY KEY,
    Name nvarchar(MAX) NOT NULL,
    CreditHours int NOT NULL,
    Description nvarchar(MAX) NOT NULL,
    CreatedBy int NOT NULL,
    UpdatedBy int NOT NULL,
    CreatedAt datetime NOT NULL,
    UpdatedAt datetime NOT NULL,
    IsDeleted bit NOT NULL
);
GO

CREATE TABLE ExamType (
    ExamTypeID int IDENTITY(1,1) PRIMARY KEY,
    Name nvarchar(MAX) NOT NULL,
    Description nvarchar(MAX) NOT NULL
);
GO

CREATE TABLE FeeStructure (
    FeeStructureID int IDENTITY(1,1) PRIMARY KEY,
    Name nvarchar(MAX) NOT NULL,
    GradeLevelID int NOT NULL,
    AcademicYearID int NOT NULL,
    TuitionFee decimal(18,2) NOT NULL,
    TransportFee decimal(18,2) NOT NULL,
    BookFee decimal(18,2) NOT NULL,
    OtherFees decimal(18,2) NOT NULL,
    CreatedAt datetime NOT NULL,
    UpdatedAt datetime NOT NULL
);
GO

CREATE TABLE Gender (
    GenderID int IDENTITY(1,1) PRIMARY KEY,
    Name nvarchar(MAX) NOT NULL,
    Description nvarchar(MAX) NOT NULL
);
GO

CREATE TABLE GradeLevel (
    GradeLevelID int IDENTITY(1,1) PRIMARY KEY,
    Name nvarchar(MAX) NOT NULL,
    OrderNo int NOT NULL,
    Description nvarchar(MAX) NOT NULL
);
GO

CREATE TABLE Grade (
    GradeID int IDENTITY(1,1) PRIMARY KEY,
    StudentID int NOT NULL,
    CourseID int NOT NULL,
    ExamTypeID int NOT NULL,
    GradeValue decimal(18,2) NOT NULL,
    OutOfValue decimal(18,2) NOT NULL,
    AcademicYearID int NOT NULL,
    CreatedBy int NOT NULL,
    CreatedAt datetime NOT NULL
);
GO

CREATE TABLE Invoice (
    InvoiceID int IDENTITY(1,1) PRIMARY KEY,
    InvoiceNumber nvarchar(MAX) NOT NULL,
    StudentID int NOT NULL,
    AcademicYearID int NOT NULL,
    FeeStructureID int NOT NULL,
    IssueDate datetime NOT NULL,
    DueDate datetime NOT NULL,
    Subtotal decimal(18,2) NOT NULL,
    DiscountAmount decimal(18,2) NOT NULL,
    TaxAmount decimal(18,2) NOT NULL,
    TotalAmount decimal(18,2) NOT NULL,
    Status nvarchar(MAX) NOT NULL,
    CreatedBy int NOT NULL
);
GO

CREATE TABLE Parent (
    ParentID int IDENTITY(1,1) PRIMARY KEY,
    FirstName nvarchar(MAX) NOT NULL,
    LastName nvarchar(MAX) NOT NULL,
    PhoneNumber nvarchar(MAX) NOT NULL,
    Email nvarchar(MAX) NOT NULL,
    Address nvarchar(MAX) NOT NULL,
    RelationshipType nvarchar(MAX) NOT NULL,
    CreatedAt datetime NOT NULL,
    UpdatedAt datetime NOT NULL,
    IsDeleted bit NOT NULL
);
GO

CREATE TABLE PaymentType (
    PaymentTypeID int IDENTITY(1,1) PRIMARY KEY,
    Name nvarchar(MAX) NOT NULL,
    Description nvarchar(MAX) NOT NULL
);
GO

CREATE TABLE Payment (
    PaymentID int IDENTITY(1,1) PRIMARY KEY,
    InvoiceID int NOT NULL,
    PaymentDate datetime NOT NULL,
    Amount decimal(18,2) NOT NULL,
    PaymentMethod nvarchar(MAX) NOT NULL,
    PaymentTypeID int NOT NULL,
    TransactionID nvarchar(MAX) NOT NULL,
    ReceiptNumber nvarchar(MAX) NOT NULL,
    Notes nvarchar(MAX) NOT NULL,
    CreatedBy int NOT NULL,
    CreatedAt datetime NOT NULL
);
GO

CREATE TABLE Room (
    RoomID int IDENTITY(1,1) PRIMARY KEY,
    Name nvarchar(MAX) NOT NULL,
    Capacity int NOT NULL,
    Description nvarchar(MAX) NOT NULL
);
GO

CREATE TABLE Schedule (
    ScheduleID int IDENTITY(1,1) PRIMARY KEY,
    ClassCourseID int NOT NULL,
    DayOfWeek nvarchar(MAX) NOT NULL,
    StartTime time NOT NULL,
    EndTime time NOT NULL,
    RoomID int NOT NULL,
    AcademicYearID int NOT NULL,
    CreatedAt datetime NOT NULL,
    UpdatedAt datetime NOT NULL
);
GO

CREATE TABLE StudentEnrollment (
    StudentEnrollmentID int IDENTITY(1,1) PRIMARY KEY,
    StudentID int NOT NULL,
    ClassID int NOT NULL,
    AcademicYearID int NOT NULL,
    EnrollmentDate datetime NOT NULL,
    WithdrawalDate datetime NULL,
    Status nvarchar(MAX) NOT NULL,
    CreatedAt datetime NOT NULL,
    UpdatedAt datetime NOT NULL
);
GO

CREATE TABLE StudentParent (
    StudentParentID int IDENTITY(1,1) PRIMARY KEY,
    StudentID int NOT NULL,
    ParentID int NOT NULL,
    Relationship nvarchar(MAX) NOT NULL,
    IsPrimaryContact bit NOT NULL
);
GO

CREATE TABLE Student (
    StudentID int IDENTITY(1,1) PRIMARY KEY,
    FirstName nvarchar(MAX) NOT NULL,
    LastName nvarchar(MAX) NOT NULL,
    NationalID nvarchar(MAX) NOT NULL,
    DateOfBirth datetime NOT NULL,
    GenderID int NOT NULL,
    Nationality nvarchar(MAX) NOT NULL,
    BloodType nvarchar(MAX) NOT NULL,
    Address nvarchar(MAX) NOT NULL,
    PhoneNumber nvarchar(MAX) NOT NULL,
    Email nvarchar(MAX) NOT NULL,
    AdmissionNo nvarchar(MAX) NOT NULL,
    AdmissionDate datetime NOT NULL,
    PreviousSchool nvarchar(MAX) NOT NULL,
    HealthStatus nvarchar(MAX) NOT NULL,
    ProfileImageURL nvarchar(MAX) NOT NULL,
    CreatedBy int NOT NULL,
    UpdatedBy int NOT NULL,
    CreatedAt datetime NOT NULL,
    UpdatedAt datetime NOT NULL
);
GO

CREATE TABLE Teacher (
    TeacherID int IDENTITY(1,1) PRIMARY KEY,
    FirstName nvarchar(MAX) NOT NULL,
    LastName nvarchar(MAX) NOT NULL,
    Address nvarchar(MAX) NOT NULL,
    PhoneNumber nvarchar(MAX) NOT NULL,
    Email nvarchar(MAX) NOT NULL,
    Specialization nvarchar(MAX) NOT NULL,
    Qualification nvarchar(MAX) NOT NULL,
    HireDate datetime NOT NULL,
    EmploymentStatus nvarchar(MAX) NOT NULL,
    About nvarchar(MAX) NOT NULL,
    GenderID int NOT NULL,
    CreatedBy int NOT NULL,
    UpdatedBy int NOT NULL,
    CreatedAt datetime NOT NULL,
    UpdatedAt datetime NOT NULL
);
GO

CREATE TABLE User (
    UserID int IDENTITY(1,1) PRIMARY KEY,
    Username nvarchar(MAX) NOT NULL,
    PasswordHash nvarchar(MAX) NOT NULL,
    Email nvarchar(MAX) NOT NULL,
    Status nvarchar(MAX) NOT NULL,
    UserType nvarchar(MAX) NOT NULL,
    ReferenceID int NULL,
    CreatedAt datetime NOT NULL,
    UpdatedAt datetime NOT NULL
);
GO

ALTER TABLE Attendance ADD CONSTRAINT FK_Attendance_StudentID FOREIGN KEY (StudentID) REFERENCES Student(StudentID);
GO

ALTER TABLE Attendance ADD CONSTRAINT FK_Attendance_ClassID FOREIGN KEY (ClassID) REFERENCES Class(ClassID);
GO

ALTER TABLE Attendance ADD CONSTRAINT FK_Attendance_SessionID FOREIGN KEY (SessionID) REFERENCES Schedule(ScheduleID);
GO

ALTER TABLE ClassCourse ADD CONSTRAINT FK_ClassCourse_ClassID FOREIGN KEY (ClassID) REFERENCES Class(ClassID);
GO

ALTER TABLE ClassCourse ADD CONSTRAINT FK_ClassCourse_CourseID FOREIGN KEY (CourseID) REFERENCES Course(CourseID);
GO

ALTER TABLE ClassCourse ADD CONSTRAINT FK_ClassCourse_TeacherID FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID);
GO

ALTER TABLE ClassCourse ADD CONSTRAINT FK_ClassCourse_AcademicYearID FOREIGN KEY (AcademicYearID) REFERENCES AcademicYear(AcademicYearID);
GO

ALTER TABLE Class ADD CONSTRAINT FK_Class_GradeLevelID FOREIGN KEY (GradeLevelID) REFERENCES GradeLevel(GradeLevelID);
GO

ALTER TABLE FeeStructure ADD CONSTRAINT FK_FeeStructure_GradeLevelID FOREIGN KEY (GradeLevelID) REFERENCES GradeLevel(GradeLevelID);
GO

ALTER TABLE FeeStructure ADD CONSTRAINT FK_FeeStructure_AcademicYearID FOREIGN KEY (AcademicYearID) REFERENCES AcademicYear(AcademicYearID);
GO

ALTER TABLE Grade ADD CONSTRAINT FK_Grade_StudentID FOREIGN KEY (StudentID) REFERENCES Student(StudentID);
GO

ALTER TABLE Grade ADD CONSTRAINT FK_Grade_CourseID FOREIGN KEY (CourseID) REFERENCES Course(CourseID);
GO

ALTER TABLE Grade ADD CONSTRAINT FK_Grade_ExamTypeID FOREIGN KEY (ExamTypeID) REFERENCES ExamType(ExamTypeID);
GO

ALTER TABLE Grade ADD CONSTRAINT FK_Grade_AcademicYearID FOREIGN KEY (AcademicYearID) REFERENCES AcademicYear(AcademicYearID);
GO

ALTER TABLE Invoice ADD CONSTRAINT FK_Invoice_StudentID FOREIGN KEY (StudentID) REFERENCES Student(StudentID);
GO

ALTER TABLE Invoice ADD CONSTRAINT FK_Invoice_AcademicYearID FOREIGN KEY (AcademicYearID) REFERENCES AcademicYear(AcademicYearID);
GO

ALTER TABLE Invoice ADD CONSTRAINT FK_Invoice_FeeStructureID FOREIGN KEY (FeeStructureID) REFERENCES FeeStructure(FeeStructureID);
GO

ALTER TABLE Payment ADD CONSTRAINT FK_Payment_InvoiceID FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID);
GO

ALTER TABLE Payment ADD CONSTRAINT FK_Payment_PaymentTypeID FOREIGN KEY (PaymentTypeID) REFERENCES PaymentType(PaymentTypeID);
GO

ALTER TABLE Schedule ADD CONSTRAINT FK_Schedule_ClassCourseID FOREIGN KEY (ClassCourseID) REFERENCES ClassCourse(ClassCourseID);
GO

ALTER TABLE Schedule ADD CONSTRAINT FK_Schedule_RoomID FOREIGN KEY (RoomID) REFERENCES Room(RoomID);
GO

ALTER TABLE Schedule ADD CONSTRAINT FK_Schedule_AcademicYearID FOREIGN KEY (AcademicYearID) REFERENCES AcademicYear(AcademicYearID);
GO

ALTER TABLE StudentEnrollment ADD CONSTRAINT FK_StudentEnrollment_StudentID FOREIGN KEY (StudentID) REFERENCES Student(StudentID);
GO

ALTER TABLE StudentEnrollment ADD CONSTRAINT FK_StudentEnrollment_ClassID FOREIGN KEY (ClassID) REFERENCES Class(ClassID);
GO

ALTER TABLE StudentEnrollment ADD CONSTRAINT FK_StudentEnrollment_AcademicYearID FOREIGN KEY (AcademicYearID) REFERENCES AcademicYear(AcademicYearID);
GO

ALTER TABLE StudentParent ADD CONSTRAINT FK_StudentParent_StudentID FOREIGN KEY (StudentID) REFERENCES Student(StudentID);
GO

ALTER TABLE StudentParent ADD CONSTRAINT FK_StudentParent_ParentID FOREIGN KEY (ParentID) REFERENCES Parent(ParentID);
GO

ALTER TABLE Student ADD CONSTRAINT FK_Student_GenderID FOREIGN KEY (GenderID) REFERENCES Gender(GenderID);
GO

ALTER TABLE Teacher ADD CONSTRAINT FK_Teacher_GenderID FOREIGN KEY (GenderID) REFERENCES Gender(GenderID);
GO

