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

        public string productoImg = "http://icon-icons.com/icons2/37/PNG/512/productapplication_producto_3010.png";
        public string precioImg = "http://www.freeiconspng.com/uploads/money-icon-15.png";
    }
}