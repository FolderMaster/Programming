using Programming.Model.Enums;
namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static uint _allRectanglesCount;

        private uint _id;

        private double _length;

        private double _width;

        static public int AllRectanglesCount
        {
            get
            {
                return (int)_allRectanglesCount;
            }
        }

        public int Id
        {
            get
            {
                return (int)_id;
            }
        }

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

        public Point2D Center { get; set; }

        public Colour Color { get; set; }

        public Rectangle()
        {
            _id = _allRectanglesCount;
            _allRectanglesCount += 1;

            Length = 1;
            Width = 1;
            Center = new Point2D();
            Color = Colour.None;
        }

        public Rectangle(double length, double width, Point2D center, Colour color)
        {
            _id = _allRectanglesCount;
            _allRectanglesCount += 1;

            Length = length;
            Width = width;
            Center = center;
            Color = color;
        }
    }
}