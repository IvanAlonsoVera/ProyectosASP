using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormularioWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Esto es para poder abrir una nueva pagina
            /*ClientScriptManager cs = Page.ClientScript;
            cs.RegisterHiddenField("Oculto1", "Datos1");*/
           
        }

        protected void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string nombreArchivo = FileUpload1.FileName;
                string ruta = "~/Files/" + nombreArchivo;
                FileUpload1.SaveAs(Server.MapPath(ruta));
                Label1.Text = "Se ha guardado una imagen en la ruta " + Environment.NewLine + ruta;
            }
        }
    }
}