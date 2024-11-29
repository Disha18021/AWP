<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prac5a.aspx.cs" Inherits="Prac5a.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="home"></asp:Label>
    
    <br />
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:Menu>
        <br />
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
    
    </div>
    </form>
</body>
</html>
