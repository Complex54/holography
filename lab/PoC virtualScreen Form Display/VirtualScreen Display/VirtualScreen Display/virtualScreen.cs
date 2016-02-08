using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualScreen_Display
{
    public class virtualScreen : IDisposable
    {
        public string imageLink;

        public virtualScreen(string url)
        {
            imageLink = url;
        }
        public void Dispose()
        {
            this.Dispose();
        }
    }
}


