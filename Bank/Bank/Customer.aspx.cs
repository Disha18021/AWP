using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bank.Models;

namespace Bank
{
    public partial class Customer : System.Web.UI.Page
    {
        List<Account> accounts;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialize accounts from session if available
            if (Session["Accounts"] != null)
            {
                accounts = (List<Account>)Session["Accounts"];
            }
            else
            {
                accounts = new List<Account>();
            }

            // Ensure controls are added only once during the initial page load
            if (!IsPostBack)
            {
                CreateCustomerControls();
            }

            // Set active view based on session state (whether customer is logged in)
            MultiView multiView = (MultiView)FindControl("MultiView1");
            if (multiView != null)
            {
                if (Session["CustomerAccount"] != null)
                {
                    multiView.SetActiveView((View)FindControl("ViewOperations"));
                }
                else
                {
                    multiView.SetActiveView((View)FindControl("ViewLogin"));
                }
            }
        }

        private void CreateCustomerControls()
        {
            // Dynamically create MultiView control
            MultiView multiView = new MultiView { ID = "MultiView1" };
            this.Form.Controls.Add(multiView);  // Add it to the existing form

            // Create Login View
            View loginView = new View { ID = "ViewLogin" };
            multiView.Views.Add(loginView);

            // Add controls for login view
            AddLoginControls(loginView);

            // Create Operations View
            View operationsView = new View { ID = "ViewOperations" };
            multiView.Views.Add(operationsView);

            // Add controls for operations view
            AddOperationsControls(operationsView);

            // Set initial active view to Login view
            multiView.SetActiveView(loginView);
        }

        private void AddLoginControls(View loginView)
        {
            // Account Number
            Label lblAccountNumber = new Label { Text = "Account Number: " };
            TextBox txtAccountNumber = new TextBox { ID = "txtAccountNumber" };
            loginView.Controls.Add(lblAccountNumber);
            loginView.Controls.Add(txtAccountNumber);
            loginView.Controls.Add(new LiteralControl("<br />"));

            // Account Name
            Label lblAccountName = new Label { Text = "Account Name: " };
            TextBox txtAccountName = new TextBox { ID = "txtAccountName" };
            loginView.Controls.Add(lblAccountName);
            loginView.Controls.Add(txtAccountName);
            loginView.Controls.Add(new LiteralControl("<br />"));

            // Password
            Label lblPassword = new Label { Text = "Password: " };
            TextBox txtPassword = new TextBox { ID = "txtPassword", TextMode = TextBoxMode.Password };
            loginView.Controls.Add(lblPassword);
            loginView.Controls.Add(txtPassword);
            loginView.Controls.Add(new LiteralControl("<br />"));

            // Login Button
            Button btnLogin = new Button { Text = "Login", ID = "btnLogin" };
            btnLogin.Click += BtnLogin_Click;
            loginView.Controls.Add(btnLogin);
            loginView.Controls.Add(new LiteralControl("<br />"));

            // Message Label
            Label lblMessage = new Label { ID = "lblMessage", ForeColor = System.Drawing.Color.Red };
            loginView.Controls.Add(lblMessage);
        }

