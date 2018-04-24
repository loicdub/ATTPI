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
    public partial class frmSelectPos : Form
    {
        public frmSelectPos()
        {
            InitializeComponent();
        }

        private void lbPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLoad.Enabled = true;
        }
    }
}
