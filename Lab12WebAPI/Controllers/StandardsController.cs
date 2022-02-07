using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Lab12WebAPI.Models;

namespace Lab12WebAPI.Controllers
{
    public class StandardsController : ApiController
    {
        private SchoolDbEntities db = new SchoolDbEntities();

        // GET: api/Standards
        public IQueryable<Standard> GetStandards()
        {
            return db.Standards;
        }

        // GET: api/Standards/5
        [ResponseType(typeof(Standard))]
        public IHttpActionResult GetStandard(int id)
        {
            Standard standard = db.Standards.Find(id);
            if (standard == null)
            {
                return NotFound();
            }

            return Ok(standard);
        }

        // PUT: api/Standards/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStandard(Standard standard)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            using (var ctx = new SchoolDbEntities())
            {
                var oldS = ctx.Standards.Where(s => s.StandardId == standard.StandardId)
                    .FirstOrDefault<Standard>();
                if (oldS != null)
                {
                    oldS.StandardName = standard.StandardName;
                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok();
        }

        // POST: api/Standards
        [ResponseType(typeof(Standard))]
        public IHttpActionResult PostStandard(Standard standard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Standards.Add(standard);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = standard.StandardId }, standard);
        }

        // DELETE: api/Standards/5
        [ResponseType(typeof(Standard))]
        public IHttpActionResult DeleteStandard(int id)
        {
            Standard standard = db.Standards.Find(id);
            if (standard == null)
            {
                return NotFound();
            }

            db.Standards.Remove(standard);
            db.SaveChanges();

            return Ok(standard);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StandardExists(int id)
        {
            return db.Standards.Count(e => e.StandardId == id) > 0;
        }
    }
}