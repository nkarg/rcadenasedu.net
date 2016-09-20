using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ProductoNoEncontradoException: Exception
    {
        public ProductoNoEncontradoException(string message):base(message)
        {

        }
    }
}
