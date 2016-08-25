using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication3
{
    class Program
    {
        static int stockAlfajores = 2;

        static void Main(string[] args)
        {
            //try
            //{
            //    // string text = System.IO.File.ReadAllText(@"C:\Users\Public\Documents\text.txt");
            //    // leerArchivo();
            //    venderAlfajor();
            //    venderAlfajor();
            //    venderAlfajor();
            //}
            ////catch (FileNotFoundException fnfe)
            ////{
            ////    throw;
            ////}
            ////catch (DirectoryNotFoundException dnfe)
            ////{
            ////    throw;
            ////}
            //catch(ProductoNoEncontradoException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //catch (Exception)
            //{
            //    throw;
            //}
            //finally
            //{
            //    Console.WriteLine("Se ejecuto al fin");
            //}
            ClaseEstatica.Saludo();
            Console.ReadKey();
        }

        static void leerArchivo()
        {
            throw new FileNotFoundException("No se encontro el archivo.");
        }

        static void venderAlfajor()
        {
            if (stockAlfajores > 0)
            {
                stockAlfajores = stockAlfajores - 1;
            }
            else
            {
                throw new ProductoNoEncontradoException("No podes vender mas Alfajores");
            }
        }
    }
}
