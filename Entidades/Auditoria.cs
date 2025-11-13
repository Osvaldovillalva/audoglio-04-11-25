using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auditoria
    {
        public int AuditoriaId { get; set; }   // Clave primaria
        public string Usuario { get; set; }    // Quién hizo la acción
        public string Accion { get; set; }     // "Login", "Logout", "PagoCuota"
        public string Detalle { get; set; }    // Detalle opcional, ej: "Pago cuota mes Enero"
        public DateTime FechaHora { get; set; } // Momento de la acción
    }
}
