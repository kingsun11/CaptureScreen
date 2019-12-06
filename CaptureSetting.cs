using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CaptureScreen
{
    public partial class CaptureSetting : Form
    {
        private CaptureDisplay sd = null;
        private WebMonitorService wms = null;

        #region Windows Library Declaration
        List<WindowInfo> wndList;
        int currentDisplayWindowsIdx = -1;
        IntPtr currentDisplayHWnd;
        private struct WindowInfo
        {
            public IntPtr hWnd { get; set; }
            public String szWindowName { get; set; }
            public String szClassName { get; set; }
            public String valuename { get; set; }
            public String name { get; set; }
            public String value()
            {
                return name;
            }
        }
        private delegate bool WNDENUMPROC(IntPtr hWnd, int lParam);
        private delegate bool EnumWindowsCallBack(IntPtr hwnd, IntPtr lParam);


        private class GDI32
        {

            public const int SRCCOPY = 0x00CC0020; // BitBlt dwRop parameter
            [DllImport("gdi32.dll")]
            public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest,
                int nWidth, int nHeight, IntPtr hObjectSource,
                int nXSrc, int nYSrc, int dwRop);
            [DllImport("gdi32.dll")]
            public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth,
                int nHeight);
            [DllImport("gdi32.dll")]
            public static extern IntPtr CreateCompatibleDC(IntPtr hDC);
            [DllImport("gdi32.dll")]
            public static extern bool DeleteDC(IntPtr hDC);
            [DllImport("gdi32.dll")]
            public static extern bool DeleteObject(IntPtr hObject);
            [DllImport("gdi32.dll")]
            public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
        }
        private class User32
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct RECT
            {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }
            [DllImport("user32.dll")]
            public static extern IntPtr GetDesktopWindow();
            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowDC(IntPtr hWnd);
            [DllImport("user32.dll")]
            public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);
            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);
            [DllImport("user32.dll")]
            public static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, int lParam);
            [DllImport("user32.dll")]
            public static extern int GetWindowTextW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder lpString, int nMaxCount);
            [DllImport("user32.dll")]
            public static extern int GetClassNameW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder lpString, int nMaxCount);
            [DllImport("user32.dll")]
            public static extern int EnumChildWindows(IntPtr hwndParent, EnumWindowsCallBack lpEnumFunc, int lParam);

        }

        #endregion

        #region Form Action
        public CaptureSetting()
        {
            InitializeComponent();
        }

        private void StartSetting_Load(object sender, EventArgs e)
        {
            int screenCount = Screen.AllScreens.Length;
            for (int idxScreen = 1; idxScreen <= screenCount; idxScreen++)
            {
                comboBoxSourceScreenIndex.Items.Add(idxScreen);
                comboBoxDestScreenIndex.Items.Add(idxScreen);
            }
            comboBoxSourceScreenIndex.SelectedIndex = comboBoxSourceScreenIndex.Items.Count - 1;
            comboBoxDestScreenIndex.SelectedIndex = 0;

            checkBoxSourceFullScreen.Checked = true;
            checkBoxShowForm.Checked = true;

            checkBoxShowWEB.Enabled = false;
            numericUpDownWebPort.Enabled = false;

            if (checkBoxSourceFullScreen.Checked)
            {
                numericUpDownSourceLeft.Value = Screen.AllScreens[comboBoxSourceScreenIndex.SelectedIndex].Bounds.Left;
                numericUpDownSourceTop.Value = Screen.AllScreens[comboBoxSourceScreenIndex.SelectedIndex].Bounds.Top;
                numericUpDownSourceWidth.Value = Screen.AllScreens[comboBoxSourceScreenIndex.SelectedIndex].Bounds.Width;
                numericUpDownSourceHeight.Value = Screen.AllScreens[comboBoxSourceScreenIndex.SelectedIndex].Bounds.Height;
            }
            numericUpDownSourceWidth.Enabled = !checkBoxSourceFullScreen.Checked;
            numericUpDownSourceHeight.Enabled = !checkBoxSourceFullScreen.Checked;

            if (checkBoxDestFullScreen.Checked)
            {
                numericUpDownDestWidth.Value = Screen.AllScreens[comboBoxDestScreenIndex.SelectedIndex].Bounds.Width;
                numericUpDownDestHeight.Value = Screen.AllScreens[comboBoxDestScreenIndex.SelectedIndex].Bounds.Width;
            }
            numericUpDownDestWidth.Enabled = !checkBoxDestFullScreen.Checked;
            numericUpDownDestHeight.Enabled = !checkBoxDestFullScreen.Checked;
        }

        private void StartSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            resetCaptureService();
        }

        private void checkBoxSourceFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSourceFullScreen.Checked)
            {
                numericUpDownSourceLeft.Value = Screen.AllScreens[comboBoxSourceScreenIndex.SelectedIndex].Bounds.Left;
                numericUpDownSourceTop.Value = Screen.AllScreens[comboBoxSourceScreenIndex.SelectedIndex].Bounds.Top;
                numericUpDownSourceWidth.Value = Screen.AllScreens[comboBoxSourceScreenIndex.SelectedIndex].Bounds.Width;
                numericUpDownSourceHeight.Value = Screen.AllScreens[comboBoxSourceScreenIndex.SelectedIndex].Bounds.Height;
            }
            numericUpDownSourceLeft.Enabled = !checkBoxSourceFullScreen.Checked;
            numericUpDownSourceTop.Enabled = !checkBoxSourceFullScreen.Checked;
            numericUpDownSourceWidth.Enabled = !checkBoxSourceFullScreen.Checked;
            numericUpDownSourceHeight.Enabled = !checkBoxSourceFullScreen.Checked;
        }

        private void checkBoxDestFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDestFullScreen.Checked)
            {
                numericUpDownDestWidth.Value = Screen.AllScreens[comboBoxDestScreenIndex.SelectedIndex].Bounds.Width;
                numericUpDownDestHeight.Value = Screen.AllScreens[comboBoxDestScreenIndex.SelectedIndex].Bounds.Height;
            }
            numericUpDownDestWidth.Enabled = !checkBoxDestFullScreen.Checked;
            numericUpDownDestHeight.Enabled = !checkBoxDestFullScreen.Checked;
        }

        private void comboBoxSourceScreenIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxSourceFullScreen.Checked)
            {
                numericUpDownSourceLeft.Value = Screen.AllScreens[comboBoxSourceScreenIndex.SelectedIndex].Bounds.Left;
                numericUpDownSourceTop.Value = Screen.AllScreens[comboBoxSourceScreenIndex.SelectedIndex].Bounds.Top;
                numericUpDownSourceWidth.Value = Screen.AllScreens[comboBoxSourceScreenIndex.SelectedIndex].Bounds.Width;
                numericUpDownSourceHeight.Value = Screen.AllScreens[comboBoxSourceScreenIndex.SelectedIndex].Bounds.Height;
            }
        }

        private void comboBoxDestScreenIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxDestFullScreen.Checked)
            {
                numericUpDownDestWidth.Value = Screen.AllScreens[comboBoxDestScreenIndex.SelectedIndex].Bounds.Width;
                numericUpDownDestHeight.Value = Screen.AllScreens[comboBoxDestScreenIndex.SelectedIndex].Bounds.Height;
            }
        }

        private void buttonRefreshPreview_Click(object sender, EventArgs e)
        {
            if (checkBoxWindowCaption.Checked && currentDisplayWindowsIdx < 0)
            {
                MessageBox.Show("请选择需要显示的程序画面", "提醒");
                return;
            }
            pictureBoxPreview.Image = captureImage();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (checkBoxWindowCaption.Checked && currentDisplayWindowsIdx < 0)
            {
                MessageBox.Show("请选择需要显示的程序画面", "提醒");
                return;
            }
            startCaptureService();
        }

        private void buttonGetRunningProblems_Click(object sender, EventArgs e)
        {
            loadRunningProgramScreen();
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (wndList != null)
            {
                int clickIndex = int.Parse(pb.Name.Substring(3));
                currentDisplayWindowsIdx = clickIndex;
                WindowInfo[] windowArray = wndList.ToArray();
                if (windowArray.Length > clickIndex)
                {
                    WindowInfo windowObj = windowArray[clickIndex];
                    currentDisplayHWnd = windowObj.hWnd;
                    Image windowImage = captionProcesImage();
                    pictureBoxPreview.Image = windowImage;
                    textBoxWindowName.Text = windowObj.szWindowName;
                    textBoxClassName.Text = windowObj.szClassName;
                }
            }
        }

        private void timerDisplayForm_Tick(object sender, EventArgs e)
        {
            if (sd != null)
            {
                using (Image imgDisp = captureImage()) { 
                    if (imgDisp != null)
                    {
                        sd.displayImage(imgDisp);
                        imgDisp.Dispose();
                    }
                }
            }
        }
        #endregion

        #region Capture Function
        private void startCaptureService()
        {
            resetCaptureService();
            if (checkBoxShowWEB.Checked)
            {
                if (wms == null)
                {
                    wms = new WebMonitorService(Decimal.ToInt32(numericUpDownWebPort.Value));
                    numericUpDownWebPort.Enabled = false;
                }
                wms.start(captureImageToByte);
            }
            if (checkBoxShowForm.Checked)
            {
                int destrnationScreenIdx = comboBoxDestScreenIndex.SelectedIndex;
                int destinationWidth = Decimal.ToInt32(numericUpDownDestWidth.Value);
                int destinationHeight = Decimal.ToInt32(numericUpDownDestHeight.Value);

                int sourceStartX = Decimal.ToInt32(numericUpDownSourceLeft.Value);
                int sourceStartY = Decimal.ToInt32(numericUpDownSourceTop.Value);
                int sourceWidth = Decimal.ToInt32(numericUpDownSourceWidth.Value);
                int sourceHeight = Decimal.ToInt32(numericUpDownSourceHeight.Value);

                int destrationX = Decimal.ToInt32(numericUpDownDestTop.Value);
                int destrationY = Decimal.ToInt32(numericUpDownDestLeft.Value);

                bool destrationMostTop = checkBoxDestMostTop.Checked;

                sd = new CaptureDisplay(sourceStartX, sourceStartY, sourceWidth, sourceHeight, destrationX, destrationY, destinationWidth, destinationHeight, destrationMostTop);
                sd.displayImage(captureImage());
                sd.Show();
                timerDisplayForm.Enabled = true;
            }
        }
        private void resetCaptureService()
        {
            timerDisplayForm.Enabled = false;
            if (sd != null)
            {
                sd.Close();
                sd = null;
            }
            if (wms != null)
            {
                wms.shutdown();
            }
        }
        private Image CaptureImage(int screenLeft, int screenTop, int screenWidh, int screenHeight)
        {
            //创建图象，保存将来截取的图象
            Bitmap image = new Bitmap(screenWidh, screenHeight);
            try
            {
                if (image != null)
                {
                    using (Graphics imgGraphics = Graphics.FromImage(image)) { 
                        //设置截屏区域
                        imgGraphics.CopyFromScreen(screenLeft, screenTop, 0, 0, new Size(screenWidh, screenHeight));
                    }
                }
            }
            catch
            {

            }
            return image;
        }
        private Image GetReducedImage(Image resourceImage, int width, int height)
        {
            try
            {
                Image data = null;
                using (Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb))
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.DrawImage(resourceImage, new Rectangle(0, 0, width, height));
                    }
                    data = new Bitmap(bitmap);
                }
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private Image captureImage()
        {
            if (checkBoxWindowCaption.Checked)
            {
                return captionProcesImage();
            }
            else
            {
                return CaptureImage(Decimal.ToInt32(numericUpDownSourceLeft.Value), Decimal.ToInt32(numericUpDownSourceTop.Value), Decimal.ToInt32(numericUpDownSourceWidth.Value), Decimal.ToInt32(numericUpDownSourceHeight.Value));
            }
        }
        private Image captionProcesImage()
        {
            return captionProcesImage(currentDisplayHWnd);
        }
        private Image captionProcesImage(IntPtr handle)
        {
            try
            {
                // get te hDC of the target window
                IntPtr hdcSrc = User32.GetWindowDC(handle);
                // get the size
                User32.RECT windowRect = new User32.RECT();
                User32.GetWindowRect(handle, ref windowRect);
                int width = windowRect.right - windowRect.left;
                int height = windowRect.bottom - windowRect.top;
                // create a device context we can copy to
                IntPtr hdcDest = GDI32.CreateCompatibleDC(hdcSrc);
                // create a bitmap we can copy it to,
                // using GetDeviceCaps to get the width/height
                IntPtr hBitmap = GDI32.CreateCompatibleBitmap(hdcSrc, width, height);
                // select the bitmap object
                IntPtr hOld = GDI32.SelectObject(hdcDest, hBitmap);
                // bitblt over
                GDI32.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, GDI32.SRCCOPY);
                // restore selection
                GDI32.SelectObject(hdcDest, hOld);
                // clean up
                GDI32.DeleteDC(hdcDest);
                User32.ReleaseDC(handle, hdcSrc);
                // get a .NET image object for it
                Image img = Image.FromHbitmap(hBitmap);
                // free up the Bitmap object
                GDI32.DeleteObject(hBitmap);

                return img;
            }
            catch
            {
                return null;
            }
        }
        private bool isBlackImage(Image imgObj)
        {
            Color c = new Color();
            Image smallImg = this.GetReducedImage(imgObj, 25, 25);
            using (Bitmap bmp = new Bitmap(smallImg))
            {
                //历遍图片的像素点
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        c = bmp.GetPixel(x, y);

                        //判断像素点的色偏差值Diff
                        if (c.R != 0 || c.G != 0 || c.B != 0)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
        }
        private byte[] captureImageToByte()
        {
            Image imgPhoto = captureImage();
            MemoryStream mstream = new MemoryStream();
            imgPhoto.Save(mstream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] byData = new Byte[mstream.Length];
            mstream.Position = 0;
            mstream.Read(byData, 0, byData.Length); mstream.Close();
            return byData;
        }
        private void loadRunningProgramScreen()
        {
            checkBoxWindowCaption.Checked = true;
            panelImg.Controls.Clear();
            currentDisplayWindowsIdx = -1;

            wndList = new List<WindowInfo>();
            User32.EnumWindows(delegate (IntPtr hWnd, int lParam)
            {
                WindowInfo wnd = new WindowInfo();
                StringBuilder sb = new StringBuilder(256);
                //get hwnd
                wnd.hWnd = hWnd;
                //get window name
                User32.GetWindowTextW(hWnd, sb, sb.Capacity);
                wnd.szWindowName = sb.ToString();
                //get window class
                User32.GetClassNameW(hWnd, sb, sb.Capacity);
                wnd.szClassName = sb.ToString();

                wnd.name = wnd.szWindowName + " - " + wnd.szClassName;
                //add it into list
                if (addPictureItem(wnd))
                {
                    wndList.Add(wnd);
                }

                return true;
            }, 0);
        }
        private bool addPictureItem(WindowInfo wInfo)
        {
            int miniWindowSize = 500;
            IntPtr hWnd = wInfo.hWnd;
            Image dispImg = captionProcesImage(wInfo.hWnd);
            if (wInfo.szWindowName != "" && dispImg.Size.Width > miniWindowSize && dispImg.Size.Height > miniWindowSize && isBlackImage(dispImg))
            {
                PictureBox pic = new PictureBox();
                pic.Image = dispImg;
                //设置图像相关属性及事件
                pic.Name = string.Format("pic{0}", this.panelImg.Controls.Count);//Name属性
                pic.Width = 200; //Size-Width
                pic.Height = 200; //Size-Height
                pic.Click += this.picBox_Click;
                pic.BorderStyle = BorderStyle.FixedSingle;//边框样式：单线边
                pic.SizeMode = PictureBoxSizeMode.Zoom;//设置图像SizeMode=Zoom
                pic.Cursor = Cursors.Hand;//鼠标悬浮样式：小手
                this.panelImg.Controls.Add(pic);

                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
