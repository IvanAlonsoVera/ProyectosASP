using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionConsola
{
    public static class Extension
    {
        public static void Imprimir<T>(this List<T> lista)
        {
            foreach (var item in lista)
                Console.Write("{0}", item);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>();
            lista1.Add(10);
            lista1.Add(11);
            lista1.Add(12);
            lista1.Add(13);
            lista1.Imprimir();
            Console.ReadKey();
        }
    }
}
