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
    public partial class FormMain : Form
    {
        public static TextBox tb = new TextBox();
        public static FormMain instance;

        public FormMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            tb.Text = "";
            instance = this;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            tb.Text = textBox1.Text;
            Hide();
            FormMove formMove = new FormMove();
            formMove.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
