
use SchoolDB;
-- Base Tables (no foreign key dependencies)
CREATE TABLE  genders (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    description NVARCHAR(MAX)
);

CREATE TABLE  grade_levels (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    order_no INT NOT NULL UNIQUE,
    description NVARCHAR(MAX)
);

CREATE TABLE  academic_years (
    id INT PRIMARY KEY IDENTITY(1,1),
    year_name NVARCHAR(255) NOT NULL UNIQUE,
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    is_current BIT DEFAULT 0,
    created_at DATETIME,
    updated_at DATETIME
);

CREATE TABLE  users (
    id INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(255) NOT NULL UNIQUE,
    password_hash NVARCHAR(255) NOT NULL,
    email NVARCHAR(255) NOT NULL UNIQUE,
    status NVARCHAR(50) NOT NULL,
    user_type NVARCHAR(50) NOT NULL, -- 'Student', 'Parent', 'Teacher', 'Admin'
    reference_id INT, -- ID of the related entity (student, parent, teacher)
    created_at DATETIME,
    updated_at DATETIME
);

CREATE TABLE  parents (
    id INT PRIMARY KEY IDENTITY(1,1),
    first_name NVARCHAR(255) NOT NULL,
    last_name NVARCHAR(255) NOT NULL,
    phone_number NVARCHAR(50) NOT NULL,
    email NVARCHAR(255) UNIQUE,
    address NVARCHAR(MAX),
    relationship_type NVARCHAR(100) NOT NULL,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BIT DEFAULT 0
);

CREATE TABLE  exam_types (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    description NVARCHAR(MAX)
);

CREATE TABLE  payment_types (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    description NVARCHAR(MAX)
);

CREATE TABLE  rooms (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    capacity INT,
    description NVARCHAR(MAX)
);

CREATE TABLE  classes (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    grade_level_id INT,
    details NVARCHAR(MAX),
    created_by INT,
    updated_by INT,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BIT DEFAULT 0,
    FOREIGN KEY (grade_level_id) REFERENCES  grade_levels(id),
    FOREIGN KEY (created_by) REFERENCES  users(id),
    FOREIGN KEY (updated_by) REFERENCES  users(id)
);

CREATE TABLE  teachers (
    id INT PRIMARY KEY IDENTITY(1,1),
    first_name NVARCHAR(255) NOT NULL,
    last_name NVARCHAR(255) NOT NULL,
    address NVARCHAR(MAX),
    phone_number NVARCHAR(50),
    email NVARCHAR(255) NOT NULL UNIQUE,
    specialization NVARCHAR(255),
    qualification NVARCHAR(255),
    hire_date DATE NOT NULL,
    employment_status NVARCHAR(100) NOT NULL,
    about NVARCHAR(MAX),
    gender_id INT,
    created_by INT,
    updated_by INT,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BIT DEFAULT 0,
    FOREIGN KEY (gender_id) REFERENCES  genders(id),
    FOREIGN KEY (created_by) REFERENCES  users(id),
    FOREIGN KEY (updated_by) REFERENCES  users(id)
);

CREATE TABLE  courses (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    credit_hours INT,
    description NVARCHAR(MAX),
    created_by INT,
    updated_by INT,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BIT DEFAULT 0,
    FOREIGN KEY (created_by) REFERENCES  users(id),
    FOREIGN KEY (updated_by) REFERENCES  users(id)
);

CREATE TABLE  students (
    id INT PRIMARY KEY IDENTITY(1,1),
    first_name NVARCHAR(255) NOT NULL,
    last_name NVARCHAR(255) NOT NULL,
    national_id NVARCHAR(255) UNIQUE,
    date_of_birth DATE NOT NULL,
    gender_id INT,
    nationality NVARCHAR(255),
    blood_type NVARCHAR(10),
    address NVARCHAR(MAX),
    phone_number NVARCHAR(50),
    email NVARCHAR(255) UNIQUE,
    admission_no NVARCHAR(255) NOT NULL UNIQUE,
    admission_date DATE NOT NULL,
    previous_school NVARCHAR(255),
    health_status NVARCHAR(MAX),
    profile_image_url NVARCHAR(255),
    created_by INT,
    updated_by INT,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BIT DEFAULT 0,
    FOREIGN KEY (gender_id) REFERENCES  genders(id),
    FOREIGN KEY (created_by) REFERENCES  users(id),
    FOREIGN KEY (updated_by) REFERENCES  users(id)
);

CREATE TABLE  student_enrollment (
    id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT NOT NULL,
    class_id INT NOT NULL,
    academic_year_id INT NOT NULL,
    enrollment_date DATE NOT NULL,
    withdrawal_date DATE,
    status NVARCHAR(50) NOT NULL, -- 'Active', 'Promoted', 'Graduated', 'Dropped'
    created_at DATETIME,
    updated_at DATETIME,
    FOREIGN KEY (student_id) REFERENCES  students(id),
    FOREIGN KEY (class_id) REFERENCES  classes(id),
    FOREIGN KEY (academic_year_id) REFERENCES  academic_years(id)
);

