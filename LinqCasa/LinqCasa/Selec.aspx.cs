using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqCasa
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    //Version Clasica
                    var cat = db.Categories
                               .Select(c => new
                               {
                                   c.CategoryID,
                                   c.CategoryName
                               }).ToList();



                    ddl1.DataSource = cat;
                    ddl1.DataTextField = "CategoryName";
                    ddl1.DataValueField = "CategoryName";
                    DataBind();

                }
            }
        }

        protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = db.Products
                    .Where(p => p.CategoryID == Convert.ToInt32(ddl1.SelectedValue))
                    .Select(p => new
                    {
                        p.ProductID,
                        p.ProductName,
                        p.QuantityPerUnit,
                        p.UnitPrice,
                        p.UnitsInStock,
                        p.UnitsOnOrder
                    }).ToList();

                  

                gv1.DataSource = data;
                gv1.DataBind();
            }
                
        }
    }
}