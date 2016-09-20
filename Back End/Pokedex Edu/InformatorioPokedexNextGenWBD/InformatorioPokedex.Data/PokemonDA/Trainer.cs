using System.Collections.Generic;

namespace InformatorioPokedex.Data.PokemonDA
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Pokemon> pokemons { get; set; }
    }
}