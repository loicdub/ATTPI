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

namespace _04serial
{
    public partial class myRagondin : Form
    {
        serializeThis a;

        public myRagondin()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Double.TryParse(tbxWeight.Text, out double outWeight);
            Double.TryParse(tbxSize.Text, out double outSize);

            a = new serializeThis(tbxName.Text, outWeight, outSize, tbxColor.Text);

            string nomFichier = "toto.xml";

            XmlSerializer serialiseur = new XmlSerializer(typeof(serializeThis));
            StreamWriter fichier = new StreamWriter(nomFichier);
            serialiseur.Serialize(fichier, a);
            fichier.Close();
            this.Close();
        }

        private void myRagondin_Load(object sender, EventArgs e)
        {
            string nomFichier = "toto.xml";
            serializeThis b;

            if (File.Exists(nomFichier))
            {
                XmlSerializer serialiseur = new XmlSerializer(typeof(serializeThis));
                StreamReader fichier = new StreamReader(nomFichier);
                b = (serializeThis)serialiseur.Deserialize(fichier);
                fichier.Close();

                tbxName.Text = b.Name;
                tbxWeight.Text = Convert.ToString(b.Weight);
                tbxSize.Text = Convert.ToString(b.Size);
                tbxColor.Text = b.Color;
            }
        }
    }
}
