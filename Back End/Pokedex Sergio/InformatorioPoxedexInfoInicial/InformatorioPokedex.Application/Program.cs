using InformatorioPokedex.Bussiness;
using InformatorioPokedex.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokedex = new Pokedex();
            var p = new pokemon ("picachu", "pica", "fuego", 15, 20);

            if (pokedex.existePokemon(p) == false)
            {
                ManejoDeDatos.agregar(p); 
                pokedex.mostrarPokemonAgregado(p);
            } else
            {
                pokedex.mostrarPokemonNoAgregado(p);
            }

            pokedex.mostrarLista(DatosPokemon.pokemones);
           

        }

     
    }
}
