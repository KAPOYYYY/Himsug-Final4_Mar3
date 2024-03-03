USE HimsugDB 
GO
/****** Object:  StoredProcedure [dbo].[Adding]    Script Date: 8/31/2023 7:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure SoftDeleteCustomers
    

AS
BEGIN

Declare @CustomerID int
UPDATE Customers
SET IsDeleted = 1
WHERE CustomerID = @CustomerID;
    

	
END 