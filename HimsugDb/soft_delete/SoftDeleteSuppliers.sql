USE HimsugDB 
GO
/****** Object:  StoredProcedure [dbo].[Adding]    Script Date: 8/31/2023 7:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure SoftDeleteSuppliers
    

AS
BEGIN

Declare @SupplierID int
UPDATE Suppliers
SET IsDeleted = 1
WHERE SupplierID = @SupplierID;
    

	
END


INSERT INTO Suppliers(SupplierName, [Address])
VALUES ('John Woke', 'Talisay city');