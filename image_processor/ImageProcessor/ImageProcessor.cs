using System;
using System.Drawing;
using System.Drawing.Imaging;

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

    ///<summary> Thumbnail method: creates a thumbnail image </summary>
    public static void Thumbnail(string[] filenames, int height)
    {
        foreach (string file in filenames)
        {
            string fileWithoutImages = file.Remove(0, 7);
            string fileWithoutImagesAndJPG = fileWithoutImages.Remove(fileWithoutImages.Length - 4, 4);
            string fileTH = fileWithoutImagesAndJPG + "_th" + ".jpg";

            Bitmap temp = new Bitmap(file);
            Bitmap bmap = (Bitmap)temp.Clone();
            int imgHeight = bmap.Height;
            int imgWidth = bmap.Width;
            double aspectRatioX = (double)imgWidth / imgHeight;
            int thumbWidth = (int)(height * aspectRatioX);

            Image thumbNailImg = bmap.GetThumbnailImage(thumbWidth, height, ()=>false, IntPtr.Zero);

            var qualityEncoder = System.Drawing.Imaging.Encoder.Quality;
            var quality = (long)100; // Image quality 
            var ratio = new EncoderParameter(qualityEncoder, quality);
            var codecParams = new EncoderParameters(1);
            codecParams.Param[0] = ratio;
            var codecInfo = GetEncoder(ImageFormat.Jpeg);

            thumbNailImg.Save("C:\\Users\\kfw2\\holbertonschool-csharp\\image_processor\\" + fileTH, codecInfo, codecParams);
        }
    }
    /// <summary> Image Decoder : found on many resources </summary>
    private static ImageCodecInfo GetEncoder(ImageFormat format)
    {
        ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
        foreach (ImageCodecInfo codec in codecs)
        {
            if (codec.FormatID == format.Guid)
            {
                return codec;
            }
        }
        return null;
    }
}
