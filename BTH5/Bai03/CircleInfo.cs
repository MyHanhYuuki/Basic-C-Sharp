using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class CircleInfo
    {
        Color color;
        public int diameter = 100;
        public int x, y;
        public CircleInfo(Color c, int xx, int yy)
        {
            color = c;
            x = xx - 50;
            y = yy - 50;
        }
        public void DrawingCircle(Graphics g)
        {
            g.FillEllipse(new SolidBrush(color), x, y, diameter, diameter);
        }
    }
}
