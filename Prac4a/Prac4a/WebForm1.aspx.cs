using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac4a
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Label lbll;
        protected void Page_Load(object sender, EventArgs e)
        {
            //-----USERNAME-------
            Label lblusername = new Label();
            lblusername.ID = "lbl1";
            lblusername.Text = "Enter Name";
            this.form1.Controls.Add(lblusername);

            TextBox txt1 = new TextBox();
            txt1.ID = "txt1";
            txt1.Text = "";
            this.form1.Controls.Add(txt1);

            RequiredFieldValidator requsername = new RequiredFieldValidator();
            requsername.ControlToValidate = "txt1";
            requsername.ErrorMessage = "UserName is Required!!";
            requsername.ForeColor = System.Drawing.Color.Red;
            form1.Controls.Add(requsername);

            this.form1.Controls.Add(new LiteralControl("<br /><br />"));

            //--------EMAIL-----------
            Label lblemail = new Label();
            lblemail.ID = "lbl2";
            lblemail.Text = "Enter Email";
            this.form1.Controls.Add(lblemail);

            TextBox txt2 = new TextBox();
            txt2.ID = "txt2";
            txt2.Text = "";
            this.form1.Controls.Add(txt2);

            RequiredFieldValidator reqEmail = new RequiredFieldValidator();
            reqEmail.ControlToValidate = "txt2";
            reqEmail.ErrorMessage = "E-MAIL is Required!!";
            reqEmail.ForeColor = System.Drawing.Color.Red;
            form1.Controls.Add(reqEmail);

            this.form1.Controls.Add(new LiteralControl("<br /><br />"));

            RegularExpressionValidator regexEmail = new RegularExpressionValidator();
            regexEmail.ControlToValidate = "txt2";
            regexEmail.ErrorMessage = "Enter a Valid Email Address!!";
            regexEmail.ValidationExpression = @"\w+@\w+\.\w+";
            regexEmail.ForeColor = System.Drawing.Color.Red;
            form1.Controls.Add(regexEmail);

            this.form1.Controls.Add(new LiteralControl("<br /><br />"));

            //--------PASSWORD--------
            Label lblpassword = new Label();
            lblpassword.Text = "Password";
            form1.Controls.Add(lblpassword);

            TextBox txt3 = new TextBox();
            txt3.ID = "txt3";
            txt3.TextMode = TextBoxMode.Password;
            form1.Controls.Add(txt3);

            RequiredFieldValidator reqPassword = new RequiredFieldValidator();
            reqPassword.ControlToValidate = "txt3";
            reqPassword.ErrorMessage = "PASSWORD is Required!!";
            reqPassword.ForeColor = System.Drawing.Color.Red;
            form1.Controls.Add(reqPassword);

            this.form1.Controls.Add(new LiteralControl("<br /><br />"));

            //---------CONFIRM PASSWORD-----------
            Label lblCpassword = new Label();
            lblCpassword.Text = "Confirm Password";
            form1.Controls.Add(lblCpassword);

            TextBox txt4 = new TextBox();
            txt4.ID = "txt4";
            txt4.TextMode = TextBoxMode.Password;
            form1.Controls.Add(txt4);

            CompareValidator Cpassword = new CompareValidator();
            Cpassword.ControlToValidate = "txt4";
            Cpassword.ControlToCompare = "txt3";
            Cpassword.ErrorMessage = "Password do not Match!!";
            Cpassword.ForeColor = System.Drawing.Color.Red;
            form1.Controls.Add(Cpassword);

            this.form1.Controls.Add(new LiteralControl("<br /><br />"));

            //---------AGE----------
            Label lblAge = new Label();
            lblAge.Text = "Age";
            form1.Controls.Add(lblAge);

            TextBox txt5 = new TextBox();
            txt5.ID = "txt5";
            form1.Controls.Add(txt5);

            RequiredFieldValidator reqAge = new RequiredFieldValidator();
            reqAge.ControlToValidate = "txt5";
            reqAge.ErrorMessage = "Age is required!";
            reqAge.ForeColor = System.Drawing.Color.Red;
            form1.Controls.Add(reqAge);

            RangeValidator rangeAge = new RangeValidator();
            rangeAge.ControlToValidate = "txt5";
            rangeAge.MinimumValue = "18";
            rangeAge.MaximumValue = "100";
            rangeAge.Type = ValidationDataType.Integer;
            rangeAge.ErrorMessage = "Age must be between 18 to 100";
            rangeAge.ForeColor = System.Drawing.Color.Red;
            form1.Controls.Add(rangeAge);

            this.form1.Controls.Add(new LiteralControl("<br /><br />"));

            //-------------Button---------------
            Button btn = new Button();
            btn.ID = "btnSubmit";
            btn.Text = "Register";
            btn.Click += new EventHandler(SubmitForm);
            form1.Controls.Add(btn);

            this.form1.Controls.Add(new LiteralControl("<br /><br />"));

           // lbll = new Label();
           // lbll.ID = "lbl";
           // form1.Controls.Add(lbll);

        }

        protected void SubmitForm(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Write("Registration successful!");
            }
            
        }
    }
}