using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Hologram1 : Hologram
    {
        private Image modelImage;
        private Image north;
        private Image east;
        private Image south;
        private Image west;
        private virtualScreen vs;
        public Hologram1(virtualScreen vs)
        {
            this.vs = vs;
            modelImage = vs.getImage();
            process();
        }

        public void process()
        {
            north = modelImage;
            east = modelImage;
            south = modelImage;
            west = modelImage;
        }

    }
}
