using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqCasa
{
    public partial class Fucionalidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var RegioWa = (from o in db.Orders
                               join c in db.Customers
                               on o.CustomerID equals c.CustomerID
                               where c.Region == "WA"
                               select new
                               {
                                   Fecha_Pedido = Convert.ToDateTime(o.OrderDate).ToShortDateString(),
                                   OrderID = o.OrderID
                               }).ToList();

                //gv1.DataSource = RegioWa;
                //gv1.DataBind();

                var ListaClientes = (from c in db.Customers
                                    select new
                                    {
                                        ID_Cliente = c.CustomerID,
                                        Nº_Pedidos = c.Orders.Count()
                                    }).ToList();

                var listadoClientesL = db.Customers
                        .Select(c => new
                        {
                            Id_Cliente = c.CustomerID,
                            N_pedidos = c.Orders.Count()
                        }).ToList();

                //gv1.DataSource = ListaClientes;
                //gv1.DataBind();

                var Listado1998 = (from o in db.Orders
                                   join c in db.Customers
                                   on o.CustomerID equals c.CustomerID
                                   where o.OrderDate >= Convert.ToDateTime("01/01/1998 0:00:00")
                                   select new
                                   {
                                       CustomerID = c.CustomerID,
                                       OrderID = o.OrderID,
                                       FechaPedido = Convert.ToDateTime(o.OrderDate).ToShortDateString()
                                   }).ToList();

                //gv1.DataSource = Listado1998;
                //gv1.DataBind();

                var listadoPedidosWashingtonOrd = from p in db.Products
                                                  join c in db.Categories
                                                  on p.CategoryID equals c.CategoryID
                                                  orderby p.ProductName descending
                                                  select p;

                //gv1.DataSource = listadoPedidosWashingtonOrd;
                //gv1.DataBind();

                var productoCaro = (from p in db.Products
                                    group p by p.CategoryID into g
                                    select new
                                    {
                                        CategoriaID = g.Key,
                                        Precio_Max = g.Max(item => item.UnitPrice)
                                    }).ToList();

                //var productoCaroL = db.Order_Details
                //    .Join(db.Products, o => o.ProductID, p => p.ProductID, (o, p) => new { o, p })
                //    .Select(p=>p.ProductName)
                //    .OrderBy(o => o.UnitPrice).First();

                gv1.DataSource = productoCaro;
                gv1.DataBind();

                var mediaPrecios = (from p in db.Products
                             group p by p.CategoryID
                             into grupo
                             select new
                             {
                                 CategoriaID = grupo.Key,
                                 Media = grupo.Average(x => x.UnitPrice)
                             }).ToList();

                //gv1.DataSource = mediaPrecios;
                //gv1.DataBind();


            }
        }
    }
}