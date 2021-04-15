using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NoRepetition("ПППОООГГГООООДДДААА"));
            Console.WriteLine(NoRepetition("Ххххоооорррооошшшиий деееннннь"));
        }

        /// <summary>
        /// Метод возвращает новую строку, в которой отсутствуют все повторяющиеся, рядом стоящие символы
        /// </summary>
        /// <param name="text">Произвольный текст в виде строки</param>
        /// <returns>Возвращает новую строку, в которой отсутствуют все повторяющиеся, рядом стоящие символы.</returns>
        public static string NoRepetition (string text)
        {
            string result = "";

            if (!string.IsNullOrEmpty(text))
            {
                text = text.ToLower();

                result += text[0];

                for (int i = 1; i < text.Length; i++)
                {
                    if (text[i - 1] != text[i])
                    {
                        result += text[i];
                    }
                }
            }

            return result;
        }
    }
}
