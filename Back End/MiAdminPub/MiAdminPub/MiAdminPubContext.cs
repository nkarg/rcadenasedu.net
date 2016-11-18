using MiAdminPub.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MiAdminPub
{
    public class MiAdminPubContext: DbContext 
    {
        public MiAdminPubContext(): base() { }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Existencia> Existencias { get; set; }
        public DbSet<Funcion> Funciones { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Pub> Pubs { get; set; }
        public DbSet<Recaudacion> Recaudaciones { get; set; }
        public DbSet<Titular> Titulares { get; set; }
    }
}