using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;

namespace ejercicio5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FarmaciaEntities1 fm = new FarmaciaEntities1();
            var query = from m in fm.PRODUCTO select m;
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
            var query2 = from a in fm.VENTAS select a;
            GridView2.DataSource = query2.ToList();
            GridView2.DataBind();

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}