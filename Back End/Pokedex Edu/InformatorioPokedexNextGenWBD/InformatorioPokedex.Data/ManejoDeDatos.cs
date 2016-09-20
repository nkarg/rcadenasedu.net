using InformatorioPokedex.Data.PokemonDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
   public class ManejoDeDatos
    {
        //agregar pokemons
        //devolver una lista con todos los pokemon registrados hasta el momento

        public void registrarPokemon(string idnombre, string tipo, string alias, float peso, float altura)
        {
            
            DatosPokemon.pokemons.Add(new Pokemon(idnombre, tipo, alias, peso, altura));
            Console.WriteLine("\nRegistrando Pokemón");
            Console.WriteLine("NuevoPoke");
        }

        public IList<Pokemon> returnList()
        {
            return DatosPokemon.pokemons;
        } 

        public List<Pokemon> getAll()
        {
            return this.PokemonContext.Pokemons.ToList();
        }

        public PokemonContext PokemonContext { get; set; }

        public ManejoDeDatos()
        {
            this.PokemonContext = new PokemonContext();
        }

        public void add (Pokemon p)
        {
            var pokemonDb = new InformatorioPokedex.Data.PokemonDA.Pokemon();
            pokemonDb.Name = p.idnombre;
            this.PokemonContext.Pokemons.Add(pokemonDb);
            this.PokemonContext.SaveChanges();
        }
    }
}
