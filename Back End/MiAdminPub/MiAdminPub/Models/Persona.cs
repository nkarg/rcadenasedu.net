using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiAdminPub.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Domicilio { get; set; }
    }
}