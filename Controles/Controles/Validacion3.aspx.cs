using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controles
{
    public partial class Validacion3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lbOutput.Text = "Page is valid";
            }
            else
            {
                lbOutput.Text = "Page is NOT valid";
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int valor = int.Parse(TextBox1.Text);
            for (int i = 2; i < 6; i++)
            {
                valor += 2;
                TextBox objTxt = (TextBox)Page.FindControl("TextBox" + Convert.ToString(i));
                if (Convert.ToInt32(objTxt.Text) != valor)
                {
                    args.IsValid = false;
                    return;
                }
            }
            args.IsValid = true;
        }
    }
}