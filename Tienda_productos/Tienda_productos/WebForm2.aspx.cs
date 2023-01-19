using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda_productos
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cliente = Request.QueryString["cliente"];
            string producto = Request.QueryString["producto"];
            int cantidad = int.Parse(Request.QueryString["cantidad"]);
            decimal precio = decimal.Parse(Request.QueryString["precio"]);
            decimal total = decimal.Parse(Request.QueryString["total"]);

            txtCliente.Text = cliente;
            txtProducto.Text = producto;
            txtCantidad.Text = cantidad.ToString();
            txtPrecio.Text = precio.ToString();
            txtTotal.Text = total.ToString();

            txtFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}