<%@ Page Language="C#" AutoEventWireup="true" CodeFile="L_q56.aspx.cs" Inherits="L_q56" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <p style="margin-left: 80px">
            THIS IS DISPLAYING 4 PERSONS USING XML FILE AND GRID CONTROL<br />
            <br />
        </p>
        <div style="margin-left: 240px">
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    
    </form>
</body>
</html>
