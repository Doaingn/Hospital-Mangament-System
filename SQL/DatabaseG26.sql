-- DDL สำหรับสร้างฐานข้อมูล
CREATE DATABASE DatabaseG26
ON PRIMARY
(
	NAME=DatabaseG26_DAT,
	FILENAME= 'D:\1101173\database\DatabaseG26.mdf',
	SIZE=5,
	MAXSIZE=20,
	FILEGROWTH=1
)
LOG ON
(
	NAME= dbEmployee_LOG,
	FILENAME='D:\1101173\database\DatabaseG26.ldf',
	SIZE=5,
	MAXSIZE=5,
	FILEGROWTH=1
)

-- DDL สำหรับสร้างตารางข้อมูล

-- ที่อยู่
CREATE TABLE Addresses (
    Address_ID CHAR(4) NOT NULL,
    House_No VARCHAR(10) NOT NULL,
    Street VARCHAR(100) NOT NULL,
    District VARCHAR(50) NOT NULL,
    Province VARCHAR(50) NOT NULL,
    Postal_Code VARCHAR(10) NOT NULL,
    Country VARCHAR(50) NOT NULL,
	CONSTRAINT PK_Address PRIMARY KEY (Address_ID)
);

-- เอาไว้สำหรับ staffs log in
CREATE TABLE Users (
	Users_ID CHAR(4) NOT NULL,
	username VARCHAR(20) NOT NULL,
	password VARCHAR(20) NOT NULL
	CONSTRAINT PK_User PRIMARY KEY (Users_ID)
)

-- ข้อมูลหลักของ staffs
CREATE TABLE Staffs (
	S_Num CHAR(4) NOT NULL,
    S_ID CHAR(13) NOT NULL, /*เลขประจำตัว ปชช*/
    First_Name VARCHAR(50) NOT NULL,
    Last_Name VARCHAR(50) NOT NULL,
    Date_of_Birth DATE NOT NULL,
    Sex CHAR(1) NOT NULL,
	Position VARCHAR(50) NOT NULL,
    PhoneNum VARCHAR(10) NOT NULL,
    CurrentSalary DECIMAL(10, 2) NOT NULL, /*มีตัวเลขได้สูงสุด 10 หลัก มีทศนิยมได้ 2 ตำแหน่ง*/
	SalaryScale VARCHAR(20) NOT NULL,
    Address_ID CHAR(4) NOT NULL,
	Users_ID CHAR(4) NOT NULL
	CONSTRAINT PK_Staff PRIMARY KEY (S_Num),
	CONSTRAINT FK_Staff_Address FOREIGN KEY (Address_ID) REFERENCES Addresses(Address_ID),
	CONSTRAINT FK_Staff_Users FOREIGN KEY (Users_ID) REFERENCES Users(Users_ID)
);

-- วุฒิการศึกษาของ staffs ต้องกรอกข้อมูลของ staffs ก่อน ถึงกรอกได้
CREATE TABLE Qualifications (
    Qualification_ID CHAR(4) NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Institution VARCHAR(50) NOT NULL,
    Date_of_Qualification DATE NOT NULL,
    S_Num CHAR(4) NOT NULL,
	CONSTRAINT PK_Qualification PRIMARY KEY (Qualification_ID),
	CONSTRAINT FK_Staff_Qualifications FOREIGN KEY (S_Num) REFERENCES Staffs(S_Num)
);

-- สัญญาจ้างงานของ staffs ต้องกรอกข้อมูลของ staffs ก่อน ถึงกรอกได้
CREATE TABLE Employment_Contracts (
    Contract_ID CHAR(4) NOT NULL,
    Hours_Worked_per_Week DECIMAL(5, 2) NOT NULL,
    Contract_Type VARCHAR(50) NOT NULL,
    Salary_Payment_Type VARCHAR(50) NOT NULL,
    S_Num CHAR(4) NOT NULL,
	CONSTRAINT PK_Employment_Cont PRIMARY KEY (Contract_ID),
    CONSTRAINT FK_Staff_Contracts FOREIGN KEY (S_Num) REFERENCES Staffs(S_Num)
);

-- ประสบการณ์การทำงานของ staffs ต้องกรอกข้อมูลของ staffs ก่อน ถึงกรอกได้
CREATE TABLE Work_Experience (
    Wex_ID CHAR(4) NOT NULL,
    Organization VARCHAR(100) NOT NULL,
    Position VARCHAR(50) NOT NULL,
    Start_Date DATE,
    End_Date DATE,
    S_Num CHAR(4) NOT NULL,
	CONSTRAINT PK_Work_Experience PRIMARY KEY (Wex_ID),
    CONSTRAINT FK_Staff_Work_Exp FOREIGN KEY (S_Num) REFERENCES Staffs(S_Num)
);

-- คลินิกท้องถิ่น
CREATE TABLE Local_Clinics (
    clinicID CHAR(5) NOT NULL,
    clinicName VARCHAR(100) NOT NULL,
    PhoneNum VARCHAR(10) NOT NULL,
    Address_ID CHAR(4) NOT NULL,
    CONSTRAINT PK_Local_Clinics PRIMARY KEY (clinicID),
    CONSTRAINT FK_Clinics_Address FOREIGN KEY (Address_ID) REFERENCES Addresses(Address_ID)
);

-- แพทย์ท้องถิ่น
CREATE TABLE Local_Doctors (
    doctorID CHAR(4) NOT NULL,
    First_Name VARCHAR(50) NOT NULL,
    Last_Name VARCHAR(50) NOT NULL,
    PhoneNum VARCHAR(10) NOT NULL,
    clinicID CHAR(5) NOT NULL,
    CONSTRAINT PK_Local_Doctors PRIMARY KEY (doctorID),
    CONSTRAINT FK_Doctors_Clinics FOREIGN KEY (clinicID) REFERENCES Local_Clinics(clinicID)
);

-- หอผู้ป่วย
CREATE TABLE Wards (
    W_Num VARCHAR(6) NOT NULL,
    W_Name VARCHAR(100) NOT NULL,
    Location VARCHAR(100) NOT NULL,
    Total_Beds INT NOT NULL,
    Telephone_Ext VARCHAR(10) NOT NULL,
    Charge_Nurse CHAR(4) NOT NULL,
    CONSTRAINT PK_Wards PRIMARY KEY (W_Num),
    CONSTRAINT FK_Charge_Nurse FOREIGN KEY (Charge_Nurse) REFERENCES Staffs(S_Num)
);

-- เตียง
CREATE TABLE Beds (
    Bed_ID VARCHAR(8) NOT NULL,
    Bed_Num VARCHAR(3) NOT NULL,
    Status VARCHAR(20) NOT NULL,
    W_Num VARCHAR(6) NOT NULL,
    CONSTRAINT PK_Beds PRIMARY KEY (Bed_ID),
    CONSTRAINT FK_Beds_Wards FOREIGN KEY (W_Num) REFERENCES Wards(W_Num)
);

