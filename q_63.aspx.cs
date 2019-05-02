using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data;
public partial class q_63 : System.Web.UI.Page
{
    //List<string> emp = (List<string>)from e1 in XDocument.Load(@"C:\Users\admin\Documents\Visual Studio 2013\Projects\LinqToXML\LinqToXML\linq_q63.xml").Descendants("employee") select e1.Element("EMPNO").Value;

    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds =new DataSet();
        string file=@"C:\Users\admin\Documents\Visual Studio 2013\WebSites\LINQcsharp\L_q63.xml";
        ds.ReadXml(file);
        GridView1.DataSource=ds.Tables["emp"];
        GridView1.DataBind();
           }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}