using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqCasa
{
    public partial class GVSumaUd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
               var categorias = (from c in db.Categories
                                select c).ToList();
               var categoriasL = db.Categories.Select(c=>c).ToList();
                gv1.DataSource = categorias;
                gv1.DataBind();
                
            }
        }
    }
}