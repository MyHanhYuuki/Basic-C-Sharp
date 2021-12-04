using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bai1
{

    public class MySprites
    {
        private Bitmap[] _listSprites = new Bitmap[8];
        private int _iSprite { get; set; }
        private int _nSprite { get; set; }
        private int _Width { get; set; }
        private int _Height { get; set; }
        private int _x { get; set; }
        private int _y { get; set; }

        public MySprites(Bitmap[] listSprites, int x, int y, int Width, int Height, int nSprite)
        {
            _listSprites = listSprites;
            _x = x;
            _y = y;
            _Width = Width;
            _Height = Height;
            _nSprite = nSprite;
        }

        internal void DrawSprite(Graphics e)
        {
            e.DrawImage(_listSprites[_iSprite], _x, _y, _Width, _Height);
        }

        internal void Update()
        {
            try
            {
                _iSprite = (_iSprite + 1) % _nSprite;
            }
            catch (DivideByZeroException)
            {

            }
        }
    }
}
