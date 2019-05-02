<%@ Page Language="C#" AutoEventWireup="true" CodeFile="L_xml_q63.aspx.cs" Inherits="L_xml_q63" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        THIS IS TO DISPLAY EMPLOYEE INFORMATION FROM TABLE TO GRID CONTROL USING LINQ TO XML<br />
        <br />
        <div style="margin-left: 280px">
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
        </div>
    
    </form>
</body>
</html>
