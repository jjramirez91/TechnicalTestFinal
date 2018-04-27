﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TechnicalTestDBEntities : DbContext
    {
        public TechnicalTestDBEntities()
            : base("name=TechnicalTestDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BloodType> BloodTypes { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
    
        public virtual ObjectResult<spBloodTypesListAll_Result> spBloodTypesListAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spBloodTypesListAll_Result>("spBloodTypesListAll");
        }
    
        public virtual ObjectResult<spNationalitiesListAll_Result> spNationalitiesListAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spNationalitiesListAll_Result>("spNationalitiesListAll");
        }
    
        public virtual int spPatientsAdd(string patientID, string firstName, string lastName, Nullable<System.DateTime> dateOfBirth, Nullable<int> nacionalityID, string diseases, string phoneNumber, Nullable<int> bloodTypeID)
        {
            var patientIDParameter = patientID != null ?
                new ObjectParameter("PatientID", patientID) :
                new ObjectParameter("PatientID", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("DateOfBirth", dateOfBirth) :
                new ObjectParameter("DateOfBirth", typeof(System.DateTime));
    
            var nacionalityIDParameter = nacionalityID.HasValue ?
                new ObjectParameter("NacionalityID", nacionalityID) :
                new ObjectParameter("NacionalityID", typeof(int));
    
            var diseasesParameter = diseases != null ?
                new ObjectParameter("Diseases", diseases) :
                new ObjectParameter("Diseases", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var bloodTypeIDParameter = bloodTypeID.HasValue ?
                new ObjectParameter("BloodTypeID", bloodTypeID) :
                new ObjectParameter("BloodTypeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spPatientsAdd", patientIDParameter, firstNameParameter, lastNameParameter, dateOfBirthParameter, nacionalityIDParameter, diseasesParameter, phoneNumberParameter, bloodTypeIDParameter);
        }
    
        public virtual int spPatientsDelete(string patientID)
        {
            var patientIDParameter = patientID != null ?
                new ObjectParameter("PatientID", patientID) :
                new ObjectParameter("PatientID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spPatientsDelete", patientIDParameter);
        }
    
        public virtual ObjectResult<spPatientsListAll_Result> spPatientsListAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spPatientsListAll_Result>("spPatientsListAll");
        }
    
        public virtual int spPatientsUpdate(string patientID, string firstName, string lastName, Nullable<System.DateTime> dateOfBirth, Nullable<int> nacionalityID, string diseases, string phoneNumber, Nullable<int> bloodTypeID)
        {
            var patientIDParameter = patientID != null ?
                new ObjectParameter("PatientID", patientID) :
                new ObjectParameter("PatientID", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("DateOfBirth", dateOfBirth) :
                new ObjectParameter("DateOfBirth", typeof(System.DateTime));
    
            var nacionalityIDParameter = nacionalityID.HasValue ?
                new ObjectParameter("NacionalityID", nacionalityID) :
                new ObjectParameter("NacionalityID", typeof(int));
    
            var diseasesParameter = diseases != null ?
                new ObjectParameter("Diseases", diseases) :
                new ObjectParameter("Diseases", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var bloodTypeIDParameter = bloodTypeID.HasValue ?
                new ObjectParameter("BloodTypeID", bloodTypeID) :
                new ObjectParameter("BloodTypeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spPatientsUpdate", patientIDParameter, firstNameParameter, lastNameParameter, dateOfBirthParameter, nacionalityIDParameter, diseasesParameter, phoneNumberParameter, bloodTypeIDParameter);
        }
    }
}