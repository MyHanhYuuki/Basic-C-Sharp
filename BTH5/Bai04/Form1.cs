using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.Black;
            rdLeft.Checked = true;

            using (InstalledFontCollection installedFont = new InstalledFontCollection())
            {
                foreach (FontFamily font in installedFont.Families)
                {
                    cbFont.Items.Add(font.Name);
                }
            }
            cbFont.SelectedItem = "Arial";
            cbSize.SelectedItem = "14";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            SetTextBox();
        }
        private void SetTextBox()
        {
            textBox.SelectAll();
      
            textBox.Font = new Font(cbFont.SelectedItem.ToString(), float.Parse(cbSize.SelectedItem.ToString()), FontStyle.Regular);
            textBox.ForeColor = button1.BackColor;
        }

        private void checkBoxB_Click(object sender, EventArgs e)
        {
            if (checkBoxB.Checked)
                textBox.Font = new Font(textBox.Font.Name, textBox.Font.Size, textBox.Font.Style ^ FontStyle.Bold);
            else
                textBox.Font = new Font(textBox.Font.Name, textBox.Font.Size, textBox.Font.Style ^ FontStyle.Bold);
        }

        private void checkBoxI_Click(object sender, EventArgs e)
        {
            if (checkBoxI.Checked)
                textBox.Font = new Font(textBox.Font.Name, textBox.Font.Size, textBox.Font.Style | FontStyle.Italic);
            else
                textBox.Font = new Font(textBox.Font.Name, textBox.Font.Size, textBox.Font.Style ^ FontStyle.Italic);
        }

        private void checkBoxU_Click(object sender, EventArgs e)
        {
            if (checkBoxU.Checked)
                textBox.Font = new Font(textBox.Font.Name, textBox.Font.Size, textBox.Font.Style | FontStyle.Underline);
            else
                textBox.Font = new Font(textBox.Font.Name, textBox.Font.Size, textBox.Font.Style ^ FontStyle.Underline);
        }

        private void rdLeft_Click(object sender, EventArgs e)
        {
            textBox.TextAlign = HorizontalAlignment.Left;
        }

        private void rdCenter_Click(object sender, EventArgs e)
        {
            textBox.TextAlign = HorizontalAlignment.Center;
        }

        private void rdRight_Click(object sender, EventArgs e)
        {
            textBox.TextAlign = HorizontalAlignment.Right;
        }

        private void cbFont_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font(cbFont.SelectedItem.ToString(), textBox.Font.Size, textBox.Font.Style);
        }
        private void cbSize_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font.Name, float.Parse(cbSize.SelectedItem.ToString()), textBox.Font.Style);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = colorDialog.Color;
                button1.BackColor = colorDialog.Color;
            }
        }
    }
}
