using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenASPIvanAlonso.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public int UnidadesStock { get; set; }
        public string NombreProducto { get; set; }
        public int CategoriaId { get; set; } 

    }
}