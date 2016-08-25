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

        public void registrarPokemon(string tipo, string alias, float peso, float altura)
        {
            if (tipo == "Fuego")
            {
                DatosPokemon.pokemons.Add(new Fuego(tipo, alias, peso, altura));    
            } 
            else if (tipo == "Agua")
            {
                DatosPokemon.pokemons.Add(new Agua(tipo, alias, peso, altura));
            }
            else
            {
                DatosPokemon.pokemons.Add(new Planta(tipo, alias, peso, altura));
            }

        }

        public void mostrarTodos()
        {

        }
    }
}
