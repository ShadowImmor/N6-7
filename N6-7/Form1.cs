using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N6_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                res = Convert.ToInt32(Delim.Text) / Convert.ToInt32(Delit.Text);
                Res.Text = res.ToString();
            }
            catch (DivideByZeroException ex)
            {
                statusStrip.Items[0].Text = ex.Message;
            }
            catch
            {
                statusStrip.Items[0].Text = "Неизвестная ошибка!";
            }

        }

        private void statusStrip_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Был нажат status bar");
        }

        private void statusStrip_Resize(object sender, EventArgs e)
        {
            statusStrip.Items[0].Width = statusStrip.Width - 200;
        }

        private void toolStripStatusLabel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Blue, width: 2), 6, 2, 15, 15);
        }
    }
}
