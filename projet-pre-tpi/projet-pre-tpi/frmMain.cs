// Référence(s) à ajouter
using Leap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace projet_pre_tpi
{
    public partial class frmMain : Form
    {
        private Controller controller = new Controller();
        List<PictureBox> fingersUser;
        List<PictureBox> fingersModel;
        List<Bitmap> crossAndRound;
        Random r;

        public frmMain()
        {
            InitializeComponent();
            controller.EventContext = WindowsFormsSynchronizationContext.Current;
            controller.FrameReady += newFrameHandler;
            crossAndRound = new List<Bitmap>();
            crossAndRound.Add(Properties.Resources.cross);
            crossAndRound.Add(Properties.Resources.round);
            fingersUser = new List<PictureBox>();

            LoadPicturebox();
            CompareFingersPosition(fingersUser, fingersModel);
        }

        public void LoadPicturebox()
        {
            fingersModel = new List<PictureBox>();
            fingersModel.Add(pbxIndex);
            fingersModel.Add(pbxThumb);
            fingersModel.Add(pbxMiddle);
            fingersModel.Add(pbxRing);
            fingersModel.Add(pbxPinky);

            r = new Random();

            for (int i = 0; i < fingersModel.Count; i++)
            {
                fingersModel[i].BackgroundImage = crossAndRound[r.Next(0, 2)];
            }
        }

        public void ShowUserFingersPosition(bool isExtended, int type)
        {
            fingersUser.Add(pbxYourThumb);
            fingersUser.Add(pbxYourIndex);
            fingersUser.Add(pbxYourMiddle);
            fingersUser.Add(pbxYourRing);
            fingersUser.Add(pbxYourPinky);

            if (isExtended)
            {
                fingersUser[type].BackgroundImage = Properties.Resources.round;
            }
            else
            {
                fingersUser[type].BackgroundImage = Properties.Resources.cross;
            }
        }

        public void CompareFingersPosition(List<PictureBox> user, List<PictureBox> model) {
            user = fingersUser;
            model = fingersModel;
            bool samePos = false;
            int cpt = 0;

            for (int i = 0; i < user.Count; i++)
            {
                if (user[i].BackgroundImage == model[i].BackgroundImage)
                {
                    cpt++;
                }
            }

            if (cpt == 5)
            {
                lblOk.Text = "Ok !";
            }
            else
            {
                lblOk.Text = "Not Ok !";
            }
        }

        void newFrameHandler(object sender, FrameEventArgs eventArgs)
        {
            Frame frame = eventArgs.frame;
            if (frame.Hands.Count > 0)
            {
                List<Hand> hands = frame.Hands;
                Hand firstHand = hands[0];
                List<Finger> fingers = firstHand.Fingers;
                for (int i = 0; i < fingers.Count; i++)
                {
                    ShowUserFingersPosition(fingers[i].IsExtended, i);
                }
            }
        }
    }
}
