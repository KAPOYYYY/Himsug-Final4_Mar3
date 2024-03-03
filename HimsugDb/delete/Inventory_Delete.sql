USE [HimsugDB]
GO
/****** Object:  StoredProcedure [dbo].[Adding]    Script Date: 8/31/2023 7:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE Inventory_Delete
@ProductID int
AS
BEGIN
Delete From Products Where ProductID = @ProductID
END
GO

select * from Products