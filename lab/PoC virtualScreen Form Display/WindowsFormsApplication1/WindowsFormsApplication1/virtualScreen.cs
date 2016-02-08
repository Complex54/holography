using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class virtualScreen : IDisposable
    {
        private Image image;

        public virtualScreen(string url)
        {
            image = pathToImage("C:\\Users\\Thibault\\Pictures\bite2.PNG");

        }

        public Image getImage()
        {
            return image;
        }

        public Image pathToImage(string path)
        {
            Image i = Image.FromFile(path);
            return i;
        }
        public void Dispose()
        {
            this.Dispose();
        }
    }
}
