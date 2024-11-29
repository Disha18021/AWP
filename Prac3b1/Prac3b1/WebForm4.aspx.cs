using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac3b1
{
    public partial class WebForm4: System.Web.UI.Page
    {
        Calendar calendar;
        TextBox txtSecondDate;
        Label lblDateDifference;
        Button btnCalculateDifference;

        protected void Page_Init(object sender, EventArgs e)
        {
            // Initialize the Calendar control dynamically
            calendar = new Calendar();
            this.Form.Controls.Add(calendar);

            // TextBox for the user to enter a second date
            txtSecondDate = new TextBox();
            txtSecondDate.Attributes.Add("placeholder", "Enter second date (DD/MM/YYYY)");
            this.Form.Controls.Add(txtSecondDate);

            // Button to calculate the difference between two dates
            btnCalculateDifference = new Button();
            btnCalculateDifference.Text = "Calculate Date Difference";
            btnCalculateDifference.Click += new EventHandler(btnCalculateDifference_Click);
            this.Form.Controls.Add(btnCalculateDifference);

            // Label to display the date difference result
            lblDateDifference = new Label();
            lblDateDifference.Text = "<br/>Date Difference: Not Calculated<br/>";
            this.Form.Controls.Add(lblDateDifference);
        }

        // Method to calculate the difference between two dates
        protected void btnCalculateDifference_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = calendar.SelectedDate;
            DateTime secondDate;

            if (DateTime.TryParse(txtSecondDate.Text, out secondDate))
            {
                TimeSpan difference = secondDate - selectedDate;
                lblDateDifference.Text = "<br/>Difference: " + Math.Abs(difference.Days) + " day(s)";
            }
            else
            {
                lblDateDifference.Text = "<br/>Invalid date format!";
            }
        }
    }
}