//3c2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tree
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize TreeView with some nodes
                TreeNode rootNode = new TreeNode("Root Node");
                TreeNode childNode1 = new TreeNode("Child Node 1");
                TreeNode childNode2 = new TreeNode("Child Node 2");

                rootNode.ChildNodes.Add(childNode1);
                rootNode.ChildNodes.Add(childNode2);

                TreeView1.Nodes.Add(rootNode);
                TreeView1.ExpandAll();
            }
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            // Display selected node text
            SelectedNodeLabel.Text = "Selected Node: " + TreeView1.SelectedNode.Text;
        }

        protected void AddNodeButton_Click(object sender, EventArgs e)
        {
            // Add a new node to the selected node, or to the root if no node is selected
            if (TreeView1.SelectedNode != null)
            {
                TreeView1.SelectedNode.ChildNodes.Add(new TreeNode(NodeTextBox.Text));
                TreeView1.SelectedNode.Expand();
            }
            else
            {
                TreeView1.Nodes.Add(new TreeNode(NodeTextBox.Text));
            }

            // Clear the textbox after adding the node
            NodeTextBox.Text = "";
        }

        protected void RemoveNodeButton_Click(object sender, EventArgs e)
        {
            // Remove the selected node
            if (TreeView1.SelectedNode != null)
            {
                if (TreeView1.SelectedNode.Parent == null)
                {
                    TreeView1.Nodes.Remove(TreeView1.SelectedNode);
                }
                else
                {
                    TreeView1.SelectedNode.Parent.ChildNodes.Remove(TreeView1.SelectedNode);
                }
            }
        }
    }
}