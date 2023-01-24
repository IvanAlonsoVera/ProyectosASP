using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqCasa
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //var data11 = (from em in db.Employees
                //              join o in db.Orders
                //              on em.EmployeeID equals o.EmployeeID
                //              join or in db.Order_Details
                //              on o.OrderID equals or.OrderID
                //              where em.FirstName == "Michael" && em.LastName == "Suyama"
                //              select or.Quantity * or.UnitPrice).Average();

                //var datosL = db.Employees
                //    .Where(em => em.LastName == "Suyama" && em.FirstName == "Michael")
                //    .Join(db.Orders, em => em.EmployeeID, or => or.EmployeeID, (em, or) => new { em, or })
                //    .Join(db.Order_Details, od => od.or.OrderID, c => c.OrderID, (od, c) => new { od, c })
                //    .Select(x => x.c.UnitPrice * x.c.Quantity).Average();

                //var paginacion = (from c in db.Customers
                //                 select c).Skip(30).Take(10).ToList();

                //var FirstOrDefault = (from c in db.Customers
                //            join o in (from t in db.Orders where t.OrderDate.Value.Year == 1998 && t.OrderDate.Value.Month == 5 select t)
                //            on c.CustomerID equals o.CustomerID
                //            select new 
                //            {
                //                Company = c.CompanyName,
                //                Country = c.Country,
                //                OrderDate= Convert.ToDateTime(o.OrderDate).ToShortDateString(),        
                //            }).FirstOrDefault(x=>x.Country == "USA");

                //var grupo = from p in db.Order_Details
                //            group p by p.ProductID into g
                //            select g;
                //foreach (var g in grupo)
                //{
                //    Response.Write("Producto nº :" + g.Key + "</br>");
                //    foreach (var x in g)
                //    {
                //        Response.Write("Pedido nº :" + x.OrderID +" Precio: "+ x.UnitPrice + "</br>");
                //    }
                //}

                //var agrupacion = from od in db.Order_Details
                //                 join p in db.Products on od.ProductID equals p.ProductID
                //                 group od by new
                //                 {
                //                     od.OrderID,
                //                     p.ProductName
                //                 } into grupo
                //                 orderby grupo.Key.ProductName descending
                //                 select grupo;
                //foreach(var grupo in agrupacion)
                //{
                //    Response.Write("Nombe del producto: " + grupo.Key.ProductName + "</br>");
                //    foreach(var x in grupo)
                //    {
                //        Response.Write("precio: " + x.UnitPrice + "</br>");
                //    }
                //}

                ////LAMBDA
                //var agrupacionL = db.Order_Details
                //    .Join(db.Products, od => od.ProductID, p => p.ProductID, (od, p) => new { od, p })
                //    .GroupBy(x => new { x.od.OrderID, x.p.ProductName })
                //    .Select(x => new { Producto = x.Key.ProductName, Pedido = x.Key.OrderID })
                //    .OrderByDescending(x => x.Producto);

                ////clasicaLamda
                //var query = (from p in db.Orders
                //             group p by p.CustomerID into g
                //             select new
                //             {
                //                 cliente = g.Key,
                //                 NPedidos = g.Count(),
                //                 Total_Freight = g.Sum(item => item.Freight),
                //                 Media_Freight = g.Average(item => item.Freight)
                //             }).ToList();

                //var orders = db.Customers.Where(c=>c.Country == "USA" && c.Region == "WA")
                //    .SelectMany(c => c.Orders);

                //var orders2 = db.Customers.Where(c => c.Country == "USA")
                //    .SelectMany(c => c.Orders, (c, o) => new
                //    {
                //        Nombre = c.ContactName,
                //        Freight = o.Freight,
                //        NPedidos = c.Orders.Count(),
                //        Proovedor = o.Shippers.CompanyName,
                //        Empleado = o.Employees.FirstName +" "+o.Employees.LastName
                //    }).OrderBy(c=>c.Empleado).OrderByDescending(c=>c.Nombre).ToList();

                //Alta, baja, modificacion de elementos. Insertar.

                //Employees employee = new Employees();
                ////employee.EmployeeID = 10;
                //employee.FirstName = "Javier";
                //employee.LastName = "Vazquez";
                //employee.City = "Madrid";
                //employee.Country = "Spain";

                //db.Employees.InsertOnSubmit(employee);
                //db.SubmitChanges();

                ////Actualizar
                //var empleado = db.Employees.SingleOrDefault(em => em.EmployeeID == 12);
                //if (empleado != null)
                //{
                //    empleado.City = "Zaragoza";
                //    db.SubmitChanges();
                //}

                //borrar
                //var empleado = db.Employees.SingleOrDefault(em => em.EmployeeID == 12);
                //if (empleado != null)
                //{
                //    db.Employees.DeleteOnSubmit(empleado);
                //    db.SubmitChanges();
                //}

                //gv1.DataSource = orders2;
                //gv1.DataBind();


            }

        }
    }
}