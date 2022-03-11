using System;
namespace Programming.Model.Classes
{
    class Rectangle
    {
        public Rectangle()
        {
            this.Length = 1;
            this.Width = 1;
            this.Color = "White";
        }
        public Rectangle(float Length, float Width, string Color)
        {
            this.Length = Length;
            this.Width = Width;
            this.Color = Color;
        }
        float length;
        public float Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        float width;
        public float Width
        {
            get
            {
                return width;
            }
            set
            {
                if(value > 0)
                {
                    width = value;
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