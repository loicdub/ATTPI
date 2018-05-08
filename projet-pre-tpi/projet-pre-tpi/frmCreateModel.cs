/*
 * Project Name : Motion Stalker 
 * Author       : DML
 * Entreprise   : CFPT-I
 * Description  : try to copy the model's fingers position or add your custom model
 * Version      : 1.0
 * Class descr. : Create your own customed fingers's model.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace projet_pre_tpi
{
    public partial class frmCreateModel : Form
    {
        List<PictureBox> fingerPos;
        List<Bitmap> ressources;
        FingersPosition fingers;

        public frmCreateModel()
        {
            InitializeComponent();
            LoadPicturebox();
        }

        /// <summary>
        /// Load PictureBox at the loading of the form
        /// </summary>
        public void LoadPicturebox()
        {
            fingerPos = new List<PictureBox>();
            fingerPos.Add(pbxThumb);
            fingerPos.Add(pbxIndex);
            fingerPos.Add(pbxMiddle);
            fingerPos.Add(pbxRing);
            fingerPos.Add(pbxPinky);

            ressources = new List<Bitmap>();
            ressources.Add(Properties.Resources.cross);
            ressources.Add(Properties.Resources.round);

            for (int i = 0; i < fingerPos.Count; i++)
            {
                fingerPos[i].BackgroundImage = ressources[0];
            }
        }

        /// <summary>
        /// Each click on the Listbox change the fingers position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_Click(object sender, EventArgs e)
        {
            if (((PictureBox)sender).BackgroundImage == ressources[0])
            {
                ((PictureBox)sender).BackgroundImage = ressources[1];
            }
            else
            {
                ((PictureBox)sender).BackgroundImage = ressources[0];
            }
        }

        /// <summary>
        /// You can't save your model until there is a name to it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxNamePos_TextChanged(object sender, EventArgs e)
        {
            if (tbxNamePos.Text.Length <= 0)
            {
                btnValidate.Enabled = false;
            }
            else
            {
                btnValidate.Enabled = true;
            }
        }

        /// <summary>
        /// Save your custom position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidate_Click(object sender, EventArgs e)
        {
            fingers = new FingersPosition();
            fingers.addHand(new myHand(tbxNamePos.Text, PbxToBoolean(pbxThumb), PbxToBoolean(pbxIndex), PbxToBoolean(pbxMiddle), PbxToBoolean(pbxRing), PbxToBoolean(pbxPinky)));
        }

        /// <summary>
        /// Set the fingers boolean state
        /// </summary>
        /// <param name="pbxFinger">PictureBox of the current finger</param>
        /// <returns>the boolean state of the current finger</returns>
        private bool PbxToBoolean(PictureBox pbxFinger)
        {
            bool fingerState = false;

            if (pbxFinger.BackgroundImage == ressources[0])
            {
                fingerState = false;
            }
            else if (pbxFinger.BackgroundImage == ressources[1])
            {
                fingerState = true;
            }

            return fingerState;
        }
    }
}
