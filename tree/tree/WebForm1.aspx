<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="tree.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TreeView ID="treeViewCategories" runat="server" OnSelectedNodeChanged="treeViewCategories_SelectedNodeChanged">
            </asp:TreeView>
            <br /><br />
            <asp:DataList ID="dataListItems" runat="server">
                <ItemTemplate>
                    <%# Eval("ItemName") %> - Price: $<%# Eval("Price") %><br />
                </ItemTemplate>
            </asp:DataList>
    
    </div>
    </form>
</body>
</html>
