using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Kon_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cms = new ContextMenuStrip();
            //При добавлении из главного меню убираются эти поля, причину не нашёл
            cms.Items.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            //cms не видимо, при смене свойства Visible на true окно меню появляется в лево верхнем углу экрана, поэтому использовал Show
            cms.Show(Kon, -70,-70);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = ((ToolStripMenuItem)sender).Text;
            MessageBox.Show(s);
        }
        
    }
}
