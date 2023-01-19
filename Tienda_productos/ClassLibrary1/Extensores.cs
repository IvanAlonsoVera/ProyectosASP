using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Extensores
    {
        public static string ObtenerNombreCompleto(this Persona persona)
        {
            return persona.nombre + " " + persona.apellido;
        }
    }
}
