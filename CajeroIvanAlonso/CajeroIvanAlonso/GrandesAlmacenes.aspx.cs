using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CajeroIvanAlonso
{
    public partial class GrandesAlmacenes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var dataCajeros = db.Cajeros
                        .Select(c => new
                        {
                            c.Codigo,
                            c.NombreApellidos
                        }).ToList();

                    ddlCajero.DataSource = dataCajeros;
                    ddlCajero.DataTextField = "NombreApellidos";
                    ddlCajero.DataValueField = "Codigo";
                    ddlCajero.DataBind();

                    var DataPlanta = db.Maquinas_Registradoras
                        .Select(c => new
                        {
                            c.Codigo,
                            c.Piso
                        }).ToList();

                    ddlPlanta.DataSource = DataPlanta;
                    ddlPlanta.DataTextField = "Piso";
                    ddlPlanta.DataValueField = "Codigo";
                    ddlPlanta.DataBind();

                    var DataPro = db.Productos
                        .Select(c => new
                        {
                            c.Codigo,
                            c.Nombre
                        }).ToList();

                    ddlProducto.DataSource = DataPro;
                    ddlProducto.DataTextField = "Nombre";
                    ddlProducto.DataValueField = "Codigo";
                    ddlProducto.DataBind();
                }
            }
            
        }

        protected void btnVenta_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                int _cajero = ddlCajero.SelectedIndex;
                int _planta = ddlPlanta.SelectedIndex;
                int _producto = ddlProducto.SelectedIndex;
                int _cantidad = Convert.ToInt32(tbCantidad.Text);
                if(!(_cajero==0 || _planta==0 || _producto==0 || _cantidad == 0))
                {
                    var newVenta = new Venta()
                    {
                        Cajero = _cajero,
                        Maquina = _planta,
                        Producto = _producto,
                        Cantidad = _cantidad
                    };
                    db.Venta.InsertOnSubmit(newVenta);
                    db.SubmitChanges();

                    int idCajero = ddlCajero.SelectedIndex;

                    var DataCajero = db.Cajeros
                    .SelectMany(x => x.Venta)
                    .Where(x => x.Cajeros.Codigo == idCajero)
                    .Select(x => new
                    {
                        IdVenta = x.Codigo,
                        Producto = x.Productos.Nombre,
                        Precio = x.Productos.Precio,
                        Cantidad = x.Cantidad,
                        Total = x.Cantidad * x.Productos.Precio
                    }).ToList();


                    gv1.DataSource = DataCajero;
                    gv1.DataBind();

                }
                else
                {
                    Response.Write("Falta algun dato");
                }
            }
            
        }

        protected void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        protected void ddlCajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                int idCajero = ddlCajero.SelectedIndex;

                var DataCajero = db.Cajeros
                    .SelectMany(x => x.Venta)
                    .Where(x => x.Cajeros.Codigo == idCajero)
                    .Select(x => new
                    {
                        IdVenta = x.Codigo,
                        Producto = x.Productos.Nombre,
                        Precio = x.Productos.Precio,
                        Cantidad = x.Cantidad,
                        Total = x.Cantidad * x.Productos.Precio
                    }).ToList();

                
                gv1.DataSource = DataCajero;
                gv1.DataBind();
            }
                
        }
    }
}