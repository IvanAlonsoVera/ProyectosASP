using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqSelectToMany
{
    public partial class SelectToMany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var query = db.Products
                    .SelectMany(p => p.Order_Details)
                    .Where(p => p.Products.Suppliers.City == "Manchester")
                    .Select(p => new
                    {
                        p.Orders.Customers.CompanyName,
                        p.Orders.Employees.FirstName,
                        p.Orders.Freight
                    }).ToList();

                var query2 = db.Orders
                    .SelectMany(od => od.Order_Details)
                    .Where(od => od.Orders.Employees.City == "London")
                    .Select(od => new
                    {
                        od.Orders.Employees.LastName,
                        od.Products.ProductName,
                        od.UnitPrice,
                        od.Quantity,
                        od.Orders.OrderDate
                    }).ToList();

                var query3 = db.Orders
                    .SelectMany(od => od.Order_Details)
                    .Where(od => od.Products.UnitPrice > 10)
                    .Select(od => new
                    {
                        name = od.Products.ProductName,
                        categoria = od.Products.Categories.CategoryName,
                        date = od.Orders.OrderDate,
                        import = od.Quantity*od.UnitPrice
                    }).ToString();

                var query4 = db.Employees
                    .SelectMany(em => em.EmployeeTerritories)
                    .Where(em => em.Employees.City == "London")
                    .Select(em => new
                    {
                        Empleado = em.Employees.FirstName + " " + em.Employees.LastName,
                        Region_Trabaja = em.Territories.Region.RegionDescription,
                        Territorio = em.Territories.TerritoryDescription
                    }).ToList();

                var query5 = db.Orders
                    .SelectMany(od => od.Order_Details)
                    .Where(od => od.Orders.Employees.FirstName == "Michael" && od.Orders.Employees.LastName == "Suyama")
                    .Select(od => od.Quantity * od.UnitPrice).Average();

                var query6 = db.Employees
                    .SelectMany(em => em.Orders)
                    .OrderBy(em => em.OrderDate)
                    .ThenBy(em => em.Employees.LastName)
                    .Select(em => new
                    {
                        Empleado = em.Employees.FirstName + " " + em.Employees.LastName,
                        fPedido = Convert.ToDateTime(em.OrderDate).ToShortDateString()
                    }).ToList();

                var query7 = (from p in db.Products
                              group p by p.Categories into g
                              select new
                              {
                                  Category = g.Key,
                                  masCaro = g.Max(p => p.UnitPrice),
                                  MostExpensiveProduct = db.Products
                                  .FirstOrDefault(pr => pr.CategoryID == g.Key.CategoryID && pr.UnitPrice ==g.Max(p => p.UnitPrice)).ProductName
                              }).ToList();

                var query8 = (from p in db.Products
                             group p by p.Categories into g
                             select new
                             {
                                 Category = g.Key.CategoryName,
                                 AveragePrice = g.Average(p=>p.UnitPrice)
                             }).ToList();

                var query9 = db.Customers
                    .OrderByDescending(c => c.CustomerID)
                    .Select(c => new
                    {
                        Cuenta = c.Orders.Count(),
                        Cliente = c.CustomerID
                    }).ToList();

                gv1.DataSource= query8;
                gv1.DataBind();
            }
        }
    }
}