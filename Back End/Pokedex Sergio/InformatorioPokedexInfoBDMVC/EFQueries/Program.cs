using InformatorioPokedex.Data.PokemonDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            // ef-object-access-db
            var pokemonContext = new PokemonContext();


            var allPkms = from pokemon
                          in pokemonContext.Pokemons
                          select pokemon;
            // SELECT * FROM Pokemons


            //Con Lambda
            var allPkmsLambda = pokemonContext.Pokemons.Select(x => x);
            allPkms.Where(x => x.Name == "Pikachu").ToList();


            // 
            var filteredPkms = from pokemon
                               in pokemonContext.Pokemons
                               where pokemon.Trainer.Name.Equals("ash ketchum")
                               select pokemon;


            var ash = pokemonContext.Trainers.FirstOrDefault(x => x.Name == "ash ketchum");
            foreach (var pk in ash.Pokemons)
            {
                Console.WriteLine(pk.Name);
            }

            // select p.* from Pokemon as p
            // inner join.Trainer as t
            //on p.trainerId = t.traineriD
            // where t.name = "ash ketchum" esto baad, lo de arriba +10 y a fav (es lo mismo, pero en sql es todo este bardo).

            //foreach (Pokemon poke in filteredPkms)
            // {
            //   Console.WriteLine(poke.Name);
            //}


            //get all pokemons catched before 23/9

            var pokemons = from pokemon
                        in pokemonContext.Pokemons
                           where pokemon.CaptureDate < new DateTime(2016, 9, 23)
                           select pokemon.Name;

            foreach ( var pokemon in pokemons)
            {
                Console.WriteLine(pokemon);
            }
            

            Console.ReadLine();
        }
    }
}
