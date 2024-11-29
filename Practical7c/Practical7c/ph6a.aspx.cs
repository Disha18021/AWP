using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical7c
{
    public partial class ph6a : Page
    {
        TextBox tb1, tb2, tb3, tb4;
        Button b1, b2, b3;
        Literal messageLiteral;
        SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLExpress;Initial Catalog=EmployeeDB;Integrated Security=True;");
        SqlDataReader ds;
        SqlCommand co = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
           
                // Create Labels
                Label lbl1 = new Label { Text = "Employee ID:" };
                this.form1.Controls.Add(lbl1);
                tb1 = new TextBox { ID = "txtEmpID" };
                this.form1.Controls.Add(tb1);
                this.form1.Controls.Add(new LiteralControl("<br />"));

                Label lbl2 = new Label { Text = "Employee Name:" };
                this.form1.Controls.Add(lbl2);
                tb2 = new TextBox { ID = "txtEmpName" };
                this.form1.Controls.Add(tb2);
                this.form1.Controls.Add(new LiteralControl("<br />"));

                Label lbl3 = new Label { Text = "Employee City:" };
                this.form1.Controls.Add(lbl3);
                tb3 = new TextBox { ID = "txtEmpCity" };
                this.form1.Controls.Add(tb3);
                this.form1.Controls.Add(new LiteralControl("<br />"));

                Label lbl4 = new Label { Text = "Employee Salary:" };
                this.form1.Controls.Add(lbl4);
                tb4 = new TextBox { ID = "txtEmpSalary" };
                this.form1.Controls.Add(tb4);
                this.form1.Controls.Add(new LiteralControl("<br />"));

                // Create Buttons
                b1 = new Button { Text = "Insert" };
                b1.Click += b1_Click;
                this.form1.Controls.Add(b1);
                this.form1.Controls.Add(new LiteralControl("<br />"));

                b2 = new Button { Text = "Delete" };
                b2.Click += b2_Click;
                this.form1.Controls.Add(b2);
                this.form1.Controls.Add(new LiteralControl("<br />"));

                b3 = new Button { Text = "View" };
                b3.Click += b3_Click;
                this.form1.Controls.Add(b3);
                this.form1.Controls.Add(new LiteralControl("<br />"));

                // Create a Literal control for messages
                messageLiteral = new Literal();
                this.form1.Controls.Add(messageLiteral);

                // Open connection
                cn.Open();
                co.Connection = cn;

                // Create GridView dynamically
                GridView gridView1 = new GridView();
                gridView1.ID = "GridView1";
                this.form1.Controls.Add(gridView1);
            
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            try
            {
                int empID = Convert.ToInt32(tb1.Text);
                string empName = tb2.Text;
                string empCity = tb3.Text;
                int empSalary = Convert.ToInt32(tb4.Text);

                // Clear previous parameters
                co.Parameters.Clear();

                // Add parameters for insertion
                co.Parameters.AddWithValue("@p1", empID);
                co.Parameters.AddWithValue("@p2", empName);
                co.Parameters.AddWithValue("@p3", empCity);
                co.Parameters.AddWithValue("@p4", empSalary);

                // SQL Insert command
                co.CommandText = "INSERT INTO Employee(empID, empName, empCity, empSalary) VALUES(@p1, @p2, @p3, @p4);";

                // Execute Insert command using ExecuteReader to simulate non-query
                using (SqlDataReader reader = co.ExecuteReader())
                {
                    // To trigger execution without needing results, read it
                    while (reader.Read()) { }
                }

                // Show success message
                messageLiteral.Text = "Data has been inserted.<br />";
            }
            catch (FormatException ex)
            {
                messageLiteral.Text = "Error: empID and empSalary must be valid integers. " + ex.Message + "<br />";
            }
            catch (Exception ex)
            {
                messageLiteral.Text = "Error: " + ex.Message + "<br />";
            }
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            try
            {
                int empID = Convert.ToInt32(tb1.Text);

                // Clear previous parameters
                co.Parameters.Clear();

                // Add parameter for empID for deletion
                co.Parameters.AddWithValue("@p1", empID);

                // SQL Delete command
                co.CommandText = "DELETE FROM Employee WHERE empID = @p1;";

                // Execute Delete command using ExecuteReader to simulate non-query
                using (SqlDataReader reader = co.ExecuteReader())
                {
                    // To trigger execution without needing results, read it
                    while (reader.Read()) { }
                }

                // Show success message
                messageLiteral.Text = "Data has been deleted.<br />";
            }
            catch (FormatException ex)
            {
                messageLiteral.Text = "Error: empID must be a valid integer. " + ex.Message + "<br />";
            }
            catch (Exception ex)
            {
                messageLiteral.Text = "Error: " + ex.Message + "<br />";
            }
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            // Clear previous parameters
            co.Parameters.Clear();

            // SQL Select command
            co.CommandText = "SELECT * FROM Employee;";
            ds = co.ExecuteReader();

            GridView gridView1 = (GridView)this.form1.FindControl("GridView1");
            gridView1.DataSource = ds;
            gridView1.DataBind();

            ds.Close(); // Close DataReader
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            // Close connection
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }
    }
}