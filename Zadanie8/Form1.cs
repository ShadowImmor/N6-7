using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int num = 0;

        private void Menu_button_Click(object sender, EventArgs e)
        {
            num++;
            ToolStripMenuItem mi = new ToolStripMenuItem(num.ToString());
            mi.Click += this.ToolStripMenuItem_Click;
            menuToolStripMenuItem.DropDownItems.Add(mi);

        }

        private void ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            string s = ((ToolStripMenuItem)sender).Text;
            MessageBox.Show(s);
        }

    }
}
