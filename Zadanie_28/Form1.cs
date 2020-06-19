using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color color;
        string Name1;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Восстановление настроек.
                color = Properties.Settings.Default.OurColor;
                Name1 = Properties.Settings.Default.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12);
            g.DrawString(Name1, font, new SolidBrush(color), 120, 20);
        }

        private void Nothing_Click(object sender, EventArgs e)
        {
            color = Color.MediumPurple;
            Name1 = "Nothing";
            Invalidate();

            Properties.Settings.Default.OurColor = color;
            Properties.Settings.Default.Name = Name1;
            Properties.Settings.Default.Save();
        }

        private void Not_Forgotten_Click(object sender, EventArgs e)
        {
            color = Color.Firebrick;
            Name1 = "Not forgotten";
            Invalidate();

            Properties.Settings.Default.OurColor = Color.Firebrick;
            Properties.Settings.Default.Name = Name1;
            Properties.Settings.Default.Save();
        }
    }
}