-- ผู้ป่วย
CREATE TABLE Patients (
    P_Num CHAR(6) NOT NULL,
    P_ID CHAR(13) NOT NULL, /*เลขประจำตัว ปชช*/
    First_Name VARCHAR(50) NOT NULL,
    Last_Name VARCHAR(50) NOT NULL,
    PhoneNum VARCHAR(10) NOT NULL,
    Date_Of_Birth DATE NOT NULL,
    Sex CHAR(1) NOT NULL,
    Marital_Status VARCHAR(10) NOT NULL,
    Date_Registered DATE NOT NULL,
    Address_ID CHAR(4) NOT NULL,
    doctorID CHAR(4) NOT NULL,
    CONSTRAINT PK_Patients PRIMARY KEY (P_Num),
    CONSTRAINT FK_Patients_Address FOREIGN KEY (Address_ID) REFERENCES Addresses(Address_ID),
    CONSTRAINT FK_Local_Doctor_ID FOREIGN KEY (doctorID) REFERENCES Local_Doctors(doctorID)
);
-- จัดสรรเตียง
CREATE TABLE BedAllocations (
    bed_allocation_id VARCHAR(10) NOT NULL,
    admit_date DATETIME NOT NULL,
    discharge_date DATETIME,
    Bed_ID VARCHAR(8) NOT NULL,
    CONSTRAINT PK_BedAllocations PRIMARY KEY (bed_allocation_id),
    CONSTRAINT FK_BedAllocations_Bed FOREIGN KEY (Bed_ID) REFERENCES Beds(Bed_ID)
);
-- จัดสรรวอร์ด
CREATE TABLE Ward_Allocations (
    allocation_id VARCHAR(10) NOT NULL,
    waitingListDate DATETIME NOT NULL,
    expected_stay INT NOT NULL,
    date_placed DATETIME,
    date_leave DATETIME,
    date_actual_leave DATETIME,
    W_Num VARCHAR(6) NOT NULL,
    P_Num CHAR(6) NOT NULL,
    bed_allocation_id VARCHAR(10),
    CONSTRAINT PK_Ward_Allocations PRIMARY KEY (allocation_id),
    CONSTRAINT FK_Ward_Allocations_Ward FOREIGN KEY (W_Num) REFERENCES Wards(W_Num),
    CONSTRAINT FK_Ward_Allocations_Patient FOREIGN KEY (P_Num) REFERENCES Patients(P_Num),
    CONSTRAINT FK_Ward_Allocations_BedAlloc FOREIGN KEY (bed_allocation_id) REFERENCES BedAllocations(bed_allocation_id)
);
-- คลินิกผู้ป่วยนอก
CREATE TABLE Outpatient_Clinics (
    Clinic_Num CHAR(5) NOT NULL,
    Clinic_Name VARCHAR(100) NOT NULL,
    Location VARCHAR(100) NOT NULL,
    Telephone_Ext VARCHAR(10) NOT NULL,
    Charge_Nurse CHAR(4) NOT NULL,
    CONSTRAINT PK_Outpatient_Clinics PRIMARY KEY (Clinic_Num),
    CONSTRAINT FK_Outpatient_Clinics_ChargeNurse FOREIGN KEY (Charge_Nurse) REFERENCES Staffs(S_Num)
);
-- กะการทำงาน
CREATE TABLE Shifts (
    Shift_ID CHAR(2) NOT NULL,
    Shift_Type VARCHAR(50) NOT NULL,
    Start_Time TIME NOT NULL,
    End_Time TIME NOT NULL,
    CONSTRAINT PK_Shifts PRIMARY KEY (Shift_ID)
);
-- ตารางเวรการทำงานในวอร์ด
CREATE TABLE Ward_Shift_Rotas (
    Rota_ID CHAR(8) NOT NULL,
    Date_of_Shift DATE NOT NULL,
    S_num CHAR(4) NOT NULL,
    W_Num VARCHAR(6) NOT NULL,
    Shift_ID CHAR(2) NOT NULL,
    CONSTRAINT PK_Ward_Shift_Rotas PRIMARY KEY (Rota_ID),
    CONSTRAINT FK_Ward_Shift_Rotas_Staff FOREIGN KEY (S_num) REFERENCES Staffs(S_Num),
    CONSTRAINT FK_Ward_Shift_Rotas_Wards FOREIGN KEY (W_Num) REFERENCES Wards(W_Num),
    CONSTRAINT FK_Ward_Shift_Rotas_Shifts FOREIGN KEY (Shift_ID) REFERENCES Shifts(Shift_ID)
);
-- ตารางเวรการทำงานในคลินิก
CREATE TABLE Clinic_Shift_Rotas (
    Rota_ID VARCHAR(8) NOT NULL,
    Date_of_Shift DATE NOT NULL,
    S_num CHAR(4) NOT NULL,
    Clinic_Num CHAR(5) NOT NULL,
	Shift_ID CHAR(2) NOT NULL,
    CONSTRAINT PK_Clinic_Shift_Rotas PRIMARY KEY (Rota_ID),
    CONSTRAINT FK_Clinic_Shift_Rotas_Staff FOREIGN KEY (S_num) REFERENCES Staffs(S_Num),
    CONSTRAINT FK_Clinic_Shift_Rotas_Shifts FOREIGN KEY (Shift_ID) REFERENCES Shifts(Shift_ID),
    CONSTRAINT FK_Clinic_Shift_Rotas_Clinics FOREIGN KEY (Clinic_Num) REFERENCES Outpatient_Clinics(Clinic_Num)
);

