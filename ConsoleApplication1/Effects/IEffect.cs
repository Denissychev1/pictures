using ConsoleApplication1.pixel;

namespace ConsoleApplication1.Effects
{
    public interface IEffect
    {
        Picture ChangePicture(Picture originalPicture, double[] parameters);
    }
}