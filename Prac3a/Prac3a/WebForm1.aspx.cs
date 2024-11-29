using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Prac3a
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        RadioButton Rb1,Rb2,Rb3;
        Button Button1;
        Label Lb1, Lb2, Lb3, Lb4,Lb5,Lb6;
        DropDownList DDL1;
        TextBox TB1;
        Literal ltr;

        protected void Page_Load(object sender, EventArgs e)
        {
            Lb1 = new Label();
            Lb1.Text = "Enter your name";
            this.form1.Controls.Add(Lb1);
            TB1 = new TextBox { ID = "TB1", AutoPostBack = true };
            TB1.TextChanged += TextBox2_TextChanged;
            this.form1.Controls.Add(TB1);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            Lb2 = new Label();
            Lb2.Text = "Choose course ";
            this.form1.Controls.Add(Lb2);

            DDL1 = new DropDownList { ID = "DDL1", AutoPostBack = true };
            DDL1.SelectedIndexChanged += DropDownList1_SelectedIndexChanged;
            this.form1.Controls.Add(DDL1);

            if (!IsPostBack)
            {
                DDL1.Items.Add("IT");
                DDL1.Items.Add("CS");
                DDL1.Items.Add("BSc");
                DDL1.Items.Add("BCom");
            }
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            Lb3 = new Label();
            Lb3.Text = "Choose Year ";
            this.form1.Controls.Add(Lb3);

            Rb1 = new RadioButton { ID = "RadioButton1", GroupName = "group", Text = "FY", AutoPostBack = true };
            Rb2 = new RadioButton { ID = "RadioButton2", GroupName = "group", Text = "SY", AutoPostBack = true };
            Rb3 = new RadioButton { ID = "RadioButton3", GroupName = "group", Text = "TY", AutoPostBack = true };
            this.form1.Controls.Add(Rb1);
            this.form1.Controls.Add(Rb2);
            this.form1.Controls.Add(Rb3);

            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            Button1 = new Button { ID = "Button1", Text = "Submit" };
            Button1.Click += Button1_Click;
            this.form1.Controls.Add(Button1);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            Lb6 = new Label();
            this.form1.Controls.Add(Lb6);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);
            Lb5 = new Label();
            this.form1.Controls.Add(Lb5);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);
            Lb4 = new Label();
            this.form1.Controls.Add(Lb4);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string selectedRadio = "";

            if (Rb1.Checked)
            {
                selectedRadio = Rb1.Text;
            }
            else if (Rb2.Checked)
            {
                selectedRadio = Rb2.Text;
            }
            else
            {
                selectedRadio = Rb3.Text;
            }

            Lb4.Text = "You selected " + selectedRadio;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lb5.Text = "You have been enrolled in " + DDL1.SelectedItem.Text;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            Lb6.Text = "Your name is " + TB1.Text;
        }
    }
}