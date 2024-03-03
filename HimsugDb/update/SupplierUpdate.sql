USE HimsugDB
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE Supplier_Update
    @SupplierName VARCHAR(255),
	@Address VARCHAR(255), 
	@ContactNumber VARCHAR(20),
	@ItemName VARCHAR(255),
	@Price Decimal(10,2),
	@TotalOrderItems INT,
	@TotalCost INT,
	@DateAdded date,
	@PackageDeliveredDate Date
AS
BEGIN

Update Suppliers set SupplierName = @SupplierName, [Address] = @Address, ContactNumber = @ContactNumber  ,Price = @Price,TotalOrderItems = @TotalOrderItems,TotalCost = @TotalCost, DateAdded = @DateAdded,PackageDeliveredDate = @PackageDeliveredDate
where SupplierID = @SupplierID


END