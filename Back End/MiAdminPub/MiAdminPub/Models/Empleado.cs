using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiAdminPub.Models
{
    public class Empleado: Persona
    {
        public List<Funcion> Funciones { get; set; }
    }
}