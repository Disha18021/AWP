//Prac8c
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac8c
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Label lbl;
        TextBox txtBox;
        Button btn;
        GridView gridView;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Create dynamic controls
            lbl = new Label();
            lbl.Text = "Employee Salary > ";
            this.form1.Controls.Add(lbl);

            txtBox = new TextBox();
            txtBox.ID = "TextBox1";
            this.form1.Controls.Add(txtBox);

            Literal ltr = new Literal();
            ltr.Text = "<br /><br />";
            this.form1.Controls.Add(ltr);

            btn = new Button();
            btn.Text = "Show";
            btn.Click += Button1_Click;
            this.form1.Controls.Add(btn);

            ltr = new Literal();
            ltr.Text = "<br /><br />";
            this.form1.Controls.Add(ltr);

            gridView = new GridView();
            gridView.ID = "GridView1";
            gridView.AutoGenerateColumns = true; // Set AutoGenerateColumns to true
            this.form1.Controls.Add(gridView);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Database connection and SQL logic
            String constr = WebConfigurationManager.ConnectionStrings["Tyit"].ConnectionString;
            using (SqlConnection scon = new SqlConnection(constr))
            {
                scon.Open();
                String sql = "Select * from Emp_Table where Emp_Sal > " + txtBox.Text;
                SqlDataAdapter da = new SqlDataAdapter(sql, scon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                // Bind GridView to the dataset
                gridView.DataSource = ds.Tables[0];
                gridView.DataBind();
            }
        }
    }
}