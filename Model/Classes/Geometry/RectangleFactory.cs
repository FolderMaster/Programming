using System;

using Programming.Model.Enums;

namespace Programming.Model.Classes.Geometry
{
    public static class RectangleFactory
    {
        private static Random _random = new Random();
        public static Rectangle Randomize(int WidthCanvas, int HeightCanvas)
        {
            return new Rectangle(
                Math.Round(/*(random.NextDouble() + 0.0001) * */(double)_random.Next(1, WidthCanvas), 10),
                Math.Round(/*(random.NextDouble() + 0.0001) * */(double)_random.Next(1, HeightCanvas), 10),
                new Point2D(
                    Math.Round(/*(random.NextDouble() + 0.0001) * */(double)_random.Next(1, WidthCanvas), 3),
                    Math.Round(/*(random.NextDouble() + 0.0001) * */(double)_random.Next(1, HeightCanvas), 3)),
                (Colour)_random.Next(0, 9));
        }
    }
}
