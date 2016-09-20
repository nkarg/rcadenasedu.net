using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            const int valor = 1;
            Console.WriteLine("Ingresa tu fecha de nacimiento: ");
            var fecha = Console.ReadLine();
            var numero = Convert.ToInt32(fecha);
            Console.WriteLine("Tu edad es de: " + (2016 - numero) + " años.");
            var resp = 2016 - numero;
            if (resp > 25)
            {
                Console.WriteLine("Estas viejo ameo");
            }
            else
            {
                Console.WriteLine("Casi casi");
            }
            Console.ReadLine();
        }
    }
}
