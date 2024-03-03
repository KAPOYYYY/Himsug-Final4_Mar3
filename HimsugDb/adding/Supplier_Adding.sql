USE [HimsugDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE Supplier_Adding
    @SupplierName VARCHAR(255),
	@Address VARCHAR(255), 
	@ContactNumber VARCHAR(20),
	@ItemName VARCHAR(255),
	@Price Decimal(10,2),
	@TotalOrderItems INT,
	@TotalCost INT,
	@DateAdded date,
	@PackageDeliveredDate Date
as
Begin
    declare @SupplierID int
	Insert into	Suppliers(SupplierName,[Address],ContactNumber,ItemName,Price,TotalOrderItems,TotalCost,DateAdded,PackageDeliveredDate)
	values (@SupplierName,@Address, @ContactNumber,@ItemName,@Price,@TotalOrderItems,@TotalCost,@DateAdded,@PackageDeliveredDate)
	set @SupplierID = SCOPE_IDENTITY()


	update Suppliers 
	set SupplierID = @SupplierID
	
	
end
go