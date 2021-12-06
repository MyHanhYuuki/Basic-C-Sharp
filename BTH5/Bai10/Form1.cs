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

namespace Bai10
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Red);
        Point start, end;
        
        int count = 0;
        GraphicsPath path = new GraphicsPath();
        public Form1()
        {
            InitializeComponent();
            cbDC.SelectedIndex = cbDS.SelectedIndex = cbEC.SelectedIndex = cbLJ.SelectedIndex = cbW.SelectedIndex = cbSC.SelectedIndex = 0;
        }

        private void cbDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDS.SelectedIndex)
            {
                case 0:
                    pen.DashStyle = DashStyle.Solid;
                    break;
                case 1:
                    pen.DashStyle = DashStyle.Dash;
                    break;
                case 2:
                    pen.DashStyle = DashStyle.Dot;
                    break;
                case 3:
                    pen.DashStyle = DashStyle.DashDot;
                    break;
                case 4:
                    pen.DashStyle = DashStyle.DashDotDot;
                    break;
            }    
        }

        private void cbW_SelectedIndexChanged(object sender, EventArgs e)
        {
            float tmp;
            float.TryParse(cbW.SelectedItem.ToString(), out tmp);
            pen.Width = tmp;
        }

        private void cbLJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLJ.SelectedIndex)
            {
                case 0:
                    pen.LineJoin = LineJoin.Miter;
                    break;
                case 1:
                    pen.LineJoin = LineJoin.Bevel;
                    break;
                case 2:
                    pen.LineJoin = LineJoin.Round;
                    break;
                case 3:
                    pen.LineJoin = LineJoin.MiterClipped;
                    break;
            }
        }

        private void cbDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDC.SelectedIndex)
            {
                case 0:
                    pen.DashCap = DashCap.Flat;
                    break;
                case 1:
                    pen.DashCap = DashCap.Round;
                    break;
                case 2:
                    pen.DashCap = DashCap.Triangle;
                    break;
            }

        }

        private void cbSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSC.SelectedIndex)
            {
                case 0:
                    pen.StartCap = LineCap.Flat;
                    break;
                case 1:
                    pen.StartCap = LineCap.Square;
                    break;
                case 2:
                    pen.StartCap = LineCap.Round;
                    break;
                case 3:
                    pen.StartCap = LineCap.Triangle;
                    break;
                case 4:
                    pen.StartCap = LineCap.NoAnchor;
                    break;
                case 5:
                    pen.StartCap = LineCap.SquareAnchor;
                    break;
                case 6:
                    pen.StartCap = LineCap.RoundAnchor;
                    break;
                case 7:
                    pen.StartCap = LineCap.DiamondAnchor;
                    break;
                case 8:
                    pen.StartCap = LineCap.ArrowAnchor;
                    break;
                case 9:
                    pen.StartCap = LineCap.AnchorMask;
                    break;
            }
        }

        private void cbEC_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEC.SelectedIndex)
            {
                case 0:
                    pen.StartCap = LineCap.Flat;
                    break;
                case 1:
                    pen.StartCap = LineCap.Square;
                    break;
                case 2:
                    pen.StartCap = LineCap.Round;
                    break;
                case 3:
                    pen.StartCap = LineCap.Triangle;
                    break;
                case 4:
                    pen.StartCap = LineCap.NoAnchor;
                    break;
                case 5:
                    pen.StartCap = LineCap.SquareAnchor;
                    break;
                case 6:
                    pen.StartCap = LineCap.RoundAnchor;
                    break;
                case 7:
                    pen.StartCap = LineCap.DiamondAnchor;
                    break;
                case 8:
                    pen.StartCap = LineCap.ArrowAnchor;
                    break;
                case 9:
                    pen.StartCap = LineCap.AnchorMask;
                    break;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            end = e.Location;
            Graphics g = CreateGraphics();
            if (count == 0)
            {

                path.AddLine(start, end);
                g.DrawLine(pen, start, end);
                count++;
            }
            else
            {
                path.AddLine(start, end);
                g.DrawPath(pen, path);
                count--;
                path = new GraphicsPath();
            }
            g.Dispose();
        }
        
    }
}
