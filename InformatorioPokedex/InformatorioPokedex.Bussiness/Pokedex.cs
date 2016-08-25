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
        
        //public void validarRegistroPeso(float resp)
        //{
        //    float x = 1;
        //    if (Object.ReferenceEquals(resp.GetType(),x.GetType()))
        //    {

        //    }
        //    else
        //    {
        //        throw new ErrorDeTipeo("Debes ingresar bien un numero Real");
        //    }
        //}
        //public void validarRegistroAltura(float resp)
        //{
        //    float x = 1;
        //    if (Object.ReferenceEquals(resp.GetType(), x.GetType()))
        //    {

        //    }
        //    else
        //    {
        //        throw new ErrorDeTipeo("Debes ingresar bien un numero Real");
        //    }
        //}

        public void registrar(string tipo, string alias, float peso, float altura)
        {
            try
            {
                validarRegistroTipo(tipo);
                //validarRegistroPeso(peso);
                //validarRegistroAltura(altura);

            }
            catch (ErrorDeTipeo edt)
            {
                Console.WriteLine(edt.Message);
            }
        }

        public void valdidarMuestra()
        {

        }
        public void mostrar() { }
    }
}
