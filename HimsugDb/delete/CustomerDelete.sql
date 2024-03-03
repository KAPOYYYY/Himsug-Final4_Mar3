USE [HimsugDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE CustomerDeleteSP
@CustomerID int
AS
BEGIN
Delete From Customers Where CustomerID = @CustomerID
END
GO


select * from Customers

