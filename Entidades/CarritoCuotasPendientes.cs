using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CarritoCuotasPendientes
    {
        public int CarritoCuotasPendientesId { get; set; }
        public int SocioId { get; set; } // ID del socio al que pertenece el carrito
        public virtual Socio Socio { get; set; }
        public virtual ICollection<CuotaMensual> CuotasSeleccionadas { get; set; }
        public Socio SocioSeleccionado { get; set; }
    }
}
