using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Devolucion
    {
        public int DevolucionId { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int PrestamoId { get; set; }
        public Prestamo Prestamo { get; set; }
    }



}
