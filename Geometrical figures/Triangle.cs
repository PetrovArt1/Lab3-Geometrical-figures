namespace GeometricalFigures
{
    /// <summary>
    /// Объект "треугольник"
    /// </summary>
    public class Triangle : FigureBase
    {		
        /// <summary>
        /// Основание треугольника
        /// </summary>
        private double _triangleBase;

        /// <summary>
        /// Высота
        /// </summary>
        private double _heigth;

        /// <summary>
        /// Основание трегуольника
        /// </summary>
        public double TriangleBase
        {
            get
            {
                return _triangleBase;
            }
            set
            {
                _triangleBase = LengthValidation(value);
            }
        }

        /// <summary>
        /// Высота
        /// </summary>
        public double Heigth
        {
            get
            {
                return _heigth;
            }
            set
            {
                _heigth = LengthValidation(value);
            }
        }

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        public override double CalculateArea
        {
            get
            {
                return (_triangleBase * _heigth) / 2;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="triangleBase">Основание треугольника</param>
        /// <param name="heigth">Высота</param>
        public Triangle(double triangleBase, double heigth)
        {
            _heigth = heigth;
            _triangleBase = triangleBase;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Triangle() { }
    }
}
