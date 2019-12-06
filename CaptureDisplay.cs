using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CaptureScreen
{
    public partial class CaptureDisplay : Form
    {
        int screenStartX;
        int screenStartY;
        int screenWidth;
        int screenHeight;

        int displayWidth;
        int displayHeight;

        public CaptureDisplay(int startX, int startY, int captionWidth, int captionHeight,int destX, int destY, int showWidth, int showHeigth,bool mostTop)
        {
            InitializeComponent();

            displayWidth = showWidth;
            displayHeight = showHeigth;

            screenStartX = startX;
            screenStartY = startY;
            screenWidth = captionWidth;
            screenHeight = captionHeight;
            this.Location = new Point(destX, destY);
            this.Size = new Size(displayWidth + 1, displayHeight + 1);
            if (mostTop) {
                this.TopMost = true;
            }
            pictureBoxDisplay.Location = new Point(0,0);
            pictureBoxDisplay.Size = new Size(displayWidth, displayHeight);
            
        }

        public void displayImage(Image imgdisplay)
        {
            try
            {
                this.pictureBoxDisplay.Image = GetReducedImage(imgdisplay, displayWidth, displayHeight);
            }
            catch
            {

            }
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
    }
}
