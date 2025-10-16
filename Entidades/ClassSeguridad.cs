using System;

namespace Entidades
{
    public static class Seguridad
    {
        // Método para comparar la clave ingresada con la almacenada
        public static bool CompararClave(string claveIngresada, string claveAlmacenada)
        {
            // Comparar la clave ingresada con la clave almacenada
            return claveIngresada == claveAlmacenada;
        }
    }
}
