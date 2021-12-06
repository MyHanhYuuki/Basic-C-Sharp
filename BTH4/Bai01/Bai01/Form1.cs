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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MessageBox.Show("Left mouse button clicked at coordinate (" + e.X.ToString() + ", " + e.Y.ToString() + ")", "");
            else if (e.Button == MouseButtons.Right)
                MessageBox.Show("Right mouse button clicked at coordinate (" + e.X.ToString() + ", " + e.Y.ToString() + ")", "");
            else if (e.Button == MouseButtons.Middle)
                MessageBox.Show("Middle mouse button clicked at coordinate (" + e.X.ToString() + ", " + e.Y.ToString() + ")", "");
            else if (e.Button == MouseButtons.XButton1)
                MessageBox.Show("Side mouse button 1 clicked at coordinate (" + e.X.ToString() + ", " + e.Y.ToString() + ")", "");
            else if (e.Button == MouseButtons.XButton2)
                MessageBox.Show("Side mouse button 2 clicked at coordinate (" + e.X.ToString() + ", " + e.Y.ToString() + ")", "");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Keys pressed: " + e.KeyData.ToString() + "\nKeys Value: " + e.KeyValue.ToString() + "\nKey ASCII: " + Convert.ToString(Convert.ToInt32(e.KeyData)));
        }
    }
}
