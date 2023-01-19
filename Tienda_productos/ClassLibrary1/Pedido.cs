using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pedido
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioProducto { get; set; }
        public bool Iva { get; set; }
        public decimal ImporteFactura { get; set; }
        
        public static Pedido CrearFactura(int idCliente, string nombreCliente, 
            int idProducto, string nombreProducto, int cantidad, decimal precio, bool iva)
        {
            Pedido pedido = new Pedido();
            pedido.IdCliente = idCliente;
            pedido.NombreCliente = nombreCliente;
            pedido.IdProducto = idProducto;
            pedido.NombreProducto = nombreProducto;
            pedido.PrecioProducto = precio;
            pedido.Cantidad = cantidad;
            pedido.Iva = iva;

            pedido.ImporteFactura= iva ? (cantidad*precio) * 1.15m : (cantidad*precio);

            return pedido;


        }
    }
}
