CREATE TABLE General.Patients
(
	PatientID VARCHAR(10) NOT NULL
	, FirstName VARCHAR(30) NOT NULL
	, LastName VARCHAR(30) NOT NULL
	, DateOfBirth DATE NOT NULL
	, NacionalityID INT NOT NULL
	, Diseases VARCHAR(100) NOT NULL
	, PhoneNumber VARCHAR(10)
	, BloodTypeID INT NOT NULL
	, CONSTRAINT PK_Patients 
		PRIMARY KEY CLUSTERED(PatientID)
	, CONSTRAINT FK_Patients_Nationalities 
		FOREIGN KEY(NacionalityID)
		REFERENCES General.Nationalities(NacionalityID)
	, CONSTRAINT FK_Patients_BloodTypes
		FOREIGN KEY(BloodTypeID)
		REFERENCES General.BloodTypes(BloodTypeID)
);