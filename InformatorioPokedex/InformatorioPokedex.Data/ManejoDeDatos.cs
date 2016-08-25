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

        public void registrarPokemon(string nombre, string tipo, string alias, float peso, float altura)
        {
            if (tipo == "Fuego")
            {
                DatosPokemon.pokemons.Add(new Fuego(nombre, tipo, alias, peso, altura));
                Console.WriteLine("Registrando Pokemón");
            } 
            else if (tipo == "Agua")
            {
                DatosPokemon.pokemons.Add(new Agua(nombre, tipo, alias, peso, altura));
                Console.WriteLine("Registrando Pokemón");
            }
            else
            {
                DatosPokemon.pokemons.Add(new Planta(nombre, tipo, alias, peso, altura));
                Console.WriteLine("Registrando Pokemón");
            }

        }

        public void mostrarTodos()
        {

        }
    }
}
