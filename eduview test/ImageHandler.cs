using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Management;
using System.Runtime.InteropServices;

namespace EduViewStudent
{
    public class ScreenshotHandler
    {
        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int nIndex);

        public Bitmap GetScreenshot()
        {
            Size size = GetScreenData();
            Console.WriteLine(size.ToString());
            Bitmap capture = CaptureScreen(size);
            return capture;
        }

        private Size GetScreenData()
        {
            Size size = new Size(GetSystemMetrics(0), GetSystemMetrics(1));
            return size;
        }

        private Bitmap CaptureScreen(Size screenData)
        {
            // Create a bitmap with the specified size
            Bitmap capture = new Bitmap(screenData.Width, screenData.Height, PixelFormat.Format32bppArgb);

            using (Graphics captureGraphics = Graphics.FromImage(capture))
            {
                // Capture the screen content
                captureGraphics.CopyFromScreen(0, 0, 0, 0, screenData);
            }

            return capture;
        }
    }
}
