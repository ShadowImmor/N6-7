using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка нажата");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Click.PerformClick();
            Press.PerformClick();
        }
    }
}
