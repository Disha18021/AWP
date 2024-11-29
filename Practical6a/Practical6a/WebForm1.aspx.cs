using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical6a
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLExpress;Initial Catalog=databaseDB;Integrated Security=True");
        SqlCommand co = new SqlCommand();

        // Declare controls at the class level
        protected TextBox TextBox1;
        protected TextBox TextBox2;
        protected Button Button1;
        protected Label lblName;
        protected Label lblResults;

        protected void Page_Load(object sender, EventArgs e)
        {
            
                // Create controls dynamically
                lblName = new Label();
                lblName.Text = "Enter Name: ";
                form1.Controls.Add(lblName);

                TextBox1 = new TextBox();
                TextBox1.ID = "TextBox1"; // Assign an ID for later access
                form1.Controls.Add(TextBox1);

                form1.Controls.Add(new LiteralControl("<br /><br />"));

                Button1 = new Button();
                Button1.Text = "Search";
                Button1.Click += new EventHandler(Button1_Click);
                form1.Controls.Add(Button1);

                form1.Controls.Add(new LiteralControl("<br /><br />"));

                lblResults = new Label();
                lblResults.Text = "Results: ";
                form1.Controls.Add(lblResults);

                form1.Controls.Add(new LiteralControl("<br /><br />"));

                TextBox2 = new TextBox();
                TextBox2.ID = "TextBox2"; // Assign an ID for later access
                TextBox2.TextMode = TextBoxMode.MultiLine; // Set to multiline
                TextBox2.Rows = 10; // Set number of rows
                TextBox2.Columns = 30; // Set number of columns
                TextBox2.ReadOnly = true; // Make it read-only
                form1.Controls.Add(TextBox2);
            

            // Open the database connection
            cn.Open();
            co.Connection = cn;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Use parameterized query to prevent SQL injection
            co.CommandText = "SELECT * FROM Table1 WHERE Name = @name"; // Fix applied here
            co.Parameters.Clear(); // Clear any previous parameters
            co.Parameters.AddWithValue("@name", TextBox1.Text); // Add the user input as a parameter

            SqlDataReader ds = co.ExecuteReader();
            TextBox2.Text = ""; // Clear the TextBox2 before displaying new results

            // Read and display data from the database
            while (ds.Read())
            {
                TextBox2.Text += ds["ID"].ToString() + "\t" + ds["Name"].ToString() + "\t" + ds["Age"].ToString() + "\n";
            }

            // Close the data reader
            ds.Close();
            // Close the database connection
            cn.Close();
        }
    }
}