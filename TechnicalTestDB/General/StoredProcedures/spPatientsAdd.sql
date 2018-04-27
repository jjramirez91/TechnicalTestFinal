CREATE PROCEDURE General.spPatientsAdd
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

--Description: Object for add a new Patient. 
--Creation Date: 20180425
--Autor: Juan José Ramírez Brenes

SET NOCOUNT ON;

INSERT INTO General.Patients
(
	PatientID
	, FirstName
	, LastName
	, DateOfBirth
	, NacionalityID
	, Diseases
	, PhoneNumber
	, BloodTypeID
)
VALUES
(
	@PatientID
	, @FirstName
	, @LastName
	, @DateOfBirth
	, @NacionalityID
	, @Diseases
	, @PhoneNumber
	, @BloodTypeID
);