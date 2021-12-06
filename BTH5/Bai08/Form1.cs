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

namespace Bai08
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToString();
            g = CreateGraphics();
            g.TranslateTransform(Size.Width / 2, Size.Height / 2);
            DrawClock(g);
            DrawHour();
            DrawMin();
            DrawSec();
            timer1.Start();
        }

        private void DrawClock(Graphics g)
        {
            Point[] pt = new Point[2];
            for (int iAngle = 0; iAngle < 360; iAngle += 6)
            {
                pt[0].X = 0;
                pt[0].Y = 150;
                RotatePoint(pt, 1, iAngle);
                pt[1].X = pt[1].Y = (iAngle % 5 == 0 ? 10 : 5);
                pt[0].X -= pt[1].X / 2;
                pt[0].Y -= pt[1].Y / 2;
                g.DrawEllipse(new Pen(Color.White), pt[0].X, pt[0].Y, pt[1].X, pt[1].Y);
                g.FillEllipse(new SolidBrush(Color.White), pt[0].X, pt[0].Y, pt[1].X, pt[1].Y);
            }    
        }

        private void RotatePoint(Point[] pt, int iRotate, int iAngle)
        {
            Point temp = new Point(0, 0);
            for (int i = 0; i < iRotate; i++)
            {
                temp.X = (int)(pt[i].X * Math.Cos(2 * Math.PI * iAngle / 360) - pt[i].Y * Math.Sin(2 * Math.PI * iAngle / 360));
                temp.Y = (int)(pt[i].Y * Math.Cos(2 * Math.PI * iAngle / 360) + pt[i].X * Math.Sin(2 * Math.PI * iAngle / 360));
                pt[i] = temp;
            }
        }

        private void DrawSec()
        {
            int sec = DateTime.Now.Second;
            int degree = 180 - (sec * 6);
            Point temp = new Point();
            temp.X = (int)(130 * Math.Sin(2 * Math.PI * degree / 360));
            temp.Y = (int)(130 * Math.Cos(2 * Math.PI * degree / 360));
            g.DrawLine(new Pen(Color.White), new Point(0, 0), temp);
        }
        private void DrawMin()
        {
            int min = DateTime.Now.Minute;
            int degree = 180 - (min * 6);
            Point p1 = new Point();
            p1.X = -(int)(15 * Math.Sin(2 * Math.PI * degree / 360));
            p1.Y = -(int)(15 * Math.Cos(2 * Math.PI * degree / 360));
            Point p2 = new Point();
            p2.X = -(int)(15 * Math.Sin(2 * Math.PI * (degree + 90) / 360));
            p2.Y = -(int)(15 * Math.Cos(2 * Math.PI * (degree + 90) / 360));
            Point p3 = new Point();
            p3.X = -(int)(15 * Math.Sin(2 * Math.PI * (degree - 90) / 360));
            p3.Y = -(int)(15 * Math.Cos(2 * Math.PI * (degree - 90) / 360));
            Point p4 = new Point();
            p4.X = (int)(120 * Math.Sin(2 * Math.PI * degree / 360));
            p4.Y = (int)(120 * Math.Cos(2 * Math.PI * degree / 360));
            g.DrawLine(new Pen(Color.White), p1, p2);
            g.DrawLine(new Pen(Color.White), p1, p3);
            g.DrawLine(new Pen(Color.White), p4, p2);
            g.DrawLine(new Pen(Color.White), p4, p3);
        }
        private void DrawHour()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int degree = 180 - (hour * 30) - (int)(1.0 * min * 30 / 60);
            Point p1 = new Point();
            p1.X = -(int)(15 * Math.Sin(2 * Math.PI * degree / 360));
            p1.Y = -(int)(15 * Math.Cos(2 * Math.PI * degree / 360));
            Point p2 = new Point();
            p2.X = -(int)(15 * Math.Sin(2 * Math.PI * (degree + 90) / 360));
            p2.Y = -(int)(15 * Math.Cos(2 * Math.PI * (degree + 90) / 360));
            Point p3 = new Point();
            p3.X = -(int)(15 * Math.Sin(2 * Math.PI * (degree - 90) / 360));
            p3.Y = -(int)(15 * Math.Cos(2 * Math.PI * (degree - 90) / 360));
            Point p4 = new Point();
            p4.X = (int)(90 * Math.Sin(2 * Math.PI * degree / 360));
            p4.Y = (int)(90 * Math.Cos(2 * Math.PI * degree / 360));
            g.DrawLine(new Pen(Color.White), p1, p2);
            g.DrawLine(new Pen(Color.White), p1, p3);
            g.DrawLine(new Pen(Color.White), p4, p2);
            g.DrawLine(new Pen(Color.White), p4, p3);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawClock(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            label1.Text = DateTime.Now.ToString();
            DrawClock(g);
            DrawHour();
            DrawMin();
            DrawSec();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
