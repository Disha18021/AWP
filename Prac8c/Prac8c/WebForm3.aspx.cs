//Prac9a
using System;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace Prac8c
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        GridView gridView;
        SqlDataSource sqlDataSource;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Create SqlDataSource dynamically
            sqlDataSource = new SqlDataSource();
            sqlDataSource.ID = "SqlDataSource1";
            sqlDataSource.ConnectionString = WebConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
            sqlDataSource.SelectCommand = "SELECT * FROM [Emp_Table]";
            this.Page.Controls.Add(sqlDataSource);  // Add SqlDataSource to the page controls

            // Create GridView dynamically
            gridView = new GridView();
            gridView.ID = "GridView1";
            gridView.AutoGenerateColumns = false;
            gridView.DataSourceID = sqlDataSource.ID;

            // Add columns dynamically
            HyperLinkField linkField = new HyperLinkField();
            linkField.DataNavigateUrlFields = new string[] { "Emp_ID" };
            linkField.DataNavigateUrlFormatString = "~/p8c.aspx?Emp_ID={0}";
            linkField.DataTextField = "Emp_ID";
            linkField.HeaderText = "Emp_ID";
            gridView.Columns.Add(linkField);

            BoundField empNameField = new BoundField();
            empNameField.DataField = "Emp_Name";
            empNameField.HeaderText = "Emp_Name";
            gridView.Columns.Add(empNameField);

            BoundField empSalField = new BoundField();
            empSalField.DataField = "Emp_Sal";
            empSalField.HeaderText = "Emp_Sal";
            gridView.Columns.Add(empSalField);

            // Add GridView to the form controls
            this.form1.Controls.Add(gridView);

            // Bind data to the GridView
            gridView.DataBind();
        }
    }
}