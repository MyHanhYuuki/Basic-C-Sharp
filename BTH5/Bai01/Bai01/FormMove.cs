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
    public partial class FormMove : Form
    {
        int x = 0, y = 0;
        Graphics g;      

        public FormMove()
        {
            InitializeComponent();
            g = CreateGraphics();           
        }

        private void FormMove_KeyDown(object sender, KeyEventArgs e)
        {
            Refresh();
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (x < 0) x = Width;
                    else x -= 5;                   
                    break;
                case Keys.Right:
                    if (x > Width) x = 0;
                    else x += 5;
                    break;
                case Keys.Up:
                    if (y < 0) y = Height;
                    else y -= 5;
                    break;
                case Keys.Down:
                    if (y > Height) y = 0;
                    else y += 5;
                    break;
            }
            StringMover(x, y);
        }

        private void FormMove_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.instance.Show();
        }

        private void FormMove_Load(object sender, EventArgs e)
        {
            g.DrawString(FormMain.tb.Text, new Font("Arial", 12), Brushes.Black, new Point(0, 0));
        }

        private void FormMove_SizeChanged(object sender, EventArgs e)
        {
            Refresh();
            g = CreateGraphics();
            StringMover(x, y);
        }

        private void FormMove_Shown(object sender, EventArgs e)
        {
            g.DrawString(FormMain.tb.Text, new Font("Arial", 12), Brushes.Black, new Point(x, y));
        }

        private void StringMover(int x, int y)
        {
            g.DrawString(FormMain.tb.Text, new Font("Arial", 12), Brushes.Black, new Point(x, y));
        }
    }
}