CREATE TABLE  student_parents (
    student_id INT,
    parent_id INT,
    relationship NVARCHAR(100) NOT NULL,
    is_primary_contact BIT DEFAULT 0,
    PRIMARY KEY (student_id, parent_id),
    FOREIGN KEY (student_id) REFERENCES  students(id),
    FOREIGN KEY (parent_id) REFERENCES  parents(id)
);

CREATE TABLE  class_courses (
    id INT PRIMARY KEY IDENTITY(1,1),
    class_id INT NOT NULL,
    course_id INT NOT NULL,
    teacher_id INT NOT NULL,
    academic_year_id INT NOT NULL,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BIT DEFAULT 0,
    FOREIGN KEY (class_id) REFERENCES  classes(id),
    FOREIGN KEY (course_id) REFERENCES  courses(id),
    FOREIGN KEY (teacher_id) REFERENCES  teachers(id),
    FOREIGN KEY (academic_year_id) REFERENCES  academic_years(id)
);

CREATE TABLE  schedules (
    id INT PRIMARY KEY IDENTITY(1,1),
    class_course_id INT NOT NULL,
    day_of_week NVARCHAR(50) NOT NULL,
    start_time TIME NOT NULL,
    end_time TIME NOT NULL,
    room_id INT NOT NULL,
    academic_year_id INT NOT NULL,
    created_at DATETIME,
    updated_at DATETIME,
    FOREIGN KEY (class_course_id) REFERENCES  class_courses(id),
    FOREIGN KEY (room_id) REFERENCES  rooms(id),
    FOREIGN KEY (academic_year_id) REFERENCES  academic_years(id)
);

CREATE TABLE  attendance (
    id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT NOT NULL,
    class_id INT NOT NULL,
    session_id INT,
    date DATE NOT NULL,
    status NVARCHAR(50) NOT NULL,
    note NVARCHAR(MAX),
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (student_id) REFERENCES  students(id),
    FOREIGN KEY (class_id) REFERENCES  classes(id),
    FOREIGN KEY (session_id) REFERENCES  schedules(id),
    FOREIGN KEY (created_by) REFERENCES  users(id)
);

CREATE TABLE  grades (
    id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT NOT NULL,
    course_id INT NOT NULL,
    exam_type_id INT NOT NULL,
    grade_value DECIMAL(5,2),
    out_of_value DECIMAL(5,2),
    academic_year_id INT NOT NULL,
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (student_id) REFERENCES  students(id),
    FOREIGN KEY (course_id) REFERENCES  courses(id),
    FOREIGN KEY (exam_type_id) REFERENCES  exam_types(id),
    FOREIGN KEY (academic_year_id) REFERENCES  academic_years(id),
    FOREIGN KEY (created_by) REFERENCES  users(id)
);

CREATE TABLE  fee_structures (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL,
    grade_level_id INT NOT NULL,
    academic_year_id INT NOT NULL,
    tuition_fee DECIMAL(10,2) NOT NULL,
    transport_fee DECIMAL(10,2),
    book_fee DECIMAL(10,2),
    other_fees DECIMAL(10,2),
    created_at DATETIME,
    updated_at DATETIME,
    FOREIGN KEY (grade_level_id) REFERENCES  grade_levels(id),
    FOREIGN KEY (academic_year_id) REFERENCES  academic_years(id)
);

CREATE TABLE  invoices (
    id INT PRIMARY KEY IDENTITY(1,1),
    invoice_number NVARCHAR(255) NOT NULL UNIQUE,
    student_id INT NOT NULL,
    academic_year_id INT NOT NULL,
    fee_structure_id INT NOT NULL,
    issue_date DATE NOT NULL,
    due_date DATE NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,
    discount_amount DECIMAL(10,2) DEFAULT 0,
    tax_amount DECIMAL(10,2) DEFAULT 0,
    total_amount DECIMAL(10,2) NOT NULL,
    status NVARCHAR(50) NOT NULL,
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (student_id) REFERENCES  students(id),
    FOREIGN KEY (academic_year_id) REFERENCES  academic_years(id),
    FOREIGN KEY (fee_structure_id) REFERENCES  fee_structures(id),
    FOREIGN KEY (created_by) REFERENCES  users(id)
);

CREATE TABLE  payments (
    id INT PRIMARY KEY IDENTITY(1,1),
    invoice_id INT NOT NULL,
    payment_date DATE NOT NULL,
    amount DECIMAL(10,2) NOT NULL,
    payment_method NVARCHAR(100) NOT NULL,
    payment_type_id INT,
    transaction_id NVARCHAR(255),
    receipt_number NVARCHAR(255) UNIQUE,
    notes NVARCHAR(MAX),
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (invoice_id) REFERENCES  invoices(id),
    FOREIGN KEY (payment_type_id) REFERENCES  payment_types(id),
    FOREIGN KEY (created_by) REFERENCES  users(id)
);
