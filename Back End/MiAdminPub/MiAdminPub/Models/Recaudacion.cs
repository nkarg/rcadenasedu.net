using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiAdminPub.Models
{
    public class Recaudacion
    {
        public int RecaudacionId { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
    }
}