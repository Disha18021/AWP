using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2a4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void B1_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(TB1.Text);
            double fahrenheit = (celsius * 9 / 5) + 32;
            Lb3.Text = fahrenheit.ToString();
            double kelvin = celsius + 273.15;
            Lb5.Text = kelvin.ToString();
        }
    }
}