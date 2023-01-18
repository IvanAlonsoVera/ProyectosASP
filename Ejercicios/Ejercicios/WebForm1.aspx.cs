using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicio_asp_javier
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)PreviousPage.FindControl("TextBox1");
            string valor = txt.Text;
        }

        protected void ddlCategory_SelectedIndexchanged(object sender, EventArgs e)
        {
            hdncategory.Value = ddlCategry.SelectedValue;
        }

        protected void ddlSupplier_SelectedIndexchanged(object sender, EventArgs e)
        {
            hdncategory.Value = ddlCategry.SelectedValue;
        }

        protected void btnSalvar_click(object sender, EventArgs e)
        {
            // string name = Request.Form["txtName"].ToString();
            //   int cat = int.Parse()

            //Server.Transfer("WebForm2.aspx");
            string[] datos =
            {
                txtName.Text,
                ddlCategry.ToString(),
                ddlSupplires.ToString(),
                txtPrice.Text
            };


            Response.Redirect("WebForm2.aspx?name="+txtName.Text+"&category"+ddlCategry.SelectedValue+"&supplier="+ddlSupplires.SelectedValue+"&price"+txtPrice.Text);


        }
    }
}