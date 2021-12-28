using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Bai03
{
    public partial class Form2 : Form
    {
        ImageList listView_ImageList = new ImageList();
        ImageList archiveView_ImageList = new ImageList();
        public Form2()
        {
            InitializeComponent();
        }
        private void initialization()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            listView_ImageList.ColorDepth = ColorDepth.Depth32Bit;
            listView_ImageList.ImageSize = new Size(20, 20);
            listView1.SmallImageList = listView_ImageList;
            listView1.LargeImageList = listView_ImageList;
            archiveView_ImageList.ColorDepth = ColorDepth.Depth32Bit;
            archiveView_ImageList.ImageSize = new Size(20, 20);
            archiveView_ImageList.Images.Add(Class1.Extract(Class1.Shell32, 3, true));
            archiveView_ImageList.Images.Add(Class1.Extract(Class1.Shell32, 0, true));
            archiveView_ImageList.Images.Add(Class1.Extract(Class1.Shell32, 2, true));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = Directory.GetLogicalDrives();
        }
        private void ShowFilesAndFolders()
        {

            int listViewImageIndex = 1;
            if (listView1 != null)
                listView1.Items.Clear();
            if (listView_ImageList != null) listView_ImageList.Images.Clear();

            listView_ImageList.Images.Add(Class1.Extract(Class1.Shell32, 3, true));
            try
            {

                string path = comboBox2.Text;

                var folders = Directory.GetDirectories(path)
                    .Where(d => !new DirectoryInfo(d).Attributes.HasFlag(FileAttributes.System | FileAttributes.Hidden));

                foreach (string folder in folders)
                {
                    DirectoryInfo info = new DirectoryInfo(folder);
                    string[] Field = new string[5];
                    Field[0] = info.Name;
                    Field[1] = "<DIR>";
                    Field[2] = "...";
                    Field[3] = info.LastWriteTime.ToString();
                    ListViewItem item = new ListViewItem(Field);
                    item.ImageIndex = 0; ;
                    listView1.Items.Add(item);
                }

                var files = Directory.GetFiles(path)
                    .Where(d => !new FileInfo(d).Attributes.HasFlag(FileAttributes.System | FileAttributes.Hidden));
                foreach (string file in files)
                {
                    listView_ImageList.Images.Add(Icon.ExtractAssociatedIcon(file));
                }
                foreach (string file in files)
                {
                    FileInfo info = new FileInfo(file);
                    string[] Field = new string[5];
                    Field[0] = info.Name;

                    Field[1] = Class1.GetFileTypeDescription(file);
                    Field[2] = (info.Length / 1024).ToString() + " KB";
                    Field[3] = info.LastWriteTime.ToString();
                    ListViewItem item = new ListViewItem(Field);
                    item.ImageIndex = listViewImageIndex++;
                    listView1.Items.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            string path = comboBox2.Text;
            ShowFilesAndFolders();
            ComboBox1.Text = Path.GetFullPath(path);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView_ImageList.ImageSize = new Size(20, 20);
        }

        private void iconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ab = new Form1();
            ab.ShowDialog();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string path = comboBox2.Text;
            String tmpNode = listView1.SelectedItems[0].SubItems[0].Text;
            string str = Path.GetFullPath(path);
            str += listView1.SelectedItems[0].SubItems[0].Text;
            if (!Directory.Exists(str))
            {
                try
                {
                    System.Diagnostics.Process.Start(str);
                }
                catch (Win32Exception)
                {
                    MessageBox.Show("Open failed. Please check and try again !");
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
