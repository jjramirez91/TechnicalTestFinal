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
    public class BloodTypesController : ApiController
    {
        private TechnicalTestDBEntities db = new TechnicalTestDBEntities();

        // GET: api/BloodTypes
        /// <summary>
        /// Get all Blood Types.
        /// </summary>
        /// <returns>Blood Types.</returns>
        public IQueryable<BloodType> Get()
        {
            return db.BloodTypes;
        }

        // GET: api/BloodTypes/5
        [ResponseType(typeof(BloodType))]
        public async Task<IHttpActionResult> GetBloodType(int id)
        {
            BloodType bloodType = await db.BloodTypes.FindAsync(id);
            if (bloodType == null)
            {
                return NotFound();
            }

            return Ok(bloodType);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BloodTypeExists(int id)
        {
            return db.BloodTypes.Count(e => e.BloodTypeID == id) > 0;
        }
    }
}