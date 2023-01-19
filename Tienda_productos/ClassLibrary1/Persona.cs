using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Persona
    {
        public string nombre { get; set; };
        public string apellido { get; set; }
        public Persona(string nombre, string apellido)
        {
            nombre = nombre;
            apellido = apellido;
        }
    }
}
