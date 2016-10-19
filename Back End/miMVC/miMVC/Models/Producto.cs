using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace miMVC.Models
{
    public class Producto
    {
        public int productoID { get; set; }
        ///[Required(AllowEmptyStrings = true)]
        public string nombreProducto { get; set; }
        [Required]
        public int precioProducto { get; set; }
        [Required]
        public DateTime fechaDeVencimiento { get; set; }
    }
}