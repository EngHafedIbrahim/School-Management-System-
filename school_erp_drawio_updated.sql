-- SQL Schema for Draw.io ER Diagram (Updated for better relationship rendering)
-- Copy and paste this code into Draw.io using: Arrange -> Insert -> Advanced -> SQL...

-- Base Tables (no foreign key dependencies or self-referencing handled later)
CREATE TABLE app_genders (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL UNIQUE,
    description TEXT
);

CREATE TABLE app_grade_levels (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL UNIQUE,
    order_no INT NOT NULL UNIQUE,
    description TEXT
);

CREATE TABLE app_academic_years (
    id INT PRIMARY KEY AUTO_INCREMENT,
    year_name VARCHAR(255) NOT NULL UNIQUE,
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    is_current BOOLEAN DEFAULT FALSE,
    created_at DATETIME,
    updated_at DATETIME
);

CREATE TABLE app_users (
    id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(255) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    status VARCHAR(50) NOT NULL,
    created_at DATETIME,
    updated_at DATETIME
);

CREATE TABLE app_parents (
    id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    phone_number VARCHAR(50) NOT NULL,
    email VARCHAR(255) UNIQUE,
    address TEXT,
    relationship_type VARCHAR(100) NOT NULL,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BOOLEAN DEFAULT FALSE
);

CREATE TABLE app_exam_types (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL UNIQUE,
    description TEXT
);

CREATE TABLE app_payment_types (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL UNIQUE,
    description TEXT
);

CREATE TABLE app_departments (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL UNIQUE,
    description TEXT
);

CREATE TABLE app_vehicles (
    id INT PRIMARY KEY AUTO_INCREMENT,
    license_plate VARCHAR(100) NOT NULL UNIQUE,
    make VARCHAR(100),
    model VARCHAR(100),
    capacity INT NOT NULL,
    status VARCHAR(50) NOT NULL
);

CREATE TABLE app_routes (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL UNIQUE,
    description TEXT,
    start_location VARCHAR(255),
    end_location VARCHAR(255)
);

CREATE TABLE app_items (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    category VARCHAR(100),
    unit VARCHAR(50),
    unit_price DECIMAL(10,2),
    stock_quantity INT DEFAULT 0,
    reorder_level INT DEFAULT 0
);

CREATE TABLE app_rooms (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL UNIQUE,
    capacity INT,
    description TEXT
);

-- Tables with dependencies on base tables
CREATE TABLE app_accounts (
    id INT PRIMARY KEY AUTO_INCREMENT,
    account_code VARCHAR(100) NOT NULL UNIQUE,
    account_name VARCHAR(255) NOT NULL UNIQUE,
    account_type VARCHAR(100) NOT NULL,
    parent_account_id INT,
    description TEXT,
    created_at DATETIME,
    updated_at DATETIME,
    FOREIGN KEY (parent_account_id) REFERENCES app_accounts(id)
);

CREATE TABLE app_classes (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL UNIQUE,
    grade_level_id INT,
    details TEXT,
    created_by INT,
    updated_by INT,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (grade_level_id) REFERENCES app_grade_levels(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id),
    FOREIGN KEY (updated_by) REFERENCES app_users(id)
);

CREATE TABLE app_teachers (
    id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    address TEXT,
    phone_number VARCHAR(50),
    email VARCHAR(255) NOT NULL UNIQUE,
    specialization VARCHAR(255),
    qualification VARCHAR(255),
    hire_date DATE NOT NULL,
    employment_status VARCHAR(100) NOT NULL,
    about TEXT,
    gender_id INT,
    created_by INT,
    updated_by INT,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (gender_id) REFERENCES app_genders(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id),
    FOREIGN KEY (updated_by) REFERENCES app_users(id)
);

CREATE TABLE app_courses (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL UNIQUE,
    credit_hours INT,
    description TEXT,
    created_by INT,
    updated_by INT,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (created_by) REFERENCES app_users(id),
    FOREIGN KEY (updated_by) REFERENCES app_users(id)
);

CREATE TABLE app_employees (
    id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    national_id VARCHAR(255) UNIQUE,
    department_id INT,
    job_title VARCHAR(255),
    hire_date DATE NOT NULL,
    salary DECIMAL(10,2),
    status VARCHAR(50) NOT NULL,
    created_at DATETIME,
    updated_at DATETIME,
    FOREIGN KEY (department_id) REFERENCES app_departments(id)
);

CREATE TABLE app_suppliers (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    contact_person VARCHAR(255),
    phone_number VARCHAR(50),
    email VARCHAR(255),
    address TEXT
);

