using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //g.DrawRectangle(new Pen(Color.Orange), 100, 100, 50, 50);
            ////g.DrawString("ĐH CNTT", new Font("Time New Roman", 16), new SolidBrush(Color.Orange), new PointF(12F, 9F));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawString("ĐH CNTT", new Font("Time New Roman", 16F), new SolidBrush(Color.Orange), new PointF(12F, 9F));
            g.DrawString("ĐH CNTT", new Font("Franklin Gothic Demi", 34F), new SolidBrush(Color.Blue), new PointF(5F, 32F));
            g.DrawString("ĐH CNTT", new Font("Franklin Gothic Demi", 34F, FontStyle.Italic), new SolidBrush(Color.Violet), new PointF(5F, 93F));
            g.DrawString("ĐH CNTT", new Font("Franklin Gothic Demi", 63F), new SolidBrush(Color.Pink), new PointF(-2F, 136F));
            g.Dispose();
        }
    }
}
