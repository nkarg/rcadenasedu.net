using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Bussiness
{
    public class Pokedex
    {
        //registrar un nuevo pokemon y verificar que ya no exista
        //mostrar todos los pokemons registrados

        public Pokedex()
        {

        }

        public void validarRegistroTipo(string resp)
        {
            if ((resp == "Fuego") || (resp == "Agua") || (resp == "Planta"))
            {
                
            }
            else
            {
                throw new ErrorDeTipeo("Debes ingresar bien el tipo Fuego-Agua-Planta");
            }
        }

        public void validarRegistroNombre(string resp)
        {
            
            if ((resp == "Charmander") || (resp == "Squartle") || (resp == "Bulbasaur"))
            {

            }
            else
            {
                throw new ErrorDeTipeo("\nDebes ingresar bien un nombre Pokemón Charmander - Squartle - Bulbasaur");
            }
        }
        
        public void validarRegistroPeso(string resp)
        {
            float tresp;
            bool condicion = float.TryParse(resp, out tresp);
            if (condicion)
            {

            }
            else
            {
                throw new ErrorDeTipeo("\nEl valor de peso ingresado no corresponde a un FLOAT");
            }
        }
        public void validarRegistroAltura(string resp)
        {
            float tresp;
            bool condicion = float.TryParse(resp, out tresp);
            if (condicion)
            {

            }
            else
            {
                throw new ErrorDeTipeo("\nEl valor de altura ingresado no corresponde a un FLOAT");
            }
        }
        public bool noVacio(IList<InformatorioPokedex.Data.Pokemon> lista)
        {
            if (InformatorioPokedex.Data.DatosPokemon.pokemons.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void registrar(string nombre, string tipo, string alias, string peso, string altura)
        {
            try
            {
                validarRegistroNombre(nombre);
                validarRegistroTipo(tipo);
                validarRegistroPeso(peso);
                validarRegistroAltura(altura);
                float fpeso = float.Parse(peso);
                float faltura = float.Parse(altura);
                InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
                if (noVacio(InformatorioPokedex.Data.DatosPokemon.pokemons))
                {
                    int flag = 0;
                    foreach (InformatorioPokedex.Data.Pokemon pika in InformatorioPokedex.Data.DatosPokemon.pokemons)
                    {
                        if (nombre == pika.nombre)
                        {
                            Console.WriteLine("\nEste pokemón ya ha sido registrado");
                            flag = 1;
                        }
                    }
                    if (flag == 0)
                    {
                        metodo.registrarPokemon(nombre, tipo, alias, fpeso, faltura);
                        Console.WriteLine("nuevoRegistro++");
                    }
                }
                else
                {
                    metodo.registrarPokemon(nombre, tipo, alias, fpeso, faltura);
                    Console.WriteLine("registro++");
                }
                       
            }
            catch (ErrorDeTipeo edt)
            {
                Console.WriteLine(edt.Message);
            }
            //try
            //{
            //    float tpeso = float.Parse(peso);
            //}
            //catch (ErrorDeTipeo edt)
            //{
            //    throw edt = new ErrorDeTipeo("El valor ingresado en el peso no es FLOAT.");
            //}
            //try
            //{
            //    float taltura = float.Parse(altura);
            //}
            //catch (ErrorDeTipeo edt)
            //{
            //    throw edt = new ErrorDeTipeo("El valor ingresado en la altura no es FLOAT");
            //}
        }

        
        public void mostrar()
        {
            if (noVacio(InformatorioPokedex.Data.DatosPokemon.pokemons))
            {
                InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
                metodo.mostrarTodos();
            }
            else
            {
                Console.WriteLine("\nTodavia no has capturado ningun Pokemón");
            } 
        }
    }
}
