using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        Graphics g;
        bool clicked = false;
        int x, y;
        int tempX, tempY;
        public Form1()
        {
            InitializeComponent();
            x = Width / 2 - 50;
            y = Height / 2 - 50;
            g = CreateGraphics();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                x = e.X - tempX;
                y = e.Y - tempY;
                Refresh();
                g.FillRectangle(new SolidBrush(Color.OrangeRed), x, y, 50, 50);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Location.X > x && e.Location.Y < x + 50 && e.Location.Y > y && e.Location.Y < y + 50)
            {
                clicked = true;
                tempX = e.X - x;
                tempY = e.Y - y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            g.FillRectangle(new SolidBrush(Color.OrangeRed), x, y, 50, 50);
        }
    }
}
