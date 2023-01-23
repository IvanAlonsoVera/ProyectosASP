using ClasesLinQ;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinQConLibrerias
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void SkipTake(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewComplete.DataSource = SampleData.Books
                .Select((book, index) => new
                { book = book.Title, index = index });
                GridViewComplete.DataBind();
                int count = SampleData.Books.Count();
                for (int i = 0; i < count; i++)
                {
                    ddlStart.Items.Add(i.ToString());
                    ddlEnd.Items.Add(i.ToString());
                }
                ddlStart.SelectedIndex = 2;
                ddlEnd.SelectedIndex = 3; DisplayPartialData();
            }
        }
        protected void ddlStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPartialData();
        }
        private void DisplayPartialData()
        {
            int startIndex = int.Parse(ddlStart.SelectedValue);
            int endIndex = int.Parse(ddlEnd.SelectedValue); GridViewPartial.DataSource = SampleData.Books
            .Select((book, index) => new
            { book = book.Title, index = index })
            .Skip(startIndex).Take(endIndex - startIndex + 1);
            GridViewPartial.DataBind();
        }
        protected void ddlEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int startIndex = int.Parse(ddlStart.SelectedValue);
            int endIndex = int.Parse(ddlEnd.SelectedValue); if (endIndex >= startIndex)
            {
                DisplayPartialData();
            }
        }
    }
}
}