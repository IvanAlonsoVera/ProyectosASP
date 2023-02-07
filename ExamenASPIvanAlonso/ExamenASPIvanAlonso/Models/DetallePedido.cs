using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenASPIvanAlonso.Models
{
    public class DetallePedido
    {
        public int ProductoId { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public short Cantidad { get; set; }
        public float Descuento { get; set; }
    }
}