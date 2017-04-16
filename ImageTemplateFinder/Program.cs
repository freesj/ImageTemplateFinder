using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTemplateFinder
{
    class Program
    {
        static bool imgIsScreenShot = true;
        static string imagePath;
        static string templatePath;
        static Bitmap img;
        static Bitmap tmpl;

        static void Main(string[] args)
        {
            if (imgIsScreenShot)
            {
                Bitmap printscreen = CaptureScreen();
            }
            else
            {
                imagePath = "";
                img = new Bitmap(imagePath);
            }
            templatePath = "c:\\test\\tmpl\\using.png";
            tmpl = new Bitmap(templatePath);


            System.Console.WriteLine(tmpl.GetPixel(0, 0).ToString());

            System.Console.WriteLine("Завершено!");
            System.Console.ReadKey();
        }

        static private Bitmap CaptureScreen(int sourceX, int sourceY, int destX, int destY, Size regionSize)
        {
            Bitmap bmp = new Bitmap(regionSize.Width, regionSize.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(sourceX, sourceY, destX, destY, regionSize);
            return bmp;
        }
        static private Bitmap CaptureScreen()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(0, 0, 0, 0, bmp.Size);
            return bmp;
        }


    }
}
