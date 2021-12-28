using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{

    public partial class Form1 : Form
    {
        MainForm MainForm;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Form form)
        {
            InitializeComponent();
            MainForm = form as MainForm;
        }

        private void btnfile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSave.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSave.Text) || string.IsNullOrEmpty(txtURL.Text))
            {
                MessageBox.Show("Please fill in all field !");
            }
            else
            {
                Class1 class1 = new Class1();
                class1.url = txtURL.Text;
                class1.filename = txtSave.Text;
                MainForm.a.Add(class1);
                MainForm.List_Download();
                this.Close();
            }
        }
    }
}
