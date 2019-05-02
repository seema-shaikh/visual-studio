using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class L_Obj_q65 : System.Web.UI.Page
{
    public List<linq_q65> q65 = new List<linq_q65>();
    protected void Page_Load(object sender, EventArgs e)
    {
        q65.Add(new linq_q65(1, "seema", 10000, "IT", 1));
        q65.Add(new linq_q65(1, "seema", 10000, "IT", 1));
        q65.Add(new linq_q65(1, "seema", 10000, "IT", 1));
        q65.Add(new linq_q65(1, "seema", 10000, "IT", 1));
        var v = from s in q65 select s;
        GridView1.DataSource = q65;
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

}