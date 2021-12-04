using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        List<MySprites> listSprites1;
        Timer timer1 = new Timer();

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void form_Load(object sender, EventArgs e)
        {
            listSprites1 = new List<MySprites>();
            Bitmap[] bitmaps = new Bitmap[8];
            bitmaps[0] = Properties.Resources.frame_1;
            bitmaps[1] = Properties.Resources.frame_2;
            bitmaps[2] = Properties.Resources.frame_3;
            bitmaps[3] = Properties.Resources.frame_4;
            bitmaps[4] = Properties.Resources.frame_5;
            bitmaps[5] = Properties.Resources.frame_6;
            bitmaps[6] = Properties.Resources.frame_7;
            bitmaps[7] = Properties.Resources.frame_8;
            listSprites1.Add(new MySprites(bitmaps, 0, 0, 500, 500, 8));
        }

        private void form_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            for (int i = 0; i < listSprites1.Count; i++)
                listSprites1[i].DrawSprite(graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval > 100)
                timer1.Interval = 1;
            timer1.Interval += 3;
            for (int i = 0; i < listSprites1.Count; i++)
                listSprites1[i].Update();
            this.Invalidate();
        }

    }

}
