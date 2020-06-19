using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fontList = new InstalledFontCollection();
            foreach (FontFamily ff in fontList.Families)
            {
                Fonts_listBox.Items.Add(ff.Name);
            }
        }

        private void Fonts_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text_label.Font = new Font(Fonts_listBox.Text, 20);
        }
    }
}