CREATE TABLE app_purchase_orders (
    id INT PRIMARY KEY AUTO_INCREMENT,
    order_number VARCHAR(255) NOT NULL UNIQUE,
    supplier_id INT NOT NULL,
    order_date DATE NOT NULL,
    expected_delivery_date DATE,
    total_amount DECIMAL(10,2),
    status VARCHAR(50) NOT NULL,
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (supplier_id) REFERENCES app_suppliers(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

-- Tables with further dependencies
CREATE TABLE app_students (
    id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    national_id VARCHAR(255) UNIQUE,
    date_of_birth DATE NOT NULL,
    gender_id INT,
    nationality VARCHAR(255),
    blood_type VARCHAR(10),
    address TEXT,
    phone_number VARCHAR(50),
    email VARCHAR(255) UNIQUE,
    admission_no VARCHAR(255) NOT NULL UNIQUE,
    admission_date DATE NOT NULL,
    previous_school VARCHAR(255),
    health_status TEXT,
    current_class_id INT,
    academic_year_id INT,
    total_fees_amount DECIMAL(10,2),
    feeding_option BOOLEAN,
    profile_image_url VARCHAR(255),
    created_by INT,
    updated_by INT,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (gender_id) REFERENCES app_genders(id),
    FOREIGN KEY (current_class_id) REFERENCES app_classes(id),
    FOREIGN KEY (academic_year_id) REFERENCES app_academic_years(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id),
    FOREIGN KEY (updated_by) REFERENCES app_users(id)
);

CREATE TABLE app_student_parents (
    student_id INT,
    parent_id INT,
    relationship VARCHAR(100) NOT NULL,
    is_primary_contact BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (student_id, parent_id),
    FOREIGN KEY (student_id) REFERENCES app_students(id),
    FOREIGN KEY (parent_id) REFERENCES app_parents(id)
);

CREATE TABLE app_class_courses (
    id INT PRIMARY KEY AUTO_INCREMENT,
    class_id INT NOT NULL,
    course_id INT NOT NULL,
    teacher_id INT NOT NULL,
    academic_year_id INT NOT NULL,
    created_at DATETIME,
    updated_at DATETIME,
    is_deleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (class_id) REFERENCES app_classes(id),
    FOREIGN KEY (course_id) REFERENCES app_courses(id),
    FOREIGN KEY (teacher_id) REFERENCES app_teachers(id),
    FOREIGN KEY (academic_year_id) REFERENCES app_academic_years(id)
);

CREATE TABLE app_schedules (
    id INT PRIMARY KEY AUTO_INCREMENT,
    class_course_id INT NOT NULL,
    day_of_week VARCHAR(50) NOT NULL,
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
    id INT PRIMARY KEY AUTO_INCREMENT,
    student_id INT NOT NULL,
    class_id INT NOT NULL,
    session_id INT,
    date DATE NOT NULL,
    status VARCHAR(50) NOT NULL,
    note TEXT,
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (student_id) REFERENCES app_students(id),
    FOREIGN KEY (class_id) REFERENCES app_classes(id),
    FOREIGN KEY (session_id) REFERENCES app_schedules(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

CREATE TABLE app_grades (
    id INT PRIMARY KEY AUTO_INCREMENT,
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
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
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
    id INT PRIMARY KEY AUTO_INCREMENT,
    invoice_number VARCHAR(255) NOT NULL UNIQUE,
    student_id INT NOT NULL,
    academic_year_id INT NOT NULL,
    fee_structure_id INT NOT NULL,
    issue_date DATE NOT NULL,
    due_date DATE NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,
    discount_amount DECIMAL(10,2) DEFAULT 0,
    tax_amount DECIMAL(10,2) DEFAULT 0,
    total_amount DECIMAL(10,2) NOT NULL,
    status VARCHAR(50) NOT NULL,
    created_by INT,
    created_at DATETIME,
    updated_at DATETIME,
    FOREIGN KEY (student_id) REFERENCES app_students(id),
    FOREIGN KEY (academic_year_id) REFERENCES app_academic_years(id),
    FOREIGN KEY (fee_structure_id) REFERENCES app_fee_structures(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

CREATE TABLE app_payments (
    id INT PRIMARY KEY AUTO_INCREMENT,
    invoice_id INT NOT NULL,
    payment_date DATE NOT NULL,
    amount DECIMAL(10,2) NOT NULL,
    payment_method VARCHAR(100) NOT NULL,
    payment_type_id INT,
    transaction_id VARCHAR(255),
    receipt_number VARCHAR(255) UNIQUE,
    notes TEXT,
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (invoice_id) REFERENCES app_invoices(id),
    FOREIGN KEY (payment_type_id) REFERENCES app_payment_types(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

CREATE TABLE app_transport_assignments (
    id INT PRIMARY KEY AUTO_INCREMENT,
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
    id INT PRIMARY KEY AUTO_INCREMENT,
    transaction_date DATE NOT NULL,
    reference_number VARCHAR(255),
    description TEXT NOT NULL,
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
    id INT PRIMARY KEY AUTO_INCREMENT,
    recipient_user_id INT,
    recipient_student_id INT,
    recipient_parent_id INT,
    type VARCHAR(50) NOT NULL,
    subject VARCHAR(255),
    message_body TEXT NOT NULL,
    sent_at DATETIME NOT NULL,
    status VARCHAR(50) NOT NULL,
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (recipient_user_id) REFERENCES app_users(id),
    FOREIGN KEY (recipient_student_id) REFERENCES app_students(id),
    FOREIGN KEY (recipient_parent_id) REFERENCES app_parents(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

CREATE TABLE app_notes (
    id INT PRIMARY KEY AUTO_INCREMENT,
    student_id INT,
    teacher_id INT,
    parent_id INT,
    note_type VARCHAR(100),
    note_content TEXT NOT NULL,
    created_by INT,
    created_at DATETIME,
    FOREIGN KEY (student_id) REFERENCES app_students(id),
    FOREIGN KEY (teacher_id) REFERENCES app_teachers(id),
    FOREIGN KEY (parent_id) REFERENCES app_parents(id),
    FOREIGN KEY (created_by) REFERENCES app_users(id)
);

CREATE TABLE app_logs (
    id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT,
    action VARCHAR(255) NOT NULL,
    table_name VARCHAR(255),
    record_id INT,
    ip_address VARCHAR(50),
    description TEXT,
    created_at DATETIME,
    FOREIGN KEY (user_id) REFERENCES app_users(id)
);
