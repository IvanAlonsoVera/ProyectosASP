using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Extension
    {
        public static void Imprimir<T>(this list<T> lista)
            //falla por que no puedes devolver mil cosas

        {
            foreach (var item in lista)
                return item;
        }
    }
}
