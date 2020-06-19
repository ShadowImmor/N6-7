using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode treeNode = treeView.Nodes.Add("Item_1");
            TreeNode treeNode11 = treeNode.Nodes.Add("Item_1.1");
            TreeNode treeNode12 = treeNode.Nodes.Add("Item_1.2");
            treeNode11.Nodes.Add("Item_1.11");
            treeNode11.Nodes.Add("Item_1.12");
            treeNode12.Nodes.Add("Item_1.21");
            treeNode12.Nodes.Add("Item_1.22");
            treeNode.ExpandAll();

        }

        private void treeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            SelectAllSubnodes(e.Node);
        }
        void SelectAllSubnodes(TreeNode treeNode)
        {
            foreach (TreeNode treeSubNode in treeNode.Nodes)
            {
                treeSubNode.Checked = treeNode.Checked;
            }
        }

    }
}