-- ใบนัด
CREATE TABLE Appointments (
    appointmentID CHAR(7) NOT NULL,
    P_Num CHAR(6) NOT NULL,
    Clinic_Num CHAR(5) NOT NULL,
    S_Num CHAR(4) NOT NULL,
    appointment_date DATETIME NOT NULL,
    reasons VARCHAR(255),
    CONSTRAINT PK_Appointments PRIMARY KEY (appointmentID),
    CONSTRAINT FK_Appointments_Patient FOREIGN KEY (P_Num) REFERENCES Patients(P_Num),
    CONSTRAINT FK_Appointments_Clinic FOREIGN KEY (Clinic_Num) REFERENCES Outpatient_Clinics(Clinic_Num),
    CONSTRAINT FK_Appointments_Staff FOREIGN KEY (S_Num) REFERENCES Staffs(S_Num)
);
-- ผู้ป่วยนอก
CREATE TABLE Outpatients (
    P_Num CHAR(6) NOT NULL,
    appointmentID CHAR(7) NOT NULL,
    CONSTRAINT PK_Outpatients PRIMARY KEY (P_Num, appointmentID),
    CONSTRAINT FK_Outpatients_Patients FOREIGN KEY (P_Num) REFERENCES Patients(P_Num),
    CONSTRAINT FK_Outpatients_Appointments FOREIGN KEY (appointmentID) REFERENCES Appointments(appointmentID)
);
-- ผู้ป่วยใน
CREATE TABLE Inpatients (
    P_Num CHAR(6) NOT NULL,
    allocation_id VARCHAR(10) NOT NULL,
    CONSTRAINT PK_Inpatients PRIMARY KEY (P_Num, allocation_id),
    CONSTRAINT FK_Inpatients_Patients FOREIGN KEY (P_Num) REFERENCES Patients(P_Num),
    CONSTRAINT FK_Inpatients_WardAllocations FOREIGN KEY (allocation_id) REFERENCES Ward_Allocations(allocation_id)
);
-- ญาติผู้ป่วย
CREATE TABLE Patients_NextOfKin (
    P_Num CHAR(6) NOT NULL,
    First_Name VARCHAR(50) NOT NULL,
    Last_Name VARCHAR(50) NOT NULL,
    PhoneNum VARCHAR(15) NOT NULL,
    Relationship VARCHAR(50),
    Address_ID CHAR(4),
    CONSTRAINT PK_NextOfKin PRIMARY KEY (P_Num),
    CONSTRAINT FK_NextOfKin_Patients FOREIGN KEY (P_Num) REFERENCES Patients(P_Num),
    CONSTRAINT FK_NextOfKin_Address FOREIGN KEY (Address_ID) REFERENCES Addresses(Address_ID)
);
-- บริษัทซัพพลาย
CREATE TABLE Suppliers (
    supplier_no CHAR(5) NOT NULL,
    supplier_name VARCHAR(100) NOT NULL,
    PhoneNum VARCHAR(15),
    fax_number VARCHAR(15),
    CONSTRAINT PK_Suppliers PRIMARY KEY (supplier_no)
);
-- ข้อมูลยา
CREATE TABLE Pharmaceutical_Supplies (
    drug_no VARCHAR(10) NOT NULL,
    drug_name VARCHAR(100) NOT NULL,
    description VARCHAR(255),
    dosage VARCHAR(50),
    method_of_admin VARCHAR(50),
    quantity_in_stock INT NOT NULL,
    reorder_level INT NOT NULL,
    cost_per_unit DECIMAL(10, 2) NOT NULL,
    supplier_no CHAR(5) NOT NULL,
    CONSTRAINT PK_Pharmaceutical_Supplies PRIMARY KEY (drug_no),
    CONSTRAINT FK_Pharmaceutical_Supplies_Supplier FOREIGN KEY (supplier_no) REFERENCES Suppliers(supplier_no)
);
-- Head เบิกยา
CREATE TABLE DrugRequisition (
    DrugReqID VARCHAR(10) NOT NULL,
    RequisitionDate DATE NOT NULL,
    DateReceived DATE,
    requisition_by CHAR(4) NOT NULL,
    received_by CHAR(4),
    Clinic_Num CHAR(5),
    W_Num VARCHAR(6),
    CONSTRAINT PK_DrugRequisition PRIMARY KEY (DrugReqID),
    CONSTRAINT FK_DrugRequisition_RequisitionBy FOREIGN KEY (requisition_by) REFERENCES Staffs(S_Num),
    CONSTRAINT FK_DrugRequisition_ReceivedBy FOREIGN KEY (received_by) REFERENCES Staffs(S_Num),
    CONSTRAINT FK_DrugRequisition_Clinic FOREIGN KEY (Clinic_Num) REFERENCES Outpatient_Clinics(Clinic_Num),
    CONSTRAINT FK_DrugRequisition_Ward FOREIGN KEY (W_Num) REFERENCES Wards(W_Num)
);
-- Details เบิกยา
CREATE TABLE DrugReq_Details (
	DrugReqID VARCHAR(10) NOT NULL,
    order_no VARCHAR(10) NOT NULL,
    drug_no VARCHAR(10) NOT NULL,
	Quantity INT NOT NULL,
    CONSTRAINT PK_DrugReq_Details PRIMARY KEY (order_no, DrugReqID),
    CONSTRAINT FK_DrugReq_Details_DrugReq FOREIGN KEY (DrugReqID) REFERENCES DrugRequisition(DrugReqID),
    CONSTRAINT FK_DrugReq_Details_Drug FOREIGN KEY (drug_no) REFERENCES Pharmaceutical_Supplies(drug_no)
);
-- ข้อมูลอุปกรณ์
CREATE TABLE Surgical_Supplies (
    item_no VARCHAR(10) NOT NULL,
    item_name VARCHAR(100) NOT NULL,
    description VARCHAR(255),
    quantity_in_stock INT NOT NULL,
    reorder_level INT NOT NULL,
    cost_per_unit DECIMAL(10, 2) NOT NULL,
    supplier_no CHAR(5) NOT NULL,
    CONSTRAINT PK_Surgical_Supplies PRIMARY KEY (item_no),
    CONSTRAINT FK_Surgical_Supplies_Supplier FOREIGN KEY (supplier_no) REFERENCES Suppliers(supplier_no)
);
-- Head อุปกรณ์
CREATE TABLE SurgicalRequisition (
    SurgicalReqID VARCHAR(10) NOT NULL,
    RequisitionDate DATE NOT NULL,
    DateReceived DATE,
    requisition_by CHAR(4) NOT NULL,
    received_by CHAR(4),
    Clinic_Num CHAR(5),
    W_Num VARCHAR(6),
    CONSTRAINT PK_SurgicalRequisition PRIMARY KEY (SurgicalReqID),
    CONSTRAINT FK_SurgicalRequisition_RequisitionBy FOREIGN KEY (requisition_by) REFERENCES Staffs(S_Num),
    CONSTRAINT FK_SurgicalRequisition_ReceivedBy FOREIGN KEY (received_by) REFERENCES Staffs(S_Num),
    CONSTRAINT FK_SurgicalRequisition_Clinic FOREIGN KEY (Clinic_Num) REFERENCES Outpatient_Clinics(Clinic_Num),
    CONSTRAINT FK_SurgicalRequisition_Ward FOREIGN KEY (W_Num) REFERENCES Wards(W_Num)
);
-- Details อุปกรณ์
DROP TABLE SurgicalReq_Details
CREATE TABLE SurgicalReq_Details (
	SurgicalReqID VARCHAR(10) NOT NULL,
    order_no VARCHAR(10) NOT NULL,
    item_no VARCHAR(10) NOT NULL,
    Quantity INT NOT NULL,
    CONSTRAINT PK_SurgicalReq_Details PRIMARY KEY (SurgicalReqID, order_no),
    CONSTRAINT FK_SurgicalReq_Details_SurgicalReq FOREIGN KEY (SurgicalReqID) REFERENCES SurgicalRequisition(SurgicalReqID),
    CONSTRAINT FK_SurgicalReq_Details_Item FOREIGN KEY (item_no) REFERENCES Surgical_Supplies(item_no)
);

