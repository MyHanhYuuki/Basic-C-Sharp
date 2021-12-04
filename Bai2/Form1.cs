using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bai2
{
    public partial class Form1 : Form
    {
        List<BallSprites> ballList;
        Basket basket;
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            ballList = new List<BallSprites>();
            for (int i = 1; i <= 2; i++)
            {
                Thread.Sleep(1);
                ballList.Add(new BallSprites(this.Width));
            }
            basket = new Basket(this.Width, this.Height);
            //ballList.AddRange(Enumerable.Repeat(new BallSprites(this.Width), 4));
            timer1.Interval = 16;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < ballList.Count; i++)
            {
                ballList[i].DrawSprite(e.Graphics);
            }
            basket.DrawBasket(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ballList.Count; i++)
            {
                ballList[i].Update();
                if (ballList[i].y + ballList[i].r >= this.Height - basket.height - basket.height1 * 2)
                {
                    if (ballList[i].x <= basket.left + basket.width + basket.width1 && ballList[i].x >= basket.left)
                        ballList[i] = new BallSprites(this.Width);
                }
                if (ballList[i].y + 2 * ballList[i].r > this.Height)
                {
                    if (ballList[i].x <= basket.left + basket.width + basket.width1 && ballList[i].x >= basket.left)
                        ballList[i] = new BallSprites(this.Width);
                    gameOver();
                }
            }
            this.Refresh();
        }

        private void gameOver()
        {
            timer1.Dispose();
            MessageBox.Show("Game Over !");
            this.Close();
        }

        private void keyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) basket.Update(true, 0, this.Width);
            if (e.KeyCode == Keys.Left) basket.Update(false, 0, this.Width);
            this.Refresh();
        }
    }
}
