using System;
namespace Programming.Model.Classes.Geometry
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double dLength = Math.Abs(rectangle1.Length + rectangle2.Length);
            double dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double dWidth = Math.Abs(rectangle1.Width + rectangle2.Width);
            return dX < (dLength / 2) && dY < (dWidth / 2);
        }

        public static bool IsCollion(Ring ring1, Ring ring2)
        {
            double c = Math.Sqrt(Math.Pow(ring1.Center.X - ring2.Center.X, 2)
                + Math.Pow(ring1.Center.Y - ring2.Center.Y, 2));
            double sumRadius = ring1.OuterRadius + ring2.OuterRadius;
            return c < sumRadius;
        }
    }
}
