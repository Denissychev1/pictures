using System;

namespace ConsoleApplication1.pixel
{
    public class Picture
    {
        public int Width;
        public int Height;
        public int PixelCount;
        public Pixel[,] Pixels;

        public Picture(int height, int width, int pixelCount)
        {
            Height = height;
            Width = width;
            PixelCount = pixelCount;
            Pixels = new Pixel[Convert.ToInt32(height/pixelCount), Convert.ToInt32(width/pixelCount)];

        }
    }
}