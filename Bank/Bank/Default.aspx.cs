using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bank.Models;

namespace Bank
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Create main menu dynamically
            var title = new LiteralControl("<h1>Welcome to the Banking System</h1>");
            form1.Controls.Add(title);

            // Banker Button
            var btnBanker = new Button { Text = "Banker" };
            btnBanker.Click += (s, ev) => Response.Redirect("Banker.aspx");
            form1.Controls.Add(btnBanker);

            // Customer Button
            var btnCustomer = new Button { Text = "Customer" };
            btnCustomer.Click += (s, ev) => Response.Redirect("Customer.aspx");
            form1.Controls.Add(btnCustomer);

            // Exit Button
            var btnExit = new Button { Text = "Exit" };
            btnExit.Click += (s, ev) => Response.Write("<script>window.close();</script>");
            form1.Controls.Add(btnExit);
        }
    }
}