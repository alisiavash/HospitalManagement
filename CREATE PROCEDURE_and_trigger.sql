/*

Ali Khoonsiavash

*/
CREATE PROCEDURE SP_INSERT_Doctor_Table
	@doctorID NVARCHAR(10),
	@Firstname NVARCHAR(40),
	@Lastname NVARCHAR(40),
	@departmentCode int,
	@yearsOfPractice int,
	@shiftHours FLOAT
AS
	INSERT INTO DoctorTable(doctorID, firstname, lastname, departmentCode,yearsOfPractice,shiftHours)
	VALUES(@doctorID , @Firstname , @Lastname, @departmentCode,@yearsOfPractice,@shiftHours)
	RETURN

-- ++++++++++++++++++++++++++++++++++++


CREATE PROCEDURE SP_UPDATE_Doctor_Table

	@doctorID NVARCHAR(10),
	@Firstname NVARCHAR(40),
	@Lastname NVARCHAR(40),
	@departmentCode int,
	@yearsOfPractice int,
	@shiftHours FLOAT
AS
	begin
	UPDATE DoctorTable
	SET firstname=@Firstname,lastname=@Lastname, departmentCode=@departmentCode, yearsOfPractice=@yearsOfPractice,shiftHours=@shiftHours WHERE doctorID =@doctorID;
	end

-- ++++++++++++++++++++++++++++++++++++


CREATE PROCEDURE SP_INSERT_Patient_Table
	@patientID NVARCHAR(10),
	@firstname nvarchar(40),
	@lastname NVARCHAR(40),
	@departmentCode int,
	@sectionNumber NVARCHAR(10),
	@disChargeStatus nvarchar(40),
	@balance float
AS
	INSERT INTO PatientTable(patientID, firstname, lastname, departmentCode,sectionNumber,disChargeStatus,balance)
	VALUES(@patientID , @firstname , @lastname, @departmentCode,@sectionNumber,@disChargeStatus,@balance)
	RETURN

-- ++++++++++++++++++++++++++++++++++++

CREATE PROCEDURE SP_UPDATE_Patient_Table

	@patientID NVARCHAR(10),
	@firstname nvarchar(40),
	@lastname NVARCHAR(40),
	@departmentCode int,
	@sectionNumber NVARCHAR(10),
	@disChargeStatus nvarchar(40),
	@balance float
AS
	begin
	UPDATE PatientTable
	SET firstname=@Firstname,lastname=@Lastname, departmentCode=@departmentCode, sectionNumber=@sectionNumber,disChargeStatus=@disChargeStatus, balance=@balance WHERE patientID =@patientID;
	end

-- ++++++++++++++++++++++++++++++++++++


create table DoctorAudit(
doctorID NVARCHAR(10) not null,
firstname nvarchar(40) not null,
lastname NVARCHAR(40) not null,
departmentCode int,
yearsOfPractice int,
shiftHours float)

CREATE TRIGGER TR_INSERT_DoctorTable ON DoctorTable
AFTER INSERT 
AS
BEGIN
	
	DECLARE @doctorID NVARCHAR(10);
	DECLARE @Firstname NVARCHAR(40);
	DECLARE @Lastname NVARCHAR(40);
	DECLARE @departmentCode int;
	DECLARE @yearsOfPractice int;
	DECLARE @shiftHours FLOAT;

	SELECT @doctorID = DoctorList.doctorID FROM inserted DoctorList;
	SELECT @Firstname = DoctorList.firstname FROM inserted DoctorList;
	SELECT @Lastname = DoctorList.lastname FROM inserted DoctorList;
	SELECT @departmentCode = DoctorList.departmentCode FROM inserted DoctorList;
	SELECT @yearsOfPractice = DoctorList.yearsOfPractice FROM inserted DoctorList;
	SELECT @shiftHours = DoctorList.shiftHours FROM inserted DoctorList;

	INSERT INTO DoctorAudit(doctorID, firstname, lastname, departmentCode,yearsOfPractice,shiftHours) VALUES
	(@doctorID,
	@Firstname,
	@Lastname,
	@departmentCode,@yearsOfPractice,@shiftHours)
END

-- ++++++++++++++++++++++++++++++++++++


create table PatientAudit(
patientID NVARCHAR(10) not null,
firstname nvarchar(40) not null,
lastname NVARCHAR(40) not null,
departmentCode int,
sectionNumber NVARCHAR(10) not null,
disChargeStatus nvarchar(40),
balance float)

CREATE TRIGGER TR_INSERT_PatientTable ON PatientTable
AFTER INSERT 
AS
BEGIN
	
	DECLARE @patientID NVARCHAR(10);
	DECLARE @Firstname NVARCHAR(40);
	DECLARE @Lastname NVARCHAR(40);
	DECLARE @departmentCode int;
	DECLARE @sectionNumber NVARCHAR(10);
	DECLARE @disChargeStatus nvarchar(40);
	DECLARE @balance FLOAT;

	SELECT @patientID = PatientList.patientID FROM inserted PatientList;
	SELECT @Firstname = PatientList.firstname FROM inserted PatientList;
	SELECT @Lastname = PatientList.lastname FROM inserted PatientList;
	SELECT @departmentCode = PatientList.departmentCode FROM inserted PatientList;
	SELECT @sectionNumber = PatientList.sectionNumber FROM inserted PatientList;
	SELECT @disChargeStatus = PatientList.disChargeStatus FROM inserted PatientList;
	SELECT @balance = PatientList.balance FROM inserted PatientList;

	INSERT INTO PatientAudit(patientID, firstname, lastname, departmentCode,sectionNumber,disChargeStatus,balance) VALUES
	(@patientID,@Firstname,@Lastname,@departmentCode,@sectionNumber,@disChargeStatus,@balance)
END

-- ++++++++++++++++++++++++++++++++++++

CREATE PROCEDURE SP_DELETE_DOCTOR
	@doctorID NVARCHAR(10)
AS
	delete from DoctorTable WHERE doctorID = @doctorID;
	
-- ++++++++++++++++++++++++++++++++++++

CREATE PROCEDURE SP_DELETE_PATIENT
	@patientID NVARCHAR(10)
AS
	delete from PatientTable WHERE patientID = @patientID;	