using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Transporte
{
    public class Moto : MedioDeTransporte
    {
        public string Cilindrada { get; set; }

        public Moto(string color, string marca):base(color, marca)
        {

        }
      
    }
}
