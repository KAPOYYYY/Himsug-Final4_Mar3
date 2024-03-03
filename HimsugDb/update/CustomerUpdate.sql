USE HimsugDB
GO
/****** Object:  StoredProcedure [dbo].[Adding]    Script Date: 8/31/2023 7:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE Customer_Update
    @CustomerName VARCHAR(255),
    @Cus_Address VARCHAR(255),
    @Phone VARCHAR(20),
	@Unit VARCHAR(255),
	@UnitPrice DECIMAL(10, 2),
	@TotalCost INT,
	@TotalOrderItems INT,
	@DateOrdered date,
	@PlannedDelivery Date
AS
BEGIN

Update Customers set CustomerName = @CustomerName, Cus_Address = @Cus_Address, Phone = @Phone  ,UnitPrice = @UnitPrice,TotalCost = @TotalCost,TotalOrderItems = @TotalOrderItems, DateOrdered = @DateOrdered,PlannedDelivery = @PlannedDelivery
where CustomerID = @CustomerID


END
Go