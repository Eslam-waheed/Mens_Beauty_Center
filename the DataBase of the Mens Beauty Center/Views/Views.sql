-- ************************************************ Eslam *******************************************
create or alter view V_AllEmployees
as
	select NationalID, FirstName, LastName, PhoneNumber, FixedSalary, 
		case 
			when [Type] = 1 then 'Cashier'
			else 'Barber'
		end as [type]
	from Employee;
-- **************************************************************************************************
go
-- ************************************************* Emad *******************************************
CREATE or alter VIEW V_AllCustomers
AS
	SELECT Code, Name, PhoneNumber
	FROM Customer
-- **************************************************************************************************
go
-- ************************************************ Fares *******************************************

--- view Service
create or alter view V_Service
AS
	select Id as ServiceNumber, ServiceName as Name, Price as Cost
	from dbo.Service;

	go
---- view Packages
-- View with alias for all columns
create or alter view V_Package
as
	select 
		Name as PackageName,
		Description as PackageDescription,
		TotalAmount as PackageTotalAmount
	from 
		dbo.Package;
-- **************************************************************************************************
go
-- ************************************************ Mokhter *****************************************
CREATE or alter VIEW V_AttendanceWithEmployeeName
AS
	SELECT a.AttendanceID, e.FirstName, e.LastName, a.ArrivalTime, a.DepartureTime, a.ExpenseMoney,
		a.DailyPocketMoney
	FROM Attendance a JOIN Employee e ON a.NationalID = e.NationalID;
-- **************************************************************************************************
go
-- ************************************************ Hosni *******************************************
create or alter view V_CoustomerVipDetails
as 
	select 
	C.Name As 'Customer Name', C.PhoneNumber As 'Customer Phone', 
	P.Name As 'Package Name', P.Description As 'Package Description', P.TotalAmount As 'Package Cost', PC.TakeDate
	from Customer C , Package P , PackageCustomer PC
	where PC.CustomerId = C.Code
	and PC.PackageId = P.ID
-- **************************************************************************************************