-- Head ใบสั่งยาให้ผู้ป่วย
CREATE TABLE Medication_Head (
    medication_no VARCHAR(10) NOT NULL,
    order_date DATETIME NOT NULL,
    S_num CHAR(4) NOT NULL,
    P_Num CHAR(6) NOT NULL,
    W_Num VARCHAR(6),
    Clinic_Num CHAR(5),
    CONSTRAINT PK_Medication_Head PRIMARY KEY (medication_no),
    CONSTRAINT FK_Medication_Head_Staff FOREIGN KEY (S_num) REFERENCES Staffs(S_Num),
    CONSTRAINT FK_Medication_Head_Patient FOREIGN KEY (P_Num) REFERENCES Patients(P_Num),
    CONSTRAINT FK_Medication_Head_Ward FOREIGN KEY (W_Num) REFERENCES Wards(W_Num),
    CONSTRAINT FK_Medication_Head_Clinic FOREIGN KEY (Clinic_Num) REFERENCES Outpatient_Clinics(Clinic_Num)
);
-- Details ใบเบิกยาให้ผู้ป่วย
CREATE TABLE Medication_Details (
	medication_no VARCHAR(10) NOT NULL,
    order_no VARCHAR(10) NOT NULL,
    start_date DATE NOT NULL,
    finish_date DATE,
    drug_no VARCHAR(10) NOT NULL,
    CONSTRAINT PK_Medication_Details PRIMARY KEY (order_no, medication_no),
    CONSTRAINT FK_Medication_Details_Drug FOREIGN KEY (drug_no) REFERENCES Pharmaceutical_Supplies(drug_no),
    CONSTRAINT FK_Medication_Details_Medication FOREIGN KEY (medication_no) REFERENCES Medication_Head(medication_no)
);

-- DDL สำหรับสร้างวิว

-- C
CREATE VIEW Staff_Allocation_View AS
SELECT 
    S.S_Num AS Staff_Number,
    S.First_Name + ' ' + S.Last_Name AS Staff_Name,
    S.Position AS Position,
    WSR.Date_of_Shift AS Shift_Date,
    Sh.Shift_Type AS Shift_Type,
    Sh.Start_Time AS Shift_Start,
    Sh.End_Time AS Shift_End,
    W.W_Name AS Work_Location
FROM 
    Staffs S
    INNER JOIN Ward_Shift_Rotas WSR ON S.S_Num = WSR.S_num
    INNER JOIN Shifts Sh ON WSR.Shift_ID = Sh.Shift_ID
    INNER JOIN Wards W ON WSR.W_Num = W.W_Num

UNION

SELECT 
    S.S_Num AS Staff_Number,
    S.First_Name + ' ' + S.Last_Name AS Staff_Name,
    S.Position AS Position,
    CSR.Date_of_Shift AS Shift_Date,
    Sh.Shift_Type AS Shift_Type,
    Sh.Start_Time AS Shift_Start,
    Sh.End_Time AS Shift_End,
    OC.Clinic_Name AS Work_Location
FROM 
    Staffs S
    INNER JOIN Clinic_Shift_Rotas CSR ON S.S_Num = CSR.S_num
    INNER JOIN Shifts Sh ON CSR.Shift_ID = Sh.Shift_ID
    INNER JOIN Outpatient_Clinics OC ON CSR.Clinic_Num = OC.Clinic_Num

ORDER BY 
    Staff_Number, Shift_Date, Shift_Start;

-- ข้อมูลพนักงาน
CREATE VIEW StaffDetails AS
SELECT 
    S.S_Num AS Staff_Number,
    S.S_ID AS National_ID,
    S.First_Name AS FirstName,
    S.Last_Name AS LastName,
    S.Date_of_Birth AS DateOfBirth,
    S.Sex AS Gender,
    S.Position AS Position,
    S.PhoneNum AS PhoneNumber,
    S.CurrentSalary AS CurrentSalary,
    S.SalaryScale AS SalaryScale,
    A.House_No AS HouseNumber,
    A.Street AS Street,
    A.District AS District,
    A.Province AS Province,
    A.Postal_Code AS PostalCode,
    A.Country AS Country,
    U.username AS Username,
    Q.Name AS Qualification,
    Q.Institution AS Institution,
    Q.Date_of_Qualification AS QualificationDate,
    E.Hours_Worked_per_Week AS HoursWorked,
    E.Contract_Type AS ContractType,
    E.Salary_Payment_Type AS PaymentType,
    W.Organization AS Organization,
    W.Position AS WorkPosition,
    W.Start_Date AS WorkStartDate,
    W.End_Date AS WorkEndDate
FROM 
    Staffs S
    INNER JOIN Addresses A ON S.Address_ID = A.Address_ID
    INNER JOIN Users U ON S.Users_ID = U.Users_ID
    LEFT JOIN Qualifications Q ON S.S_Num = Q.S_Num
    LEFT JOIN Employment_Contracts E ON S.S_Num = E.S_Num
    LEFT JOIN Work_Experience W ON S.S_Num = W.S_Num;

-- ข้อมูลผู้ป่วย
CREATE VIEW PatientDetails AS
SELECT
    P.P_Num AS Patient_Number,
    P.P_ID AS National_ID,
    P.First_Name AS Patient_FirstName,
    P.Last_Name AS Patient_LastName,
    P.PhoneNum AS Patient_Phone,
    P.Date_Of_Birth AS DateOfBirth,
    P.Sex AS Gender,
    P.Marital_Status AS MaritalStatus,
    P.Date_Registered AS DateRegistered,
    A.House_No AS HouseNumber,
    A.Street AS Street,
    A.District AS District,
    A.Province AS Province,
    A.Postal_Code AS PostalCode,
    A.Country AS Country,
    D.First_Name AS Doctor_FirstName,
    D.Last_Name AS Doctor_LastName,
    C.clinicName AS Clinic_Name
FROM 
    Patients P
    INNER JOIN Addresses A ON P.Address_ID = A.Address_ID
    INNER JOIN Local_Doctors D ON P.doctorID = D.doctorID
    INNER JOIN Local_Clinics C ON D.clinicID = C.clinicID;


-- F
CREATE VIEW Outpatient_Appointments_View AS
SELECT 
    O.P_Num AS Patient_Number,
    P.First_Name + ' ' + P.Last_Name AS Patient_Name,
    A.appointmentID AS Appointment_ID,
    A.appointment_date AS Appointment_Date,
    A.reasons AS Appointment_Reasons,
    C.Clinic_Name AS Clinic_Name,
    S.First_Name + ' ' + S.Last_Name AS Doctor_Name
