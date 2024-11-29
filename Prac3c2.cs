using System;
class Prac3c2
{
	public static void Main(string[] args)
        {
            // Simulate nodes in a TreeView
            List<string> nodes = new List<string> { "Node1", "Node2", "Node3", "Node4" };

            // Display the nodes to the user
            Console.WriteLine("Select a node by entering its number:");

            for (int i = 0; i < nodes.Count; i++)
            {
                Console.WriteLine("{i + 1}. {nodes[i]}");
            }

            // Capture the user's selection
            int selectedNodeIndex = int.Parse(Console.ReadLine()) - 1;

            // Trigger the equivalent of TreeView1_SelectedNodeChanged
            SelectedNodeChanged(nodes[selectedNodeIndex]);

            // Ask the user if they want to collapse the node
            Console.WriteLine("Would you like to collapse this node? (yes/no)");
            string collapseChoice = Console.ReadLine();

            if (collapseChoice.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                // Trigger the equivalent of TreeView1_TreeNodeCollapsed
                TreeNodeCollapsed(nodes[selectedNodeIndex]);
            }
        }

        // Simulate the TreeView1_SelectedNodeChanged method
        static void SelectedNodeChanged(string selectedNode)
        {
            Console.WriteLine("You have selected the option: " + selectedNode);
        }

        // Simulate the TreeView1_TreeNodeCollapsed method
        static void TreeNodeCollapsed(string collapsedNode)
        {
            Console.WriteLine("The value Collapsed Was: " + collapsedNode);
        }
    }
}
}