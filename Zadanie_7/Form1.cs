﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace Zadanie_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DochYzl_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("..\\..\\..\\Zadanie7.xml");
            XmlNode d = xml.DocumentElement;
            XmlNodeList xnl = d.ChildNodes;
            for (int i = 0; i < d.ChildNodes.Count; i++)
            {
                MessageBox.Show(xnl[i].Attributes["text"].Value + "  " + xnl[i].Attributes["rustext"].Value);
            }

        }
    }
}
