CREATE PROCEDURE General.spPatientsDelete
(
	@PatientID VARCHAR(10)
)
AS

--Description: Object for delete a Patient. 
--Creation Date: 20180425
--Autor: Juan José Ramírez Brenes

SET NOCOUNT ON;

DELETE FROM General.Patients
WHERE PatientID = @PatientID;