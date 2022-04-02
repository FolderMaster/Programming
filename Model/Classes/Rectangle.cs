using System;
using Programming.Model.Enums;
namespace Programming.Model.Classes
{
    public class Rectangle
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
                    throw new ArgumentException("Programming.Model.Classes.Rectangle.Length <= 0");
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
                    throw new ArgumentException("Programming.Model.Classes.Rectangle.Width <= 0");
                }
            }
        }

        public Colour Color { get; set; }

        public Rectangle()
        {
            Length = 1;
            Width = 1;
            Color = Colour.None;
        }

        public Rectangle(double length, double width, Colour color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
    }
}