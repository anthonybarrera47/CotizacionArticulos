using CotizacionArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionArticulos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulo> articulo { get; set; }

        public Contexto() : base("ConStr")
        {   }
    }
}
