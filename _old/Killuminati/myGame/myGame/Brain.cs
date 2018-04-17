using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGame
{
    class Brain
    {
        Point position;

        public Point Position
        {
            set { position = value; }
        }
        Image img;

        public Brain(Image img)
        {
            this.img = img;
        }

        public  void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, position.X, position.Y, 65, 75);
        }

        public Rectangle getRectangle()
        {
            return new Rectangle(position, img.Size);
        }
    }
}
