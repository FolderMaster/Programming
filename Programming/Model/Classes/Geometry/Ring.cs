using System;
namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Кольцо с внутренним и внешним радиусами.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Размеры внутреннего радиуса.
        /// </summary>
        double _innerRadius;

        /// <summary>
        /// Размеры внешнего радиуса.
        /// </summary>
        double _outerRadius;

        /// <summary>
        /// Возвращает и задаёт координаты центра.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задаёт размер внутреннего радиуса.
        /// Должен быть неотрицательным числом и больше размера внешнего радиуса.
        /// </summary>
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
        
        /// <summary>
        /// Возвращает и задаёт размер внешнего радиуса.
        /// Должен быть неотрицательным числом и меньше размера внутреннего радиуса.
        /// </summary>
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

        /// <summary>
        /// Возвращает площадь.
        /// </summary>
        public double Area { get; private set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/> по умолчанию.
        /// </summary>
        public Ring()
        {
            Center = new Point2D();
            InnerRadius = 1;
            OuterRadius = 2;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="center">Координаты центра.</param>
        /// <param name="innerRadius">Размер внутреннего радиуса.</param>
        /// <param name="outerRadius">Размер внешнего радиуса.</param>
        public Ring(Point2D center, double innerRadius, double outerRadius)
        {
            Center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }

        /// <summary>
        /// Обновляет площадь.
        /// </summary>
        private void UpdateArea()
        {
            Area = Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
        }
    }
}
