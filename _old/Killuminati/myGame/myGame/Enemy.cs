using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace myGame
{
    class Enemy
    {
        int tailleBas = 225;
        int tailleHaut = 15;
        int tailleCoteDroit = 100;
        int tailleCoteGauche = 15;
        Bitmap img = new Bitmap(Properties.Resources.illuminati);

        Random rdm = new Random();

        int vitesseX;
        int vitesseY;
        int limiteBord;
        int limiteHauteur;
        Point position = new Point();

        

        public Enemy(int vitesseX, int vitesseY, Point depart, int limiteBord, int limiteHauteur)
        {
            this.vitesseX = vitesseX;
            this.vitesseY = vitesseY;
            this.position = depart;
            this.limiteBord = limiteBord;
            this.limiteHauteur = limiteHauteur;
        }

        public void Paint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, position);
        }
        public void Move()
        {
            position.X += vitesseX;
            position.Y += vitesseY;

            if (vitesseX > 0 && position.X > limiteBord - tailleCoteDroit)
            {
                vitesseX *= -1;
            }

            if (vitesseX < 0 && position.X < 0 + tailleCoteGauche)
            {
                vitesseX *= -1;
            }

            if (vitesseY > 0 && position.Y > limiteHauteur - tailleBas)
            {
                vitesseY *= -1;
            }

            if (vitesseY < 0 && position.Y < 0 + tailleHaut)
            {
                vitesseY *= -1;
            }
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

