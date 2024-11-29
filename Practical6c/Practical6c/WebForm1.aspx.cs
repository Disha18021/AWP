using System;
using System.Data;
using System.Data.SqlClient;

namespace Practical6c
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDataList();
            }
        }

        private void BindDataList()
        {
            // Connection string defined here in the code-behind instead of web.config
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=databaseDB;Integrated Security=True";

            // SQL query to retrieve data from the table
            string query = "SELECT ID, Name, Age FROM [Table1]";

            // Create a connection and command
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    // Create a data adapter
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    // Fill the DataTable with the query result
                    da.Fill(dt);

                    // Bind the DataList to the DataTable
                    DataList1.DataSource = dt;
                    DataList1.DataBind();
                }
            }
        }
    }
}