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
using Multum.API.Models;
using Multum.API.Services;
using Multum.API.Interfaces;
using Multum.API.Filters;

namespace Multum.API.Controllers
{

    public class NDCCoreDescriptionController : ApiController
    {
        private static MultumDBContext db = new MultumDBContext();

        private INDCCoreDescriptionService descServices = new NDCCoreDescriptionServices(db);

        // GET: api/NDCCoreDescription
        public IQueryable<ndc_core_description> Getndc_core_description()
        {
            return db.ndc_core_description;
        }

        // GET: api/NDCCoreDescription/5
        [ResponseType(typeof(ndc_core_description))]
        public async Task<IHttpActionResult> Getndc_core_description(string id)
        {
            ndc_core_description ndc_core_description = await descServices.GetNDCCoreDescription(id);

            if (ndc_core_description == null)
            {
                return NotFound();
            }

            return Ok(ndc_core_description);
        }

        // PUT: api/NDCCoreDescription/5
        [ResponseType(typeof(void))]
        [ValidateModel]
        public async Task<IHttpActionResult> Putndc_core_description(string id, ndc_core_description ndc_core_description)
        {
            if (id != ndc_core_description.ndc_code)
            {
                return BadRequest();
            }

            db.Entry(ndc_core_description).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ndc_core_descriptionExists(id))
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

        // POST: api/NDCCoreDescription
        [ResponseType(typeof(ndc_core_description))]
        public async Task<IHttpActionResult> Postndc_core_description(ndc_core_description ndc_core_description)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ndc_core_description.Add(ndc_core_description);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ndc_core_descriptionExists(ndc_core_description.ndc_code))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = ndc_core_description.ndc_code }, ndc_core_description);
        }

        // DELETE: api/NDCCoreDescription/5
        [ResponseType(typeof(ndc_core_description))]
        public async Task<IHttpActionResult> Deletendc_core_description(string id)
        {
            ndc_core_description ndc_core_description = await db.ndc_core_description.FindAsync(id);
            if (ndc_core_description == null)
            {
                return NotFound();
            }

            db.ndc_core_description.Remove(ndc_core_description);
            await db.SaveChangesAsync();

            return Ok(ndc_core_description);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ndc_core_descriptionExists(string id)
        {
            return db.ndc_core_description.Count(e => e.ndc_code == id) > 0;
        }
    }
}