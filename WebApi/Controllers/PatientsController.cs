using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class PatientsController : ApiController
    {
        private TechnicalTestDBEntities db = new TechnicalTestDBEntities();

        // GET: api/Patients
        /// <summary>
        /// Get all patients.
        /// </summary>
        /// <returns>Patient</returns>
        public IQueryable<Patient> Get()
        {
            return db.Patients;
        }

        // GET: api/Patients/5
        [ResponseType(typeof(Patient))]
        public async Task<IHttpActionResult> GetPatient(string id)
        {
            Patient patient = await db.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }

            return Ok(patient);
        }

        // PUT: api/Patients/5
        /// <summary>
        /// Update the Patient.
        /// </summary>
        /// <param name="id">The Patient Id.</param>
        /// <param name="patient">The Patient Object.</param>
        /// <returns>Patient</returns>
        [ResponseType(typeof(void))]
        [HttpPut]
        public async Task<IHttpActionResult> Update(string id, Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != patient.PatientID)
            {
                return BadRequest();
            }

            var updatePatient = db.spPatientsUpdate(id, patient.FirstName, patient.LastName, patient.DateOfBirth
                , patient.NacionalityID, patient.Diseases, patient.PhoneNumber, patient.BloodTypeID);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Patients
        /// <summary>
        /// Create new patient.
        /// </summary>
        /// <param name="patient">The patient.</param>
        /// <returns>Patient</returns>
        [ResponseType(typeof(Patient))]
        [HttpPost]
        public async Task<IHttpActionResult> Create(Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newPatient = db.spPatientsAdd(patient.PatientID, patient.FirstName, patient.LastName, patient.DateOfBirth
                , patient.NacionalityID, patient.Diseases, patient.PhoneNumber, patient.BloodTypeID);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PatientExists(patient.PatientID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = patient.PatientID }, patient);
        }

        // DELETE: api/Patients/5
        /// <summary>
        /// Delete the patient.
        /// </summary>
        /// <param name="id">The Patient ID.</param>
        /// <returns>Patient.</returns>
        [ResponseType(typeof(Patient))]
        [HttpDelete]
        public async Task<IHttpActionResult> Delete(string id)
        {
            Patient patient = await db.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }

            var deletePatient = db.spPatientsDelete(id);
            await db.SaveChangesAsync();
            return Ok(patient);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PatientExists(string id)
        {
            return db.Patients.Count(e => e.PatientID == id) > 0;
        }
    }
}