using System;
class Ex
{
	public void Fun()
	{

            // Simulate checked nodes in a TreeView
            List<string> checkedNodes = new List<string>();
            Console.WriteLine("Enter items for the list (enter 'done' to finish):");

            // Input simulation for checked nodes
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done") break;
                checkedNodes.Add(input);
            }

            // Display the checked nodes
            Console.WriteLine("Checked Nodes:");
            DisplayCheckedNodes(checkedNodes);
        }

        // Method to simulate DataList binding and display
        static void DisplayCheckedNodes(List<string> nodes)
        {
            foreach (var node in nodes)
            {
                Console.WriteLine(node);
            }
        }
}
class Prac3c1
{
	public static void Main(string[] args)
	{
		Ex obj=new Ex();
		obj.Fun();
	 }
}