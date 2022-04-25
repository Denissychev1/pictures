using System;

namespace ConsoleApplication1.pixel
{
    public class Pixel
    {
        public double red;

        private double CheckValue(double value)
        {
            if (value < 0 || value > 1) throw new ArgumentException("value must be betwwen 0 and 1");
            return value;
        }

        public double Red
        {
            get => red;
            set => red = CheckValue(value);
        }

        public double green;

        public double Green
        {
            get => green;
            set => green = CheckValue(value);
        }

        public double blue;

        public double Blue
        {
            get => blue;
            set => blue = CheckValue(value);
        }
    }
}