using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml.Linq;

public partial class L_q56 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      //  DataSet ds = new DataSet();
        
       
       // DataTable empTable = ds.Tables["person"];
        //var v = empTable.AsEnumerable();
        string file = @"C:\Users\admin\Documents\Visual Studio 2013\WebSites\LINQcsharp\L_q56.xml";
        XDocument d = XDocument.Load(file);
        var query = from r in d.Descendants("person")
                    where (int)r.Element("Age") < 60
                    select new
                    {
                        Name = r.Element("Name").Value,
                        Age = r.Element("Age").Value,
                        Address = r.Element("Address").Value
                    };
        GridView1.DataSource = query;
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
protected void Button1_Click(object sender, EventArgs e)
{
   
}
}