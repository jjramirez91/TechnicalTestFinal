CREATE PROCEDURE General.spPatientsUpdate
(
	@PatientID VARCHAR(10) 
	, @FirstName VARCHAR(30) 
	, @LastName VARCHAR(30) 
	, @DateOfBirth DATE
	, @NacionalityID INT
	, @Diseases VARCHAR(100) 
	, @PhoneNumber VARCHAR(10)
	, @BloodTypeID INT
)
AS

--Description: Object for update a Patient. 
--Creation Date: 20180425
--Autor: Juan José Ramírez Brenes

SET NOCOUNT ON;

UPDATE General.Patients
	SET FirstName = @FirstName
		, LastName = @LastName
		, DateOfBirth = @DateOfBirth
		, NacionalityID = @NacionalityID
		, Diseases = @Diseases
		, PhoneNumber = @PhoneNumber
		, BloodTypeID = @BloodTypeID
WHERE PatientID = @PatientID;