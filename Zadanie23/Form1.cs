using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.ContextMenuStrip = contextMenuStrip1;
                c.MouseDown += new MouseEventHandler(this.ShowPopupMenu);
            }
        }

        private void ShowPopupMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Control c = (Control)sender;
                if (c.ContextMenuStrip != null)
                {
                    c.ContextMenuStrip.Show(c, new Point(e.X, e.Y));
                }
            }
        }

        private void ShowText_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Text_textBox.Text);
        }

        private void item1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You is real?", "???", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                MessageBox.Show("not true", "?!?", MessageBoxButtons.OK);
            else
                MessageBox.Show("lie", "!?!", MessageBoxButtons.OK);
        }

        private void item1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Is this Урок 23?", " ? ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                MessageBox.Show("Okay", "?", MessageBoxButtons.OK);
            else
                MessageBox.Show("Why did you say that?", "!", MessageBoxButtons.OK);
        }
    }
}
