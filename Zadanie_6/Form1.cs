using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Без строки ниже у меня выдовало исключение:
            //System.InvalidOperationException: "Этот компонент BackgroundWorker не сообщает о ходе выполнения. 
            // Измените свойство WorkerReportsProgress так, сведения о ходе выполнения выдавались."
            backgroundWorker.WorkerReportsProgress = true;
        }

        private void StrartThread_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
            StrartThread.Enabled = false;
        }

        private void MsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Какое-то действие");
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                backgroundWorker.ReportProgress(i);
                Thread.Sleep(millisecondsTimeout: 100);
            }

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Text = e.ProgressPercentage.ToString();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Финиш!");
            StrartThread.Enabled = true;

        }
    }
}
