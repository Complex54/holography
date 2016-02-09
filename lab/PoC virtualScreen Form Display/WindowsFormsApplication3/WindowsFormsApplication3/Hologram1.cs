using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication3
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
