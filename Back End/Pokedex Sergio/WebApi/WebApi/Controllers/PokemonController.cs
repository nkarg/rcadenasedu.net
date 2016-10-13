using InformatorioPokedex.Data.PokemonDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class PokemonController : ApiController
    {
        public IEnumerable<PokemonSerializable> Get()
        {
            var pokecontext = new PokemonContext();
            var pokemons = pokecontext.Pokemons.ToList();
            var serializableList = new List<PokemonSerializable>();
            foreach (var item in pokemons)
            {
                serializableList.Add(new PokemonSerializable()
                {
                    PokemonID = item.PokemonId,
                    Name = item.Name
                });
            }
            return serializableList;
        } 
    }
}
