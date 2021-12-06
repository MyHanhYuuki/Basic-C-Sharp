using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < FontFamily.Families.Count(); i++)
            {
                ListViewFonts.Items.Add(FontFamily.Families[i].Name);
                ListViewFonts.Items[i].Font = new Font(new FontFamily(FontFamily.Families[i].Name), 20, FontStyle.Regular, GraphicsUnit.Pixel);
            }
        }
    }
}
