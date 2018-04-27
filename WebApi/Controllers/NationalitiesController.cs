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
    public class NationalitiesController : ApiController
    {
        private TechnicalTestDBEntities db = new TechnicalTestDBEntities();

        // GET: api/Nationalities
        /// <summary>
        /// Get all Nationalities.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Nationality> Get()
        {
            return db.Nationalities;
        }

        // GET: api/Nationalities/5
        [ResponseType(typeof(Nationality))]
        public async Task<IHttpActionResult> GetNationality(int id)
        {
            Nationality nationality = await db.Nationalities.FindAsync(id);
            if (nationality == null)
            {
                return NotFound();
            }

            return Ok(nationality);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NationalityExists(int id)
        {
            return db.Nationalities.Count(e => e.NacionalityID == id) > 0;
        }
    }
}