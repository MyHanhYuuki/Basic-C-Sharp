using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Bai05
{
    public partial class Form1 : Form
    {
        string fullsourceFile;
        string fulldesFile;
        public Form1()
        {
            InitializeComponent();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSource.Text = Path.GetDirectoryName(openFileDialog.FileName);
                    fullsourceFile = openFileDialog.FileName;
                }    
            }
            btn_copy.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtTarget.Text = folderBrowserDialog.SelectedPath;
                    fulldesFile = Path.Combine(txtTarget.Text, Path.GetFileName(fullsourceFile));
                }
            }
            btn_copy.Focus();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyFile();
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label3.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == 100)
            {
                txtSource.Clear();
                txtTarget.Clear();
                fullsourceFile = "";
                fulldesFile = "";
                label4.Text = "Đang sao chép: ";
                progressBar1.Value = 0;
                label3.Text = "0%";

                MessageBox.Show("Xong");
            }
        }

        private void CopyFile()
        {
            byte[] buffer = new byte[1024 * 1024]; // 1MB buffer

            using (FileStream source = new FileStream(fullsourceFile, FileMode.Open, FileAccess.Read))
            {
                using (FileStream dest = new FileStream(fulldesFile, FileMode.Create, FileAccess.Write))
                {
                    int readbyte = 0;
                    while ((readbyte = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        dest.Write(buffer, 0, readbyte);
                        worker.ReportProgress((int)(source.Position * 100 / source.Length));
                        Thread.Sleep(1000);
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fullsourceFile) || String.IsNullOrEmpty(fulldesFile))
            {
                MessageBox.Show("Thiếu file cần sao chép hoặc thư mục muốn chép file", "Chú ý");
                return;
            }

            worker.RunWorkerAsync();
            label4.Text = label4.Text + fullsourceFile;
        }
    }
}
