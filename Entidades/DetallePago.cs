using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallePago
    {
        [Key]
        public int DetallePagoId {  get; set; }
        public int SocioId { get; set; }
        public int CuotaMensualId { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoCobrado { get; set; }

        public virtual Socio Socio { get; set; }
        public virtual CuotaMensual CuotaMensual { get; set; }



    }


}
