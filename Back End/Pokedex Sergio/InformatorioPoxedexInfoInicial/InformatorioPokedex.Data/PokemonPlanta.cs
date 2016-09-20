using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    public class PokemonPlanta : pokemon
    {
       
        public PokemonPlanta(string nombre, string tipo, string alias, int peso, int altura) : base()
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Alias = alias;
            this.Peso = peso;
            this.ALtura = aLtura; 

        }

        public void latigoCepa()
        {
            Console.WriteLine ("El ataque de latigo de cepa se ha ejecutado")
        }
    }
}
