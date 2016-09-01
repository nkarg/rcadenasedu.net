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
                Console.WriteLine("\nRegistrando Pokemón");
                Console.WriteLine("NuevoFuego");
            } 
            else if (tipo == "Agua")
            {
                DatosPokemon.pokemons.Add(new Agua(nombre, tipo, alias, peso, altura));
                Console.WriteLine("\nRegistrando Pokemón");
                Console.WriteLine("nuevoAgua");
            }
            else
            {
                DatosPokemon.pokemons.Add(new Planta(nombre, tipo, alias, peso, altura));
                Console.WriteLine("\nRegistrando Pokemón");
                Console.WriteLine("nuevoPlanta");
            }

        }

        public void mostrarTodos()
        {
            foreach (Pokemon pika in DatosPokemon.pokemons)
            {
                Console.WriteLine("*** STATS ***");
                Console.WriteLine("Nombre: "+ pika.nombre);
                Console.WriteLine("Descripcion: " + pika.descripcion(pika.nombre));
                Console.WriteLine("Tipo: " + pika.tipo);
                Console.WriteLine("Alias: " + pika.alias);
                Console.WriteLine("Peso: " + pika.peso + "kg");
                Console.WriteLine("Altura: " + pika.altura +"cm");
                Console.WriteLine("**AtaqueEspecial**");

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
                Console.WriteLine("*** *** ***\n");
            }
        }

        public IList<Pokemon> returnList()
        {
            return DatosPokemon.pokemons;
        } 
    }
}
