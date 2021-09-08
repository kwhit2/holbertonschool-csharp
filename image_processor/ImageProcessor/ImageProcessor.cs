using System;
using System.Drawing;

///<summary> ImageProcessor class </summary>
class ImageProcessor
{
    ///<summary> Inverse method: inverts an image’s color </summary>
    public static void Inverse(string[] filenames)
    {
        foreach (string file in filenames)
        {
            string fileWithoutImages = file.Remove(0, 7);
            string fileWithoutImagesAndJPG = fileWithoutImages.Remove(fileWithoutImages.Length - 4, 4);
            string fileInverse = fileWithoutImagesAndJPG + "_inverse" + ".jpg";
            // Console.WriteLine(fileInverse);

            Bitmap temp = new Bitmap(file);
            Bitmap bmap = (Bitmap)temp.Clone();
                Color c;
            for (int i = 0; i < bmap.Width; i++)
                {
                    for (int j = 0; j < bmap.Height; j++)
                        {
                            c = bmap.GetPixel(i, j);
                            bmap.SetPixel(i, j,
                Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
            temp = (Bitmap)bmap.Clone();
            temp.Save("C:\\Users\\kfw2\\holbertonschool-csharp\\image_processor\\" + fileInverse);
        }
    }
}
