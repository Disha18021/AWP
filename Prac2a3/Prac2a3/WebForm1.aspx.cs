using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2a3
{

    public partial class WebForm1 : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Enter coefficients (a, b, c) of the quadratic equation ax^2 + bx + c:");
        	int a = Convert.ToInt32(TextBox1.Text);
        	int b = Convert.ToInt32(TextBox2.Text);
        	int c = Convert.ToInt32(TextBox3.Text);

            if (a == 0)
            {
                Lb4.Text = "Invalid: 'a' cannot be zero in a quadratic equation.";
                return;
            }

            int d = b * b - 4 * a * c;
            double sqrt_val = Math.Sqrt(Math.Abs(d));

            if (d > 0)
            {
                double n= ((-b + sqrt_val) / (2 * a));
                double m= ((-b - sqrt_val) / (2 * a));
                string s = Convert.ToString("Roots are real and different :\n" + n + "\n<br/>" + m);
                Lb4.Text = s;
                //TextBox4.Text = "Roots are real and different:";
                //Console.WriteLine((-b + sqrt_val) / (2 * a));
                //Console.WriteLine((-b - sqrt_val) / (2 * a));
            }
            else if (d == 0)
            {
                Lb4.Text = "Roots are real and same:";
                Console.WriteLine(-b / (2.0 * a));
            }
            else
            {
                double realPart = -b / (2.0 * a);
                double imaginaryPart = sqrt_val / (2 * a);
                string x = Convert.ToString("Roots are comple x:  \n " + realPart + " + " + imaginaryPart + "i \n <br/>   " + realPart + " - " + imaginaryPart + "i");
                Lb4.Text = x;
                //TextBox4.Text = "Roots are complex:\n" ;
                //TextBox4.Text = realPart + " + " + imaginaryPart + "i\n";
                //TextBox4.Text = realPart + " - " + imaginaryPart + "i";
            }
	        // Function call
        	//findRoots(a, b, c);

        }
    }
}