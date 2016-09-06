using InformatorioPokedex.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Bussiness
{
    public class Pokedex
    {
        
      public Boolean existePokemon (pokemon p)
          {
            
            Boolean resultado = false;
            foreach (pokemon p1 in DatosPokemon.pokemones)
              {
                if (p1.Nombre == p.Nombre)
                 {
                    resultado = true;
                    

                 }
                



            }
            return resultado;
        
      

        }
         
       public void mostrarPokemonAgregado(pokemon p)
        {
            Console.WriteLine("El pokemon " + p.Nombre + " se ha agregado correctamente");
        }

       public void mostrarPokemonNoAgregado (pokemon p)
        {
            Console.WriteLine("El pokemon " + p.Nombre + " no se ha agregado correctamente");
        }

        public void mostrarLista(List<pokemon> listaPokemon)
        {
            foreach (pokemon p in listaPokemon)
            {
                Console.WriteLine(p.Nombre);
            }
        }
      
        //registrar un nuevo pokemon y verificar que ya no exista
        //mostrar todos los pokemons registrados
      }
}
