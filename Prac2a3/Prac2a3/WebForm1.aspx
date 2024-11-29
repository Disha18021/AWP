<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prac2a3.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter coefficients (a, b, c) of the quadratic equation ax^2 + bx + c:</div>
    <asp:Label ID="Label1" runat="server" Text="Enter coefficient a"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 27px"></asp:TextBox>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Enter coefficient b"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 27px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Enter coefficient c"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 28px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Find Quadratic equation of coefficients" />
    </p>
    <p>
        <asp:Label ID="Lb4" runat="server" Text=" "></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
