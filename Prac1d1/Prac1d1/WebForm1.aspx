<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prac1d1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
        <asp:Label ID="Lb1" runat="server" Text="Enter the Range"></asp:Label>
        <br />
        <asp:TextBox ID="TB1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="B1" runat="server" onclick="B1_Click" 
            Text="Fibonacci series till the range" />
        <br />
        <br />
        <asp:Label ID="Lb2" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
