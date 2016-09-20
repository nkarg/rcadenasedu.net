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

        public void validateName(string resp)
        {
            int tresp;
            bool condicion = int.TryParse(resp, out tresp);
            if (condicion)
            {
                
            }

            else if (true)
            {

            }
            else
            {
                throw new ErrorDeTipeo("\nEl valor de ID ingresado no corresponde a un Pokemon");
            }
        }

        public void validarType(string resp)
        {

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


            }
            catch (ErrorDeTipeo edt)
            {
                Console.WriteLine(edt.Message);
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
            IList<InformatorioPokedex.Data.Pokemon> pika = metodo.returnList();
            pika.Count(x => x.tipo == "Edu");
            pika.Contains(x => x.tipo == "Edu");
        }

        public void searchByAlias(string alias)
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            IList<InformatorioPokedex.Data.Pokemon> miLista = metodo.returnList();
        }

        public void pokemonCount()
        {
            InformatorioPokedex.Data.ManejoDeDatos metodo = new InformatorioPokedex.Data.ManejoDeDatos();
            Console.WriteLine(metodo.returnList().Count());
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
