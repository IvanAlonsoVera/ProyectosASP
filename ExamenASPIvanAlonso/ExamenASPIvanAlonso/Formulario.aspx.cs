using ExamenASPIvanAlonso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenASPIvanAlonso
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Services.WebMethod]
        public static List<Categoria> Llenar_ddlCategorias()
        {
            using (var db = new NORTHWNDEntities1())
            {
                var query = db.Categories
                    .Select(c => new Categoria
                    {
                        CategoriaID = c.CategoryID,
                        NombreCategoria = c.CategoryName
                    }).ToList();
                return query;
            }
        }
        [System.Web.Services.WebMethod]
        public static List<Producto> Llenar_ddlProductos(int CategoriaId)
        {
            using (var db = new NORTHWNDEntities1())
            {
                var query = db.Products
                    .Where(p=>p.CategoryID == CategoriaId)
                    .Select(p => new Producto
                    {
                        Id = p.ProductID,
                        NombreProducto = p.ProductName
                    }).ToList();
                return query;
            }
        }
        [System.Web.Services.WebMethod]
        public static Producto Devolver_Stock(int Id)
        {
            using (var db = new NORTHWNDEntities1())
            {
                var query = db.Products
                    .Where(p => p.ProductID == Id)
                    .Select(p => new Producto { UnidadesStock = (int)p.UnitsInStock }).FirstOrDefault();
                return query;
            }
        }
        [System.Web.Services.WebMethod]
        public static decimal Calcular_Media(int Id)
        {
            using (var db = new NORTHWNDEntities1())
            {
                var media = db.Order_Details
                    .Where(o => o.ProductID == Id)
                    .Average(o => o.UnitPrice * o.Quantity);

                return media;
            }
        }

    }
}