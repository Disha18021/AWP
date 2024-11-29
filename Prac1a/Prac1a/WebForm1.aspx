<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prac1a.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 46px">
    <form id="form1" runat="server">
    <p>
        <asp:Label ID="Label2" runat="server" Text="Num 1:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Height="29px" 
            style="margin-left: 36px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Num 2:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 37px" 
            Width="163px"></asp:TextBox>
    </p>
    <asp:Label ID="Label4" runat="server" Text="Num 3:"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 35px"></asp:TextBox>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Num 4:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 36px"></asp:TextBox>
    </p>
    <asp:Button ID="Button1" runat="server" Text="Product" 
        onclick="Button1_Click" />
    <p>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    </form>
</body>
</html>
