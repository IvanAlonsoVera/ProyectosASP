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
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //Version Clasica
                var cat = (from c in db.Categories
                           select c.CategoryName).ToList();
                foreach (var catItem in cat)
                {
                    ddl1.Items.Add(catItem);
                }
                //Version LAMBDA
                var catL = db.Categories.Select(c=>c.CategoryName).ToList();

            }
        }

        protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //Version Clasica
                var catSelect = (from p in db.Products
                                 join c in db.Categories
                                 on p.CategoryID equals c.CategoryID
                                 where c.CategoryName == ddl1.SelectedValue
                                 select new 
                                 { 
                                   Nombre_Productos_Cat_Selected = p.ProductName
                                 }).ToList();
                //Version LAMBDA
                //var catSelectL = db.Products.Join(db.Categories, p=>p.CategoryID, c=>c.CategoryID, (p, c) => new {p,c})
                //    .Where(c=>c.CategoryName == ddl1.SelectedValue
                  

                gv1.DataSource = catSelect;
                gv1.DataBind();
            }
                
        }
    }
}