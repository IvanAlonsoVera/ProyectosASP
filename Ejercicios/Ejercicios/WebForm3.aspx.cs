using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicios
{
    public partial class WebForm3 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (Radio1.SelectedIndex > -1)
            {
                LblSeleccionado.Text = "Has seleccionado " + Radio1.SelectedItem.Text;
            }
        }
    }
}