using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac3b1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected Calendar vacationCalendar;
        protected Label selectedDateLabel;
        protected Button confirmVacationButton;
        protected Label messageLabel;
        protected TextBox vacationDetailTextBox;
        protected Label vacationDetailLabel;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialize the Calendar control
            vacationCalendar = new Calendar
            {
                ID = "vacationCalendar",
                SelectionMode = CalendarSelectionMode.Day
            };
            vacationCalendar.SelectionChanged += new EventHandler(VacationCalendar_SelectionChanged);

            // Initialize the Label to display the selected date
            selectedDateLabel = new Label
            {
                ID = "selectedDateLabel",
                Text = "Select a date for your vacation."
            };

            // Initialize the TextBox for vacation details (destination, reason, etc.)
            vacationDetailTextBox = new TextBox
            {
                ID = "vacationDetailTextBox",
                TextMode = TextBoxMode.MultiLine,
                Rows = 3,
                Columns = 40,
                Text = "Enter your vacation details here..."
            };

            // Label for vacation details
            vacationDetailLabel = new Label
            {
                ID = "vacationDetailLabel",
                Text = "Vacation Details:"
            };

            // Initialize the Button to confirm the vacation date and details
            confirmVacationButton = new Button
            {
                ID = "confirmVacationButton",
                Text = "Confirm Vacation Date",
                Enabled = false // Initially disabled until a date is selected
            };
            confirmVacationButton.Click += new EventHandler(ConfirmVacationButton_Click);

            // Initialize the Label to display confirmation message
            messageLabel = new Label
            {
                ID = "messageLabel",
                Text = string.Empty
            };

            // Add controls to the page
            Form.Controls.Add(vacationCalendar);
            Form.Controls.Add(new LiteralControl("<br/>"));
            Form.Controls.Add(selectedDateLabel);
            Form.Controls.Add(new LiteralControl("<br/><br/>"));
            Form.Controls.Add(vacationDetailLabel);
            Form.Controls.Add(new LiteralControl("<br/>"));
            Form.Controls.Add(vacationDetailTextBox);
            Form.Controls.Add(new LiteralControl("<br/><br/>"));
            Form.Controls.Add(confirmVacationButton);
            Form.Controls.Add(new LiteralControl("<br/><br/>"));
            Form.Controls.Add(messageLabel);
        }

        // Event handler when the user selects a date on the calendar
        protected void VacationCalendar_SelectionChanged(object sender, EventArgs e)
        {
            selectedDateLabel.Text = "Selected Vacation Date: " + vacationCalendar.SelectedDate.ToShortDateString();
            confirmVacationButton.Enabled = true; // Enable the button once a date is selected
        }

        // Event handler when the confirm vacation button is clicked
        protected void ConfirmVacationButton_Click(object sender, EventArgs e)
        {
            string vacationDetails = vacationDetailTextBox.Text;
            messageLabel.Text = "Your vacation has been confirmed for: " + vacationCalendar.SelectedDate.ToShortDateString() + "<br/>" +
                                "Details: " + vacationDetails;
        }
    }
}


