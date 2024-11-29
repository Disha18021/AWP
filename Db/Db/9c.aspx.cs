using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Db
{
    public partial class _9c : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Create the GridView dynamically
                GridView gridView1 = new GridView();
                gridView1.ID = "GridView1";
                gridView1.AllowPaging = true;
                gridView1.PageSize = 3;
                gridView1.AutoGenerateColumns = false;
                gridView1.DataSourceID = "SqlDataSource1"; // DataSource assigned to SQL DataSource

                // BoundField for Emp_ID with styling
                BoundField empIDField = new BoundField();
                empIDField.DataField = "Emp_ID";
                empIDField.HeaderText = "Emp_ID";
                empIDField.SortExpression = "Emp_ID";
                empIDField.HeaderStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFCCCC");
                empIDField.HeaderStyle.BorderColor = System.Drawing.ColorTranslator.FromHtml("#FF99FF");
                empIDField.HeaderStyle.BorderStyle = BorderStyle.Ridge;
                empIDField.HeaderStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6600FF");

                // BoundField for Emp_Name with styling
                BoundField empNameField = new BoundField();
                empNameField.DataField = "Emp_Name";
                empNameField.HeaderText = "Emp_Name";
                empNameField.SortExpression = "Emp_Name";
                empNameField.HeaderStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF33CC");
                empNameField.HeaderStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#CCFF99");

                // BoundField for Emp_Sal with formatting and styling
                BoundField empSalField = new BoundField();
                empSalField.DataField = "Emp_Sal";
                empSalField.HeaderText = "Emp_Sal";
                empSalField.SortExpression = "Emp_Sal";
                empSalField.DataFormatString = "{0:c}"; // Currency format
                empSalField.HeaderStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#3333FF");
                empSalField.HeaderStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFF66");

                // Add all columns to the GridView
                gridView1.Columns.Add(empIDField);
                gridView1.Columns.Add(empNameField);
                gridView1.Columns.Add(empSalField);

                // Create SqlDataSource dynamically
                SqlDataSource sqlDataSource1 = new SqlDataSource();
                sqlDataSource1.ID = "SqlDataSource1";
                sqlDataSource1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
                sqlDataSource1.SelectCommand = "SELECT * FROM [Emp_Table]";
                this.Page.Controls.Add(sqlDataSource1); // Add to the page

                // Add the GridView to the form
                form1.Controls.Add(gridView1);

                // Add the SqlDataSource to the page
                this.Page.Controls.Add(sqlDataSource1);
        }
    }
}