using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac3b1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Calendar calendar;
        Label lblSelectedDate;

        protected void Page_Init(object sender, EventArgs e)
        {
            // Initialize the Calendar control dynamically
            calendar = new Calendar();
            calendar.SelectionChanged += new EventHandler(Calendar1_SelectionChanged);

            // Define SelectedDayStyle properties
            calendar.SelectedDayStyle.BackColor = System.Drawing.Color.LightBlue;
            calendar.SelectedDayStyle.ForeColor = System.Drawing.Color.White;
            calendar.SelectedDayStyle.Font.Bold = true;

            this.Form.Controls.Add(calendar);

            // Label to display the selected date
            lblSelectedDate = new Label();
            lblSelectedDate.Text = "<br/>Selected Date: None<br/>";
            this.Form.Controls.Add(lblSelectedDate);
        }

        // Method to handle day selection
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblSelectedDate.Text = "<br/>You selected: " + calendar.SelectedDate.ToString("D");
        }
    }
}

