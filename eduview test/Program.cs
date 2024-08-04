using System.Drawing.Imaging;
using System.Drawing;

namespace EduViewStudent
{
    public partial class Program
    {
        

        public static int Main()
        {
            ScreenshotHandler sh = new ScreenshotHandler();

            Bitmap capture = sh.GetScreenshot();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "screenshot.png");
            capture.Save(filePath, ImageFormat.Png);

            return 0;
        }
    }
}
