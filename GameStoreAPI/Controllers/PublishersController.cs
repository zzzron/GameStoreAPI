using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        // db
        private GameStoreModel db;

        public PublishersController(GameStoreModel db)
        {
            this.db = db;
        }

        // GET: api/Publishers
        [HttpGet]
        public IEnumerable<Publisher> Get()
        {
            return db.Publishers;
        }

        // GET: api/Publishers/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Publisher publisher = db.Publishers.SingleOrDefault(p => p.id == id);

            if (publisher == null)
            {
                return NotFound();
            }
            return Ok(publisher);
        }

        // POST: api/Publishers
        [HttpPost]
        public ActionResult Post([FromBody] Publisher publisher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Publishers.Add(publisher);
            db.SaveChanges();
            return CreatedAtAction("Post", new { id = publisher.id });
        }

        // PUT: api/Publishers/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Publisher publisher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            db.Entry(publisher).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return AcceptedAtAction("Put", publisher);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Publisher publisher = db.Publishers.SingleOrDefault(p => p.id == id);

            if (publisher == null)
            {
                return BadRequest();
            }

            db.Publishers.Remove(publisher);
            db.SaveChanges();
            return Ok();
        }
    }
}
