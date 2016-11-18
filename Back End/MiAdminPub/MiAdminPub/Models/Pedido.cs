using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiAdminPub.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime FechaPedido { get; set; }
        public Persona Proveedor { get; set; }
        public List<Articulo> Articulos { get; set; }
        public float PrecioTotal { get; set; }
    }
}