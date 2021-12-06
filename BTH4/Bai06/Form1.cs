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
        private string source_path;
        private string destination_path;

        public Form1()
        {
            InitializeComponent();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
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
                TextBoxSource.Clear();
                TextBoxDestination.Clear();
                source_path = "";
                destination_path = "";
                toolStripStatusLabelCopying.Text = "Đang sao chép: ";
                progressBar1.Value = 0;
                label3.Text = "0%";
                MessageBox.Show("Sao chép hoàn tất");
            }
        }

        private void CopyFile()
        {
            byte[] buffer = new byte[1024 * 1024];

            using (FileStream source = new FileStream(source_path, FileMode.Open, FileAccess.Read))
            {
                using (FileStream destination = new FileStream(destination_path, FileMode.Create, FileAccess.Write))
                {
                    int readbyte = 0;
                    while ((readbyte = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        destination.Write(buffer, 0, readbyte);
                        worker.ReportProgress((int)(source.Position * 100 / source.Length));
                        Thread.Sleep(1000);
                    }
                }
            }

        }

        private void ButtonBrowseSource_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TextBoxSource.Text = Path.GetDirectoryName(ofd.FileName);
                    source_path = ofd.FileName;
                }
            }
            ButtonCopy.Focus();
        }

        private void ButtonBrowseDestination_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    TextBoxDestination.Text = fbd.SelectedPath;
                    destination_path = Path.Combine(TextBoxDestination.Text, Path.GetFileName(source_path));
                }
            }
            ButtonCopy.Focus();
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(source_path) || string.IsNullOrEmpty(destination_path))
            {
                MessageBox.Show("Chưa có đường dẫn", "Lỗi");
                return;
            }
            else if (!File.Exists(source_path) || !Directory.Exists(TextBoxDestination.Text))
            {
                MessageBox.Show("Không tìm thấy file hay thư mục với đường dẫn đã cho", "Lỗi");
                return;
            }
            worker.RunWorkerAsync();
            toolStripStatusLabelCopying.Text += source_path;
        }
    }
}
