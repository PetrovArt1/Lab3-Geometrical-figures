namespace GeometricalFigures
{
    /// <summary>
    ///  Объект "Прямоугольник"
    /// </summary>
    public class Rectangle : FigureBase
    {
        /// <summary>
        /// Ширина
        /// </summary>
        private double _width;

        /// <summary>
        /// Длина
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = LengthValidation(value);
            }
        }

        /// <summary>
        /// Длина
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = LengthValidation(value);
            }
        }

        /// <summary>
        /// Расчет площади фигуры
        /// </summary>
        public override double CalculateArea
        {
            get
            {
                return _width * _length;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="length">Длина</param>
        public Rectangle(double width, double length)
        {
            _length = length;
            _width = width;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Rectangle() { }
    }
}
