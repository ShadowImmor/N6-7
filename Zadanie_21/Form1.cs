using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public interface ISomeInterface
        {
            void SomeMethod();
        }

        public class Class1 : ISomeInterface
        {
            public void SomeMethod()
            {
                System.Windows.Forms.MessageBox.Show("Class1");
            }
        }

        public class Class2 : ISomeInterface
        {
            public void SomeMethod()
            {
                System.Windows.Forms.MessageBox.Show("Class2");
            }
        }

        private void CreateClass_button_Click(object sender, EventArgs e)
        {
            Type t = Type.GetType("Zadanie_21.Form1+" + TypeClass_textBox.Text);
            ISomeInterface w = (Zadanie_21.Form1.ISomeInterface)Activator.CreateInstance(t);
            w.SomeMethod();
        }
    }
}
