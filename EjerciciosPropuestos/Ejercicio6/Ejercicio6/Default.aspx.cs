using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio6
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FarmaciaEntities fm = new FarmaciaEntities();
            var query = from m in fm.PRODUCTO select m;
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
            var query2 = from a in fm.VENTAS select a;
            GridView2.DataSource = query2.ToList();
            GridView2.DataBind();
        }
        protected void ClickBuscar(object sender, EventArgs e)
        {
            FarmaciaEntities bdfarmacia = new FarmaciaEntities();
            GridView2.Visible = false;
            if (idVenta.Text != "")
            {
                GridView2.Visible = true;
                var query = from m in bdfarmacia.VENTAS where m.ID_venta.ToString() == idVenta.Text select m;
                GridView2.DataSource = query.ToList();
                GridView2.DataBind();
                labelPro.Text = "SE ENCONTRO LA VENTA QUE ESTA BUSCANDO...";
            }
            else
            {
                labelPro.Text = "El id de la venta ingresado no existe";
                GridView2.Visible = false;
            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}