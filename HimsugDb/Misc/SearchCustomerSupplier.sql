USE HimsugDB 
GO
/****** Object:  StoredProcedure [dbo].[Adding]    Script Date: 8/31/2023 7:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE SearchCustomerSupplier 
    @SearchStr NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        c.CustomerID,
        c.CustomerName,
        c.Cus_Address,
        c.Phone,
        c.Unit,
        c.UnitPrice,
        c.TotalCost,
        c.TotalOrderItems,
        c.DateOrdered,
        c.PlannedDelivery,
        c.ProductID,
        s.SupplierID,
        s.SupplierName,
        s.[Address],
        s.ContactNumber,
        s.ItemName,
        s.Price,
        s.TotalOrderItems,
        s.TotalCost,
        s.DateAdded,
        s.PackageDeliveredDate

    FROM 
        Customers c 
    JOIN 
        Products p ON c.ProductID = p.ProductID
    JOIN 
        Suppliers s ON p.SupplierID = s.SupplierID
    WHERE 
        c.CustomerName LIKE '%' + @SearchStr + '%'
        OR s.SupplierName LIKE '%' + @SearchStr + '%'

END
GO