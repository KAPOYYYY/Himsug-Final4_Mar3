CREATE PROCEDURE PersontoAccount

AS
BEGIN
	SELECT PersonID 
FROM Person
WHERE PersonID = (
    SELECT MAX(PersonID)
  	FROM Person)
END
GO
