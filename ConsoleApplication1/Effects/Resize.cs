using System;
using ConsoleApplication1.pixel;

namespace ConsoleApplication1.Effects
{
    public class Resize : IEffect
    {
        public Picture ChangePicture(Picture originalPicture, double[] parameters)
        {
            return new Picture(
                Convert.ToInt32(originalPicture.Height * parameters[0]),
                Convert.ToInt32(originalPicture.Width * parameters[0]), originalPicture.PixelCount);
        }
    }
}