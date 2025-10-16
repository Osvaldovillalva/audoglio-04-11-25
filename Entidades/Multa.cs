using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Multa
    {
        public int MultaId { get; set; }
        public int SocioId { get; set; }
        public Socio Socio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
           
        
        public bool Pagada { get; set; }
    }
}
