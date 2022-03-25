using System;
namespace Programming.Model.Classes
{
    class Rectangle
    {
        public Rectangle()
        {
            Length = 1;
            Width = 1;
            Color = "White";
        }

        public Rectangle(float length, float width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        float _length;

        public float Length
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

        float _width;

        public float Width
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

        public string Color
        {
            get;
            set;
        }
    }
}