FROM 
    Outpatients O
    INNER JOIN Patients P ON O.P_Num = P.P_Num
    INNER JOIN Appointments A ON O.appointmentID = A.appointmentID
    INNER JOIN Outpatient_Clinics C ON A.Clinic_Num = C.Clinic_Num
    INNER JOIN Staffs S ON A.S_Num = S.S_Num;


-- H
CREATE VIEW InpatientDetails AS
SELECT 
    I.P_Num AS Patient_Number,
    P.First_Name AS Patient_FirstName,
    P.Last_Name AS Patient_LastName,
	W.W_Num AS Ward_Number,
    W.W_Name AS Ward_Name,
    B.Bed_Num AS Bed_Number,
    BA.admit_date AS AdmitDate,
    BA.discharge_date AS DischargeDate,
    WA.waitingListDate AS WaitingListDate,
    WA.expected_stay AS ExpectedStay,
    WA.date_placed AS DatePlaced,
    WA.date_leave AS DateLeave,
    WA.date_actual_leave AS DateActualLeave
FROM 
    Inpatients I
    INNER JOIN Patients P ON I.P_Num = P.P_Num
    INNER JOIN Ward_Allocations WA ON I.allocation_id = WA.allocation_id
    INNER JOIN Wards W ON WA.W_Num = W.W_Num
    INNER JOIN BedAllocations BA ON WA.bed_allocation_id = BA.bed_allocation_id
    INNER JOIN Beds B ON BA.Bed_ID = B.Bed_ID;


-- K
CREATE VIEW Medication_View AS
SELECT 
    MH.medication_no AS Medication_Number,
    MH.order_date AS Order_Date,
    S.First_Name + ' ' + S.Last_Name AS Ordered_By,
    P.First_Name + ' ' + P.Last_Name AS Patient_Name,
    CASE
        WHEN MH.Clinic_Num IS NOT NULL THEN 
            (SELECT Clinic_Name FROM Outpatient_Clinics WHERE Clinic_Num = MH.Clinic_Num)
        ELSE 
            (SELECT W_Name FROM Wards WHERE W_Num = MH.W_Num)
    END AS Prescription_Location,
    MD.order_no AS Order_Number,
    MD.drug_no AS Drug_Number,
    PS.drug_name AS Drug_Name,
    MD.start_date AS Start_Date,
    MD.finish_date AS Finish_Date
FROM 
    Medication_Head MH
    INNER JOIN Medication_Details MD ON MH.medication_no = MD.medication_no
    INNER JOIN Staffs S ON MH.S_num = S.S_Num
    INNER JOIN Patients P ON MH.P_Num = P.P_Num
    INNER JOIN Pharmaceutical_Supplies PS ON MD.drug_no = PS.drug_no;

-- N
CREATE VIEW Drug_Requisition_View AS
SELECT 
    DR.DrugReqID AS Requisition_ID,
    DR.RequisitionDate AS Requisition_Date,
    DR.DateReceived AS Date_Received,
    RS.First_Name + ' ' + RS.Last_Name AS Requisition_By,
    CASE 
        WHEN DR.received_by IS NOT NULL THEN 
            (SELECT First_Name + ' ' + Last_Name FROM Staffs WHERE S_Num = DR.received_by)
        ELSE 
            'Pending'
    END AS Received_By,
    PS.drug_no AS Drug_Number,
    PS.drug_name AS Drug_Name,
    DRD.Quantity AS Quantity,
    CASE
        WHEN DR.Clinic_Num IS NOT NULL THEN 
            (SELECT Clinic_Name FROM Outpatient_Clinics WHERE Clinic_Num = DR.Clinic_Num)
        ELSE 
            (SELECT W_Name FROM Wards WHERE W_Num = DR.W_Num)
    END AS Requisition_Location
FROM 
    DrugRequisition DR
    INNER JOIN DrugReq_Details DRD ON DR.DrugReqID = DRD.DrugReqID
    INNER JOIN Pharmaceutical_Supplies PS ON DRD.drug_no = PS.drug_no
    INNER JOIN Staffs RS ON DR.requisition_by = RS.S_Num;


-- N
CREATE VIEW Surgical_Requisition_View AS
SELECT 
    SR.SurgicalReqID AS Requisition_ID,
    SR.RequisitionDate AS Requisition_Date,
    SR.DateReceived AS Date_Received,
    RS.First_Name + ' ' + RS.Last_Name AS Requisition_By,
    CASE 
        WHEN SR.received_by IS NOT NULL THEN 
            (SELECT First_Name + ' ' + Last_Name FROM Staffs WHERE S_Num = SR.received_by)
        ELSE 
            'Pending'
    END AS Received_By,
    SS.item_no AS Item_Number,
    SS.item_name AS Item_Name,
    SS.description AS Item_Description,
    SRD.Quantity AS Quantity,
    CASE
        WHEN SR.Clinic_Num IS NOT NULL THEN 
            (SELECT Clinic_Name FROM Outpatient_Clinics WHERE Clinic_Num = SR.Clinic_Num)
        ELSE 
            (SELECT W_Name FROM Wards WHERE W_Num = SR.W_Num)
    END AS Requisition_Location
FROM 
    SurgicalRequisition SR
    INNER JOIN SurgicalReq_Details SRD ON SR.SurgicalReqID = SRD.SurgicalReqID
    INNER JOIN Surgical_Supplies SS ON SRD.item_no = SS.item_no
    INNER JOIN Staffs RS ON SR.requisition_by = RS.S_Num;


-- ใบนัด
CREATE VIEW PatientAppointments AS
SELECT 
    Patients.P_Num,
    Patients.First_Name AS Patient_First_Name,
    Patients.Last_Name AS Patient_Last_Name,
    Appointments.appointmentID,
    Appointments.appointment_date,
    Appointments.reasons,
    Staffs.S_Num,
    Staffs.First_Name AS Staff_First_Name,
    Staffs.Last_Name AS Staff_Last_Name,
    Outpatient_Clinics.Clinic_Num,
    Outpatient_Clinics.Clinic_Name
FROM 
    Patients
JOIN 
    Appointments ON Patients.P_Num = Appointments.P_Num
JOIN 
    Staffs ON Appointments.S_Num = Staffs.S_Num
LEFT JOIN 
    Outpatient_Clinics ON Appointments.Clinic_Num = Outpatient_Clinics.Clinic_Num;


-- I
CREATE VIEW Patients_Waiting_For_Beds AS
SELECT 
    WA.allocation_id AS Allocation_ID,
    WA.waitingListDate AS Waiting_List_Date,
    WA.expected_stay AS Expected_Stay_Days,
    P.P_Num AS Patient_Number,
    P.First_Name + ' ' + P.Last_Name AS Patient_Name,
    W.W_Name AS Ward_Name
FROM 
    Ward_Allocations WA
    INNER JOIN Patients P ON WA.P_Num = P.P_Num
    INNER JOIN Wards W ON WA.W_Num = W.W_Num
WHERE 
    WA.date_placed IS NULL
