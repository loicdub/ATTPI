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

        public class FingersList
        {
            private List<FingersPosition> listFingers;
            public FingersList()
            {
                listFingers = new List<FingersPosition>();
            }
            [XmlElement("finger")]
            public FingersPosition[] Fingers
            {
                get
                {
                    FingersPosition[] fingers = new FingersPosition[listFingers.Count];
                    return fingers;
                }
                set
                {
                    if (value == null)
                        return;
                    FingersPosition[] fingers = (FingersPosition[])value;
                    listFingers.Clear();
                    foreach (FingersPosition finger in fingers)
                        listFingers.Add(finger);
                }
            }
        }

        public class FingersPosition
        {
            private string _name;
            private bool _thumb;
            private bool _index;
            private bool _middle;
            private bool _ring;
            private bool _pinky;

            [XmlElement("")]
            public string Name { get => _name; set => _name = value; }
            public bool Thumb { get => _thumb; set => _thumb = value; }
            public bool Index { get => _index; set => _index = value; }
            public bool Middle { get => _middle; set => _middle = value; }
            public bool Ring { get => _ring; set => _ring = value; }
            public bool Pinky { get => _pinky; set => _pinky = value; }

            public FingersPosition() { }

            public FingersPosition(string name, bool thumb, bool index, bool middle, bool ring, bool pinky)
            {
                this.Name = name;
                this.Thumb = thumb;
                this.Index = index;
                this.Middle = middle;
                this.Ring = ring;
                this.Pinky = pinky;
            }
        }
    }
}
