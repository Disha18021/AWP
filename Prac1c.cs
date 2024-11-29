class StudentManager
{
    // Fields to hold student data
    private string studentId;
    private string studentName;
    private CourseName studentCourse;
    private System.DateTime studentDateOfBirth;

    // Enum for course names
    public enum CourseName
    {
        Mathematics = 1,
        Science = 2,
        History = 3
    }

    // Method to collect student data
    public void CollectStudentData()
    {
        // Collect Student ID
        System.Console.Write("Enter Student ID: ");
        studentId = System.Console.ReadLine();

        // Collect Student Name
        System.Console.Write("Enter Student Name: ");
        studentName = System.Console.ReadLine();


	// Collect Course Name
	System.Console.Write("Enter Course Name (1 for Mathematics, 2 for Science, 3 for History): ");
    	studentCourse = (CourseName)System.Enum.Parse(typeof(CourseName), System.Console.ReadLine());

    	// Collect Date of Birth
    	System.Console.Write("Enter Date of Birth (yyyy-mm-dd): ");
    	studentDateOfBirth = System.DateTime.Parse(System.Console.ReadLine());
    }

    // Method to display student information
    public void DisplayStudent()
    {
        System.Console.WriteLine("\nStudent Information:");
        System.Console.WriteLine("ID: " + studentId);
        System.Console.WriteLine("Name: " + studentName);
        System.Console.WriteLine("Course: " + studentCourse);
        System.Console.WriteLine("Date of Birth: " + studentDateOfBirth.ToShortDateString());
    }
}

class Prac1c
{
   public static void Main(string[] args)
    {
        StudentManager studentManager = new StudentManager();

        // Collect and display data for one student
        studentManager.CollectStudentData();
        studentManager.DisplayStudent();

        // Wait for user input before closing
        // System.Console.WriteLine("Press any key to exit...");
        // System.Console.ReadKey();
    }
}