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
using InformatorioPokedex.Data.PokemonDA;

namespace PokemonMVC.Controllers
{
    public class PokemonsAPIController : ApiController
    {
        private PokemonContext db = new PokemonContext();

        // GET: api/PokemonsAPI
        public IQueryable<Pokemon> GetPokemons()
        {
            return db.Pokemons;
        }

        // GET: api/PokemonsAPI/5
        [ResponseType(typeof(Pokemon))]
        public IHttpActionResult GetPokemon(int id)
        {
            Pokemon pokemon = db.Pokemons.Find(id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return Ok(pokemon);
        }

        // PUT: api/PokemonsAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPokemon(int id, Pokemon pokemon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pokemon.PokemonId)
            {
                return BadRequest();
            }

            db.Entry(pokemon).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PokemonExists(id))
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

        // POST: api/PokemonsAPI
        [ResponseType(typeof(Pokemon))]
        public IHttpActionResult PostPokemon(Pokemon pokemon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pokemons.Add(pokemon);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pokemon.PokemonId }, pokemon);
        }

        // DELETE: api/PokemonsAPI/5
        [ResponseType(typeof(Pokemon))]
        public IHttpActionResult DeletePokemon(int id)
        {
            Pokemon pokemon = db.Pokemons.Find(id);
            if (pokemon == null)
            {
                return NotFound();
            }

            db.Pokemons.Remove(pokemon);
            db.SaveChanges();

            return Ok(pokemon);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PokemonExists(int id)
        {
            return db.Pokemons.Count(e => e.PokemonId == id) > 0;
        }
    }
}