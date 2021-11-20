using System;
using System.Windows.Forms;

namespace Bai_02
{
    public partial class Form_Clock : Form
    {
        public Form_Clock()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox_Clock.Text = DateTime.Today.DayOfWeek.ToString() + ", " + DateTime.Now.ToString();
        }

        private void Form_Clock_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
