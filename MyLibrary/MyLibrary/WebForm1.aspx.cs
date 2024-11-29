/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyLibrary
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}*/
using System;
using MyLibrary;  // Import the DLL namespace

namespace MyLibrary
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);
            MathOperations math = new MathOperations();
            int result = math.Add(num1, num2);
            LabelResult.Text = "Addition Result: " + result.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);
            MathOperations math = new MathOperations();
            int result = math.Subtract(num1, num2);
            LabelResult.Text = "Subtraction Result: " + result.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);
            MathOperations math = new MathOperations();
            int result = math.Multiply(num1, num2);
            LabelResult.Text = "Multiplication Result: " + result.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);
            MathOperations math = new MathOperations();
            try
            {
                double result = math.Divide(num1, num2);
                LabelResult.Text = "Division Result: " + result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                LabelResult.Text = ex.Message;
            }
        }
    }
}
