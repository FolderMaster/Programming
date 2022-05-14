using System;

using Programming.Model.Enums;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Фабрика, создающая экземпляры класса <see cref="Rectangle"/>.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Размер отсутупа от краёв полотна.
        /// </summary>
        private static int _margin = 15;

        /// <summary>
        /// Экземпляр генератора случайных чисел.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Метод рандомизации экзепляров класса <see cref="Rectangle"/> по размерам полотна.
        /// </summary>
        /// <param name="widthCanvas">Длина полотна.</param>
        /// <param name="heightCanvas">Высота полотна.</param>
        /// <returns>Возвращает экземпляр класса <see cref="Rectangle"/>.</returns>
        public static Rectangle Randomize(int widthCanvas, int heightCanvas)
        {
            double length = Math.Round(_random.NextDouble() +
                _random.Next(0, widthCanvas - (_margin * 2 + 1)), 0);
            double width = Math.Round(_random.NextDouble() +
                _random.Next(0, heightCanvas - (_margin * 2 + 1)), 0);
            double x = Math.Round(_random.NextDouble() +
                _random.Next(_margin + (int)length / 2, widthCanvas - (_margin + 1 + (int)length / 2)), 0);
            double y = Math.Round(_random.NextDouble() +
                _random.Next(_margin + (int)width / 2, heightCanvas - (_margin + 1 + (int)width / 2)), 0);
            return new Rectangle(length, width, new Point2D(x, y), (Colour)_random.Next(0, 9));
        }
    }
}
