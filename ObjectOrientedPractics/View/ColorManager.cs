using System.Drawing;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Класс цветов.
    /// </summary>
    public static class ColorManager
    {
        /// <summary>
        /// Возращает цвет для обозначения правильного значения.
        /// </summary>
        public static Color CorrectColor { get; } = Color.White;

        /// <summary>
        /// Возвращет цвет для обозначения неправильного значения.
        /// </summary>
        public static Color ErrorColor { get; } = Color.LightPink;
    }
}