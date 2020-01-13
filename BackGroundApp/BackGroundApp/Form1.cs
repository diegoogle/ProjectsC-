using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace BackGroundApp {
    public partial class Form1: Form {
        public Form1 () {
            InitializeComponent();
        }

        private void button1_Click (object sender, EventArgs e) {
            if (backgroundWorker1.IsBusy != true) {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork (object sender, DoWorkEventArgs e) {
            for (int i =1;i<=10;i++) {
                if (backgroundWorker1.CancellationPending == true) {
                    e.Cancel = true;
                    break;
                }
                Thread.Sleep(1000);
                backgroundWorker1.ReportProgress(i * 10);
            }
        }

        private void backgroundWorker1_ProgressChanged (object sender, ProgressChangedEventArgs e) {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted (object sender, RunWorkerCompletedEventArgs e) {
            MessageBox.Show("Proceso terminado");
        }

        private void button2_Click (object sender, EventArgs e) {
            backgroundWorker1.CancelAsync();
        }
    }
}
