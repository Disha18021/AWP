﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="tree.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TreeView ID="TreeView1" runat="server" 
                          OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
            </asp:TreeView>
            <br />

            <asp:TextBox ID="NodeTextBox" runat="server" Width="200px"></asp:TextBox>
            <br /><br />

            <asp:Button ID="AddNodeButton" runat="server" Text="Add Node" OnClick="AddNodeButton_Click" />
            <asp:Button ID="RemoveNodeButton" runat="server" Text="Remove Node" OnClick="RemoveNodeButton_Click" />
            <br /><br />

            <asp:Label ID="SelectedNodeLabel" runat="server" Text="Selected Node: "></asp:Label>
        
    </div>
    </form>
</body>
</html>
