using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        Graphics g;
        List<CircleInfo> circles = new List<CircleInfo>();
        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            g = CreateGraphics();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            circles.Add(new CircleInfo(Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255)), e.X, e.Y));
            Refresh();
            foreach(CircleInfo circle in circles)
            {
                circle.DrawingCircle(g);
            }    
        }

        private void btn_zOut_Click(object sender, EventArgs e)
        {
            Refresh();
            foreach (CircleInfo circle in circles)
            {
                circle.x += 10;
                circle.y += 10;
                circle.diameter -= 20;
                circle.DrawingCircle(g);
            }
        }

        private void btn_zIn_Click(object sender, EventArgs e)
        {
            Refresh();
            foreach (CircleInfo circle in circles)
            {
                circle.x -= 10;
                circle.y -= 10;
                circle.diameter += 20;
                circle.DrawingCircle(g);
            }
        }
    }
}
