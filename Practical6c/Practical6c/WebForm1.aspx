<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical6c.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" DataKeyField="ID" RepeatColumns="1">
                <ItemTemplate>
                    <p><b>ID:</b> <%# Eval("ID") %></p>
                    <p><b>Name:</b> <%# Eval("Name") %></p>
                    <p><b>Age:</b> <%# Eval("Age") %></p>
                    <hr />
                </ItemTemplate>
            </asp:DataList>
    
        </div>
    </form>
</body>
</html>
