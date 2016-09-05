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
                throw new ErrorDeTipeo("\nDebes ingresar bien el tipo Fuego-Agua-Planta");
            }
        }

        public void validarRegistroNombre(string resp)
        {

            if ((resp == "Charmander") || (resp == "Squirtle") || (resp == "Bulbasaur"))
            {

            }
            else
            {
                throw new ErrorDeTipeo("\nDebes ingresar bien un nombre Pokemón Charmander - Squirtle - Bulbasaur");
            }
        }

        public void validateName(string resp)
        {
            int tresp;
            bool condicion = int.TryParse(resp, out tresp);
            if (condicion)
            {

            }
            else
            {
                throw new ErrorDeTipeo("\nEl valor de ID ingresado no corresponde a un INT");
            }
        }

        public void validarRegistroNameType(string resp1, string resp2)
        {
            if ((resp1 == "Charmander") && (resp2 != "Fuego"))
            {
                throw new ErrorDeTipeo("\n" + resp1 + " No es de tipo " + resp2 + " Es de tipo Fuego");
            }
            else if ((resp1 == "Squirtle") && (resp2 != "Agua"))
            {
                throw new ErrorDeTipeo("\n" + resp1 + " No es de tipo " + resp2 + " Es de tipo Agua");
            }
            else if ((resp1 == "Bulbasaur") && (resp2 != "Planta"))
            {
                throw new ErrorDeTipeo("\n" + resp1 + " No es de tipo " + resp2 + " Es de tipo Planta");
            }
            else
            {

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
                validarRegistroNameType(nombre, tipo);
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
                        if (alias == pika.alias)
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

        public void register(string numero, string tipo, string alias, string peso, string altura)
        {
            try
            {
                validateName(numero);
                validarRegistroPeso(peso);
                validarRegistroAltura(altura);
                int fnumero = int.Parse(numero);
                float fpeso = float.Parse(peso);
                float faltura = float.Parse(altura);
                InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
                if (noVacio(InformatorioPokedex.Data.DatosPokemon.pokemons))
                {
                    int flag = 0;
                    foreach (InformatorioPokedex.Data.Pokemon pika in InformatorioPokedex.Data.DatosPokemon.pokemons)
                    {
                        if (alias == pika.alias)
                        {
                            Console.WriteLine("\nEste pokemón ya ha sido registrado");
                            flag = 1;
                        }
                    }
                    if (flag == 0)
                    {
                        metodo.registrarPokemon(numero, tipo, alias, fpeso, faltura);
                        Console.WriteLine("nuevoRegistro++");
                    }
                }
                else
                {
                    metodo.registrarPokemon(numero, tipo, alias, fpeso, faltura);
                    Console.WriteLine("registro++");
                }

            }
            catch (ErrorDeTipeo edt)
            {
                Console.WriteLine(edt.Message);
            }
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

        public void show()
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            if (noVacio(metodo.returnList()))
            {
                IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
            }
            else
            {
                Console.WriteLine("\nTodavia no has capturado ningun Pokemón");
            }
        }

        public void searchByName(string name)
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            metodo.returnList().Where<x =>
        }

        public void searchByAlias(string alias)
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
        }

        public void pokemonCount()
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
        }

        public void pokemonTypeCount(string type)
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
        }

        public void pokemonTallest()
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
        }

        public void pokemonSmaller()
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
        }

        public void pokemonFattest()
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
        }

        public void pokemonLightest()
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
        }

        public void averageHeight()
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
        }
        
        public void averageWeight()
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
        }

        public void averageHeightByType(string type)
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
        }

        public void averageWeightByType(string type)
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
        }

        public void orderByAlias()
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
        }


    }
}
