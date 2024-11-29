using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*namespace Prac1c
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Web.UI;
using System.Web.UI.WebControls;*/

namespace Prac1c
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // Enum for course names
        public enum CourseName
        {
            Mathematics = 1,
            Science = 2,
            History = 3
        }

        // Fields to hold student data
        private string studentId;
        private string studentName;
        private CourseName studentCourse;
        private DateTime studentDateOfBirth;


        protected void Page_Load(object sender, EventArgs e)
        {
            // Create and configure controls
            Label idLabel = new Label();
            idLabel.Text = "Student ID:";
            idLabel.ID = "idLabel";
            this.form1.Controls.Add(idLabel);

            TextBox idTextBox = new TextBox();
            idTextBox.ID = "idTextBox";
            this.form1.Controls.Add(idTextBox);

            Label nameLabel = new Label();
            nameLabel.Text = "Student Name:";
            nameLabel.ID = "nameLabel";
            this.form1.Controls.Add(nameLabel);

            TextBox nameTextBox = new TextBox();
            nameTextBox.ID = "nameTextBox";
            this.form1.Controls.Add(nameTextBox);

            Label courseLabel = new Label();
            courseLabel.Text = "Course Name:";
            courseLabel.ID = "courseLabel";
            this.form1.Controls.Add(courseLabel);

            DropDownList courseDropDownList = new DropDownList();
            courseDropDownList.ID = "courseDropDownList";

            // Populate DropDownList with enum values
            foreach (CourseName course in Enum.GetValues(typeof(CourseName)))
            {
                courseDropDownList.Items.Add(new ListItem(course.ToString(), ((int)course).ToString()));
            }
            this.form1.Controls.Add(courseDropDownList);

            Label dobLabel = new Label();
            dobLabel.Text = "Date of Birth (yyyy-mm-dd):";
            dobLabel.ID = "dobLabel";
            this.form1.Controls.Add(dobLabel);

            TextBox dobTextBox = new TextBox();
            dobTextBox.ID = "dobTextBox";
            this.form1.Controls.Add(dobTextBox);

            Button collectButton = new Button();
            collectButton.Text = "Collect Data";
            collectButton.Click += new EventHandler(collectButton_Click);
            collectButton.ID = "collectButton";
            this.form1.Controls.Add(collectButton);

            Label studentInfoLabel = new Label();
            studentInfoLabel.ID = "studentInfoLabel";
            this.form1.Controls.Add(studentInfoLabel);
        }

        protected void collectButton_Click(object sender, EventArgs e)
        {
            // Find controls
            TextBox idTextBox = (TextBox)this.FindControl("idTextBox");
            TextBox nameTextBox = (TextBox)this.FindControl("nameTextBox");
            DropDownList courseDropDownList = (DropDownList)this.FindControl("courseDropDownList");
            TextBox dobTextBox = (TextBox)this.FindControl("dobTextBox");
            //Label studentInfoLabel = (Label)this.FindControl("studentInfoLabel");

            // Collect Student ID
            studentId = idTextBox.Text;

            // Collect Student Name
            studentName = nameTextBox.Text;

            // Collect Course Name
            studentCourse = (CourseName)Enum.Parse(typeof(CourseName), courseDropDownList.SelectedValue);

            // Collect Date of Birth
            studentDateOfBirth = DateTime.Parse(dobTextBox.Text);

            //DisplayStudent();
        //}

        //private void DisplayStudent()
        //{
            // Find the studentInfoLabel control
            Label studentInfoLabel = (Label)this.FindControl("studentInfoLabel");

            // Display student information in the label
            studentInfoLabel.Text = "Student Information:<br />" +
                                    "ID: " + studentId + "<br />" +
                                    "Name: " + studentName + "<br />" +
                                    "Course: " + studentCourse + "<br />" +
                                    "Date of Birth: " + studentDateOfBirth.ToShortDateString();
        }
    }
}