<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TreeView.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:TreeView ID="TreeView1" runat="server" Height="222px" 
        ImageSet="WindowsHelp" onselectednodechanged="TreeView1_SelectedNodeChanged" 
        ShowLines="True" Width="184px">
        <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" />
        <Nodes>
            <asp:TreeNode Checked="True" ShowCheckBox="True" Text="studentdetail" 
                Value="studentdetail">
                <asp:TreeNode Checked="True" NavigateUrl="~/WebForm2.aspx" ShowCheckBox="True" 
                    Text="student" Value="student">
                    <asp:TreeNode Checked="True" ShowCheckBox="True" Text="sid" Value="sid">
                    </asp:TreeNode>
                    <asp:TreeNode Checked="True" ShowCheckBox="True" Text="sname" Value="sname">
                    </asp:TreeNode>
                    <asp:TreeNode Checked="True" ShowCheckBox="True" Text="sclass" Value="sclass">
                    </asp:TreeNode>
                </asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
        <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" 
            HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="1px" />
        <ParentNodeStyle Font-Bold="False" />
        <SelectedNodeStyle BackColor="#B5B5B5" Font-Underline="False" 
            HorizontalPadding="0px" VerticalPadding="0px" />
    </asp:TreeView>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:DataList ID="DataList1" runat="server" DataSourceID="XmlDataSource1">
        <ItemTemplate>
            sid:
            <asp:Label ID="sidLabel" runat="server" Text='<%# Eval("sid") %>' />
            <br />
            sname:
            <asp:Label ID="snameLabel" runat="server" Text='<%# Eval("sname") %>' />
            <br />
            sclass:
            <asp:Label ID="sclassLabel" runat="server" Text='<%# Eval("sclass") %>' />
            <br />
<br />
        </ItemTemplate>
    </asp:DataList>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile1.xml">
    </asp:XmlDataSource>
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
