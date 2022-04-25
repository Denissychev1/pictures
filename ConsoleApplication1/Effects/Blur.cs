using System;
using ConsoleApplication1.pixel;

namespace ConsoleApplication1.Effects
{
    public class Blur: IEffect
    {
        public Picture ChangePicture(Picture originalPicture, double[] parameters)
        {
            var newPhoto = new Picture(originalPicture.Height, originalPicture.Width, originalPicture.PixelCount);
            for (int h = 0; h < newPhoto.Height; h++)
            {
                for (int w = 0; w < newPhoto.Width; w++)
                {
                    newPhoto.PixelCount = Convert.ToInt32(originalPicture.PixelCount * parameters[0]);
                }
            }

            return newPhoto;
        }
    }
}