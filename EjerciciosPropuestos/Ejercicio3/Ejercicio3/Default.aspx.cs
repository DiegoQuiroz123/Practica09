using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Ejercicio3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var query = from m in XElement.Load(MapPath("Farmacia.xml")).Elements("Producto")
                        select new Producto
                        {
                            Nombre = (string)m.Element("Nombre"),
                            Cantidad = (int)m.Element("Cantidad"),
                            Precio = (float)m.Element("Precio")
                        };
            this.GridView1.DataSource = query;
            this.GridView1.DataBind();
            var query2 = from m in XElement.Load(MapPath("Farmacia.xml")).Elements("Venta")
                         select new Venta
                         {
                             Numero = (int)m.Element("Numero"),
                             Nombre = (string)m.Element("Nombre"),
                             total = (float)m.Element("Total")
                         };
            this.GridView2.DataSource = query2;
            this.GridView2.DataBind();
        }
            public class Producto
        {
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public float Precio { get; set; }
        }
        public class Venta
        {
            public int Numero { get; set; }
            public string Nombre { get; set; }
            public float total { get; set; }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}



