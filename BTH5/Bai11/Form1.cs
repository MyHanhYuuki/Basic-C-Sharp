using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        Point start, end;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            end = e.Location;
            Graphics g = pictureBox1.CreateGraphics();

            if (rdLine.Checked == true)
            {
                float f;
                if (!float.TryParse(textBox1.Text, out f))
                {
                    MessageBox.Show("Vui lòng nhập đúng");
                }
                Pen pen = new Pen(btnColor.ForeColor, f);
                g.DrawLine(pen, start, end);
            }    
            else
            {
                Brush brush;
                if (rdSB.Checked == true)
                    brush = new SolidBrush(Color.Green);
                else if (rdHB.Checked == true)
                    brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
                else if (rdTB.Checked == true)
                    brush = new TextureBrush(new Bitmap(Properties.Resources.test));
                else
                    brush = new LinearGradientBrush(new PointF((end.X - start.X) / 2, start.X), new PointF((end.X - start.X) / 2, end.Y), Color.Red, Color.Green);

                if (rdEllipse.Checked == true)
                {
                    g.FillEllipse(brush, Math.Min(start.X, end.X), Math.Min(start.Y, end.Y), Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));
                }
                else if (rdRectangle.Checked == true)
                {
                    g.FillRectangle(brush, Math.Min(start.X, end.X), Math.Min(start.Y, end.Y), Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));
                }    
            }
            g.Dispose();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnColor.ForeColor = colorDialog1.Color;
        }
    }
}
