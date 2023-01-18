using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicios
{
    public partial class Ejercicio_Final_Validaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int valor = Convert.ToInt32(Request.QueryString["valor"]);
            //string valor2 = Request.QueryString["valor2"];
            string valor = Request.Form["txtNombre"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                txtUsuario.Text = "";
                txtEdad.Text = "";
                txtpass.Text = "";
                txtpass2.Text = "";
            }
        }
    }
}