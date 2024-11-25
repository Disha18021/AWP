using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myWesite
{
    public partial class OrderConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["TotalAmount"] != null)
            {
                TotalAmountLabel.Text = "Total Amount: Rs. " + Session["TotalAmount"].ToString();
            }
            else
            {
                TotalAmountLabel.Text = "Order details are not available.";
            }
        }
    }
}