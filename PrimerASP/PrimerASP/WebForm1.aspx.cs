using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Convertir(object sender, EventArgs e)
            {
                string cadena = txtCaja.Value;
                spnRes.InnerHtml = cadena.ToUpper();
            }
    }
}