<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MyLibrary.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Math Operations Using DLL</h2>
            <label>Enter First Number:</label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <label>Enter Second Number:</label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Subtract" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Multiply" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Divide" OnClick="Button4_Click" />
            <br />
            <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
       
    </div>
    </form>
</body>
</html>
