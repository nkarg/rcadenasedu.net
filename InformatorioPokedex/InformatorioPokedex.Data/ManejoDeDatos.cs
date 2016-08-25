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
                Console.WriteLine("BanderaF");
            } 
            else if (tipo == "Agua")
            {
                DatosPokemon.pokemons.Add(new Agua(nombre, tipo, alias, peso, altura));
                Console.WriteLine("Registrando Pokemón");
                Console.WriteLine("BanderaA");
            }
            else
            {
                DatosPokemon.pokemons.Add(new Planta(nombre, tipo, alias, peso, altura));
                Console.WriteLine("Registrando Pokemón");
                Console.WriteLine("BanderaP");
            }

        }

        public void mostrarTodos()
        {
            foreach (Pokemon pika in DatosPokemon.pokemons)
            {
                Console.WriteLine("*** *** ***");
                Console.WriteLine(pika.nombre);
                Console.WriteLine(pika.tipo);
                Console.WriteLine(pika.alias);
                Console.WriteLine(pika.peso);
                Console.WriteLine(pika.altura);
                if (pika.tipo == "Agua")
                {
                    Agua agua = new Agua(pika.nombre, pika.tipo, pika.alias, pika.peso, pika.altura);
                    Console.WriteLine(agua.chorroDeAgua());
                }
                else if (pika.tipo == "Fuego")
                {
                    Fuego fuego = new Fuego(pika.nombre, pika.tipo, pika.alias, pika.peso, pika.altura);
                    Console.WriteLine(fuego.lanzallamas());
                }
                else
                {
                    Planta planta = new Planta(pika.nombre, pika.tipo, pika.alias, pika.peso, pika.altura);
                    Console.WriteLine(planta.latigoSepa());
                }
            }
        }
    }
}
