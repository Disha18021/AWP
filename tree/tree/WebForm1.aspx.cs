//3c1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tree
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private Dictionary<string, List<Item>> categoryItems = new Dictionary<string, List<Item>>
        {
            { "Electronics", new List<Item> { new Item("Phone", 799), new Item("Laptop", 1200), new Item("Tablet", 500) } },
            { "Books", new List<Item> { new Item("The Great Gatsby", 10), new Item("1984", 15), new Item("Moby Dick", 20) } },
            { "Clothing", new List<Item> { new Item("T-Shirt", 25), new Item("Jeans", 50), new Item("Jacket", 80) } }
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateTreeView();
            }
        }

        private void PopulateTreeView()
        {
            // Adding categories as parent nodes to TreeView
            foreach (var category in categoryItems.Keys)
            {
                TreeNode node = new TreeNode(category);
                treeViewCategories.Nodes.Add(node);
            }
        }

        protected void treeViewCategories_SelectedNodeChanged(object sender, EventArgs e)
        {
            // Get the selected category from TreeView
            string selectedCategory = treeViewCategories.SelectedNode.Text;

            // Populate the DataList with items from the selected category
            if (categoryItems.ContainsKey(selectedCategory))
            {
                dataListItems.DataSource = categoryItems[selectedCategory];
                dataListItems.DataBind();
            }
        }
    }

    // Class representing an item
    public class Item
    {
        public string ItemName { get; set; }
        public decimal Price { get; set; }

        public Item(string itemName, decimal price)
        {
            ItemName = itemName;
            Price = price;
        }
        
    }
}