ORDER BY 
    WA.waitingListDate;



-- DML สำหรับเพิ่มข้อมูลตัวอย่าง

INSERT INTO Addresses (Address_ID, House_No, Street, District, Province, Postal_Code, Country)
VALUES 
('A001', '789', 'Mittraphap Rd', 'Mueang', 'Nakhon Ratchasima', '30000', 'Thailand'),
('A002', '101', 'Sukhumvit Rd', 'Wattana', 'Bangkok', '10110', 'Thailand'),
('A003', '202', 'Chayangkun Rd', 'Mueang', 'Ubon Ratchathani', '34000', 'Thailand'),
('A004', '303', 'Jiranakorn Rd', 'Mueang', 'Buri Ram', '31000', 'Thailand'),
('A005', '404', 'Sirindhorn Rd', 'Sirindhorn', 'Ubon Ratchathani', '34350', 'Thailand');

INSERT INTO Users (Users_ID, username, password)
VALUES 
('U001', 'doctor1', 'doctor1'),
('U002', 'ChargeNurse1', 'CNurse1'),
('U003', 'ChargeNurse2', 'CNurse2'),
('U004', 'Nurse1', 'Nurse1'),
('U005', 'Nurse2', 'Nurse2'),
('U006', 'PersonOff1', 'PersonOff1'),
('U007', 'MedicDi1', 'MedicDi1');

INSERT INTO Staffs (S_Num, S_ID, First_Name, Last_Name, Date_of_Birth, Sex, Position, PhoneNum, CurrentSalary, SalaryScale, Address_ID, Users_ID)
VALUES
('S001', '1100701234567', 'Chanachon', 'Preechachawalitkool', '1985-01-15', 'M', 'Doctor', '0891234567', 50000.00, 'A1', 'A001', 'U001'),
('S002', '1100702345678', 'Natthaphob', 'Chomsri', '1990-02-20', 'M', 'Charge Nurse', '0812345678', 35000.00, 'B2', 'A002', 'U002'),
('S003', '1100703456789', 'Yada', 'Hoonsungnoen', '1988-03-10', 'F', 'Charge Nurse', '0823456789', 40000.00, 'A2', 'A003', 'U003'),
('S004', '1100704567890', 'Naphumin', 'Ounart', '1975-04-25', 'M', 'Nurse', '0834567890', 30000.00, 'C1', 'A004', 'U004'),
('S005', '1100705678901', 'Pantakarn', 'Sinlapathiwat', '1980-05-30', 'M', 'Nurse', '0845678901', 60000.00, 'A3', 'A005', 'U005'),
('S006', '1100705688510', 'Thana', 'Khan', '1985-07-31', 'M', 'Personnel Officer', '0845655123', 20000.00, 'A3', 'A005', 'U006'),
('S007', '1100705774852', 'Thanee', 'Jaijing', '1985-07-31', 'F', 'Medical Director', '0845554879', 70000.00, 'A3', 'A005', 'U007');


INSERT INTO Qualifications (Qualification_ID, Name, Institution, Date_of_Qualification, S_Num)
VALUES
('Q001', 'Bachelor of Medicine', 'Chulalongkorn University', '2010-03-15', 'S001'),
('Q002','Bachelor of Nursing', 'Mahidol University', '2012-06-10', 'S002'),
('Q003','Bachelor of Nursing', 'Khon Kaen University', '2011-09-22', 'S003'),
('Q004','Bachelor of Nursing', 'Bangkok University', '2000-05-20', 'S004'),
('Q005','Bachelor of Nursing', 'Thammasat University', '2015-08-30', 'S005'),
('Q006','Bachelor of Nursing', 'Thammasat University', '2015-08-30', 'S006'),
('Q007','Bachelor of Medicine', 'Chulalongkorn University', '2015-08-30', 'S007');

INSERT INTO Employment_Contracts (Contract_ID, Hours_Worked_per_Week, Contract_Type, Salary_Payment_Type, S_Num)
VALUES
('C001', 40.00, 'Full-time', 'Monthly', 'S001'),
('C002', 45.00, 'Full-time', 'Monthly', 'S002'),
('C003', 40.00, 'Full-time', 'Monthly', 'S003'),
('C004', 20.00, 'Part-time', 'Hourly', 'S004'),
('C005', 35.00, 'Part-time', 'Hourly', 'S005'),
('C006', 40.00, 'Full-time', 'Monthly', 'S006'),
('C007', 45.00, 'Full-time', 'Monthly', 'S007');


INSERT INTO Work_Experience (Wex_ID, Organization, Position, Start_Date, End_Date, S_Num)
VALUES
('X001', 'Bangkok Hospital', 'Doctor', '2011-04-01', '2015-12-31', 'S001'),
('X002', 'Samitivej Hospital', 'Nurse', '2012-07-01', '2018-06-30', 'S002'),
('X003','Pharmacy Co., Ltd.', 'Pharmacist', '2011-10-01', '2016-08-31', 'S003'),
('X004','Techno Repairs', 'Technician', '2000-06-01', '2010-12-31', 'S004'),
('X005','MegaCorp Ltd.', 'Manager', '2015-09-01', NULL, 'S005'),
('X006','Global Health Clinic', 'Doctor', '2017-01-01', '2020-12-31', 'S006'),
('X007','ABC Technology', 'IT Support', '2010-05-01', '2014-04-30', 'S007');

INSERT INTO Local_Clinics (clinicID, clinicName, PhoneNum, Address_ID)
VALUES
('CL001', 'Happy Health Clinic', '0891234567', 'A001'),
('CL002', 'Sunshine Medical Center', '0812345678', 'A002'),
('CL003', 'Green Valley Clinic', '0823456789', 'A003'),
('CL004', 'Downtown Medical Clinic', '0834567890', 'A004'),
('CL005', 'Family Care Clinic', '0845678901', 'A005');

INSERT INTO Local_Doctors (doctorID, First_Name, Last_Name, PhoneNum, clinicID)
VALUES
('D001', 'Michael', 'Johnson', '0899876543', 'CL001'),
('D002', 'Emily', 'Davis', '0818765432', 'CL002'),
('D003', 'Sophia', 'Martinez', '0827654321', 'CL003'),
('D004', 'Daniel', 'Brown', '0836543210', 'CL004'),
('D005', 'Olivia', 'Taylor', '0845432109', 'CL005');

INSERT INTO Wards (W_Num, W_Name, Location, Total_Beds, Telephone_Ext, Charge_Nurse)
VALUES
('W001', 'Surgical Ward', 'Building A, Floor 3', 50, '1234', 'S002'),
('W002', 'Pediatric Ward', 'Building B, Floor 2', 30, '5678', 'S002'),
('W003', 'Maternity Ward', 'Building C, Floor 1', 40, '9101', 'S003'),
('W004', 'Emergency Ward', 'Building D, Ground Floor', 60, '1123', 'S003'),
('W005', 'ICU', 'Building A, Floor 5', 20, '3141', 'S002');

