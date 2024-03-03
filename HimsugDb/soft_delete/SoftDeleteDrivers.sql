USE HimsugDB 
GO
/****** Object:  StoredProcedure [dbo].[Adding]    Script Date: 8/31/2023 7:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure SoftDeleteDrivers
    

AS
BEGIN

Declare @DriverID int
UPDATE Drivers
SET IsDeleted = 1
WHERE DriverID = @DriverID;
    

	
END 