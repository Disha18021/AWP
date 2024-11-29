using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultipleInheritance
{
    interface A
    {
        string Method1();
    }

    interface B
    {
        string Method2();
    }

    public class C : A, B
    {
        public string Method1()
        {
            string s = "Method1 is called.";
            return s;
        }
        public string Method2()
        {
            string p = "Method2 is called. ";
            return p;
        }
    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        Button b1;
        protected void Page_Load(object sender, EventArgs e)
        {
            b1 = new Button();
            b1.Click += button_1;
            b1.Text = "click";
            this.form1.Controls.Add(b1);

        }
        protected void button_1(object sender, EventArgs e)
        {
            C obj = new C();
            Response.Write(obj.Method1() + "</br>");
            Response.Write(obj.Method2());

        }
    }
}