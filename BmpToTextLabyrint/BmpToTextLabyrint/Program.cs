using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BmpToArray
{
    class Program
    {
        static string savePath = "Map.txt";

        static void Main(string[] args)
        {
            Bitmap bmp = new Bitmap("image.bmp");
            FileCheck();
            StreamWriter sw = new StreamWriter(savePath);
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    if (bmp.GetPixel(j, i).B == 0)
                        sw.Write("X");
                    else
                        sw.Write(" ");
                }
                sw.WriteLine();
            }
            sw.Close();

        }
        static void FileCheck()
        {
            if (!File.Exists(savePath))
                File.Create(savePath).Dispose();
        }


    }
}
