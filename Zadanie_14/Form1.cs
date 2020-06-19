using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            if (node == null)
            {
                treeView.Nodes.Add(addNodeTextBox.Text);
            }
            else
            {
                node.Nodes.Add(addNodeTextBox.Text);
            } 
            addNodeTextBox.Text = "";
            addNodeTextBox.Focus();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            if (node != null)
            {
                treeView.Nodes.Remove(node);
            }
            else
            {
                MessageBox.Show("Ничего не выделено");
            }
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            treeView.SelectedNode = null;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            treeView.SelectedNode = null;
            TreeNode treenode = FindNode(treeView.Nodes, findNodeTextBox.Text);
            if (treenode != null)
            {
                treeView.SelectedNode = treenode;
                treeView.Focus();
            }
        }

        private TreeNode FindNode(TreeNodeCollection tnc, string name)
        {
            foreach (TreeNode tn in tnc)
            {
                if (tn.Text == name)
                {
                    return tn;
                }
            }

            TreeNode node;
            foreach (TreeNode tn in tnc)
            {
                node = FindNode(tn.Nodes, name);
                if (node != null)
                {
                    return node;
                }
            }

            return null;
        }

    }
}
