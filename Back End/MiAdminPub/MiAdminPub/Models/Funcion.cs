using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiAdminPub.Models
{
    public class Funcion
    {
        public int FuncionId { get; set; }
        public Pub UnPub { get; set; }
        public Empleado UnEmpleado { get; set; }
        public string Nombre { get; set; }

    }
}