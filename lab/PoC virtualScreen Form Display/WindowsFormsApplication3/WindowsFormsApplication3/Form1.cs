using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    
    public partial class Form1 : Form
    {
        private virtualScreen vs;
        public Form1(virtualScreen vs)
        {
            this.vs = vs;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
