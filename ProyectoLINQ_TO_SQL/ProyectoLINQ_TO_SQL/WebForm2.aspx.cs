using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLINQ_TO_SQL
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = db.Categories
                    .OrderBy(c => c.CategoryID)
                    .Select(c => new
                    {
                        c.CategoryID,
                        c.CategoryName,
                        c.Description
                    }).ToList();

                GridView1.DataSource = data;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GridViewRow row = GridView1.SelectedRow;
            //string codigo = row.Cells[0].Text;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow fila = GridView1.Rows[index];
                TableCell categoria = fila.Cells[1];
                int id = Int16.Parse(categoria.Text);
                MostrarCaja(id);
            }
        }

        private void MostrarCaja(int id)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = db.Products
                    .Where(p => p.CategoryID == id)
                    .Select(p => p.UnitPrice).Sum(p => p.Value);

                TextBox1.Text = data.ToString();
            }
        }
    }
}