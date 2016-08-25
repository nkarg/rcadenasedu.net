using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    class Planta: Pokemon
    {
        public Planta(string var_tipo, string var_alias, float var_peso, float var_altura) : base(var_tipo, var_alias, var_peso, var_altura)
        {

        }
        /// <summary>
        /// Permite utilizar el ataque especial de este Pokemon
        /// </summary>
        /// <returns>Mensaje de ataque</returns>
        public string latigoSepa()
        {
            return "pokemon ha usado LATIGO SEPA!! No muy efectivo! ha restado 25 ps al enemigo";
        }
    }
}
