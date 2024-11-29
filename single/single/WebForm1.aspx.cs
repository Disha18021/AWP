using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace single
{
    public class Basec
    {
        
        public string Bm()
        {
            return "base class";
        }
    }

    public class Derived : Basec
    {
        public string Dm()
        {
            return "derived class";
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
            Basec b = new Basec();
            Derived d = new Derived();

            Response.Write("Calling Basec class: " + b.Bm() + "</br>");
            Response.Write("Calling Base class by Derived class: " + d.Bm() + "</br>");
            Response.Write("Calling Derived class: " + d.Dm() + "</br>");
        }
    }
}