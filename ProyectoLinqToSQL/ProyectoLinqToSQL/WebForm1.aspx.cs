using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLinqToSQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = (from c in db.Customers
                           where c.Country == "Spain"
                           select c).ToList();

                var data1 = (from c in db.Customers
                            where c.Country == "Spain"
                            select new
                            {
                                Cia = c.CompanyName,
                                Contacto = c.ContactName
                            }).ToList();

                var dataL = db.Customers.Where(c => c.Country == "Spain").ToList();
                var dataLCompany = db.Customers.Where(c => c.Country == "Spain").OrderBy(c=>c.CompanyName).ToList();
                var dat1L = db.Customers.Where(c => c.Country == "Spain")
                    .Select(c => new {
                        Cia = c.CompanyName, 
                        Contacto = c.ContactName
                    })
                    .OrderBy(c=>c.Cia).ToList();

                var dataEj = (from c in db.Customers
                              where c.City == "Sao Paulo"
                              select new { clientes = c.CompanyName }).ToList();
                var dataEjL = db.Customers.Where(c => c.City == "Sao Paulo").Select (c => new { clientes = c.CompanyName }).ToList();

                var name = (from em in db.Employees
                            where em.City == "London"
                            orderby em.BirthDate
                            select new
                            {
                                Nombre_Apellidos = em.FirstName + " " + em.LastName,
                                Fecha_Nac = Convert.ToDateTime(em.BirthDate).ToShortTimeString()
                            }).ToList();

                var nameL = db.Employees
                    .Where(em => em.City == "London")
                    .OrderBy(em => em.BirthDate)
                    .Select(em => new
                    {
                        Nombre_Apellidos = em.FirstName + " " + em.LastName,
                        Fecha_Nac = Convert.ToDateTime(em.BirthDate).ToShortTimeString()
                    }).ToList();

                var product = (from p in db.Products
                               where p.UnitPrice < 50
                               select new
                               {
                                   NameProduct = p.ProductName,
                                   UdStock = p.UnitsInStock
                               }).ToList();

                var productL = db.Products.Where(p => p.UnitPrice < 50).Select(p =>new
                {
                    NameProduct = p.ProductName,
                    UdStock = p.UnitsInStock
                }).ToList();

                var data5 = (from c in db.Customers
                             where c.Country == "Spain"
                             orderby c.CompanyName
                             select new
                             {
                                 c.CustomerID,
                                 c.CompanyName,
                                 c.Country,
                                 Pedidos_Realizados = c.Orders.Count
                             }).ToList();

                var dataMany = (from c in db.Customers
                                where c.Country == "Spain"
                                select new { c.Orders }).ToList();

                var dataMany2 = (from c in db.Customers
                             where c.Country == "Spain"
                             select c).SelectMany(c=>c.Orders).ToList();

                var dataJoin = (from c in db.Customers
                                join o in db.Orders
                                on c.CustomerID equals o.CustomerID
                                select new
                                {
                                    c.ContactName,
                                    o.OrderDate
                                }).ToList();

                var dataAgregacion = (from od in db.Order_Details
                                     where od.OrderID == 10250
                                     select od.Quantity * od.UnitPrice).Sum();

                var data10 = (from o in db.Orders
                             join em in db.Employees
                             on o.EmployeeID equals em.EmployeeID
                             select new
                             {
                                 fe_Nom = o.OrderDate + "(" + em.FirstName + " " + em.LastName + ")",

                             }).ToList();

                var data10L = db.Orders
                      .Join(db.Employees, or => or.EmployeeID, emp => emp.EmployeeID, (or, emp) => new
                      {
                          Fecha = Convert.ToDateTime(or.OrderDate).ToShortDateString(),
                          Nombre = "(" + emp.FirstName + " " + emp.LastName + ")"
                      }).Where(emp => emp.Nombre == "(Steven Buchanan)").ToList();

                gv1.DataSource = data10;
                gv1.DataBind();
            }
        }
    }
}