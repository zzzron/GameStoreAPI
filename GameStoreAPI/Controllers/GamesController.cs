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
    public class GamesController : ControllerBase
    {
        // db
        private GameStoreModel db;

        public GamesController(GameStoreModel db)
        {
            this.db = db;
        }

        // GET: api/Games
        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return db.Games.ToList();
        }

        // GET: api/Games/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Game game = db.Games.SingleOrDefault(g => g.id == id);

            if (game == null)
            {
                return NotFound();
            }
            return Ok(game);
        }

        // POST: api/Games
        [HttpPost]
        public ActionResult Post([FromBody] Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Games.Add(game);
            db.SaveChanges();
            return CreatedAtAction("Post", new { id = game.id });
        }

        // PUT: api/Games/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            db.Entry(game).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return AcceptedAtAction("Put", game);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Game game = db.Games.SingleOrDefault(g => g.id == id);

            if (game == null)
            {
                return BadRequest();
            }

            db.Games.Remove(game);
            db.SaveChanges();
            return Ok();
        }
    }
}