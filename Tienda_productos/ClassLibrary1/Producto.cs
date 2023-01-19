using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public static List<Producto> CrearListaProductos()
        {
            List<Producto> listaProductos = new List<Producto>();

            Producto c1 = new Producto();
            c1.idProducto = 1;
            c1.nombreProducto = "Frigorifico";
            listaProductos.Add(c1);

            Producto c2 = new Producto();
            c2.idProducto = 2;
            c2.nombreProducto = "Lavadora";
            listaProductos.Add(c2);

            Producto c3 = new Producto();
            c3.idProducto = 3;
            c3.nombreProducto = "Microhondas";
            listaProductos.Add(c3);

            Producto vacio = new Producto();
            vacio.idProducto = 0;
            vacio.nombreProducto = "-Elegir Producto-";
            listaProductos.Insert(0, vacio);

            return listaProductos;
        }
    }
}
