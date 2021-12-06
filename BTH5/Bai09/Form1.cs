using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        bool painting = false;
        Graphics g;
        Point start, end;
        int mode;
        Random rand = new Random();
        Color color;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = comboBox1.SelectedIndex;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            end = e.Location;
            int x = Math.Min(start.X, end.X);
            int y = Math.Min(start.Y, end.Y);
            int width = Math.Max(Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));


            if (painting)
            {
                switch (mode)
                {
                    case 0:
                        {
                            g.DrawEllipse(new Pen(color, 2F), x, y, width, width);
                            break;
                        }
                    case 1:
                        {
                            g.DrawRectangle(new Pen(color, 2F), x, y, width, width);
                            break;
                        }
                    case 2:
                        {
                            g.DrawEllipse(new Pen(color, 2F), x, y, Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));
                            break;
                        }
                    case 3:
                        {
                            g.DrawPie(new Pen(color, 2F), x, y, Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y), 0F, 360F);
                            break;
                        }
                    case 4:
                        {
                            g.FillEllipse(new SolidBrush(color), x, y, width, width);
                            break;
                        }
                    case 5:
                        {
                            g.FillRectangle(new SolidBrush(color), x, y, width, width);
                            break;
                        }
                    case 6:
                        {
                            g.FillEllipse(new SolidBrush(color), x, y, Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));
                            break;
                        }
                    case 7:
                        {
                            g.FillPie(new SolidBrush(color), x, y, Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y), 0, 360);
                            break;
                        }
                }
            }
            painting = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            painting = true;
            color = Color.FromArgb(rand.Next(20, 255), rand.Next(20, 255), rand.Next(20, 255));
        }
    }
}
