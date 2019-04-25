using System;

namespace GeometricalFigures
{
    /// <summary>
    /// Базовый абстрактный класс фигур
    /// </summary>
    public abstract class FigureBase
    {
        /// <summary>
        /// Проверка параметров фигур на значения меньше или равных нулю
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns>Корректное значение</returns>
         protected double LengthValidation(double value)
        {
            if (value <= 0)
            {
                throw new Exception("Используйте значения больше нуля.");
            }
            return value;
        }
        /// <summary>
        /// Вычисленная площадь фигуры
        /// </summary>
        public abstract double CalculateArea { get; }
    }
}
