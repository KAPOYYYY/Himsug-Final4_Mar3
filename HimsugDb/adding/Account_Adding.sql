USE [HimsugDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE AccountSP
@Username varchar (100),
@Password varchar (200),
@Access_Level varchar(10)

AS
BEGIN


Insert into	Accounts(Username,[Password],Access_Level)
	values (@Username,@Password,@Access_Level)
	
END
GO