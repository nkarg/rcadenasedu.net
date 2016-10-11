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
            //ef objet. access db
            var pokemonContext = new PokemonContext();

            var allPkms = from pokemon 
                          in pokemonContext.Pokemons
                          select pokemon;
            //SELECT * FROM pokemon

            var filteredPkms = from pokemon
                               in pokemonContext.Pokemons
                               where pokemon.Trainer.Name.Equals("ash ketchum")
                               select pokemon;
            //SELECT * FROM pokemon WHERE  pokemon.trainer-name = Ash
            // select p.* from Pokemon as p
            // inner join Trainer as t
            // on p.TrainerID = t.TrainerID
            // weher t.name = "Ash Ketchum"

            var trainers = from trainer
                                    in pokemonContext.Trainers
                                    select trainer;

            var ash = pokemonContext.Trainers.FirstOrDefault(x => x.Name == "ash ketchum");
            foreach (var ppk in ash.Pokemons)
            {
                Console.WriteLine(ppk.Name);
            }

            var allPkmsLambda = pokemonContext.Pokemons.Select(x => x.Type.Equals("Fire"));
            //SELECT * FROM pokemons

            IEnumerable<Pokemon> filteredPkmn = from pokemon
                                                in pokemonContext.Pokemons
                                                where trainers.Equals("ash ketchum")
                                                select pokemon;
            

            foreach (Pokemon poke in allPkms)
            {
                Console.WriteLine(poke.Name);
            }


            //Get all Pokemons catched before 23/09
            var allPkmsBefore = from pokemon
                                in pokemonContext.Pokemons
                                where pokemon.CaptureDate < new DateTime (2016, 9, 20)
                                select pokemon;

            foreach (Pokemon poe in allPkmsBefore)
            {
                Console.WriteLine(poe.Name + " Este");
            }

            Console.ReadKey();
        }
    }
}
