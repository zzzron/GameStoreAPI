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
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Publishers
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Publishers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
