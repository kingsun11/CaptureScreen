using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CaptureScreen
{
    class ImageCapture
    {
        public Image CaptureImage()
        {
            int screenLeft = Screen.PrimaryScreen.Bounds.Left;
            int screenTop = Screen.PrimaryScreen.Bounds.Top;
            int screenWidh = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            return CaptureImage(screenLeft, screenTop, screenWidh, screenHeight);
        }
        public Image CaptureImage(int screenLeft, int screenTop, int screenWidh, int screenHeight)
        {
            //创建图象，保存将来截取的图象
            Bitmap image = new Bitmap(screenWidh - screenLeft, screenHeight - screenTop);

            Graphics imgGraphics = Graphics.FromImage(image);

            //设置截屏区域
            imgGraphics.CopyFromScreen(screenLeft, screenTop, 0, 0, new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));

            return image;
        }

        public Image GetReducedImage(Image resourceImage, int width, int height)
        {
            try
            {
                Image data = null;
                //用指定的大小和格式初始化Bitmap类的新实例 
                using (Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb))
                {
                    //从指定的Image对象创建新Graphics对象 
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        //清除整个绘图面并以透明背景色填充 
                        //graphics.Clear(Color.Transparent);
                        //在指定位置并且按指定大小绘制原图片对象 
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

        public void SaveImage(Image sourceImage, string fileName)
        {
            if (sourceImage != null)
                sourceImage.Save(fileName, ImageFormat.Jpeg);
        }

    }
}
