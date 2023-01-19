using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PreviousPage
{
    public partial class SegundaPaginaAsociada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string valor = Request.Form["ctl00$contenido$TextBox1"];
            TextBox1.Text = valor;
        }
    }
}