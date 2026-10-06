# School ERP System - Use Cases Specification

This document outlines the core use cases for the School Management System. When building features, ensure that the UI, BLL, and DAL implementations strictly adhere to these workflows and constraints.

## 1. Students Management (إدارة الطلاب)

### UC-001: Register a New Student
* **Actor**: Admin
* **Description**: Enter basic information for a new student.
* **Constraints/Rules**:
  * `admission_no` must be unique per student.
  * `national_id` must be unique per student.
  * `email` must be unique and valid.
  * `date_of_birth` must be valid (student cannot be younger than minimum admission age).
* **Postcondition**: Record created in `app_students` and optionally `app_users`.

### UC-002: Link Student with Parent
* **Actor**: Admin
* **Description**: Select an existing student and parent, and create a relationship (Father, Mother, Guardian).
* **Constraints/Rules**:
  * Each student must have at least one primary contact (`is_primary_contact = TRUE`).
  * Cannot link the same student to the same parent with the same relationship type more than once.
* **Postcondition**: Record created in `app_student_parents`.

### UC-003: Register Student in a Class
* **Actor**: Admin
* **Description**: Enroll a student in a specific class for a specific academic year.
* **Constraints/Rules**:
  * A student cannot be enrolled in two different classes in the same academic year.
  * `enrollment_date` must be valid.
* **Postcondition**: Record created in `app_student_enrollment`.

---

## 2. Teachers and Courses Management (إدارة المعلمين والمواد الدراسية)

### UC-004: Register a New Teacher
* **Actor**: Admin
* **Description**: Enter basic information for a new teacher (Name, phone, email, specialization, hire date, etc.).
* **Constraints/Rules**:
  * `email` must be unique and valid.
  * `hire_date` must be valid.
* **Postcondition**: Record created in `app_teachers` and `app_users`.

### UC-005: Create a New Course (Subject)
* **Actor**: Admin
* **Description**: Add a new course with its name, credit hours, and description.
* **Constraints/Rules**:
  * `name` must be unique.
  * `credit_hours` must be a positive integer.
* **Postcondition**: Record created in `app_courses`.

### UC-006: Assign Course to Class and Teacher
* **Actor**: Admin
* **Description**: Link a course to a specific class and assign a teacher for a specific academic year.
* **Constraints/Rules**:
  * Cannot assign the same course to the same class with the same teacher in the same academic year.
  * Teacher must be qualified for the course.
* **Postcondition**: Record created in `app_class_courses`.

---

## 3. Schedules Management (إدارة الجداول الزمنية)

### UC-007: Create Class Schedule
* **Actor**: Admin
* **Description**: Define the time (day, start time, end time) and room for a class course.
* **Constraints/Rules**:
  * No time conflicts allowed for the same Teacher, Class, or Room.
  * `start_time` must be before `end_time`.
* **Postcondition**: Record created in `app_schedules`.

---

## 4. Attendance Management (إدارة الحضور والغياب)

### UC-008: Record Student Attendance
* **Actor**: Teacher
* **Description**: Mark student attendance (Present, Absent, Late) for a specific scheduled session.
* **Constraints/Rules**:
  * Cannot record attendance for a future date.
  * Attendance status must be strictly one of the defined values (Present, Absent, Late).
  * Cannot record duplicate attendance for the same student, session, and date.
* **Postcondition**: Record created in `app_attendance`.

---

## 5. Grades and Evaluation Management (إدارة الدرجات والتقييم)

### UC-009: Enter Student Grades
* **Actor**: Teacher
* **Description**: Enter the grade obtained by a student for a specific course and exam type.
* **Constraints/Rules**:
  * `grade_value` must not exceed `out_of_value`.
  * Cannot enter multiple grades for the same student, course, exam type, and academic year.
* **Postcondition**: Record created in `app_grades`.

---

## 6. Fees and Payments Management (إدارة الرسوم والمدفوعات)

### UC-010: Define Fee Structures
* **Actor**: Admin
* **Description**: Define tuition, transport, books, and other fees for an academic level and year.
* **Constraints/Rules**:
  * All fee amounts must be positive numbers.
  * Cannot define multiple fee structures for the same level and academic year.
* **Postcondition**: Record created in `app_fee_structures`.

### UC-011: Issue Invoice to Student
* **Actor**: Admin
* **Description**: Generate an invoice for a student based on the applicable fee structure.
* **Constraints/Rules**:
  * `invoice_number` must be unique.
  * `issue_date` and `due_date` must be valid.
  * `subtotal` must match the applied fee structure.
  * `discount_amount` and `tax_amount` must be positive or zero.
* **Postcondition**: Record created in `app_invoices` with status `Unpaid`.

### UC-012: Record a Payment
* **Actor**: Admin
* **Description**: Record a payment made by a parent/student against a specific invoice.
* **Constraints/Rules**:
  * `amount` must be positive and cannot exceed the remaining balance of the invoice.
  * `payment_date` must be valid.
* **Postcondition**: Record created in `app_payments`. Invoice status updated to `Paid` or `Partial`.

### UC-013: View Invoices and Payments Status
* **Actor**: Parent
* **Description**: Parent logs in to view a list of invoices and payments associated with their children.
* **Constraints/Rules**:
  * Parents can only view financial data linked to their registered children.
  * Data displayed must be accurate and up to date.

---

## 7. Users and Permissions Management (إدارة المستخدمين والصلاحيات)

### UC-014: Create User Account
* **Actor**: Admin
* **Description**: Create accounts for different user types (Admin, Teacher, Parent, Student) and link to respective entity.
* **Constraints/Rules**:
  * `username` and `email` must be unique.
  * `user_type` must be strictly Admin, Teacher, Parent, or Student.
  * `reference_id` must point to a valid ID in the respective entity table based on `user_type`.
* **Postcondition**: Record created in `app_users`.

---

## 8. Reports (التقارير)

### UC-015: View Student Performance Report
* **Actor**: Admin, Parent
* **Description**: Generate a comprehensive report combining a student's grades, attendance, and enrollment status.
* **Constraints/Rules**:
  * Parents can only view reports for their own children.
