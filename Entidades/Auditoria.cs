using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auditoria
    {
        public int AuditoriaId { get; set; } // Clave primaria

        // Nombre del bibliotecario o usuario que realizó la acción
        public string Usuario { get; set; }

        // Qué entidad se afectó: CuotaMensual, DetallePago, Sistema, etc.
        public string Entidad { get; set; }

        // Tipo de acción: Alta, Modificación, Eliminación, Login, Logout
        public string Accion { get; set; }

        // Momento exacto de la acción
        public DateTime FechaHora { get; set; }

        // Datos antes de la modificación (si aplica)
        public string ValorAnterior { get; set; }

        // Datos nuevos después de la acción (si aplica)
        public string ValorNuevo { get; set; }
    }
}
