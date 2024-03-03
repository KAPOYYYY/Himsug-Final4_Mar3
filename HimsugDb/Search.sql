use HimsugDB
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Alter procedure SearchbyID
@Search varchar(50)
	
AS
BEGIN


select ItemId as Id,
Iname as ItemName,
Mname as [Middle Name],
Lname as [Last Name],
Email,
Gender,
[Address],
Contact_Num as [Contact #],
Bdate as [Date of Birth],
Programs,
Accounts.Access_Level as [Access level],
Accounts.Status as [Account Status]

from Inventory
Inner join Accounts on Person.PersonID = Accounts.AccountsID
where Accounts.Access_Level = 'Student' and Person.Fname = @Search
END
GO


Create proc SearchbyMname
@Search varchar(50)
	
AS
BEGIN

select PersonID as ID,
Fname as [First Name],
Mname as [Middle Name],
Lname as [Last Name],
Email,
Gender,
[Address],
Contact_Num as [Contact #],
Bdate as [Date of Birth],
Programs,
Accounts.Access_Level as [Access level],
Accounts.Status as [Account Status]

from Person
Inner join Accounts on Person.PersonID = Accounts.AccountsID
where Accounts.Access_Level = 'Student' and Person.Mname = @Search
END
GO

Create proc SearchbyLname
@Search varchar(50)
	
AS
BEGIN

select PersonID as ID,
Fname as [First Name],
Mname as [Middle Name],
Lname as [Last Name],
Email,
Gender,
[Address],
Contact_Num as [Contact #],
Bdate as [Date of Birth],
Programs,
Accounts.Access_Level as [Access level],
Accounts.Status as [Account Status]

from Person
Inner join Accounts on Person.PersonID = Accounts.AccountsID
where Accounts.Access_Level = 'Student' and Person.Lname = @Search
END
GO
