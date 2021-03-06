﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holography
{
    public class virtualScreen : IDisposable
    {
        private Image image;

        public virtualScreen(string url)
        {
            image = pathToImage(url);
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
