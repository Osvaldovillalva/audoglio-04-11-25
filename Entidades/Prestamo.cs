using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    

        public class Prestamo
        {
            public int PrestamoId { get; set; }
            public DateTime FechaPrestamo { get; set; }
            public DateTime FechaDevolucion { get; set; }   
            public int LibroId { get; set; }
            public Libro Libro { get; set; }
            public int SocioId { get; set; }
            public Socio Socio { get; set; }
            public int CarritoId { get; set; }
            public bool EnPrestamo { get; set; }    


        }


    
}
