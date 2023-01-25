using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqSelectToMany
{
    public partial class Grids : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["dirtState"] = "Asc";
            }
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var query = db.Customers
                    .Select(c => new
                    {
                        c.CustomerID,
                        c.CompanyName,
                        c.ContactName,
                        c.City
                    }).ToList();

                GridView1.DataSource = query;
                GridView1.DataBind();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            DataBind();
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                switch (e.SortExpression)
                {
                    case "CompanyName":
                        {
                            if (Convert.ToString(ViewState["dirState"]) == "Asc")
                            {
                                GridView1.DataSource = db.Customers
                                    .OrderBy(c => c.CompanyName).ToList();
                                GridView1.DataBind();
                                ViewState["dirState"] = "Desc";
                            }
                            else
                            {
                                GridView1.DataSource = db.Customers
                                   .OrderByDescending(c => c.CompanyName).ToList();
                                GridView1.DataBind();
                                ViewState["dirState"] = "Asc";
                            }
                            break;
                        }
                    case "CustomerID":
                        {
                            if (Convert.ToString(ViewState["dirState"]) == "Asc")
                            {
                                GridView1.DataSource = db.Customers
                                    .OrderBy(c => c.CustomerID).ToList();
                                GridView1.DataBind();
                                ViewState["dirState"] = "Desc";
                            }
                            else
                            {
                                GridView1.DataSource = db.Customers
                                   .OrderByDescending(c => c.CustomerID).ToList();
                                GridView1.DataBind();
                                ViewState["dirState"] = "Asc";
                            }
                            break;
                        }

                }
            }
            
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow fila = GridView1.Rows[index];
                TableCell company = fila.Cells[1];
                string nombreCompany = company.Text;

                Response.Write(nombreCompany);
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex=e.NewEditIndex;
            DataBind();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var query = db.Customers
                    .Where(c=>c.CompanyName.Contains(txtCliente.Text))
                    .OrderBy(c=>c.CompanyName)
                    .Select(c => new
                    {
                        c.CustomerID,
                        c.CompanyName,
                        c.ContactName,
                        c.City
                    }).ToList();
                GridView1.DataSource=query;
                DataBind();
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();

            TextBox CompanyName = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_CompanyName");

            using(DataClasses2DataContext db = new DataClasses2DataContext())
            {
                Customers customer = db.Customers
                    .Where(c => c.CustomerID == id)
                    .Select(c => c).First();

                customer.CompanyName=CompanyName.Text;
                db.SubmitChanges();

                GridView1.EditIndex = -1;

                var query = db.Customers
                    .Where(c => c.CompanyName.Contains(txtCliente.Text))
                    .OrderBy(c => c.CompanyName)
                    .Select(c => new
                    {
                        c.CustomerID,
                        c.CompanyName,
                        c.ContactName,
                        c.City
                    }).ToList();
                GridView1.DataSource = query;
                DataBind();
            }
        }
    }
}