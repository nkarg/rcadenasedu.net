using InformatorioPokedex.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokedex = new Pokedex();
            Console.WriteLine("                                              888");
            Console.WriteLine("                                              888");
            Console.WriteLine("                888");
            Console.WriteLine("88888b.  .d88b. 888  888.d88b. 88888b.d88b.  .d88b. 88888b.");
            Console.WriteLine("888 '88bd88''88b888 .88Pd8P  Y8b888 '888 '88bd88''88b888 '88b");
            Console.WriteLine("888  888888  888888888K 88888888888  888  888888  888888  888");
            Console.WriteLine("888 d88PY88..88P888 '88bY8b.    888  888  888Y88..88P888  888");
            Console.WriteLine("88888P'  'Y88P' 888  888 'Y8888 888  888  888 'Y88P' 888  888");
            Console.WriteLine("888");
            Console.WriteLine("888");
            Console.WriteLine("888");
            Console.WriteLine("                        ░█▀▀▄░░░░░░░░░░░▄▀▀█");
            Console.WriteLine("                        ░█░░░▀▄░▄▄▄▄▄░▄▀░░░█");
            Console.WriteLine("                        ░░▀▄░░░▀░░░░░▀░░░▄▀");
            Console.WriteLine("                        ░░░░▌░▄▄░░░▄▄░▐▀▀");
            Console.WriteLine("                        ░░░▐░░█▄░░░▄█░░▌▄▄▀▀▀▀█");
            Console.WriteLine("                        ░░░▌▄▄▀▀░▄░▀▀▄▄▐░░░░░░█");
            Console.WriteLine("                        ▄▀▀▐▀▀░▄▄▄▄▄░▀▀▌▄▄▄░░░█");
            Console.WriteLine("                        █░░░▀▄░█░░░█░▄▀░░░░█▀▀▀");
            Console.WriteLine("                        ░▀▄░░▀░░▀▀▀░░▀░░░▄█▀");
            Console.WriteLine("                        ░░░█░░░░░░░░░░░▄▀▄░▀▄");
            Console.WriteLine("                        ░░░█░░░░░░░░░▄▀█░░█░░█");
            Console.WriteLine("                        ░░░█░░░░░░░░░░░█▄█░░▄▀");
            Console.WriteLine("                        ░░░█░░░░░░░░░░░████▀");
            Console.WriteLine("                        ░░░▀▄▄▀▀▄▄▀▀▄▄▄█▀\n\n\n");
            Console.WriteLine("Bienvenido al fantastico mundo de los pokemón!");
            Console.ReadKey();
            Console.WriteLine("Desea usar la pokedex?: (S-N)");
            string rpta = Console.ReadLine();
            rpta = rpta.ToUpper();
            while ((rpta != "S") && (rpta != "N"))
            {
                Console.WriteLine("Debes ingresar una respuesta posible. S-N");
                rpta = Console.ReadLine();
                rpta = rpta.ToUpper();
                Console.WriteLine(rpta);
            }
            if (rpta == "S")
            {
                Console.WriteLine("Que deseas hacer: \n1-Registrar 2-VerLista");
                rpta = Console.ReadLine();
                while ((rpta != "1") && (rpta != "2"))
                {
                    Console.WriteLine("Debes ingresar una respuesta posible. 1-2");
                    rpta = Console.ReadLine();
                }
                if (rpta == "1")
                {
                    Console.WriteLine("Bienvenido al sistema de Registro Pokemón \n Ahora vamos a registrar un nuevo Pokemón: ");
                    Console.WriteLine("Por favor ingresa el Tipo: Fuego, Agua, Planta");
                    string tipo = Console.ReadLine();
                    Console.WriteLine("Por favor ingresa el Alias: ");
                    string alias = Console.ReadLine();
                    Console.WriteLine("Por favor ingresa el Peso del pokemón: ");
                    float peso = float.Parse(Console.ReadLine()); 
                    Console.WriteLine("Por favor ingresa la Altura del pokemón: ");
                    float altura = float.Parse(Console.ReadLine());
                    pokedex.registrar(tipo, alias, peso, altura);
                    Console.WriteLine("RegistroValidado");
                    Console.ReadKey();
                }
                else
                {
                    pokedex.mostrar();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Vuelve para convertirte en un MAESTRO");
                Console.ReadKey();
                Console.WriteLine("────────▄███████████▄────────");
                Console.WriteLine("─────▄███▓▓▓▓▓▓▓▓▓▓▓███▄─────");
                Console.WriteLine("────███▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓███────");
                Console.WriteLine("───██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██───");
                Console.WriteLine("──██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██──");
                Console.WriteLine("─██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██─");
                Console.WriteLine("██▓▓▓▓▓▓▓▓▓███████▓▓▓▓▓▓▓▓▓██");
                Console.WriteLine("██▓▓▓▓▓▓▓▓██░░░░░██▓▓▓▓▓▓▓▓██");
                Console.WriteLine("██▓▓▓▓▓▓▓██░░███░░██▓▓▓▓▓▓▓██");
                Console.WriteLine("███████████░░███░░███████████");
                Console.WriteLine("██░░░░░░░██░░███░░██░░░░░░░██");
                Console.WriteLine("██░░░░░░░░██░░░░░██░░░░░░░░██");
                Console.WriteLine("██░░░░░░░░░███████░░░░░░░░░██");
                Console.WriteLine("─██░░░░░░░░░░░░░░░░░░░░░░░██─");
                Console.WriteLine("──██░░░░░░░░░░░░░░░░░░░░░██──");
                Console.WriteLine("───██░░░░░░░░░░░░░░░░░░░██───");
                Console.WriteLine("────███░░░░░░░░░░░░░░░███────");
                Console.WriteLine("─────▀███░░░░░░░░░░░███▀─────");
                Console.WriteLine("────────▀███████████▀────────");
                Console.WriteLine("Atrapalos YA! PO-KE-MÓN");
                Console.ReadKey();
            }



        }
    }
}
