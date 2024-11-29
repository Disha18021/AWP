//Prac9b
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Prac8c
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected GridView GridView1;
        protected Label Label1;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialize GridView and Label
            GridView1 = new GridView();
            GridView1.AutoGenerateColumns = false;
            GridView1.RowCommand += GridView1_RowCommand;

            // Create SqlDataSource dynamically
            SqlDataSource sqlDataSource = new SqlDataSource();
            sqlDataSource.ConnectionString = WebConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
            sqlDataSource.SelectCommand = "SELECT * FROM Emp_Table";

            // Bind GridView to SqlDataSource
            GridView1.DataSource = sqlDataSource;

            // Define BoundFields for GridView columns
            BoundField empIdField = new BoundField();
            empIdField.DataField = "Emp_ID";
            empIdField.HeaderText = "Emp_ID";
            GridView1.Columns.Add(empIdField);

            BoundField empNameField = new BoundField();
            empNameField.DataField = "Emp_Name";
            empNameField.HeaderText = "Emp_Name";
            GridView1.Columns.Add(empNameField);

            BoundField empSalField = new BoundField();
            empSalField.DataField = "Emp_Sal";
            empSalField.HeaderText = "Emp_Sal";
            GridView1.Columns.Add(empSalField);

            // Define TemplateField for the Button
            TemplateField buttonField = new TemplateField();
            buttonField.ItemTemplate = new GridViewButtonTemplate();
            GridView1.Columns.Add(buttonField);

            // Initialize and add Label control
            Label1 = new Label();
            Label1.Text = "Label";

            // Bind data and add controls to page
            GridView1.DataBind();
            form1.Controls.Add(GridView1);
            form1.Controls.Add(Label1);
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Show")
            {
                // Correctly retrieve the row index
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                string name = row.Cells[1].Text; // Emp_Name is in Cells[1]
                Label1.Text = "Name : " + name;
            }
        }

        // Template class for dynamic button field
        public class GridViewButtonTemplate : ITemplate
        {
            public void InstantiateIn(Control container)
            {
                Button showButton = new Button();
                showButton.Text = "Show";
                showButton.CommandName = "Show";
                showButton.DataBinding += (sender, e) =>
                {
                    Button btn = (Button)sender;
                    GridViewRow row = (GridViewRow)btn.NamingContainer;
                    btn.CommandArgument = row.RowIndex.ToString(); // Correctly bind the row index
                };
                container.Controls.Add(showButton);
            }
        }
    }
}