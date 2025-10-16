using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClassLibrosParaComprar
    {
        public int Id { get; set; }  // Id del libro en la base de datos
        public string TextoCompleto { get; set; }  // El texto completo (título + autor)
        public int Contador { get; set; }  

    }
}
