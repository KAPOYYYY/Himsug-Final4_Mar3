use HimsugDB
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Alter procedure SearchbyID
@
	
AS
BEGIN


SELECT * FROM Suppliers
WHERE SupplierName LIKE '%SearchTerm%' OR [Address] LIKE '%SearchTerm%' OR ContactNumber LIKE '%SearchTerm%' OR ItemName LIKE '%SearchTerm%' OR DateAdded LIKE '%SearchTerm%' OR PackageDeliveredDate LIKE '%SearchTerm%' OR isDeleted = 0;

-- Products Search
SELECT * FROM Products
WHERE ProductName LIKE '%SearchTerm%' OR Unit LIKE '%SearchTerm%' OR UnitPrice LIKE '%SearchTerm%' OR QuantityInStock LIKE '%SearchTerm%' OR ArrivalDate LIKE '%SearchTerm%' OR ExpirationDate LIKE '%SearchTerm%' OR isDeleted = 0;

-- Customers Search
SELECT * FROM Customers
WHERE CustomerName LIKE '%SearchTerm%' OR Cus_Address LIKE '%SearchTerm%' OR Phone LIKE '%SearchTerm%' OR Unit LIKE '%SearchTerm%' OR UnitPrice LIKE '%SearchTerm%' OR TotalCost LIKE '%SearchTerm%' OR TotalOrderItems LIKE '%SearchTerm%' OR DateOrdered LIKE '%SearchTerm%' OR PlannedDelivery LIKE '%SearchTerm%' OR isDeleted = 0;

-- Drivers Search
SELECT * FROM Drivers
WHERE DriverName LIKE '%SearchTerm%' OR ContactNumber LIKE '%SearchTerm%' OR DeliveryDate LIKE '%SearchTerm%' OR isDeleted = 0;
END
GO
