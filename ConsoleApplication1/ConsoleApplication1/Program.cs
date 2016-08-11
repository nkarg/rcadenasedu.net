using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Ingrese un numero por favor: ");
            var str = Console.ReadLine();
            var numero = Convert.ToInt32(str);
            if ((numero % 2) == 0)
            {
                Console.WriteLine("El numero ingresado es PAR.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El numero ingresado es IMPAR.");
                Console.ReadLine();
            }
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Ingrese un numero del 1 al 7: ");
            var str2 = Console.ReadLine();
            var numero2 = Convert.ToInt16(str2);
            while ((numero2 < 1) || (numero2 > 7))
            {
                Console.WriteLine("Error el numero no esta entre los limites.");
                str2 = Console.ReadLine();
                numero2 = Convert.ToInt16(str2);
            }
            if (numero2 == 7)
            {
                Console.WriteLine("Hoy es Lunes!");
                Console.ReadLine();
            }
            else if (numero2 == 2)
            {
                Console.WriteLine("Hoy es Martes!");
                Console.ReadLine();
            }
            else if (numero2 == 3)
            {
                Console.WriteLine("Hoy es Miercoles!");
                Console.ReadLine();
            }
            else if (numero2 == 4)
            {
                Console.WriteLine("Hoy es Jueves!");
                Console.ReadLine();
            }
            else if (numero2 == 5)
            {
                Console.WriteLine("Hoy es Viernes!");
                Console.ReadLine();
            }
            else if (numero2 == 6)
            {
                Console.WriteLine("Hoy es Sabado!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hoy es Domingo!");
                Console.ReadLine();
            }
            Console.WriteLine("Ejercicio 3");
            int num1, num2, num3;
            Console.WriteLine("Ingrese 3 numeros por favor: ");
            Console.WriteLine("Numero 1: ");
            var str3 = Console.ReadLine();
            Console.WriteLine("Numero 2: ");
            var str4 = Console.ReadLine();
            Console.WriteLine("Numero 3: ");
            var str5 = Console.ReadLine();
            num1 = Convert.ToInt32(str3);
            num2 = Convert.ToInt32(str4);
            num3 = Convert.ToInt32(str5);
            if ((num1 < num2) && (num2 < num3)){
                Console.WriteLine("Los numeros fueron ingresados en orden Creciente");
                Console.ReadLine();
            }
            else if ((num3 < num2) && (num2 < num1)){
                Console.WriteLine("Los numeros fueron ingresados en orden Decreciente");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Los numeros fueron ingresados de manera Aleatoria");
                Console.ReadLine();
            }
            Console.WriteLine("Ejercicio 4");
            int [] vector = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("A continuacion ingresaremos 10 numeros.");
                Console.WriteLine("Ingrese el numero " + (i + 1) + " por favor: ");
                var rpta = Console.ReadLine();
                vector[i] = Convert.ToInt32(rpta);
            }
            int mayor, menor;
            mayor = 0;
            menor = 0;
            for (int j = 0; j < 10; j++)
            {
                if (vector[j] > mayor)
                {
                    mayor = vector[j];
                }
                if (vector[j] < menor)
                {
                    menor = vector[j];
                }
            }
            Console.WriteLine("El numero mas grande encontrado es: " + mayor + " Mientras que el numero mas pequeño fue: " + menor);
            Console.ReadLine();
            Console.WriteLine("Ejercicio 5");
            int sueldo = 40000;
            Console.WriteLine("Ingrese los años de antiguedad en la empresa: ");
            var rpta3 = Console.ReadLine();
            var antiguedad = Convert.ToInt32(rpta3);
            if (antiguedad >= 10)
            {
                sueldo = (((sueldo * 10) / 100) + sueldo);
            }
            else if ((antiguedad > 5) && (antiguedad < 10))
            {
                sueldo = (((sueldo * 7) / 100) + sueldo);
            }
            else if ((antiguedad > 3) && (antiguedad < 5))
            {
                sueldo = (((sueldo * 5) / 100) + sueldo);
            }
            else
            {
                sueldo = (((sueldo * 3) / 100) + sueldo);
            }
            Console.WriteLine("El sueldo del empleado es de: " + sueldo);
            Console.ReadLine();
        }
    }
}
