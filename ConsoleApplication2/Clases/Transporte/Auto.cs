using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Transporte
{
    public class Auto : MedioDeTransporte
    {
        public int AñoFabricación { get; set; }

        public Auto(string color, string marca, string modelo, int añoFabricacion):base(color, marca)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.AñoFabricación = añoFabricacion;
        }

        public Auto(string color, string marca):base(color, marca)
        {
            this.Marca = marca;
        }

        public void Mover(int metros, string direccion)
        {
            Console.WriteLine("El auto se movio {0} hacia el {1}", metros, direccion);
        }

        public void Mover(int metros)
        {
            Console.WriteLine("El auto se movio {0}", metros);
        }

        public string NombreCompleto()
        {
            var nombreCompleto = Marca + " " + Modelo + " " + AñoFabricación;
            return nombreCompleto;
            
        }
    }
}
