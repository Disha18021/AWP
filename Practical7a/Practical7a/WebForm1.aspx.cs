using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Practical7a
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        TextBox tb1;
        DropDownList d1;

        SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLExpress;Initial Catalog=StudentDB;Integrated Security=True");
        SqlCommand co = new SqlCommand();
        SqlDataReader ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            tb1 = new TextBox();
            this.form1.Controls.Add(tb1);

            this.form1.Controls.Add(new LiteralControl("<br/><br/>"));

            d1 = new DropDownList();
            d1.SelectedIndexChanged += d1_list; // Attach the event handler
            d1.AutoPostBack = true; // Ensures that the selection change triggers a postback
            this.form1.Controls.Add(d1);

            if (!IsPostBack) // Populate the dropdown only on the initial load
            {
                cn.Open();
                co.Connection = cn;
                co.CommandText = "SELECT * FROM Table1;"; // Change to the new table name
                ds = co.ExecuteReader();
                d1.DataSource = ds;
                d1.DataTextField = "studName"; // Change to the new column name
                d1.DataBind();
                ds.Close(); // Close the reader after use
                cn.Close(); // Close the connection
            }
        }

        protected void d1_list(object sender, EventArgs e)
        {
            tb1.Text = d1.SelectedItem.Text; // Display the selected item in the textbox
        }
    }
}