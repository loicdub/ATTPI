using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnValidate_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