INSERT INTO Beds (Bed_ID, Bed_Num, Status, W_Num)
VALUES
('B001001', '001', 'Occupied', 'W001'),
('B001002', '002', 'Available', 'W001'),
('B002001', '001', 'Occupied', 'W002'),
('B002002', '002', 'Available', 'W002'),
('B003001', '001', 'Available', 'W003'),
('B003002', '002', 'Available', 'W003'),
('B004001', '001', 'Occupied', 'W004'),
('B004002', '002', 'Available', 'W004'),
('B005001', '001', 'Available', 'W005'),
('B005002', '002', 'Available', 'W005'),
('B005003', '003', 'Available', 'W005');

INSERT INTO Patients (P_Num, P_ID, First_Name, Last_Name, PhoneNum, Date_Of_Birth, Sex, Marital_Status, Date_Registered, Address_ID, doctorID)
VALUES
('P00123', '1100701234567', 'Somsak', 'Yudee', '0891234567', '1985-01-15', 'M', 'Single', '2024-09-01', 'A001', 'D001'),
('P00234', '1100702345678', 'Jiranan', 'Jaiyen', '0812345678', '1990-02-20', 'F', 'Married', '2024-09-02', 'A002', 'D002'),
('P00345', '1100703456789', 'Suntree', 'Deejang', '0823456789', '1988-03-10', 'M', 'Single', '2024-09-03', 'A003', 'D003'),
('P00456', '1100704567890', 'Suthat', 'Makmee', '0834567890', '1975-04-25', 'F', 'Married', '2024-09-04', 'A004', 'D004'),
('P00567', '1100705678901', 'Thananon', 'Phakdee', '0845678901', '1980-05-30', 'M', 'Divorced', '2024-09-05', 'A005', 'D005');

INSERT INTO BedAllocations (bed_allocation_id, admit_date, discharge_date, Bed_ID)
VALUES
('BA001', '2024-09-01 10:00:00', NULL, 'B001001'),
('BA002', '2024-09-02 14:30:00', NULL, 'B001002'),
('BA003', '2024-09-03 09:15:00', '2024-09-10 11:00:00', 'B002001'),
('BA004', '2024-09-04 08:45:00', NULL, 'B003001'),
('BA005', '2024-09-05 15:20:00', '2024-09-08 10:00:00', 'B004001'),
('BA006', '2024-10-04 08:45:00', NULL, 'B003001');

INSERT INTO Ward_Allocations (allocation_id, waitingListDate, expected_stay, date_placed, date_leave, date_actual_leave, W_Num, P_Num, bed_allocation_id)
VALUES
('WA001', '2024-09-01 09:00:00', 7, '2024-09-01 10:00:00', NULL, NULL, 'W001', 'P00123', 'BA001'),
('WA002', '2024-09-02 11:30:00', 5, '2024-09-02 14:30:00', NULL, NULL, 'W002', 'P00234', 'BA002'),
('WA003', '2024-09-03 08:00:00', 10, '2024-09-03 09:15:00', '2024-09-10 11:00:00', NULL, 'W003', 'P00345', 'BA003'),
('WA004', '2024-09-04 14:45:00', 4, '2024-09-04 08:45:00', NULL, NULL, 'W004', 'P00456', 'BA004'),
('WA005', '2024-09-05 16:20:00', 6, '2024-09-05 15:20:00', '2024-09-08 10:00:00', '2024-09-08 09:00:00', 'W001', 'P00567', 'BA005'),
('WA006', '2024-10-04 08:45:00', 3, NULL, NULL, NULL, 'W003', 'P00567', NULL);

INSERT INTO Outpatient_Clinics (Clinic_Num, Clinic_Name, Location, Telephone_Ext, Charge_Nurse)
VALUES
('OC001', 'Family Health Clinic', 'Building A, 1st Floor', '1234', 'S001'),
('OC002', 'Wellness Center', 'Building B, Ground Floor', '5678', 'S002'),
('OC003', 'Pediatric Clinic', 'Building C, 2nd Floor', '9101', 'S003'),
('OC004', 'Geriatric Clinic', 'Building D, 1st Floor', '1122', 'S004'),
('OC005', 'Women’s Health Clinic', 'Building E, Ground Floor', '3141', 'S005');

INSERT INTO Shifts (Shift_ID, Shift_Type, Start_Time, End_Time)
VALUES
('S1', 'Morning Shift', '08:00:00', '14:00:00'),
('S2', 'Afternoon Shift', '14:00:00', '20:00:00'),
('S3', 'Night Shift', '20:00:00', '08:00:00'),
('S4', 'Weekend Shift', '08:00:00', '18:00:00'),
('S5', 'Holiday Shift', '08:00:00', '20:00:00');

INSERT INTO Ward_Shift_Rotas (Rota_ID, Date_of_Shift, S_num, W_Num, Shift_ID)
VALUES
('WR000001', '2024-09-20', 'S001', 'W001', 'S1'),
('WR000002', '2024-09-21', 'S002', 'W002', 'S2'),
('WR000003', '2024-09-22', 'S003', 'W003', 'S3'),
('WR000004', '2024-09-23', 'S004', 'W004', 'S4'),
('WR000005', '2024-09-24', 'S005', 'W005', 'S5');

INSERT INTO Clinic_Shift_Rotas (Rota_ID, Date_of_Shift, S_num, Clinic_Num, Shift_ID)
VALUES
('CR000001', '2024-09-20', 'S001', 'OC001', 'S1'),
('CR000002', '2024-09-21', 'S002', 'OC002', 'S2'),
('CR000003', '2024-09-22', 'S003', 'OC003', 'S3'),
('CR000004', '2024-09-23', 'S004', 'OC004', 'S4'),
('CR000005', '2024-09-24', 'S005', 'OC005', 'S5');

INSERT INTO Appointments (appointmentID, P_Num, Clinic_Num, S_Num, appointment_date, reasons)
VALUES
('AP00001', 'P00123', 'OC001', 'S001', '2024-09-20 10:00:00', 'Follow-up required'),
('AP00002','P00234', 'OC002', 'S002', '2024-09-21 14:30:00', 'Normal check-up'),
('AP00003','P00345', 'OC003', 'S003', '2024-09-22 09:15:00', 'Prescribed medication'),
('AP00004','P00456', 'OC004', 'S004', '2024-09-23 08:45:00', 'Further tests required'),
('AP00005','P00567', 'OC005', 'S005', '2024-09-24 15:20:00', 'Normal check-up');

INSERT INTO Outpatients (P_Num, appointmentID)
VALUES
('P00123', 'AP00001'),
('P00234', 'AP00002'),
('P00345', 'AP00003'),
('P00456', 'AP00004'),
('P00567', 'AP00005');

