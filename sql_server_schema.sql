-- SQL Server Schema for Draw.io ER Diagram
-- Based on the provided MySQL schema, converted for SQL Server compatibility.

-- Base Tables
CREATE TABLE app_genders (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    description NVARCHAR(MAX)
);

CREATE TABLE app_grade_levels (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    order_no INT NOT NULL UNIQUE,
    description NVARCHAR(MAX)
);

CREATE TABLE app_academic_years (
    id INT PRIMARY KEY IDENTITY(1,1),
    year_name NVARCHAR(255) NOT NULL UNIQUE,
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    is_current BIT DEFAULT 0,
    created_at DATETIME,
    updated_at DATETIME
);

CREATE TABLE app_users (
    id INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(255) NOT NULL UNIQUE,
    password_hash NVARCHAR(255) NOT NULL,
    email NVARCHAR(255) NOT NULL UNIQUE,
    status NVARCHAR(50) NOT NULL,
    created_at DATETIME,
    updated_at DATETIME
);

CREATE TABLE app_parents (
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

CREATE TABLE app_exam_types (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    description NVARCHAR(MAX)
);

CREATE TABLE app_payment_types (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    description NVARCHAR(MAX)
);

CREATE TABLE app_departments (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    description NVARCHAR(MAX)
);

CREATE TABLE app_vehicles (
    id INT PRIMARY KEY IDENTITY(1,1),
    license_plate NVARCHAR(100) NOT NULL UNIQUE,
    make NVARCHAR(100),
    model NVARCHAR(100),
    capacity INT NOT NULL,
    status NVARCHAR(50) NOT NULL
);

CREATE TABLE app_routes (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    description NVARCHAR(MAX),
    start_location NVARCHAR(255),
    end_location NVARCHAR(255)
);

CREATE TABLE app_items (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL,
    category NVARCHAR(100),
    unit NVARCHAR(50),
    unit_price DECIMAL(10,2),
    stock_quantity INT DEFAULT 0,
    reorder_level INT DEFAULT 0
);

CREATE TABLE app_rooms (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    capacity INT,
    description NVARCHAR(MAX)
);

-- Tables with dependencies on base tables
CREATE TABLE app_accounts (
    id INT PRIMARY KEY IDENTITY(1,1),
    account_code NVARCHAR(100) NOT NULL UNIQUE,
    account_name NVARCHAR(255) NOT NULL UNIQUE,
    account_type NVARCHAR(100) NOT NULL,
    parent_account_id INT,
    description NVARCHAR(MAX),
    created_at DATETIME,
    updated_at DATETIME,
    FOREIGN KEY (parent_account_id) REFERENCES app_accounts(id)
);

CREATE TABLE app_classes (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    grade_level_id INT,
    details NVARCHAR(MAX),
    created_by INT,
    updated_by INT,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BIT DEFAULT 0,
    FOREIGN KEY (grade_level_id) REFERENCES app_grade_levels(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id),
    FOREIGN KEY (updated_by) REFERENCES app_users(id)
);

CREATE TABLE app_teachers (
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
    FOREIGN KEY (gender_id) REFERENCES app_genders(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id),
    FOREIGN KEY (updated_by) REFERENCES app_users(id)
);

CREATE TABLE app_courses (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL UNIQUE,
    credit_hours INT,
    description NVARCHAR(MAX),
    created_by INT,
    updated_by INT,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BIT DEFAULT 0,
    FOREIGN KEY (created_by) REFERENCES app_users(id),
    FOREIGN KEY (updated_by) REFERENCES app_users(id)
);

CREATE TABLE app_employees (
    id INT PRIMARY KEY IDENTITY(1,1),
    first_name NVARCHAR(255) NOT NULL,
    last_name NVARCHAR(255) NOT NULL,
    national_id NVARCHAR(255) UNIQUE,
    department_id INT,
    job_title NVARCHAR(255),
    hire_date DATE NOT NULL,
    salary DECIMAL(10,2),
    status NVARCHAR(50) NOT NULL,
    created_at DATETIME,
    updated_at DATETIME,
    FOREIGN KEY (department_id) REFERENCES app_departments(id)
);

CREATE TABLE app_suppliers (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL,
    contact_person NVARCHAR(255),
    phone_number NVARCHAR(50),
    email NVARCHAR(255),
    address NVARCHAR(MAX)
);

CREATE TABLE app_purchase_orders (
    id INT PRIMARY KEY IDENTITY(1,1),
    order_number NVARCHAR(255) NOT NULL UNIQUE,
    supplier_id INT NOT NULL,
    order_date DATE NOT NULL,
    expected_delivery_date DATE,
    total_amount DECIMAL(10,2),
    status NVARCHAR(50) NOT NULL,
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (supplier_id) REFERENCES app_suppliers(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

-- Tables with further dependencies
CREATE TABLE app_students (
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
    current_class_id INT,
    academic_year_id INT,
    total_fees_amount DECIMAL(10,2),
    feeding_option BIT,
    profile_image_url NVARCHAR(255),
    created_by INT,
    updated_by INT,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BIT DEFAULT 0,
    FOREIGN KEY (gender_id) REFERENCES app_genders(id),
    FOREIGN KEY (current_class_id) REFERENCES app_classes(id),
    FOREIGN KEY (academic_year_id) REFERENCES app_academic_years(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id),
    FOREIGN KEY (updated_by) REFERENCES app_users(id)
);

CREATE TABLE app_student_parents (
    student_id INT,
    parent_id INT,
    relationship NVARCHAR(100) NOT NULL,
    is_primary_contact BIT DEFAULT 0,
    PRIMARY KEY (student_id, parent_id),
    FOREIGN KEY (student_id) REFERENCES app_students(id),
    FOREIGN KEY (parent_id) REFERENCES app_parents(id)
);

CREATE TABLE app_class_courses (
    id INT PRIMARY KEY IDENTITY(1,1),
    class_id INT NOT NULL,
    course_id INT NOT NULL,
    teacher_id INT NOT NULL,
    academic_year_id INT NOT NULL,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BIT DEFAULT 0,
    FOREIGN KEY (class_id) REFERENCES app_classes(id),
    FOREIGN KEY (course_id) REFERENCES app_courses(id),
    FOREIGN KEY (teacher_id) REFERENCES app_teachers(id),
    FOREIGN KEY (academic_year_id) REFERENCES app_academic_years(id)
);

CREATE TABLE app_schedules (
    id INT PRIMARY KEY IDENTITY(1,1),
    class_course_id INT NOT NULL,
    day_of_week NVARCHAR(50) NOT NULL,
    start_time TIME NOT NULL,
    end_time TIME NOT NULL,
    room_id INT NOT NULL,
    academic_year_id INT NOT NULL,
    created_at DATETIME,
    updated_at DATETIME,
    FOREIGN KEY (class_course_id) REFERENCES app_class_courses(id),
    FOREIGN KEY (room_id) REFERENCES app_rooms(id),
    FOREIGN KEY (academic_year_id) REFERENCES app_academic_years(id)
);

CREATE TABLE app_attendance (
    id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT NOT NULL,
    class_id INT NOT NULL,
    session_id INT,
    date DATE NOT NULL,
    status NVARCHAR(50) NOT NULL,
    note NVARCHAR(MAX),
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (student_id) REFERENCES app_students(id),
    FOREIGN KEY (class_id) REFERENCES app_classes(id),
    FOREIGN KEY (session_id) REFERENCES app_schedules(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

CREATE TABLE app_grades (
    id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT NOT NULL,
    course_id INT NOT NULL,
    exam_type_id INT NOT NULL,
    grade_value DECIMAL(5,2),
    out_of_value DECIMAL(5,2),
    academic_year_id INT NOT NULL,
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (student_id) REFERENCES app_students(id),
    FOREIGN KEY (course_id) REFERENCES app_courses(id),
    FOREIGN KEY (exam_type_id) REFERENCES app_exam_types(id),
    FOREIGN KEY (academic_year_id) REFERENCES app_academic_years(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

CREATE TABLE app_fee_structures (
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
    FOREIGN KEY (grade_level_id) REFERENCES app_grade_levels(id),
    FOREIGN KEY (academic_year_id) REFERENCES app_academic_years(id)
);

CREATE TABLE app_invoices (
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
    FOREIGN KEY (student_id) REFERENCES app_students(id),
    FOREIGN KEY (academic_year_id) REFERENCES app_academic_years(id),
    FOREIGN KEY (fee_structure_id) REFERENCES app_fee_structures(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

CREATE TABLE app_payments (
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
    FOREIGN KEY (invoice_id) REFERENCES app_invoices(id),
    FOREIGN KEY (payment_type_id) REFERENCES app_payment_types(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

CREATE TABLE app_transport_assignments (
    id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT NOT NULL,
    vehicle_id INT NOT NULL,
    route_id INT NOT NULL,
    academic_year_id INT NOT NULL,
    pickup_time TIME,
    dropoff_time TIME,
    FOREIGN KEY (student_id) REFERENCES app_students(id),
    FOREIGN KEY (vehicle_id) REFERENCES app_vehicles(id),
    FOREIGN KEY (route_id) REFERENCES app_routes(id),
    FOREIGN KEY (academic_year_id) REFERENCES app_academic_years(id)
);

CREATE TABLE app_purchase_order_items (
    purchase_order_id INT,
    item_id INT,
    quantity INT NOT NULL,
    unit_price DECIMAL(10,2) NOT NULL,
    total_price DECIMAL(10,2) NOT NULL,
    PRIMARY KEY (purchase_order_id, item_id),
    FOREIGN KEY (purchase_order_id) REFERENCES app_purchase_orders(id),
    FOREIGN KEY (item_id) REFERENCES app_items(id)
);

CREATE TABLE app_transactions (
    id INT PRIMARY KEY IDENTITY(1,1),
    transaction_date DATE NOT NULL,
    reference_number NVARCHAR(255),
    description NVARCHAR(MAX) NOT NULL,
    debit_account_id INT NOT NULL,
    credit_account_id INT NOT NULL,
    amount DECIMAL(10,2) NOT NULL,
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (debit_account_id) REFERENCES app_accounts(id),
    FOREIGN KEY (credit_account_id) REFERENCES app_accounts(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

CREATE TABLE app_notifications (
    id INT PRIMARY KEY IDENTITY(1,1),
    recipient_user_id INT,
    recipient_student_id INT,
    recipient_parent_id INT,
    type NVARCHAR(50) NOT NULL,
    subject NVARCHAR(255),
    message_body NVARCHAR(MAX) NOT NULL,
    sent_at DATETIME NOT NULL,
    status NVARCHAR(50) NOT NULL,
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (recipient_user_id) REFERENCES app_users(id),
    FOREIGN KEY (recipient_student_id) REFERENCES app_students(id),
    FOREIGN KEY (recipient_parent_id) REFERENCES app_parents(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

CREATE TABLE app_notes (
    id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT,
    teacher_id INT,
    parent_id INT,
    note_type NVARCHAR(100),
    note_content NVARCHAR(MAX) NOT NULL,
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (student_id) REFERENCES app_students(id),
    FOREIGN KEY (teacher_id) REFERENCES app_teachers(id),
    FOREIGN KEY (parent_id) REFERENCES app_parents(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

CREATE TABLE app_logs (
    id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT,
    action NVARCHAR(255) NOT NULL,
    table_name NVARCHAR(255),
    record_id INT,
    ip_address NVARCHAR(50),
    description NVARCHAR(MAX),
    created_at DATETIME,
    FOREIGN KEY (user_id) REFERENCES app_users(id)
);
