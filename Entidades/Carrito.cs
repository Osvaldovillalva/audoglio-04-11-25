using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrito
    {
        public int CarritoId { get; set; }

        public int? PrestamoId { get; set; }
        public Socio SocioSeleccionado { get; set; }

        public List<Libro> LibrosSeleccionados { get; set; } = new List<Libro> ();
        public DateTime FechaPrestamo { get; set; }
    public DateTime FechaDevolucion { get; set; }
}
}
