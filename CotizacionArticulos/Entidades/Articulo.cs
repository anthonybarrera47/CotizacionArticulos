using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionArticulos.Entidades
{
    public class Articulo
    {
        [Key]
        public int ArticuloId { get; set; }
        public DateTime FechaVencimiento{ get; set; }
        public String Descripcion { get; set; }
        public float Precio { get; set; }
        public float Existencia { get; set; }
        public float CantidadCotizada { get; set; }

        public Articulo()
        {
            ArticuloId = 0;
            FechaVencimiento = DateTime.Now;
            Descripcion = string.Empty;
            Precio = 0.0f;
            Existencia = 0.0f;
            CantidadCotizada = 0.0f;
        }
    }
}
