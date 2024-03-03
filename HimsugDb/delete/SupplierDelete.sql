USE HimsugDB
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE SupplierDeleteSP
AS
BEGIN 

declare @SupplierID int
Delete From Suppliers Where SupplierID = @SupplierID;

END
go


select * from Suppliers
