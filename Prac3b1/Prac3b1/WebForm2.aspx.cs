using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac3b1
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class WebForm2 : System.Web.UI.Page
    {
        Calendar calendar;
        DateTime[] vacationDates = { new DateTime(2024, 9, 10), new DateTime(2024, 12, 25), new DateTime(2024, 1, 1) };

        protected void Page_Init(object sender, EventArgs e)
        {
            // Initialize the Calendar control dynamically
            calendar = new Calendar();
            calendar.DayRender += new DayRenderEventHandler(Calendar1_DayRender);
            this.Form.Controls.Add(calendar);
        }

        // Method to highlight vacation days
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            foreach (DateTime vacation in vacationDates)
            {
                if (e.Day.Date == vacation)
                {
                    e.Cell.BackColor = System.Drawing.Color.LightCoral;
                    //e.Cell.ToolTip = "Vacation Day!";
                    e.Cell.Controls.Add(new LiteralControl("<br/>Vacation"));
                }
            }
        }
    }
}
