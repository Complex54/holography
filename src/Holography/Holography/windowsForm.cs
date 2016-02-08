using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holography
{
    public partial class windowsForm : Form
    {
        public windowsForm()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void SelectionImage_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPEG|*.jpeg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                FileName.Text = ofd.FileName;
                SafeFileName.Text = ofd.SafeFileName;
            }
        }

        private void BouttonDemarrer_Click(object sender, EventArgs e)
        {
            if ( String.IsNullOrEmpty(SafeFileName.Text) && String.IsNullOrEmpty(textBoxTailleEcran.Text) )
            {
                appeller avec textBoxTailleEcran.Text ofd.SafeFileName
            }
        }
    }
}
