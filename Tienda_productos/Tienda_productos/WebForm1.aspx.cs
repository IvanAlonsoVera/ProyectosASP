using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda_productos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cmbClientes.DataValueField = "idCliente";
                cmbClientes.DataTextField = "NombreCompleto";
                cmbClientes.DataSource = Cliente.CrearListaClientes();
                cmbClientes.DataBind();

                cmbProductos.DataValueField = "idProducto";
                cmbProductos.DataTextField = "nombreProducto";
                cmbProductos.DataSource = Producto.CrearListaProductos();
                cmbProductos.DataBind();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            bool iva = false;
            iva = rdbIVA.SelectedItem.Value == "SI";
            Pedido factura = new Pedido();
            factura = Pedido.CrearFactura(
                Convert.ToInt32(hdnIdCliente.Value),
                hdnNombreCliente.Value,
                Convert.ToInt32(hdnIdProducto.Value),
                hdnNombreProducto.Value,
                Convert.ToInt32(txtCantidad.Text),
                Convert.ToDecimal(txtPrecio.Text),
                iva);

            Response.Redirect("WebForm2.aspx?cliente=" + factura.NombreCliente
                + "&producto=" + factura.NombreProducto
                + "&cantidad=" + factura.Cantidad
                + "&precio=" + factura.PrecioProducto
                + "&total=" + factura.ImporteFactura);

        }

        protected void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            hdnIdCliente.Value = cmbClientes.SelectedItem.Value;
            hdnNombreCliente.Value = cmbClientes.SelectedItem.Text;
        }

        protected void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            hdnIdProducto.Value = cmbProductos.SelectedItem.Value;
            hdnNombreProducto.Value = cmbProductos.SelectedItem.Text;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}