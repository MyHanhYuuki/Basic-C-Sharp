using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Bai01
{
    public partial class MainForm : Form
    {
        int flag = 0;
        public List<Class1> a { get; set; }
        public MainForm()
        {
            InitializeComponent();
            a = new List<Class1>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
        }
        public void List_Download()
        {
            int position = a.Count - 1;
            ListViewItem item = new ListViewItem(a[position].filename);
            item.SubItems.Add("");
            item.SubItems.Add(a[position].process.ToString());
            item.SubItems.Add(a[position].speed);
            item.SubItems.Add(a[position].status);
            item.SubItems.Add(a[position].url);
            lvfile.Items.Add(item);

            for (int i = 0; i < a.Count; i++)
                DownloadFile(a[i].url, a[i].filename, i);
        }
        public void DownloadFile(string urlAddress, string location, int rowHandle)
        {
            Stopwatch sw = new Stopwatch();
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler((sender, e) => Completed(sender, e, rowHandle, sw));
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler((sender, e) => ProgressChanged(sender, e, rowHandle, sw, webClient));
                Uri URL = new Uri(urlAddress);
                location = location + "/" + Path.GetFileName(URL.AbsolutePath);
                sw.Start();
                try
                {
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e, int rowHandle, Stopwatch sw, WebClient wb)
        {
            if (flag == 1)
            {
                int position_cancelled = -1;
                string text = lvfile.SelectedItems[0].Text;
                for (int i = 0; i < lvfile.Items.Count; i++)
                    if (lvfile.Items[i].Text.Equals(text))
                    {
                        position_cancelled = i;
                        break;
                    }
                if (position_cancelled != -1 && position_cancelled == rowHandle)
                {
                    a[position_cancelled] = new Class1();
                    wb.CancelAsync();
                }
                flag = 0;
            }
            lvfile.Items[rowHandle].SubItems[2].Text = e.ProgressPercentage + "%";
            lvfile.Items[rowHandle].SubItems[1].Text = e.BytesReceived + "/" + e.TotalBytesToReceive;
            lvfile.Items[rowHandle].SubItems[4].Text = "Downloading";
            lvfile.Items[rowHandle].SubItems[3].Text = (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00") + "Kb/s";
        }

        private void Completed(object sender, AsyncCompletedEventArgs e, int rowHandle, Stopwatch sw)
        {
            if (e.Cancelled == true)
            {
                lvfile.Items[rowHandle].SubItems[4].Text = "Cancelled";
                sw.Stop();
            }
            else
            {
                lvfile.Items[rowHandle].SubItems[4].Text = "Finish";
                lvfile.Items[rowHandle].SubItems[3].Text = "0 Kb/s";
                sw.Stop();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            flag = 1;
        }


    }
}
