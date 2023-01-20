using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class Ej1Linq : System.Web.UI.Page
    {
        public class pieza
        {
            public int nPieza { get; set; }
            public string desc { get; set; }

            public static List<pieza> crearlista()
            {
                List<pieza> piezas = new List<pieza>()
                    {
                        new pieza {nPieza=1, desc="Correa de distribucion"},
                        new pieza {nPieza=2, desc="Arbol de levas"},
                        new pieza {nPieza=3, desc="Piston"},
                        new pieza {nPieza=4, desc="Biela"},
                        new pieza {nPieza=5, desc="Carter"},
                        new pieza {nPieza=6, desc="Volante Motor"},

                    };
                return piezas;
            }
                
        }
        

        public void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<pieza> piezas = pieza.crearlista();
            var piezasAsc =
                (from p in piezas
                 orderby p.desc ascending
                 select p).ToList();

            //version LABMDA
            var listaLambda = piezas
                .OrderBy(p => p.desc)
                .Select(p => p);

            foreach (var p in piezasAsc)
            {
                Response.Write(p.nPieza);
                Response.Write(p.desc);
                Response.Write("</br>");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            List<pieza> piezas = pieza.crearlista();
            var piezasC = (
                from p in piezas
                where p.desc.StartsWith("C")
                select p
                ).ToList();
            //version LABMDA
            var listaLambda = piezas
                .Where(p => p.desc.StartsWith("C"))
                .Select(p => p);

            foreach (var p in piezasC)
            {
                Response.Write(p.nPieza);
                Response.Write(p.desc);
                Response.Write("</br>");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            List<pieza> piezas = pieza.crearlista();
            var piezaN = (
                from p in piezas
                where p.nPieza == 1
                select p
                ).FirstOrDefault();
            //version LABMDA
            var listaLambda = piezas
                .Where(p => p.nPieza == 1)
                .Select(p => p);

            Response.Write(piezaN.desc);
        }
    }
}