using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGame
{
    class Necronomicon
    {
        int limiteBord;
        int limiteHauteur;
        Point position = new Point();

        Bitmap img = new Bitmap(Properties.Resources.necronomicon);

        public Necronomicon(int limiteBord, int limiteHauteur, Point depart)
        {
            this.limiteBord = limiteBord;
            this.limiteHauteur = limiteHauteur;
            this.position = depart;
        }

        public void Paint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, position);
        }

        public Rectangle getRectangle()
        {
            Rectangle Rect = new Rectangle(position, img.Size);
            return Rect;
        }

        public bool collision(Rectangle r)
        {
            Rectangle Rect = new Rectangle(position, img.Size);
            return Rect.IntersectsWith(r);
        }
    }
}
