using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioPokedex.Bussiness
{
    class ErrorDeTipeo: Exception
    {
        public ErrorDeTipeo(string message):base(message)
        {

        }
    }

}
