using System;
namespace Programming.Model.Classes
{
    class Rectangle
    {
        float length;
        public float Lenght
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
        string color;
        public string Color
        {
            get;
            set;
        }
    }
}