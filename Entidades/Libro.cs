using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {

        [Key]
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public string Ubicacion { get; set; }


        
        public bool Disponible { get; set; }



       

    }
}

