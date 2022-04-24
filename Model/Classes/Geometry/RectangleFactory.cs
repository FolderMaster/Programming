using System;

using Programming.Model.Enums;

namespace Programming.Model.Classes.Geometry
{
    public static class RectangleFactory
    {
        private static Random _random = new Random();
        public static Rectangle Randomize(int widthCanvas, int heightCanvas)
        {
            double legth = Math.Round(_random.NextDouble() + _random.Next(1, widthCanvas - 30), 0);
            double width = Math.Round(_random.NextDouble() + _random.Next(1, heightCanvas - 30), 0);
            double x = Math.Round(_random.NextDouble() + _random.Next(15 + (int)legth / 2, widthCanvas - (16 + (int)legth / 2)), 0);
            double y = Math.Round(_random.NextDouble() + _random.Next(15 + (int)width / 2, heightCanvas - (16 + (int)width / 2)), 0);
            return new Rectangle(legth, width, new Point2D(x, y), (Colour)_random.Next(0, 9));
        }
    }
}
