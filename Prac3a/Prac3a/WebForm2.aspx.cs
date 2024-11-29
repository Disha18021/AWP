using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac3a
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Label lbl1, rb1;
        DropDownList ddl;
        RadioButtonList radiob1;
        Label chklbl, dlbl;
        CheckBoxList chk1;
        protected void Page_Load(object sender, EventArgs e)
        {
            //-----TEXTBOX-----
            TextBox txt1 = new TextBox();

            txt1.ID = "textbox1";
            txt1.Attributes["placeholder"] = "Enter Email";
            txt1.TextMode = TextBoxMode.SingleLine;  
            txt1.AutoPostBack = true;  
            txt1.MaxLength = 300;
            txt1.Width = 100;
            txt1.ToolTip = "Please enter your email";  
            txt1.Enabled = true;  
            txt1.Visible = true;  
            txt1.Text = "";  

            form1.Controls.Add(txt1);  // form1 is the ID of the form

            this.form1.Controls.Add(new LiteralControl("<br /> <br />"));

            //-----RADIOBUTTONLIST-----
            lbl1 = new Label();
            lbl1.ID = "lbl1";
            lbl1.Text = "Gender";
            form1.Controls.Add(lbl1);

            radiob1 = new RadioButtonList();
            radiob1.ID = "radiobl";
            radiob1.AutoPostBack = true;
            radiob1.Font.Bold = true;
            radiob1.Font.Size = FontUnit.Large;
            radiob1.Enabled = true;

            ListItem ltI = new ListItem("Male", "1");
            radiob1.Items.Add(ltI);
            //radiob1.Items.Add(new ListItem("Male", "1"));
            radiob1.Items.Add(new ListItem("Female", "2"));
            radiob1.SelectedIndexChanged += new EventHandler(RadioButtonList_SelectedIndexChanged);
            form1.Controls.Add(radiob1);

            rb1 = new Label();
            rb1.ID = "rb1";
            form1.Controls.Add(rb1);

            this.form1.Controls.Add(new LiteralControl("<br /> <br />"));

            //------CHECKBOXLIST------
            Label lbl3 = new Label();
            lbl3.Text = "Select your Fav Language";

            chk1 = new CheckBoxList();
            chk1.AutoPostBack = true;
            chk1.Enabled = true;
            chk1.Attributes.Add("style", "text-align:right;");
            chk1.ViewStateMode = ViewStateMode.Enabled;

            chk1.Items.Add(new ListItem("Python", "0"));
            chk1.Items.Add(new ListItem("R", "1"));
            chk1.Items.Add(new ListItem("C#", "2"));
            chk1.Items.Add(new ListItem("C++", "3"));

            this.form1.Controls.Add(lbl3);
            this.form1.Controls.Add(chk1);

            Button btn1 = new Button();
            btn1.ID = "btn";
            btn1.Text = "Click";
            btn1.Visible = true;
            btn1.Click += new EventHandler(Button1_Click);
            this.form1.Controls.Add(btn1);

            this.form1.Controls.Add(new LiteralControl("<br />"));

            chklbl = new Label();
            chklbl.ID = "chklbl";
            this.form1.Controls.Add(chklbl);

            this.form1.Controls.Add(new LiteralControl("<br /> <br />"));

            //------DROPDOWNLIST------
            ddl = new DropDownList();
            ddl.ID = "DDL1";
            ddl.AutoPostBack = true;
            //ddl.EnableViewState = true;
            ddl.Enabled = true;
            ddl.Width = 150;

            ddl.Items.Add(new ListItem("Select your Country", "0"));
            ddl.Items.Add(new ListItem("India", "1"));
            ddl.Items.Add(new ListItem("South Korea", "2"));
            ddl.Items.Add(new ListItem("USA", "3"));

            ddl.SelectedIndexChanged += new EventHandler(DropDownList1_SelectedIndexChanged);
            this.form1.Controls.Add(ddl);

            this.form1.Controls.Add(new LiteralControl("<br /> <br />"));

            dlbl = new Label();
            dlbl.ID = "dlbl";
            this.form1.Controls.Add(dlbl);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (chklbl != null)
            {
                chklbl.Text = "You SELECTED: "; // Initialize the label text

                // Loop through CheckBoxList to get all selected items
                foreach (ListItem item in chk1.Items)
                {
                    if (item.Selected)
                    {
                        chklbl.Text += item.Text + " "; // Append selected items to the label
                    }
                }
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dlbl != null)
            {
                dlbl.Text = "YOU SELECTED: " + ddl.SelectedItem.Text;
            }

        }
        protected void RadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb1 != null)
            {
                rb1.Text = "Selected Gender: " + radiob1.SelectedItem.Text;
            }
        }
    }
}