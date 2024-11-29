using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bank.Models;

namespace Bank
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Title
            var title = new LiteralControl("<h1>Create Account</h1>");
            form1.Controls.Add(title);

            // Account Number
            var lblAccountNumber = new LiteralControl("Account Number: ");
            form1.Controls.Add(lblAccountNumber);
            var txtAccountNumber = new TextBox { ID = "txtAccountNumber" };
            form1.Controls.Add(txtAccountNumber);

            // Account Name
            var lblAccountName = new LiteralControl("<br />Account Name: ");
            form1.Controls.Add(lblAccountName);
            var txtAccountName = new TextBox { ID = "txtAccountName" };
            form1.Controls.Add(txtAccountName);

            // Password
            var lblPassword = new LiteralControl("<br />Password: ");
            form1.Controls.Add(lblPassword);
            var txtPassword = new TextBox { ID = "txtPassword", TextMode = TextBoxMode.Password };
            form1.Controls.Add(txtPassword);

            // Create Button
            var btnCreate = new Button { Text = "Create Account" };
            btnCreate.Click += BtnCreate_Click;
            form1.Controls.Add(btnCreate);

            // Message Label
            var lblMessage = new Label { ID = "lblMessage" };
            form1.Controls.Add(lblMessage);
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var accounts = (List<Account>)Session["Accounts"] ?? new List<Account>();

            var accountNumber = int.Parse(((TextBox)form1.FindControl("txtAccountNumber")).Text);
            var accountName = ((TextBox)form1.FindControl("txtAccountName")).Text;
            var password = ((TextBox)form1.FindControl("txtPassword")).Text;

            accounts.Add(new Account(accountNumber, accountName, password));
            Session["Accounts"] = accounts;

            var lblMessage = (Label)form1.FindControl("lblMessage");
            lblMessage.Text = "Account created successfully.";
        }
    }
}