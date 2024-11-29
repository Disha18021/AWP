using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multilevel
{
    class A
    {
        public string Show()
        {
            string s = "first base class";
            return s;
        }
    }

    class B : A
    {
        public string Show1()
        {
            string p = "first derived class";
            return p;
        }
    }

    class C : B
    {
        public string Show2()
        {
            string g = "second derived class";
            return g;
        }
    }

    public partial class WebForm1 : System.Web.UI.Page
    {
        Button b1;
        protected void Page_Load(object sender, EventArgs e)
        {
            b1 = new Button();
            b1.Text = "Click";
            b1.Click += b1_Click;
            this.form1.Controls.Add(b1);
        }
        protected void b1_Click(object sender, EventArgs e)
        {
            C obj = new C();
            Response.Write(obj.Show() + "</br>" );
            Response.Write(obj.Show1() + "</br>" );
            Response.Write(obj.Show2() + "</br>");
        }
    }
}