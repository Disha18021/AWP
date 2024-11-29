using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace Prac3b1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Calendar calendar;
        Label lblMessage;
        TextBox txtMessage;
        Button btnSubmit;
        Dictionary<DateTime, string> messages; // Dictionary to store messages for specific dates

        protected void Page_Init(object sender, EventArgs e)
        {
            // Initialize the Calendar control dynamically
            calendar = new Calendar();
            calendar.DayRender += new DayRenderEventHandler(Calendar1_DayRender);
            calendar.SelectionChanged += new EventHandler(Calendar_SelectionChanged);
            this.Form.Controls.Add(calendar);

            // TextBox for user to enter a message
            txtMessage = new TextBox();
            this.Form.Controls.Add(txtMessage);

            // Button to submit the message
            btnSubmit = new Button();
            btnSubmit.Text = "Submit Message";
            btnSubmit.Click += new EventHandler(BtnSubmit_Click);
            this.Form.Controls.Add(btnSubmit);

            // Label to display messages
            lblMessage = new Label();
            lblMessage.Text = "<br/>";
            this.Form.Controls.Add(lblMessage);

            // Initialize the dictionary to store messages for dates
            if (ViewState["Messages"] == null)
            {
                messages = new Dictionary<DateTime, string>();
                ViewState["Messages"] = messages;
            }
            else
            {
                messages = (Dictionary<DateTime, string>)ViewState["Messages"];
            }
        }

        // Event handler for submitting a message
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (calendar.SelectedDate != DateTime.MinValue && !string.IsNullOrEmpty(txtMessage.Text))
            {
                // Add or update the message for the selected date
                messages[calendar.SelectedDate] = txtMessage.Text;
                ViewState["Messages"] = messages; // Update ViewState
                lblMessage.Text = "Message added for " + calendar.SelectedDate.ToShortDateString() + ": " + txtMessage.Text;
            }
            else
            {
                lblMessage.Text = "Please select a date and enter a message.";
            }
        }

        // Method to display messages on the calendar
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            // Check if there is a message for this date
            if (messages.ContainsKey(e.Day.Date))
            {
                e.Cell.Controls.Add(new LiteralControl("<br/>" + messages[e.Day.Date]));
                e.Cell.BackColor = System.Drawing.Color.LightBlue; // Highlight the date where message is added
            }
        }

        // Event handler for calendar date selection
        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            // Display selected date to user
            lblMessage.Text = "Selected Date: " + calendar.SelectedDate.ToShortDateString();
        }
    }
}
