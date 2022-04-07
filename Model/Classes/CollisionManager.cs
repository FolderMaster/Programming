using System;
namespace Programming.Model.Classes
{
    public class CollisionManager
    {
        static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return (Math.Abs(rectangle1.Center.X - rectangle2.Center.X)
                < Math.Abs(rectangle1.Length - rectangle2.Length) / 2)
                || (Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y)
                < Math.Abs(rectangle1.Width - rectangle2.Width) / 2);
        }

        static bool IsCollion(Ring ring1, Ring ring2)
        {
            return Math.Sqrt(Math.Pow(ring1.Center.X - ring2.Center.X, 2)
                + Math.Pow(ring1.Center.Y - ring2.Center.Y, 2))
                < (ring1.OuterRadius + ring2.OuterRadius);
        }
    }
}
