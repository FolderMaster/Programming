using System;
namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Предоставляет методы проверки коллизий различных геометрических объектов.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет коллизию между двумя прямоугольниками.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если условия коллизии выполнены для прямоугольников,
        /// а иначе - false.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double sLength = Math.Abs(rectangle1.Length + rectangle2.Length);
            double dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double sWidth = Math.Abs(rectangle1.Width + rectangle2.Width);
            return dX < (sLength / 2) && dY < (sWidth / 2);
        }

        /// <summary>
        /// Проверяет коллизию между двумя кольцами.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true, если условия коллизиии выполнены для колец,
        /// а иначе - false.</returns>
        public static bool IsCollion(Ring ring1, Ring ring2)
        {
            double c = Math.Sqrt(Math.Pow(ring1.Center.X - ring2.Center.X, 2)
                + Math.Pow(ring1.Center.Y - ring2.Center.Y, 2));
            double sumRadius = ring1.OuterRadius + ring2.OuterRadius;
            return c < sumRadius;
        }
    }
}
