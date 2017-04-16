using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImageTemplateFinder
{
    class Program
    {
        string imagePath;
        string templatePath;
        Bitmap img;
        Bitmap tmpl;

        void Main(string[] args)
        {
            imagePath = "";
            templatePath = "";
            img = new Bitmap(imagePath);
            tmpl = new Bitmap(templatePath);



        }

    }
}
