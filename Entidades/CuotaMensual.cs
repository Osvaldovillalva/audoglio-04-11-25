using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuotaMensual
    {
        public int CuotaMensualId { get; set; } // Identificador único de la cuota
        public int Año { get; set; }
        public int NumeroMes { get; set; }
        
        public string Mes { get; set; }  // Número de mes
        public decimal? Valor { get; set; }
        public virtual ICollection<DetallePago> DetallePagos { get; set; }
    }
}
