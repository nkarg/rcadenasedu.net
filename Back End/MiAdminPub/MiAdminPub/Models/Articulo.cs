using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiAdminPub.Models
{
    public class Articulo
    {
        public int ArticuloId { get; set; }
        public string Codigo { get; set; }
        public float PrecioLista { get; set; }
    }
}