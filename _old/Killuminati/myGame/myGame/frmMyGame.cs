using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leap;
using System.Diagnostics;
using System.Threading;

namespace myGame
{
    public partial class frmMyGame : Form
    {
        const int NBILLUMINATI = 15; //Détermine le nombre d'Illuminatis à afficher        
        private Controller _leap = new Controller();
        int score = 0;
        Brain b;
        bool Commence = false;

        Random popPosition = new Random();

        List<Enemy> listeIlluminati = new List<Enemy>();
        List<Necronomicon> listeNecronomicon = new List<Necronomicon>();

        public frmMyGame()
        {
            InitializeComponent();
            DoubleBuffered = true;

            popEnnemies(); //Appelle la méthode popEnnemies()
        }

        //Quitte le jeu avec confirmation
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult leaveGame = MessageBox.Show("Voulez-vous vraiment quitter ?", "Quitter ?", MessageBoxButtons.YesNo);
            if (leaveGame == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMyGame_Paint(object sender, PaintEventArgs e)
        {
            if (_leap == null)
                return;

            Frame frame = _leap.Frame();
            Finger finger = frame.Fingers.Frontmost;
            
            Vector stabPosition = finger.StabilizedTipPosition;
            InteractionBox iBox = _leap.Frame().InteractionBox;
            Vector normalizedPosition = iBox.NormalizePoint(stabPosition);

            //Indique la position actuelle du joueur (falcultatif)
            float x = normalizedPosition.x * this.Width;
            float y = this.Height - normalizedPosition.y * this.Height;
            b.Position = new Point((int)x, (int)y);
            label1.Text = String.Format("{0},{1}", x, y);

            //Affiche les ennemis et le joueur
            foreach (Enemy v in listeIlluminati)
            {
                v.Paint(e);
            }

            b.OnPaint(e);

            //Affiche les Necronomicons
            foreach (Necronomicon n in listeNecronomicon)
            {
                n.Paint(e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Commence) //Les ennemis bougent seulement si on appuye sur le bouton "Commencer" 
            {
                foreach (Enemy v in listeIlluminati)
                {
                    v.Move();

                    if (v.collision(b.getRectangle())) //Suprrime l'Illuminati en collision avec le joueur et baisse le score
                    {
                        //Stoppe le jeu durant un certain temps
                        Commence = !Commence;
                        score--;
                        listeIlluminati.Remove(v);
                        tmrFreeze.Start();
                        break;
                    }
                }

                foreach (Necronomicon n in listeNecronomicon)
                {
                    if (n.collision(b.getRectangle())) //Suprrime l'Illuminati en collision avec le joueur et baisse le score
                    {
                        //Stoppe le jeu durant un certain temps
                        score++;
                        listeNecronomicon.Remove(n);
                        break;
                    }
                }

                tmrPopNecro.Enabled = true;
                lblScore.Text = "Score : " + score; //Affiche le score
            }
            else
                tmrPopNecro.Enabled = false;


            Invalidate();
        }

        public Rectangle getRectangle()
        {
            Rectangle Rect = new Rectangle();
            return Rect;
        }

        public void btnNewGame_Click(object sender, EventArgs e)
        {
            //Supprime tous les Illuminatis créés, réinitialise le score et recréer de nouveaux ennemis 
            listeIlluminati.Clear();
            score = 0;

            popEnnemies();

            btnPause.Focus(); //Place le focus sur Pause
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Commence = true; //Permet de mettre en mouvement les ennemis
            //Les boutons "Pause" et "Nouvelle partie" sont cliquables et le bouton "Commencer" ne l'est plus
            btnPause.Enabled = true;
            btnNewGame.Enabled = true;
            btnStartGame.Enabled = false;
            btnPause.Focus(); //Place le focus sur Pause
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Commence = !Commence; //Stoppe les Illuminatis si le joueur clique sur "Pause"
        }

        //Créer les ennemis et le joueur
        public void popEnnemies()
        {
            int cpt = 1;
            Random rdm = new Random();

            for (int i = 0; i < NBILLUMINATI; i++)
            {
                int vx = 2 + rdm.Next(0, 2);
                int vy = 2 + rdm.Next(0, 2);

                Point depart = new Point(rdm.Next(0, Width - 75), rdm.Next(0, 650));

                Enemy e = new Enemy(vx, vy, depart, Width, Height);
                listeIlluminati.Add(e);
                cpt++;
            }

            b = new Brain(Properties.Resources.brain);
        }

        //La barre Espace permet de mettre le jeu en pause
        private void btnPause_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Space))
                btnPause.PerformClick();
        }

        //Stop l'action quand le joueur est touché
        private void tmrFreeze_Tick(object sender, EventArgs e)
        {
            Commence = true;
            tmrFreeze.Stop();
        }

        //Créer un Necronomicon tout les ticks
        public void tmrPopNecro_Tick(object sender, EventArgs e)
        {
            Necronomicon necronomicon = new Necronomicon(100, 100, new Point(popPosition.Next(0, Width - Properties.Resources.necronomicon.Width), popPosition.Next(0, Height - Properties.Resources.necronomicon.Height - panel1.Height - 50)));
            listeNecronomicon.Add(necronomicon);
        }
    }
}
