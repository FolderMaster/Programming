using System;
namespace Programming.Model.Classes.Geometry
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
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validator.AssertMoreValue(value, _outerRadius,
                    nameof(InnerRadius), nameof(OuterRadius));
                _innerRadius = value;
                UpdateArea();
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
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertLessValue(value, _innerRadius,
                    nameof(OuterRadius), nameof(InnerRadius));
                _outerRadius = value;
                UpdateArea();
            }
        }

        public double Area { get; private set; }

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

        private void UpdateArea()
        {
            Area = Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
        }
    }
}
