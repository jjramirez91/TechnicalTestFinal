CREATE PROCEDURE General.spPatientsListAll
AS

--Description: Object for list all Patients. 
--Creation Date: 20180425
--Autor: Juan José Ramírez Brenes

SET NOCOUNT ON;

SELECT P.PatientID
	, P.FirstName
	, P.LastName
	, P.DateOfBirth
	, N.NacionalityID
	, N.NacionalityName
	, P.Diseases
	, P.PhoneNumber
	, B.BloodTypeID
	, B.BloodTypeName
FROM General.Patients AS P
INNER JOIN General.Nationalities AS N
	ON P.NacionalityID = N.NacionalityID
INNER JOIN General.BloodTypes AS B
	ON P.BloodTypeID = B.BloodTypeID
ORDER BY NacionalityName;