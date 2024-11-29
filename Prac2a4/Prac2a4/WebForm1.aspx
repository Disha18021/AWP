<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prac2a4.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Lb1" runat="server" Text="Enter Temperature in celcius"></asp:Label>
&nbsp;
        <asp:TextBox ID="TB1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="B1" runat="server" onclick="B1_Click" 
            Text="Temperature Conversion" />
        <br />
        <br />
        <asp:Label ID="Lb2" runat="server" Text="Temperature in Fahrenheit"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="Lb3" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Lb4" runat="server" Text="Temperature in Kelvin"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="Lb5" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
