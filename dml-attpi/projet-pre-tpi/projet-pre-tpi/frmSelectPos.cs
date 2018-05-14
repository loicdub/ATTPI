/*
 * Project Name : Motion Stalker 
 * Author       : DML
 * Entreprise   : CFPT-I
 * Description  : try to copy the model's fingers position or add your custom model
 * Version      : 1.0
 * Class descr. : Select previously saved position.
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
    public partial class frmSelectPos : Form
    {
        savedHand loadPos;

        public frmSelectPos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load saved positions in ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSelectPos_Load(object sender, EventArgs e)
        {
            string nomFichier = "fingers-position.xml";

            if (File.Exists(nomFichier))
            {
                XmlSerializer serialiseur = new XmlSerializer(typeof(savedHand));
                StreamReader fichier = new StreamReader(nomFichier);
                loadPos = (savedHand)serialiseur.Deserialize(fichier);
                fichier.Close();

                lbPos.Items.Add(loadPos.Name);
                LoadedPosition();
            }
        }

        /// <summary>
        /// Button "Charger" is enabled only if a ListBox element is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLoad.Enabled = true;
        }

        /// <summary>
        /// Load the informations of the chosen position
        /// </summary>
        /// <returns>boolean list of fingers position</returns>
        public List<bool> LoadedPosition()
        {
            List<bool> fingersBool = new List<bool>();

            fingersBool.Add(loadPos.Thumb);
            fingersBool.Add(loadPos.Index);
            fingersBool.Add(loadPos.Middle);
            fingersBool.Add(loadPos.Ring);
            fingersBool.Add(loadPos.Pinky);

            return fingersBool;
        }
    }
}
