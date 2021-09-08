using System;
using System.Drawing;

///<summary> ImageProcessor class </summary>
class ImageProcessor
{
    ///<summary> Inverse method: inverts image(s) color </summary>
    public static void Inverse(string[] filenames)
    {
        foreach (string file in filenames)
        {
            string fileWithoutImages = file.Remove(0, 7);
            string fileWithoutImagesAndJPG = fileWithoutImages.Remove(fileWithoutImages.Length - 4, 4);
            string fileInverse = fileWithoutImagesAndJPG + "_inverse" + ".jpg";

            Bitmap temp = new Bitmap(file);
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;

            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    bmap.SetPixel(i, j, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
            temp = (Bitmap)bmap.Clone();
            temp.Save("C:\\Users\\kfw2\\holbertonschool-csharp\\image_processor\\" + fileInverse);
        }
    }

    ///<summary> GrayScale method: converts image(s) to grayscale </summary>
    public static void Grayscale(string[] filenames)
    {
        foreach (string file in filenames)
        {
            string fileWithoutImages = file.Remove(0, 7);
            string fileWithoutImagesAndJPG = fileWithoutImages.Remove(fileWithoutImages.Length - 4, 4);
            string fileGrayscale = fileWithoutImagesAndJPG + "_grayscale" + ".jpg";
        
            Bitmap temp = new Bitmap(file);
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;

            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);
                    bmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            temp = (Bitmap)bmap.Clone();
            temp.Save("C:\\Users\\kfw2\\holbertonschool-csharp\\image_processor\\" + fileGrayscale);
        }
    }

    ///<summary> BlackWhite method: reduces each image to only black and white values, based on a given threshold. </summary>
    public static void BlackWhite(string[] filenames, double threshold)
    {
        foreach (string file in filenames)
        {
            string fileWithoutImages = file.Remove(0, 7);
            string fileWithoutImagesAndJPG = fileWithoutImages.Remove(fileWithoutImages.Length - 4, 4);
            string fileBW = fileWithoutImagesAndJPG + "_bw" + ".jpg";
        
            Bitmap temp = new Bitmap(file);
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;

            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    double luminance = ((c.R * 0.3) + (c.G * 0.59) + (c.B * 0.11));

                    if (luminance < threshold)
                    {
                        bmap.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        bmap.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            temp = (Bitmap)bmap.Clone();
            temp.Save("C:\\Users\\kfw2\\holbertonschool-csharp\\image_processor\\" + fileBW);
        }
    }
}
