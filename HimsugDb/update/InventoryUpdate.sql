USE HimsugDB
GO
/****** Object:  StoredProcedure [dbo].[Adding]    Script Date: 8/31/2023 7:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE ProductUpdate 
    @ProductName VARCHAR(255),
	@Unit VARCHAR(255),
    @UnitPrice DECIMAL(10, 2),
    @QuantityInStock INT,
	@ArrivalDate DATE,
    @ExpirationDate DATE
AS
BEGIN

Update Products set ProductName = @ProductName, Unit = @Unit, UnitPrice = @UnitPrice, QuantityInStock = @QuantityInStock,ArrivalDate = @ArrivalDate, ExpirationDate = @ExpirationDate
where ProductID = @ProductID


END