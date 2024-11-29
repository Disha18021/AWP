using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2cc2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Button b1;
        Label lb1, lb2, lb3, lb4;
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
            ltr = new Literal();
            ltr.Text = "</br>";
            this.form1.Controls.Add(ltr);

            lb4 = new Label();
            this.form1.Controls.Add(lb4);
        }
        protected void b1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(tb1.Text);
                int num2 = int.Parse(tb2.Text);

                int result = num1 / num2;
                lb3.Text = "Result: " + num1 + " / " + num2 + " = " + result;
            }
            catch (DivideByZeroException)
            {
                // Handle division by zero
                lb3.Text = "Error: Cannot divide by zero!";
            }
            catch (FormatException)
            {
                // Handle invalid input
                lb3.Text = "Error: Please enter valid numbers.";
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                lb3.Text = "An unexpected error occurred: " + ex.Message ;
            }
            finally
            {
                // Code in this block always runs
                lb4.Text = "End of the program.";
            }
        }
    }
}