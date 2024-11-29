<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prac1d3.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter a alphabet"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 42px"></asp:TextBox>
    
    </div>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Find Vowel or Consonant" />
    </p>
    <p>
        <asp:Label ID="Solution" runat="server"></asp:Label>
    </p>
    </form>
</body>
</html>
