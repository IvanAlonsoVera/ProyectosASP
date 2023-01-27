using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CajeroIvanAlonso
{
    public partial class Imprimir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Request.Form["hdnID"]);
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var DataCajero = db.Cajeros
                    .SelectMany(x => x.Venta)
                    .Where(x => x.Cajeros.Codigo == Id)
                    .Select(x => new
                    {
                        IdVenta = x.Codigo,
                        Producto = x.Productos.Nombre,
                        Precio = x.Productos.Precio,
                        Cantidad = x.Cantidad,
                        Total = x.Cantidad * x.Productos.Precio
                    }).ToList();

                var facturacion = db.Venta
                     .Where(vt => vt.Cajero == Id)
                     .Select(vt => vt).Sum(vt => vt.Cantidad * vt.Productos.Precio);

                tbEmpleado.Text = db.Cajeros.Where(c => c.Codigo == Id).Select(c => c.NombreApellidos).First();
                tbFacturacion.Text = Convert.ToString(facturacion);
                gvImprimir.DataSource = DataCajero;
                gvImprimir.DataBind();
            }
        }
    }
}