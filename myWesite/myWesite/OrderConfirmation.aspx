<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderConfirmation.aspx.cs" Inherits="myWesite.OrderConfirmation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="styles.css">
    <title>Order Confirmation</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }
        .container {
            width: 60%;
            margin: 20px auto;
            border: 1px solid #ccc;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0px 2px 5px rgba(0, 0, 0, 0.2);
        }
        h1 {
            text-align: center;
        }
        .order-details {
            margin: 20px 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="navbar">
    <div class="brand">Crochet Website</div>
    <div>
        <a href="HomePage.aspx">Home</a>
        <a href="AboutUs.aspx" >About Us</a>
        <a href="Register.aspx">Register</a>
        <a href="Cart.aspx">Cart</a>
        <a href="Products.aspx">Products</a>
    </div>
</div>


    
    </div>
    <div class="container">
            <h1>Order Confirmation</h1>
            </div>
            <div class="container">
            <div class="order-details">
                <h2>Thank you for your order!</h2>
                <p><strong>Order ID:</strong> <asp:Label ID="OrderIdLabel" runat="server" /></p>
                <p><strong>Total Amount:</strong> <asp:Label ID="TotalAmountLabel" runat="server" /></p>
                <p>Your order has been placed successfully. You will receive a confirmation email shortly.</p>
            </div>
        </div>
    
    </form>
</body>
</html>
