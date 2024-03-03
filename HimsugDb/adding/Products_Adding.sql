USE [HimsugDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE Products_Adding
    @ProductName VARCHAR(255),
	@Unit VARCHAR(255),
    @UnitPrice DECIMAL(10, 2),
    @QuantityInStock INT,
	@ArrivalDate DATE,
    @ExpirationDate DATE
as
Begin
    declare @ProductID int
	Insert into	Products(ProductName,Unit,UnitPrice,QuantityInStock,ArrivalDate,ExpirationDate)
	values (@ProductName,@Unit,@UnitPrice,@QuantityInStock,@ArrivalDate,@ExpirationDate)
	set @ProductID = SCOPE_IDENTITY()


	update Products
	set ProductID = @ProductID
	
	
end
GO