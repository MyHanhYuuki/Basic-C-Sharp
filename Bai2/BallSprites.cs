using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Bai2
{
    class BallSprites
    {
        public int r { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int speed { get; set; }
        static Random rd = new Random();

        public BallSprites(int x)
        {
            this.r = rd.Next(30, 30);
            this.x = rd.Next(0, x);
            this.y = 0;
            speed = rd.Next(1, 4);
        }

        ~BallSprites()
        {

        }

        internal void DrawSprite(Graphics e)
        {
            e.DrawEllipse(new Pen(Color.Yellow), x, y, r, r);
            e.FillEllipse(Brushes.Yellow, x, y, r, r);
        }

        public void Update()
        {
            y += speed;
        }

    }
}
