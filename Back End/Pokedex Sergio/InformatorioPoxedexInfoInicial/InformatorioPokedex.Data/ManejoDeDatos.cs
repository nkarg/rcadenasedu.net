using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    public class ManejoDeDatos
    {
       
       
      public static void agregar( pokemon p)
        {
            
            
                DatosPokemon.pokemones.Add(p);
                
            
       
        }
          
         
       //agregar pokemons
       //devolver una lista con todos los pokemon registrados hasta el momento
    }
}
