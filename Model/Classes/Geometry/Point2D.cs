﻿namespace Programming.Model.Classes.Geometry
{
    public class Point2D
    {
        private double _x;

        private double _y;

        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }

        public Point2D()
        {
            X = 0;
            Y = 0;
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}