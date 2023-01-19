using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ErroresASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Page_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            if(ex is NotImplementedException)
            {
                Server.Transfer("/errorpage/notimplementeddescripction.aspx");
            }
            else
            {
                Server.Transfer("/errorpage/aperror.aspx");
            }
            Server.ClearError();
        }
    }
}