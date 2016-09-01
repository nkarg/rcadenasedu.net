using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    class Fuego: Pokemon
    {
        public Fuego(string var_nombre, string var_tipo, string var_alias, float var_peso, float var_altura) : base(var_nombre, var_tipo, var_alias, var_peso, var_altura)
        {

        }
        /// <summary>
        /// Permite utilizar el ataque especial de este Pokemon
        /// </summary>
        /// <returns>Mensaje de ataque</returns>
        public string lanzallamas()
        {
            return "pokemon ha usado LANZALLAMAS!! ha restado 35 ps al enemigo, el enemigo se ha quemado";
        }
    }
}
