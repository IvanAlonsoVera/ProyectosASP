using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicio_asp_javier
{
    public partial class WebForm21 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            /*string name = Request.Form["txtName"].ToString();
            int cat = Convert.ToInt32(Request.Form["ddlCategry"]);
            int supplier = Convert.ToInt32(Request.Form["ddlSupplires"]);
            string price = Request.Form["txtPrice"].ToString();*/
            
            string name = Request.QueryString["name"];
            nameTxt.Text = name;
            string cat = Request.QueryString["category"];
            categoryTxt.Text = cat;
            string supplier = Request.QueryString["supplier"];
            priceTxt.Text = supplier;
            string price = Request.QueryString["price"];
            categoryTxt.Text = price;


        }
    }
}