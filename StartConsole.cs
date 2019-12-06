using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaptureScreen
{
    class StartConsole
    {
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

        [DllImport("User32.dll", EntryPoint = "ShowWindow")]
        private static extern bool ShowWindow(IntPtr hWnd, int type);
              
        static void Main(string[] args)
        {
            // 最小化运行窗口
            string AppName = "CaptureScreen";
            Console.Title = AppName;
            IntPtr ParenthWnd = new IntPtr(0);
            IntPtr et = new IntPtr(0);
            ParenthWnd = FindWindow(null, AppName);
            ShowWindow(ParenthWnd, 0);//隐藏本Command窗体, 0: 后台执行；1:正常启动；2:最小化到任务栏；3:最大化

            // 
            Thread.Sleep(500);
            
            WebMonitorService wms = new WebMonitorService(8080);
            wms.start(captureImageToByte);

            Console.ReadLine();
            
    }
        private static byte[] captureImageToByte()
        {
            ImageCapture screenUtil = new ImageCapture();
            Image imgPhoto = screenUtil.CaptureImage();
            MemoryStream mstream = new MemoryStream();
            imgPhoto.Save(mstream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] byData = new Byte[mstream.Length];
            mstream.Position = 0;
            mstream.Read(byData, 0, byData.Length); mstream.Close();
            return byData;
        }

    }
}
