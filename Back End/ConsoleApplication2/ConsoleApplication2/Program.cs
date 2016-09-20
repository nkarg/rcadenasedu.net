using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.Transporte;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var auto1 = new Auto("Blanco", "Toyota", "Corolla", 2010);
            var auto2 = new Auto("Verde", "Nissan");
            auto1.Mover(100, "Norte");
            var moto1 = new Moto("Amarillo", "Honda"); 
            Console.WriteLine(auto1.NombreCompleto());
            Console.WriteLine(auto2.NombreCompleto());
            Console.WriteLine(moto1.NombreCompleto());
            Console.ReadKey();
        }
    }
}
