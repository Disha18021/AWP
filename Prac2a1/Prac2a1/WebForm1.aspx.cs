using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2a1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        public static int factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * factorial(n - 1);
        }
            
        protected void Bt1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TB1.Text);
            string s;
            s = Convert.ToString("Factorial of " + num + " is " + factorial(num));
            Lb2.Text = s;
        }
    }
}