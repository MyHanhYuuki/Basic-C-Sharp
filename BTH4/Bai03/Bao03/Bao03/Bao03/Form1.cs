using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace Bao03
{
    public partial class Form1 : Form
    {
        private static int pre_index = -1, current_index = -1;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            listBox_MediaFiles.DisplayMember = "Name";
            listBox_MediaFiles.ValueMember = "Path";
        }

        private void listBox_MediaFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_index = listBox_MediaFiles.SelectedIndex;
            if (current_index != pre_index && listBox_MediaFiles.SelectedItem is MediaFileInfo file && file != null)
            {
                pre_index = current_index;
                axWindowsMediaPlayer.URL = file.Path;
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true,
                Filter = "Media Files(*.avi;*.mpeg;*.wmv;*.wav;*.midi;*.mp4;*.mp3)|*.avi;*.mpeg;*.wmv;*.wav;*.midi;*.mp4;*.mp3" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFileInfo> media_files = new List<MediaFileInfo>();
                    foreach (string file in ofd.FileNames)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        media_files.Add(new MediaFileInfo() { Name = Path.GetFileNameWithoutExtension(fileInfo.FullName), Path = fileInfo.FullName });
                    }
                    listBox_MediaFiles.DataSource = media_files;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Time.Text = DateTime.Now.ToString();
        }
    }
}
