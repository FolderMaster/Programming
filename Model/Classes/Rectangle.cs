using System;
namespace Programming.Model.Classes
{
    class Rectangle
    {
        private double _length;

        private double _width;
        
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException();
                }
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
                if(value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Color { get; set; }

        public Rectangle()
        {
            Length = 1;
            Width = 1;
            Color = "";
        }

        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
    }
}