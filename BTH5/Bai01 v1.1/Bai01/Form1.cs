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
        public bool is_moving = false;
        public Size sz;
        
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            sz.Width = this.Width;
            sz.Height = this.Height;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            is_moving = true;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && is_moving)
            {
                var pos = this.PointToClient(Cursor.Position);
                label1.Location = new Point(pos.X, pos.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            is_moving = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            is_moving = true;
            var pos = label1.Location;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    label1.Location = new Point(pos.X - 5, pos.Y);
                    break;
                case Keys.Right:
                    label1.Location = new Point(pos.X + 5, pos.Y);
                    break;
                case Keys.Up:
                    label1.Location = new Point(pos.X, pos.Y - 5);
                    break;
                case Keys.Down:
                    label1.Location = new Point(pos.X, pos.Y + 5);
                    break;
            }
        }
    }
}
