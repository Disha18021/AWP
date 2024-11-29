using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2b4
{
    interface ICalculator
    {
        int Add(int a, int b);
    }

    class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    
    public partial class WebForm1 : System.Web.UI.Page
    {
        Label lb1, lb2, lb3;
        TextBox TB1, TB2;
        Button b1;
        Literal ltr;
        protected void Page_Load(object sender, EventArgs e)
        {
            lb1 = new Label();
            lb1.Text = "Enter the first number: ";
            this.form1.Controls.Add(lb1);
            
            TB1 = new TextBox();
            this.form1.Controls.Add(TB1);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            lb2 = new Label();
            lb2.Text = "Enter the second number: ";
            this.form1.Controls.Add(lb2);
            TB2 = new TextBox();
            this.form1.Controls.Add(TB2);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            b1 = new Button();
            b1.Text = "Result";
            b1.Click += b1_Click;
            this.form1.Controls.Add(b1);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            lb3 = new Label();
            lb3.Text = " ";
            this.form1.Controls.Add(lb3);
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            int number1 = System.Convert.ToInt32(TB1.Text);
            int number2 = System.Convert.ToInt32(TB2.Text);

            ICalculator calculator = new Calculator();
            int result = calculator.Add(number1, number2);
            lb3.Text="The sum of "+ number1+" and "+ number2 + " is: " +result;
        }

    }
}