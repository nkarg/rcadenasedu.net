using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Transporte
{
    public class MedioDeTransporte
    {
        public string Color { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public MedioDeTransporte(string color, string marca)
        {
            this.Color = color;
            this.Marca = marca;
        }

        public string NombreCompleto()
        {
            var nombreCompleto = Marca + " " + Modelo;
            return nombreCompleto;

        }
    }
}
