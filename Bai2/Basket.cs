using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bai2
{
    class Basket
    {

        public int speed;
        public int width1 { get; set; }
        public int height1 { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int top { get; set; }
        public int left { get; set; }
        public Basket(int windowWidth, int windowHeight)
        {
            left = 0;
            width = 150;
            width1 = 15;
            height = 40;
            height1 = 20;
            speed = 60;
            top = windowHeight - height - height1;
        }

        public void DrawBasket(Graphics g)
        {
            g.FillRectangle(Brushes.Green, left, top, width, height);
            g.FillRectangle(Brushes.Green, left, top - height1, width1, height1);
            g.FillRectangle(Brushes.Green, width + left - width1, top - height1, width1, height1);
        }

        public void Update(bool direct, int left, int right)
        {
            if (direct) this.left += speed;
            else this.left -= speed;
            this.left = Math.Max(this.left, left);
            this.left = Math.Min(right - width - width1, this.left);
        }
    }
}
