using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLINQ_TO_SQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                using(DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var data = db.Categories
                        .Select(c => new
                        {
                            c.CategoryID,
                            c.CategoryName
                        }).ToList();

                    DropDownList1.DataSource = data;
                    DropDownList1.DataTextField = "CategoryName";
                    DropDownList1.DataValueField = "CategoryID";
                    DataBind();
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = db.Products
                    .Where(p => p.CategoryID == Convert.ToInt32(DropDownList1.SelectedValue))
                    .Select(p => new
                    {
                        p.ProductID,
                        p.ProductName,
                        p.QuantityPerUnit,
                        p.UnitPrice,
                        p.UnitsInStock,
                        p.UnitsOnOrder
                    }).ToList();

                GridView1.DataSource = data;
                GridView1.DataBind();
            }
        }
    }
}