using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Data
{

    public class pokemon
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Alias { get; set; }
        public int Peso { get; set; }
        public int ALtura { get; set; }



        public pokemon (string nombre, string tipo, string alias, int peso, int altura)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Alias = alias;
            this.Peso = peso;
            this.ALtura = altura;
        }

        public void placaje()
        {
            Console.WriteLine("El poder de placaje fue ejecutado");
        }

        public void gruñido()
        {
            Console.WriteLine("El poder placaje fue ejecutado");
        }
       
    }
   







}
