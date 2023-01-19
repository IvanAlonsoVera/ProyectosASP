using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTienda
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}", Apellido,Nombre);
        }
        public static List<Cliente> CrearListaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            Cliente c1 = new Cliente();
            c1.idCliente = 1;
            c1.Nombre = "Juan";
            c1.Apellido = "Rodriguez";
            c1.NombreCompleto = c1.ToString();
            clientes.Add(c1);

            Cliente c2 = new Cliente();
            c2.idCliente = 2;
            c2.Nombre = "José";
            c2.Apellido = "Escribano";
            c2.NombreCompleto = c2.ToString();
            clientes.Add(c2);

            Cliente c3 = new Cliente();
            c3.idCliente = 3;
            c3.Nombre = "María";
            c3.Apellido = "Guzmán";
            c3.NombreCompleto = c3.ToString();
            clientes.Add(c3);

            return clientes;
        }
    }
}
