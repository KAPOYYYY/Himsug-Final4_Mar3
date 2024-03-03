USE [HimsugDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE Customer_Adding
    @CustomerName VARCHAR(255),
    @Cus_Address VARCHAR(255),
    @Phone VARCHAR(20),
	@Unit VARCHAR(255),
	@UnitPrice DECIMAL(10, 2),
	@TotalCost INT,
	@TotalOrderItems INT,
	@DateOrdered date,
	@PlannedDelivery Date
as
Begin
	declare @CustomerID int
	Insert into	Customers(CustomerName,Cus_Address,Phone,Unit,UnitPrice,TotalCost,TotalOrderItems,DateOrdered,PlannedDelivery)
	values (@CustomerName,@Cus_Address,@Phone,@Unit,@UnitPrice,@TotalCost,@TotalOrderItems,@DateOrdered,@PlannedDelivery)
	set @CustomerID = SCOPE_IDENTITY()


	update Customers 
	set CustomerID = @CustomerId
	
	
end
GO
