using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bank.Models;

namespace Bank
{
    public partial class Banker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Title
            var title = new LiteralControl("<h1>Banker Menu</h1>");
            form1.Controls.Add(title);

            // Create Account Button
            var btnCreateAccount = new Button { Text = "Create Account" };
            btnCreateAccount.Click += BtnCreateAccount_Click;
            form1.Controls.Add(btnCreateAccount);

            // Display Accounts Button
            var btnDisplayAccounts = new Button { Text = "Display All Accounts" };
            btnDisplayAccounts.Click += BtnDisplayAccounts_Click;
            form1.Controls.Add(btnDisplayAccounts);

            // Back Button
            var btnBack = new Button { Text = "Back to Main Menu" };
            btnBack.Click += (s, ev) => Response.Redirect("Default.aspx");
            form1.Controls.Add(btnBack);

            // Message Label
            var lblMessage = new Label { ID = "lblMessage" };
            form1.Controls.Add(lblMessage);
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateAccount.aspx");
        }

        private void BtnDisplayAccounts_Click(object sender, EventArgs e)
        {
            var accounts = (List<Account>)Session["Accounts"] ?? new List<Account>();
            var lblMessage = (Label)form1.FindControl("lblMessage");
            lblMessage.Text = "<h2>Accounts:</h2>";
            foreach (var account in accounts)
            {
                lblMessage.Text += string.Format("Account Number: {0}, Name: {1}<br />", account.AccountNumber, account.AccountName);
            }
        }
    }
}