using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2b3
{
    class ADD
    {
        int x, y;
        double f;
        string s;

        public ADD(int a, double b)
        {
            x = a;
            f = b;
        }

        public ADD(int a, string b)
        {
            y = a;
            s = b;
        }

        public void show(Label Lb5)
        {
            Lb5.Text="1st constructor (int + double): " + (x + f) ;
        }

        public void show1(Label Lb6)
        {
            Lb6.Text="2nd constructor (int + string): "+ (s + y);
        }
    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        Label Lb1, Lb2, Lb3, Lb4, Lb5, Lb6;
        TextBox TB1, TB2, TB3, TB4;
        Button Bt1;
        Literal ltr;

        protected void Page_Load(object sender, EventArgs e)
        {
            Lb1 = new Label();
            Lb1.Text="Enter an integer value: ";
            this.form1.Controls.Add(Lb1);

            TB1 = new TextBox();
            this.form1.Controls.Add(TB1);

            Lb2 = new Label();
            Lb2.Text = "Enter a double value: ";
            this.form1.Controls.Add(Lb2);

            TB2 = new TextBox();
            this.form1.Controls.Add(TB2);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            Lb3 = new Label();
            Lb3.Text = "Enter another integer value: ";
            this.form1.Controls.Add(Lb3);

            TB3 = new TextBox();
            this.form1.Controls.Add(TB3);

            Lb4 = new Label();
            Lb4.Text = "Enter a string value:  ";
            this.form1.Controls.Add(Lb4);

            TB4 = new TextBox();
            this.form1.Controls.Add(TB4);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            Bt1 = new Button();
            Bt1.Text = "Result";
            Bt1.Click += Bt1_Click;
            this.form1.Controls.Add(Bt1);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            Lb5 = new Label();
            this.form1.Controls.Add(Lb5);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            Lb6 = new Label();
            this.form1.Controls.Add(Lb6);
        }
        protected void Bt1_Click(object sender, EventArgs e)
        {
            int intInput = Convert.ToInt32(TB1.Text);

            double doubleInput = Convert.ToDouble(TB2.Text);

            ADD g = new ADD(intInput, doubleInput);
            g.show(Lb5);

            int intInput2 = Convert.ToInt32(TB3.Text);

            string stringInput = Convert.ToString(TB4.Text);

            ADD q = new ADD(intInput2, stringInput);
            q.show1(Lb6);
        }
    }
}