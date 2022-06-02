using System.Drawing;

namespace Programming.View
{
    /// <summary>
    /// Хранит в себе константные значения цветов приложения.
    /// </summary>
    public class AppColors
    {
        public static readonly Color SpringColor = Color.LightGreen;

        public static readonly Color AutumnColor = Color.Orange;

        public static readonly Color CorrectColor = Color.White;

        public static readonly Color ErrorColor = Color.Pink;

        public static readonly Color CollisionColor = Color.FromArgb(127, 255, 127, 127);

        public static readonly Color NoneCollisionColor = Color.FromArgb(127, 127, 255, 127);
    }
}