        private void AddOperationsControls(View operationsView)
        {
            // Deposit Button
            Button btnDeposit = new Button { Text = "Deposit", ID = "btnDeposit" };
            btnDeposit.Click += BtnDeposit_Click;
            operationsView.Controls.Add(btnDeposit);
            operationsView.Controls.Add(new LiteralControl("<br />"));

            // Withdraw Button
            Button btnWithdraw = new Button { Text = "Withdraw", ID = "btnWithdraw" };
            btnWithdraw.Click += BtnWithdraw_Click;
            operationsView.Controls.Add(btnWithdraw);
            operationsView.Controls.Add(new LiteralControl("<br />"));

            // Check Balance Button
            Button btnCheckBalance = new Button { Text = "Check Balance", ID = "btnCheckBalance" };
            btnCheckBalance.Click += BtnCheckBalance_Click;
            operationsView.Controls.Add(btnCheckBalance);
            operationsView.Controls.Add(new LiteralControl("<br />"));

            // Logout Button
            Button btnLogout = new Button { Text = "Logout", ID = "btnLogout" };
            btnLogout.Click += BtnLogout_Click;
            operationsView.Controls.Add(btnLogout);
            operationsView.Controls.Add(new LiteralControl("<br />"));

            // Operation Message Label
            Label lblOperationMessage = new Label { ID = "lblOperationMessage", ForeColor = System.Drawing.Color.Green };
            operationsView.Controls.Add(lblOperationMessage);

            // Deposit Amount TextBox
            Label lblDepositAmount = new Label { Text = "Deposit Amount: " };
            TextBox txtDepositAmount = new TextBox { ID = "txtDepositAmount" };
            operationsView.Controls.Add(lblDepositAmount);
            operationsView.Controls.Add(txtDepositAmount);
            operationsView.Controls.Add(new LiteralControl("<br />"));

            // Withdraw Amount TextBox
            Label lblWithdrawAmount = new Label { Text = "Withdraw Amount: " };
            TextBox txtWithdrawAmount = new TextBox { ID = "txtWithdrawAmount" };
            operationsView.Controls.Add(lblWithdrawAmount);
            operationsView.Controls.Add(txtWithdrawAmount);
            operationsView.Controls.Add(new LiteralControl("<br />"));
        }

        // Login Button Click event
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            int accountNumber;
            if (!int.TryParse(Request.Form["txtAccountNumber"], out accountNumber))
            {
                lblMessage.Text = "Invalid account number.";
                return;
            }

            string accountName = Request.Form["txtAccountName"];
            string password = Request.Form["txtPassword"];

            // Find the account
            Account customerAccount = accounts.Find(account =>
                account.AccountNumber == accountNumber &&
                account.AccountName == accountName &&
                account.Password == password);

            if (customerAccount != null)
            {
                Session["CustomerAccount"] = customerAccount; // Store account in session for further operations
                MultiView multiView = (MultiView)FindControl("MultiView1");
                multiView.SetActiveView((View)FindControl("ViewOperations"));
                lblMessage.Text = "Login successful!";
            }
            else
            {
                lblMessage.Text = "Account not found or invalid credentials.";
            }
        }

        // Deposit Button Click event
        protected void BtnDeposit_Click(object sender, EventArgs e)
        {
            if (Session["CustomerAccount"] != null)
            {
                Account customerAccount = (Account)Session["CustomerAccount"];
                double depositAmount;

                if (!double.TryParse(Request.Form["txtDepositAmount"], out depositAmount) || depositAmount <= 0)
                {
                    lblOperationMessage.Text = "Enter a valid deposit amount.";
                    return;
                }

                customerAccount.Deposit(depositAmount);
                lblOperationMessage.Text = string.Format("Deposit successful! Current Balance: {0}", customerAccount.Balance);
            }
        }

        // Withdraw Button Click event
        protected void BtnWithdraw_Click(object sender, EventArgs e)
        {
            if (Session["CustomerAccount"] != null)
            {
                Account customerAccount = (Account)Session["CustomerAccount"];
                double withdrawAmount;

                if (!double.TryParse(Request.Form["txtWithdrawAmount"], out withdrawAmount) || withdrawAmount <= 0)
                {
                    lblOperationMessage.Text = "Enter a valid withdrawal amount.";
                    return;
                }

                if (customerAccount.Withdraw(withdrawAmount))
                {
                    lblOperationMessage.Text = string.Format("Withdrawal successful! Current Balance: {0}", customerAccount.Balance);
                }
                else
                {
                    lblOperationMessage.Text = "Insufficient balance.";
                }
            }
        }

        // Check Balance Button Click event
        protected void BtnCheckBalance_Click(object sender, EventArgs e)
        {
            if (Session["CustomerAccount"] != null)
            {
                Account customerAccount = (Account)Session["CustomerAccount"];
                lblOperationMessage.Text = string.Format("Current Balance: {0}", customerAccount.Balance);
            }
        }

        // Logout Button Click event
        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Session["CustomerAccount"] = null; // Clear session for the customer
            MultiView multiView = (MultiView)FindControl("MultiView1");
            multiView.SetActiveView((View)FindControl("ViewLogin"));
        }
    }
}
