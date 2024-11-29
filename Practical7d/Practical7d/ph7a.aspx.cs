using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical7d
{
    public partial class ph7a : System.Web.UI.Page
    {
        // Declare controls
        Label lblSelectCompany;
        CheckBox chkApple, chkDell, chkLenevo, chkAcer, chkSony, chkWipro;
        Button cmdSubmit;
        Label lblResult;

        protected void Page_Load(object sender, EventArgs e)
        {
          //  protected global::System.Web.UI.HtmlControls.HtmlForm form1;
            // Initialize and set properties for the dynamic controls

            // Label for selecting company
            lblSelectCompany = new Label();
            lblSelectCompany.ID = "lblSelectCompany";
            lblSelectCompany.Text = "Select the company";
            lblSelectCompany.Font.Bold = true;
          
            form1.Controls.Add(lblSelectCompany);

            // CheckBoxes for company names
            chkApple = new CheckBox();
            chkApple.ID = "chkApple";
            chkApple.Text = "Apple";
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(chkApple);

            chkDell = new CheckBox();
            chkDell.ID = "chkDell";
            chkDell.Text = "Dell";
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(chkDell);

            chkLenevo = new CheckBox();
            chkLenevo.ID = "chkLenevo";
            chkLenevo.Text = "Lenevo";
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(chkLenevo);

            chkAcer = new CheckBox();
            chkAcer.ID = "chkAcer";
            chkAcer.Text = "Acer";
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(chkAcer);

            chkSony = new CheckBox();
            chkSony.ID = "chkSony";
            chkSony.Text = "Sony";
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(chkSony);

            chkWipro = new CheckBox();
            chkWipro.ID = "chkWipro";
            chkWipro.Text = "Wipro";
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(chkWipro);

            // Submit button
            cmdSubmit = new Button();
            cmdSubmit.ID = "cmdSubmit";
            cmdSubmit.Text = "Submit";
            cmdSubmit.Click += new EventHandler(cmdSubmit_Click);
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(cmdSubmit);

            // Label to display the result
            lblResult = new Label();
            lblResult.ID = "lblResult";
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(lblResult);

            // Expire the "comp" cookie if it exists
            Response.Cookies["comp"].Expires = DateTime.Now.AddDays(-1);
        }

        protected void cmdSubmit_Click(object sender, EventArgs e)
        {
            lblResult.Text = ""; // Reset result label

            // Add values to the "comp" cookie based on the selected checkboxes
            if (chkApple.Checked) Response.Cookies["comp"]["apple"] = "apple";
            if (chkDell.Checked) Response.Cookies["comp"]["dell"] = "dell";
            if (chkLenevo.Checked) Response.Cookies["comp"]["lenevo"] = "lenevo";
            if (chkAcer.Checked) Response.Cookies["comp"]["acer"] = "acer";
            if (chkSony.Checked) Response.Cookies["comp"]["sony"] = "sony";
            if (chkWipro.Checked) Response.Cookies["comp"]["wipro"] = "wipro";

            // Fetch and display the selected companies from the cookie
            if (Request.Cookies["comp"] != null)
            {
                if (Request.Cookies["comp"]["apple"] != null) lblResult.Text += Request.Cookies["comp"]["apple"] + " ";
                if (Request.Cookies["comp"]["dell"] != null) lblResult.Text += Request.Cookies["comp"]["dell"] + " ";
                if (Request.Cookies["comp"]["lenevo"] != null) lblResult.Text += Request.Cookies["comp"]["lenevo"] + " ";
                if (Request.Cookies["comp"]["acer"] != null) lblResult.Text += Request.Cookies["comp"]["acer"] + " ";
                if (Request.Cookies["comp"]["sony"] != null) lblResult.Text += Request.Cookies["comp"]["sony"] + " ";
                if (Request.Cookies["comp"]["wipro"] != null) lblResult.Text += Request.Cookies["comp"]["wipro"] + " ";
            }
            else
            {
                lblResult.Text = "Please select your choice.";
            }

            // Expire the "comp" cookie after use
            Response.Cookies["comp"].Expires = DateTime.Now.AddDays(-1);
        }
    }
}