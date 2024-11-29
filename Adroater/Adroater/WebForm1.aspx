<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Adroater.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

 
 <head id="Head1" runat="server">
    <title>AdRotator Example</title>
</head>
 
 <body>

    <form id="form2" runat="server">
 
       <h3>AdRotator Example</h3>
       <p>
           <asp:AdRotator ID="AdRotator1" runat="server" 
               AdvertisementFile="~/XMLFile1.xml" Width="100" Height="100" />
       </p>
 
    </form>
 

  </body>
</html>
