using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsProgression(new int[] { 1,2,4,8,16}));
        }

        /// <summary>
        /// Метод определяет, являются ли числа в массиве арифметической или геометрической прогрессией или массив не содержит прогрессии
        /// </summary>
        /// <param name="num">Массив чисел</param>
        /// <returns>Результат в виде строки</returns>
        public static string IsProgression (params int[] num)
        {
            string result = "";

            if (num != null)
            {
                bool isArithmetic = true;
                bool isGeometric = true;

                if (num.Length > 1)
                {
                    int a = num[1] - num[0];
                    double g = (double)num[1] / num[0];

                    for (int i = 2; i < num.Length; i++)
                    {
                        if (num[i] - num[i - 1] != a)
                        {
                            isArithmetic = false;
                        }

                        if ((double)num[i]/ num[i - 1] != g)
                        {
                            isGeometric = false;
                        }

                        if (!isArithmetic && !isGeometric)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    isArithmetic = false;
                    isGeometric = false;
                }

                if (isArithmetic) { result = "Арифметическая прогрессия"; }
                else if (isGeometric) { result = "Геометрическая прогрессия"; }
                else { result = "Не являются прогрессией"; }

            }

            return result;
        }
    }
}
