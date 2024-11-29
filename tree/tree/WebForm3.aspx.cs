using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tree
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize the TreeView with a root node
                TreeNode rootNode = new TreeNode("Root Node");
                TreeView1.Nodes.Add(rootNode);
            }
        }

        protected void AddNodeButton_Click(object sender, EventArgs e)
        {
            // Add a new node under the root node
            TreeNode newNode = new TreeNode(NodeTextBox.Text);
            TreeView1.Nodes[0].ChildNodes.Add(newNode);
            NodeTextBox.Text = ""; // Clear the TextBox
        }

        protected void RemoveNodeButton_Click(object sender, EventArgs e)
        {
            // Remove the selected node
            if (TreeView1.SelectedNode != null)
            {
                if (TreeView1.SelectedNode.Parent != null)
                {
                    // Remove from parent if it has a parent
                    TreeView1.SelectedNode.Parent.ChildNodes.Remove(TreeView1.SelectedNode);
                }
                else
                {
                    // Remove root node
                    TreeView1.Nodes.Remove(TreeView1.SelectedNode);
                }
            }
        }
    }
}