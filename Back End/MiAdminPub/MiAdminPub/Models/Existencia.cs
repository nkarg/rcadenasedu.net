using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiAdminPub.Models
{
    public class Existencia
    {
        public int ExistenciaId { get; set; }
        public int Cantidad { get; set; }
        public Articulo UnArticulo { get; set; }
    }
}