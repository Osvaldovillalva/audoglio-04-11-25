using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Socio
    {
        [Key]
        public int SocioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
         public int Dni {  get; set; }
        public int CantidadLibros { get; set; }
        public DateTime? MultadoHasta { get; set; }
        public bool Habilitado { get; set; }
        public DateTime FechaIngreso { get; set; }
        // Otras propiedades de Socio

        public virtual ICollection<DetallePago> DetallePagos { get; set; }
    }
}
