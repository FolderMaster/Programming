namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Точка в двухмерном пространстве с координатами.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата точки x.
        /// </summary>
        private double _x;

        /// <summary>
        /// Коодината точки y.
        /// </summary>
        private double _y;


        /// <summary>
        /// Возвращает и задает координату x. Должна быть неотрицательным числом.
        /// </summary>
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

        /// <summary>
        /// Возвращает задает координату y. Должна быть неотрицательным числом.
        /// </summary>
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
        
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/> по умолчанию.
        /// </summary>
        public Point2D()
        {
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата x. Должна быть неотрицательным числом.</param>
        /// <param name="y">Координата y. Должна быть неотрицательным числом.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
