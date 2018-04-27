CREATE PROCEDURE General.spNationalitiesListAll
AS

--Description: Object for list all Nationalities. 
--Creation Date: 20180425
--Autor: Juan José Ramírez Brenes

SET NOCOUNT ON;

SELECT NacionalityID
	, NacionalityName
FROM General.Nationalities
ORDER BY NacionalityName;