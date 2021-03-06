﻿/*
 * Project Name : Motion Stalker 
 * Author       : DML
 * Entreprise   : CFPT-I
 * Description  : try to copy the model's fingers position or add your custom model
 * Version      : 1.0
 * Class descr. : Show your fingers and model's fingers position.
*/
using Leap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace projet_pre_tpi
{
    public partial class frmMain : Form
    {
        private Controller controller = new Controller();
        List<PictureBox> fingersUser;
        List<PictureBox> fingersModel;
        List<bool> userExtended;
        List<bool> modelExtended;
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
        }

        /// <summary>
        /// Refresh the fingers info on every frame of the Leap Motion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        void newFrameHandler(object sender, FrameEventArgs eventArgs)
        {
            userExtended = new List<bool>();

            Frame frame = eventArgs.frame;
            if (frame.Hands.Count > 0)
            {
                List<Hand> hands = frame.Hands;
                Hand firstHand = hands[0];
                List<Finger> fingers = firstHand.Fingers;
                for (int i = 0; i < fingers.Count; i++)
                {
                    ShowUserFingersPosition(fingers[i].IsExtended, i);
                    userExtended.Add(fingers[i].IsExtended);
                }
                compareUserModel();
            }
        }

        /// <summary>
        /// Load the fingers's model PictureBox
        /// </summary>
        public void LoadPicturebox()
        {
            fingersModel = new List<PictureBox>();
            modelExtended = new List<bool>();
            fingersModel.Add(pbxThumb);
            fingersModel.Add(pbxIndex);
            fingersModel.Add(pbxMiddle);
            fingersModel.Add(pbxRing);
            fingersModel.Add(pbxPinky);

            r = new Random();

            for (int i = 0; i < fingersModel.Count; i++)
            {
                int index = r.Next(0, 2);
                fingersModel[i].BackgroundImage = crossAndRound[index];
                if (index == 0)
                {
                    modelExtended.Add(false);
                }
                else if (index == 1)
                {
                    modelExtended.Add(true);
                }
            }
        }
        
        /// <summary>
        /// Show the user fingers's position
        /// </summary>
        /// <param name="isExtended">Leap Motion interpretation on whether or not the finger is extended</param>
        /// <param name="type">precising what finger is affected</param>
        public void ShowUserFingersPosition(bool isExtended, int type)
        {
            fingersUser.Add(pbxYourThumb);
            fingersUser.Add(pbxYourIndex);
            fingersUser.Add(pbxYourMiddle);
            fingersUser.Add(pbxYourRing);
            fingersUser.Add(pbxYourPinky);

            if (isExtended)
            {
                fingersUser[type].BackgroundImage = crossAndRound[1];
            }
            else
            {
                fingersUser[type].BackgroundImage = crossAndRound[0];
            }
        }

        /// <summary>
        /// Compare user's fingers's position to the model
        /// </summary>
        /// <returns>true if the user copied well the model, false if not</returns>
        public bool compareUserModel() {
            bool isOk = false;

            for (int i = 0; i < userExtended.Count; i++)
            {
                if (userExtended[i] != modelExtended[i])
                {
                    isOk = false;
                    break;
                }
                else
                {
                    isOk = true;
                }
            }

            if (isOk)
            {
                lblOk.Text = "Position correcte !";
            }
            else
            {
                lblOk.Text = "Position incorrecte.";
            }
            lblOk.Visible = true;

            return isOk;
        }

        /// <summary>
        /// Set a new finger's model randomly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewModel_Click(object sender, EventArgs e)
        {
            LoadPicturebox();
        }

        /// <summary>
        /// Open the position creation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateModel_Click(object sender, EventArgs e)
        {
            frmCreateModel createModel = new frmCreateModel();

            createModel.ShowDialog();
        }

        /// <summary>
        /// Open the position loading form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadModel_Click(object sender, EventArgs e)
        {
            frmSelectPos selectPos = new frmSelectPos();

            selectPos.ShowDialog();

            if (selectPos.DialogResult == DialogResult.OK)
            {
                modelExtended = new List<bool>();

                for (int i = 0; i < selectPos.LoadedPosition().Count; i++)
                {
                    if (!(selectPos.LoadedPosition()[i]))
                    {
                        fingersModel[i].BackgroundImage = crossAndRound[0];
                        modelExtended.Add(false);
                    }
                    else if (selectPos.LoadedPosition()[i])
                    {
                        fingersModel[i].BackgroundImage = crossAndRound[1];
                        modelExtended.Add(true);
                    }
                }
            }
        }
    }
}
