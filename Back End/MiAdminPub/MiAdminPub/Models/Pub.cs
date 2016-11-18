using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiAdminPub.Models
{
    public class Pub
    {
        public int PubId { get; set; }
        public string Nombre { get; set; }
        public string LicenciaFiscal { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime Horario { get; set; }
        public string DiasApertura { get; set; }

        public List<Funcion> Puestos { get; set; }
        public List<Existencia> Existencias { get; set; }
        public List<Recaudacion> Recaudaciones { get; set; }

    }
}