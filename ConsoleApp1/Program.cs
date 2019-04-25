using System;
using System.Reflection;

namespace GeometricalFigures
{	
    /// <summary>
    /// Программа для лабораторной 3
    /// </summary>
	/// //TODO: RSDN
    class Program
    {		
        /// <summary>
        /// Начало выполнения программы
        /// </summary>
        /// <param name="args">Имя</param>
		/// //TODO: RSDN
        static void Main(string[] args)
        {
			var figures = new FigureBase[] 
			{
				new Rectangle(),
				new Circle(),
				new Triangle()
			};

            //Заполнение информации о фигурах с консоли
            FillFigureData(figures);

            //Расчет площади фигур
            CalculateFigure(figures);

            Console.ReadKey();
        }

        /// <summary>
        /// Заполнение информации о фигурах с консоли
        /// </summary>
        /// <param name="figureList">Список фигур</param>
        static void FillFigureData(params FigureBase[] figureList)
        {
            for (var i = 0; i < figureList.Length; i++)
            {
                //Запись списка свойств фигур в массив
				PropertyInfo[] figureProperties = figureList[i].GetType().GetProperties();
                Console.WriteLine("*****" + figureList[i].GetType().Name + "*****");
                foreach (var property in figureProperties)
                {
                    if (property.CanWrite)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Write($"Введите параметр {property.Name}:");
                                property.SetValue(figureList[i], ReturnValueFromConsole());
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.InnerException.Message);
                            }
                        }

                    }
                }
            }
        }

        /// <summary>
        /// Расчет площади фигур
        /// </summary>
        /// <param name="figureList">Список фигур</param>
        static void CalculateFigure(params FigureBase[] figureList)
        {
            for (int i = 0; i < figureList.Length; i++)
            {               
                Console.WriteLine($"Площадь фигуры {figureList[i].GetType().Name} " +
					$"= {figureList[i].CalculateArea}");
            }
        }

        /// <summary>
        /// Получение значения из консоли
        /// </summary>
        /// <returns>Введенное значение</returns>
        static double ReturnValueFromConsole()
        {
            double value;
            while (true)
            {
                try
                {
                    value = Convert.ToDouble(Console.ReadLine());
                    break;
                }

                catch
                {
                    Console.WriteLine("Возможен ввод только чисел. Поторите ввод.");
                }
            }
            return value;
        }
    }
}
