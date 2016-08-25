using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{
    public class Pokemon
    {
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string alias { get; set; }
        public float peso { get; set; }
        public float altura { get; set; }

        public Pokemon(string var_nombre,string var_tipo, string var_alias, float var_peso, float var_altura)
        {
            nombre = var_nombre;
            tipo = var_tipo;
            alias = var_alias;
            peso = var_peso;
            altura = var_altura;
        }

        public string placaje()
        {
            return "pokemon ha usado PLACAJE!! ha restado 15 ps al enemigo";
        }

        public string gruñido()
        {
            return "pokemon ha usado GRUÑIDO!! resistencia del enemigo ha bajado";
        }
    }
}
