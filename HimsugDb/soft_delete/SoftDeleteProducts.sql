USE HimsugDB 
GO
/****** Object:  StoredProcedure [dbo].[Adding]    Script Date: 8/31/2023 7:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure SoftDeleteProducts
    

AS
BEGIN

Declare @ProductID int
UPDATE Products
SET IsDeleted = 1
WHERE ProductID = @ProductID;
    

	
END


INSERT INTO Products(ProductName, Unit)
VALUES ('Strepsils', 'Box');