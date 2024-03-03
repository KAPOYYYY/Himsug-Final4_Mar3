USE HimsugDB
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DriversDeleteSP
AS
BEGIN 

declare @DriverID int
Delete From Drivers Where DriverID = @DriverID;

END
go
