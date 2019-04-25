using System;

namespace GeometricalFigures
{
    /// <summary>
    /// Объект "круг"
    /// </summary>
    public class Circle : FigureBase
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private double _radius;

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = LengthValidation(value);
            }
        }

        /// <summary>
        /// Вычисленная площадь
        /// </summary>
        public override double CalculateArea
        {
            get
            {
                return (Math.Pow(_radius, 2) * Math.PI);
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// Конструктор по умолячанию
        /// </summary>
        public Circle() { }
    }
}
