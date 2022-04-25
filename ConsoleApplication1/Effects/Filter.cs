using ConsoleApplication1.pixel;

namespace ConsoleApplication1.Effects
{
    public class Filter: IEffect
    {
        public Picture ChangePicture(Picture originalPicture, double[] parameters)
        {
            var newPicture = new Picture(originalPicture.Height, originalPicture.Width, originalPicture.PixelCount);
            for (int h = 0; h < originalPicture.Height; h++)
            {
                for (int w = 0; w < originalPicture.Width; w++)
                {
                    newPicture.Pixels[w, h].Red = originalPicture.Pixels[w, h].Red * parameters[0];
                    newPicture.Pixels[w, h].Green = originalPicture.Pixels[w, h].Green * parameters[0];
                    newPicture.Pixels[w, h].Blue = originalPicture.Pixels[w, h].Blue * parameters[0];
                }
            }

            return newPicture;
        }
    }
}