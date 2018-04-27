CREATE PROCEDURE General.spBloodTypesListAll
AS

--Description: Object for list all Blood Types. 
--Creation Date: 20180425
--Autor: Juan José Ramírez Brenes

SET NOCOUNT ON;

SELECT BloodTypeID
	, BloodTypeName
FROM General.BloodTypes
ORDER BY BloodTypeName;