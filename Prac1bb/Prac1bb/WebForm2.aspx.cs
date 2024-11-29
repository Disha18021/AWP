using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*namespace Prac1bb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Web.UI;
using System.Web.UI.WebControls;*/

namespace Prac1bb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        // Controls
        private TextBox inputTextBox;
        private Button processButton;
        private Label outputLabel;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Dynamically create and configure controls
            inputTextBox = new TextBox();
            inputTextBox.ID = "inputTextBox";
            inputTextBox.Width = 200;
            this.form1.Controls.Add(inputTextBox);  // Add to form

            // Add a line break for better formatting
            this.form1.Controls.Add(new LiteralControl("<br /><br />"));

            processButton = new Button();
            processButton.ID = "processButton";
            processButton.Text = "Perform String Operations";
            processButton.Click += new EventHandler(ProcessButton_Click);  // Assign event handler
            this.form1.Controls.Add(processButton);  // Add to form

            // Add a line break for better formatting
            this.form1.Controls.Add(new LiteralControl("<br /><br />"));

            outputLabel = new Label();
            outputLabel.ID = "outputLabel";
            outputLabel.Text = "Results will appear here.";
            outputLabel.Font.Bold = true;
            this.form1.Controls.Add(outputLabel);  // Add to form

            // Ensure the controls persist across postbacks
            if (!IsPostBack)
            {
                outputLabel.Text = "Results will appear here.";
            }
        }

        // Button click event handler
        protected void ProcessButton_Click(object sender, EventArgs e)
        {
            // Get the input string from the TextBox
            string inputString = inputTextBox.Text;

            // Perform string operations
            PerformStringOperations(inputString);
        }

        // Method to perform string operations
        private void PerformStringOperations(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                outputLabel.Text = "Please enter a valid string.";
                return;
            }

            // Sorting
            char[] sortedArray = str.ToCharArray();
            Array.Sort(sortedArray);
            string sorted = new string(sortedArray);

            // Reversing
            char[] reversedArray = str.ToCharArray();
            Array.Reverse(reversedArray);
            string reversed = new string(reversedArray);

            // Last Index Of 'o' (you can change the character)
            int lastIndex = str.LastIndexOf('o'); // Change 'o' as needed

            // Length of the string
            int length = str.Length;

            // Copy the string
            string copied = string.Copy(str);

            // Display the results in the output label
            outputLabel.Text = "<b>Sorting:</b>" + sorted + "<br />" +
                               "<b>Reversing:</b>" + reversed + "<br />" +
                               "<b>Last Index Of 'o':</b>" + lastIndex + "<br />" +
                               "<b>Length:</b>" + length + "<br />" +
                               "<b>Copy:</b>" + copied ;
        }
    }
}