INSERT INTO Inpatients (P_Num, allocation_id)
VALUES
('P00123', 'WA001'),
('P00234', 'WA002'),
('P00345', 'WA003'),
('P00456', 'WA004'),
('P00567', 'WA005'),
('P00567', 'WA006');

INSERT INTO Patients_NextOfKin (P_Num, First_Name, Last_Name, PhoneNum, Relationship, Address_ID)
VALUES
('P00123', 'Sunin', 'Yudee', '0891112233', 'Mother', 'A001'),
('P00234', 'Ethan', 'Jaiyen', '0812223344', 'Husband', 'A002'),
('P00345', 'Dang', 'Deejang', '0823334455', 'Mother', 'A003'),
('P00456', 'Sukhothai', 'Makmee', '0834445566', 'Father', 'A004'),
('P00567', 'Nana', 'Phakdee', '0845556677', 'Sister', 'A005');

INSERT INTO Suppliers (supplier_no, supplier_name, PhoneNum, fax_number)
VALUES
('SUP01', 'Medical Supplies Co., Ltd.', '0891234567', '022345678'),
('SUP02', 'Healthcare Essentials Inc.', '0812345678', '023456789'),
('SUP03', 'PharmaPlus Corp.', '0823456789', '024567890'),
('SUP04', 'Global Med Devices Ltd.', '0834567890', '025678901'),
('SUP05', 'BioTech Supplies', '0845678901', '026789012');

INSERT INTO Pharmaceutical_Supplies (drug_no, drug_name, description, dosage, method_of_admin, quantity_in_stock, reorder_level, cost_per_unit, supplier_no)
VALUES
('DRG001', 'Paracetamol', 'Pain reliever and fever reducer', '500 mg', 'Oral', 100, 20, 0.50, 'SUP01'),
('DRG002', 'Ibuprofen', 'Nonsteroidal anti-inflammatory drug', '200 mg', 'Oral', 150, 30, 0.80, 'SUP02'),
('DRG003', 'Amoxicillin', 'Antibiotic used to treat bacterial infections', '500 mg', 'Oral', 200, 50, 1.20, 'SUP03'),
('DRG004', 'Aspirin', 'Pain reliever and anti-inflammatory', '100 mg', 'Oral', 120, 25, 0.60, 'SUP04'),
('DRG005', 'Cetirizine', 'Antihistamine used to treat allergies', '10 mg', 'Oral', 180, 40, 0.70, 'SUP05');

INSERT INTO DrugRequisition (DrugReqID, RequisitionDate, DateReceived, requisition_by, received_by, Clinic_Num, W_Num)
VALUES
('REQ001', '2024-09-20', '2024-09-21', 'S001', 'S002', 'OC001', NULL),
('REQ002', '2024-09-21', NULL, 'S003', NULL, 'OC002', NULL),
('REQ003', '2024-09-22', '2024-09-23', 'S004', 'S005', NULL, 'W001'),
('REQ004', '2024-09-23', NULL, 'S001', NULL, NULL, 'W002'),
('REQ005', '2024-09-24', '2024-09-25', 'S002', 'S003', 'OC003', NULL);

INSERT INTO DrugReq_Details (DrugReqID, order_no, drug_no, Quantity)
VALUES
('REQ001', '1', 'DRG001', 50),
('REQ001', '2', 'DRG002', 20),
('REQ001', '3', 'DRG003', 50),
('REQ002', '1', 'DRG002', 30),
('REQ002', '2', 'DRG001', 30),
('REQ003', '1', 'DRG003', 100),
('REQ004', '1', 'DRG004', 20),
('REQ005', '1', 'DRG005', 40);

INSERT INTO Surgical_Supplies (item_no, item_name, description, quantity_in_stock, reorder_level, cost_per_unit, supplier_no)
VALUES
('SS001', 'Scalpel', 'Sterile surgical blade', 100, 20, 15.00, 'SUP01'),
('SS002', 'Surgical Gloves', 'Disposable latex gloves', 200, 50, 0.50, 'SUP02'),
('SS003', 'Surgical Mask', '3-layer surgical face mask', 300, 100, 0.30, 'SUP03'),
('SS004', 'Surgical Gown', 'Disposable sterile gown', 150, 30, 12.00, 'SUP04'),
('SS005', 'Suture Kit', 'Sterile suture and needle', 80, 20, 25.00, 'SUP05');

INSERT INTO SurgicalRequisition (SurgicalReqID, RequisitionDate, DateReceived, requisition_by, received_by, Clinic_Num, W_Num)
VALUES
('SR001', '2024-09-20', '2024-09-21', 'S001', 'S002', 'OC001', NULL),
('SR002', '2024-09-21', '2024-09-22', 'S003', 'S004', NULL, 'W001'),
('SR003', '2024-09-22', NULL, 'S005', NULL, 'OC002', NULL),
('SR004', '2024-09-23', '2024-09-24', 'S001', 'S003', NULL, 'W002'),
('SR005', '2024-09-24', '2024-09-25', 'S004', 'S005', 'OC003', NULL);

INSERT INTO SurgicalReq_Details (SurgicalReqID, order_no, item_no, Quantity)
VALUES
('SR001', '1', 'SS001', 50),
('SR001', '2', 'SS002', 50),
('SR001', '3', 'SS003', 50),
('SR002', '1', 'SS002', 100),
('SR002', '2', 'SS001', 100),
('SR003', '1', 'SS003', 200),
('SR004', '1', 'SS004', 30),
('SR005', '1', 'SS005', 20);

INSERT INTO Medication_Head (medication_no, order_date, S_num, P_Num, W_Num, Clinic_Num)
VALUES
('MDH001', '2024-09-20 10:30:00', 'S001', 'P00123', 'W001', NULL),
('MDH002', '2024-09-21 14:00:00', 'S002', 'P00234', NULL, 'OC001'),
('MDH003', '2024-09-22 09:45:00', 'S003', 'P00345', 'W002', NULL),
('MDH004', '2024-09-23 11:15:00', 'S004', 'P00456', NULL, 'OC002'),
('MDH005', '2024-09-24 16:20:00', 'S005', 'P00567', 'W003', NULL);

INSERT INTO Medication_Details (medication_no, order_no, start_date, finish_date, drug_no)
VALUES
('MDH001', '1', '2024-09-20', '2024-09-25', 'DRG001'),
('MDH001', '2', '2024-09-20', '2024-09-25', 'DRG002'),
('MDH001', '3', '2024-09-20', '2024-09-25', 'DRG003'),
('MDH002', '1', '2024-09-21', '2024-09-26', 'DRG002'),
('MDH002', '2', '2024-09-21', '2024-09-26', 'DRG001'),
('MDH003', '1', '2024-09-22', NULL, 'DRG003'),
('MDH004', '1', '2024-09-23', '2024-09-30', 'DRG004'),
('MDH005', '1', '2024-09-24', NULL, 'DRG005');
