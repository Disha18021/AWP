using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac4c
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        PlaceHolder PlaceHolder;
        protected void Page_Load(object sender, EventArgs e)
        {
            var userControl = Page.LoadControl("~/WebUserControl1.ascx");

            PlaceHolder = new PlaceHolder();
            PlaceHolder.Controls.Add(userControl);

            form1.Controls.Add(PlaceHolder);
        }
    }
}