using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac1a
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TextBox2.Text);
            int b = Convert.ToInt32(TextBox3.Text);
            int c = Convert.ToInt32(TextBox4.Text);
            int d = Convert.ToInt32(TextBox5.Text);
            int Result = a * b * c * d;
            TextBox6.Text = Result.ToString();
        }

    }
}