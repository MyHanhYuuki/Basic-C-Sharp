using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_04
{
    public partial class Form1 : Form
    {
        bool check = false;
        string path;
        string name;
        float size;
        public string text = "";
        public Form1()
        {
            InitializeComponent();
            using (InstalledFontCollection installedFont = new InstalledFontCollection())
            {
                foreach (FontFamily font in installedFont.Families)
                {
                    toolStripComboBoxFont.Items.Add(font.Name);
                }
            }

            toolStripComboBoxFont.SelectedItem = "Tahoma";
            toolStripComboBoxSize.SelectedIndex = 5;

            name = (string)toolStripComboBoxFont.SelectedItem;
            size = float.Parse(toolStripComboBoxSize.SelectedItem.ToString());
            richTextBox1.SelectionFont = new Font(name, size, FontStyle.Regular);
            check = true;

            toolStripComboBoxSize.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBoxFont.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void toolStripComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check)
            {
                name = (string)toolStripComboBoxFont.SelectedItem;
                richTextBox1.SelectionFont = new Font(name, size, richTextBox1.SelectionFont.Style);
            }
        }

        private void toolStripComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check)
            {
                size = float.Parse(toolStripComboBoxSize.SelectedItem.ToString());
                richTextBox1.SelectionFont = new Font(name, size, richTextBox1.SelectionFont.Style);
                //SetTextStyle(richTextBox, name, size, richTextBox.SelectionFont.Style);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Bold)
                new1 = new Font(old1, old1.Style & ~FontStyle.Bold);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Bold);

            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Italic)
                new1 = new Font(old1, old1.Style & ~FontStyle.Italic);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Italic);

            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Underline)
                new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Underline);

            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                name = fontDialog.Font.Name;
                size = fontDialog.Font.Size;
                FontStyle style = fontDialog.Font.Style;
                toolStripComboBoxFont.SelectedItem = fontDialog.Font.Name;
                toolStripComboBoxSize.SelectedItem = ((int)fontDialog.Font.Size).ToString();
                richTextBox1.SelectionFont = new Font(fontDialog.Font.FontFamily, fontDialog.Font.Size, style);
                richTextBox1.Focus();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (text != richTextBox1.Text)
            {
                DialogResult result = MessageBox.Show("Do you want to save before create new file?", "Inform", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem1_ClickAsync(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
                else
                {

                }
            }
            richTextBox1.Clear();
            richTextBox1.SelectionFont = new Font(name, size, FontStyle.Regular);
            path = "";
            text = "";
        }

        private async void saveToolStripMenuItem1_ClickAsync(object sender, EventArgs e)
        {
            if (path == "" || path == null)
            {
                using (SaveFileDialog save = new SaveFileDialog()
                {
                    Filter = "Text Document | *.rtf",
                    ValidateNames = true
                })
                {
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter write = new StreamWriter(save.FileName))
                        {
                            path = save.FileName;
                            await write.WriteLineAsync(richTextBox1.Text);

                        }
                    }
                }
            }
            else
            {
                using (StreamWriter write = new StreamWriter(path))
                {
                    await write.WriteLineAsync(richTextBox1.Text);
                }
            }
            text = richTextBox1.Text;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog()
            {
                Filter = "Text Document | *.txt; *.rtf",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (text != richTextBox1.Text)
                {
                    var result = MessageBox.Show("Do you want to save before open another file?", "Inform", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        saveToolStripMenuItem1_ClickAsync(sender, e);
                        if (open.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamReader read = new StreamReader(open.FileName))
                            {
                                path = open.FileName;
                                Task<string> str = read.ReadToEndAsync();
                                richTextBox1.Text = str.Result;
                            }
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        if (open.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamReader read = new StreamReader(open.FileName))
                            {
                                path = open.FileName;
                                Task<string> str = read.ReadToEndAsync();
                                richTextBox1.Text = str.Result;

                            }
                        }
                    }
                    else { }
                }
                else
                {
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader read = new StreamReader(open.FileName))
                        {
                            path = open.FileName;
                            Task<string> str = read.ReadToEndAsync();
                            richTextBox1.Text = str.Result;

                        }
                    }
                }
            }
            text = richTextBox1.Text;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save before exit?", "Inform", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                saveToolStripMenuItem1_ClickAsync(sender, e);
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem1_ClickAsync(sender, e);
        }
    }
}
