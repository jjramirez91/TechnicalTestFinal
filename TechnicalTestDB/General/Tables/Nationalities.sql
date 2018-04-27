CREATE TABLE General.Nationalities
(
	NacionalityID INT IDENTITY(1,1) NOT NULL
	, NacionalityName VARCHAR(40)
	, CountryName VARCHAR(40)
	, CONSTRAINT PK_Nationalities 
		PRIMARY KEY CLUSTERED(NacionalityID)
);