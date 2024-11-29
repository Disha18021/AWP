using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac1d1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void B1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 1, c;
            string s;
            int end = System.Convert.ToInt32(TB1.Text);
            s = System.Convert.ToString(a + " " + b );
            for (int i = 2; i < end; i++)
            {
                c = a + b ;
                s = System.Convert.ToString(s + " " + c);
                a = b;
                b = c;
            }
            Lb2.Text = s;
        }
    }
}