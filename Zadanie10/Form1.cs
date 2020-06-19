using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YznInfo_button_Click(object sender, EventArgs e)
        {
            SysInfo.Text += "Размер экрана: " + SystemInformation.PrimaryMonitorSize + "\n";
            SysInfo.Text += "Имя компьтера: " + SystemInformation.ComputerName + "\n";
            SysInfo.Text += "Количество кнопок у мыши: " + SystemInformation.MouseButtons + "\n";
            SysInfo.Text += "Используемый шрифт для меню и его имя: " + SystemInformation.MenuFont.Name + "\n";
            SysInfo.Text += "Присутствует ли сеть: " + SystemInformation.Network + "\n";
            SysInfo.Text += "Имя текущего пользователя: " + SystemInformation.UserName + "\n";
            SysInfo.Text += "Ширина вертикальной полосы прокрутки: " + SystemInformation.VerticalScrollBarWidth + "\n";
        }
    }
}
