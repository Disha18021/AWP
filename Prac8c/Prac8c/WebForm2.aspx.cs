//Prac8a
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Prac8c
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection scon;
        TextBox txtEmpId, txtEmpName, txtEmpSal;
        Button btnAdd;
        Label lblResult;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Create Label and TextBox for Emp_ID
            CreateLabel("Emp_ID");
            txtEmpId = new TextBox();
            this.form1.Controls.Add(txtEmpId);

            // Line break
            this.form1.Controls.Add(new Literal { Text = "<br/><br/>" });

            // Create Label and TextBox for Emp_Name
            CreateLabel("Emp_Name");
            txtEmpName = new TextBox();
            this.form1.Controls.Add(txtEmpName);

            // Line break
            this.form1.Controls.Add(new Literal { Text = "<br/><br/>" });

            // Create Label and TextBox for Emp_Sal
            CreateLabel("Emp_Salary");
            txtEmpSal = new TextBox();
            this.form1.Controls.Add(txtEmpSal);

            // Line break
            this.form1.Controls.Add(new Literal { Text = "<br/><br/>" });

            // Create Add Button
            btnAdd = new Button();
            btnAdd.Text = "Add Employee";
            btnAdd.Click += btnAdd_Click;
            this.form1.Controls.Add(btnAdd);

            // Line break
            this.form1.Controls.Add(new Literal { Text = "<br/><br/>" });

            // Create Label for showing result
            lblResult = new Label();
            this.form1.Controls.Add(lblResult);
        }

        // Helper function to create labels dynamically
        private void CreateLabel(string labelText)
        {
            Label lbl = new Label();
            lbl.Text = labelText + ": ";
            this.form1.Controls.Add(lbl);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            scon = new SqlConnection();
            String constr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
            scon.ConnectionString = constr;

            using (scon)
            {
                scon.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ETable (Eid, Ename, Esal) VALUES (@Eid, @Ename, @Esal)", scon);
                cmd.Parameters.AddWithValue("@Eid", txtEmpId.Text);
                cmd.Parameters.AddWithValue("@Ename", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@Esal", txtEmpSal.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                scon.Close();

                // Show result
                if (rowsAffected > 0)
                {
                    lblResult.Text = "Employee added successfully!";
                }
                else
                {
                    lblResult.Text = "Failed to add employee.";
                }

                // Clear textboxes
                txtEmpId.Text = "";
                txtEmpName.Text = "";
                txtEmpSal.Text = "";
            }
        }
    }
}