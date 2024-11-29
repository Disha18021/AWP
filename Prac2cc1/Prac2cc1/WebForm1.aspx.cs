using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2cc1
{
    public delegate void MathOperationEventHandler(int a, int b);

    public class Calculator
    {
        // Declare events for addition and subtraction
        public event MathOperationEventHandler OnAdd;

        // Method to trigger addition event
        public void Add(int a, int b)
        {
            if (OnAdd != null)
            {
                OnAdd(a, b);
            }
        }
    }

    public class MathHandler
    {
        // Event handler for addition
        public void HandleAddition(int a, int b,Label lb3)
        {
            lb3.Text= "Addition: " + a + " + " + b + " = " + (a+b) ;
        }
    }

    public partial class WebForm1 : System.Web.UI.Page
    {
        Button b1;
        Label lb1, lb2, lb3;
        TextBox tb1, tb2;
        Literal ltr;

        protected void Page_Load(object sender, EventArgs e)
        {
            lb1 = new Label();
            lb1.Text = "Enter first number: ";
            this.form1.Controls.Add(lb1);

            tb1 = new TextBox();
            this.form1.Controls.Add(tb1);
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            lb2 = new Label();
            lb2.Text = "Enter second number: ";
            this.form1.Controls.Add(lb2);

            tb2 = new TextBox();
            this.form1.Controls.Add(tb2);
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
            this.form1.Controls.Add(lb3);

        }

        protected void b1_Click(object sender, EventArgs e)
        {

            Calculator calculator = new Calculator();
            MathHandler handler = new MathHandler();

            calculator.OnAdd += (int a,int b) => handler.HandleAddition( a, b, lb3);

            int num1 = int.Parse(tb1.Text);
            int num2 = int.Parse(tb2.Text);

            calculator.Add(num1, num2);
        }
    }
}