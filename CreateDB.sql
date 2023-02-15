
/*

Ali Khoonsiavash

*/
create database Hospital

-- ++++++++++++++++++++++++++++++++++++

create table PatientTable(
patientID NVARCHAR(10) not null primary key,
firstname nvarchar(40) not null,
lastname NVARCHAR(40) not null,
departmentCode int,
sectionNumber NVARCHAR(10) not null,
disChargeStatus nvarchar(40),
balance float)

-- ++++++++++++++++++++++++++++++++++++
select * from PatientTable

create table DoctorTable(
doctorID NVARCHAR(10) not null primary key,
firstname nvarchar(40) not null,
lastname NVARCHAR(40) not null,
departmentCode int,
yearsOfPractice int,
shiftHours float)

select * from DoctorTable


-- ++++++++++++++++++++++++++++++++++++


create table Login(
Username NVARCHAR(40)not null primary key,
Password nvarchar(40)not null)

insert into login(Username,Password) values('doctor','doctor123')
insert into login(Username,Password) values('admin','admin123')
