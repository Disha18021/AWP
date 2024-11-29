using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TreeView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
           Label1.Text = TreeView1.SelectedNode.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TreeNodeCollection T;
            T = TreeView1.CheckedNodes;
            DataList1.DataSource = T;
            DataList1.DataBind();
            DataList1.Visible = true;
        }
    }
}