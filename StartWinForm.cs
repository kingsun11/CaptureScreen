using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureScreen
{
    class StartWinForm
    {
        static void Main(string[] args)
        {
            //ScreenDisplay sd = new ScreenDisplay();
            CaptureSetting sd = new CaptureSetting();
            Application.EnableVisualStyles();
            Application.Run(sd);
        }
    }
}
