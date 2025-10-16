using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Regla
    {

        public int ReglaId { get; set; }    
        // Propiedad para almacenar la cantidad de días permitidos para prestar un libro
        public int DiasPrestamo { get; set; }

        // Propiedad para almacenar la cantidad máxima de libros que puede llevar un usuario
        public int MaxLibrosPorUsuario { get; set; }

        public int DiasMulta { get; set; }
        // Constructor para inicializar las propiedades

        public int DiasVencimientoCuota { get; set; }

        // Propiedad para almacenar el porcentaje de recargo por mora
        public int PorcentajeRecargoCuota { get; set; }

    }

}
