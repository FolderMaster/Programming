using Programming.Model.Enums;
namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Прямоугольник с координатами центра, длиной и шириной.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Количество всех экземпляров класса.
        /// </summary>
        private static uint _allRectanglesCount;

        /// <summary>
        /// Уникальный индентификатор для всех экземпляров класса.
        /// </summary>
        private uint _id;

        /// <summary>
        /// Длина.
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина.
        /// </summary>
        private double _width;

        /// <summary>
        /// Возвращает количество всех экземпляров класса.
        /// </summary>
        static public int AllRectanglesCount
        {
            get
            {
                return (int)_allRectanglesCount;
            }
        }

        /// <summary>
        /// Возвращает уникальный индентификатор экземпляра класса.
        /// </summary>
        public int Id
        {
            get
            {
                return (int)_id;
            }
        }

        /// <summary>
        /// Возвращает и задает длину. Должна быть неотрицательным числом.
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задает длину. Должна быть неотрицательным числом.
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координаты центра.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает цвет.
        /// </summary>
        public Colour Color { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/> по умолчанию.
        /// </summary>
        public Rectangle()
        {
            _id = _allRectanglesCount;
            _allRectanglesCount += 1;

            Length = 1;
            Width = 1;
            Center = new Point2D();
            Color = Colour.None;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длина. Должна быть неотрицательным числом.</param>
        /// <param name="width">Ширина. Должна быть неотрицательным числом.</param>
        /// <param name="center">Координаты центра.</param>
        /// <param name="color">Цвет.</param>
        public Rectangle(double length, double width, Point2D center, Colour color)
        {
            _id = _allRectanglesCount;
            _allRectanglesCount += 1;

            Length = length;
            Width = width;
            Center = center;
            Color = color;
        }

        override public string ToString()
        {
            return $"{_id}. (X = {Center.X}, Y = {Center.Y}, L = {Length}, W = {Width})";
        }
    }
}