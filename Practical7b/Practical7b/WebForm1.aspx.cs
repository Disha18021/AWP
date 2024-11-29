using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Practical7b
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        TextBox tb1;
        Button btnGetPhoneNumber; // Renamed button for clarity
        Label lblPrompt; // Label for user prompt
        Label lblResult; // Label for displaying results


        SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLExpress;Initial Catalog=AuthorDB;Integrated Security=True;");
        SqlCommand co = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Create and configure the prompt label
            lblPrompt = new Label();
            lblPrompt.Text = "Enter the author's name:";
            this.form1.Controls.Add(lblPrompt);

            // Create and configure the text box
            tb1 = new TextBox();
            this.form1.Controls.Add(tb1);

            this.form1.Controls.Add(new LiteralControl("<br />"));

            // Create and configure the button
            btnGetPhoneNumber = new Button();
            btnGetPhoneNumber.Click += b1_Click;
            btnGetPhoneNumber.Text = "Get Phone Number"; // Descriptive button text
            this.form1.Controls.Add(btnGetPhoneNumber);

            this.form1.Controls.Add(new LiteralControl("<br />"));

            // Create and configure the result label
            lblResult = new Label();
            this.form1.Controls.Add(lblResult);



            // Open database connection
            cn.Open();
            co.Connection = cn;
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            // Query to get the phone number for the specified author name
            co.CommandText = "SELECT phoneNo FROM Table1 WHERE name=@name;";
            co.Parameters.AddWithValue("@name", tb1.Text);

            var result = co.ExecuteScalar();

            // Check if a result was returned and display it
            lblResult.Text = result != null ? "Phone Number: " + result.ToString() : "No phone number found.";
        }
    }
}