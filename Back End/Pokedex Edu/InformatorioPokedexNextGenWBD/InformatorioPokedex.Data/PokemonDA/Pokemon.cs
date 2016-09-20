using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data.PokemonDA
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CaptureDay { get; set; }
        public PokemonType? Type { get; set; }

        public virtual Trainer Trainer { get; set; }
    }
}
