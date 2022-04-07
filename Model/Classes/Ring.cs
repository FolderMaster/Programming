using System;
namespace Programming.Model.Classes
{
    public class Ring
    {
        double _innerRadius;

        double _outerRadius;

        public Point2D Center { get; set; }

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Ring.InnerRadius");
                Validator.AssertMoreValue(value, _outerRadius, "Ring.InnerRadius", "Ring.OuterRadius");
                _innerRadius = value;
                UpdateSquare();
            }
        }

        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Ring.OuterRadius");
                Validator.AssertLessValue(value, _innerRadius, "Ring.OuterRadius", "Ring.InnerRadius");
                _outerRadius = value;
                UpdateSquare();
            }
        }

        public double Square { get; private set; }

        public Ring()
        {
            Center = new Point2D();
            InnerRadius = 1;
            OuterRadius = 2;
        }

        public Ring(Point2D center, double innerRadius, double outerRadius)
        {
            Center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }

        private void UpdateSquare()
        {
            Square = Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
        }
    }
}
