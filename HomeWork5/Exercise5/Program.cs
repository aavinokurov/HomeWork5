using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Метод вычисляет функцию Аккермана
        /// </summary>
        /// <param name="n">Число - n</param>
        /// <param name="m">Число - m</param>
        /// <returns>Возвращает результат в виде числа</returns>
        public static uint FunAckerman (uint m, uint n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return FunAckerman(m - 1, 1);
            }
            else if (m > 0 && n > 0)
            {
                return FunAckerman(m - 1, FunAckerman(m, n - 1));
            }
            else
            {
                return 0;
            }
        }
    }
}
