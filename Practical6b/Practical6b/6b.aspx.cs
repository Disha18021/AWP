using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical6b
{
    public partial class _6b : System.Web.UI.Page
    {
        TextBox tb1;
        Button b1;
        Label lb1;
        Label promptLabel; // New label for prompting user input

        SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLExpress;Initial Catalog=tyitDB;Integrated Security=True;");
        SqlCommand co = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Create a label to prompt for roll number
            promptLabel = new Label();
            promptLabel.Text = "Enter the roll number: "; // Prompt text
            this.form1.Controls.Add(promptLabel);

            tb1 = new TextBox();
            this.form1.Controls.Add(tb1);

            this.form1.Controls.Add(new LiteralControl("<br/> <br/>"));

            b1 = new Button();
            b1.Click += b1_Click;
            b1.Text = "Search Name of the Student"; // Changed button text to "Search"
            this.form1.Controls.Add(b1);

            this.form1.Controls.Add(new LiteralControl("<br/><br/>"));

            lb1 = new Label();
            this.form1.Controls.Add(lb1);

            cn.Open();
            co.Connection = cn;
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            // Use parameterized query to avoid SQL injection
            co.CommandText = "SELECT tyname FROM Table1 WHERE tyrollno = @rollno;";
            co.Parameters.Clear();
            co.Parameters.AddWithValue("@rollno", tb1.Text);
            object result = co.ExecuteScalar();
            lb1.Text = result != null ? result.ToString() : "No record found.";
        }
    }
}