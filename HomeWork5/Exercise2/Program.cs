using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Ищет слово с минимальной длиной в тексте
        /// </summary>
        /// <param name="text">Строка с текстом</param>
        /// <returns>Слово с минимальной длиной</returns>
        public static string MinWord(string text)
        {
            string minWord = null;

            if (!String.IsNullOrEmpty(text))
            {
                char[] charSeparators = new char[] { ' ' };

                string[] arrText = text.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

                if (arrText.Length > 0)
                {
                    minWord = arrText[0];

                    for (int i = 0; i < arrText.Length; i++)
                    {
                        if (arrText[i].Length < minWord.Length)
                        {
                            minWord = arrText[i];
                        }
                    }
                }
            }

            return minWord;
        }

        /// <summary>
        /// Ищет слово с максимальной длиной в тексте
        /// </summary>
        /// <param name="text">Строка с текстом</param>
        /// <returns>Коллекцию слов с максимальной длиной</returns>
        public static List<string> MaxWord(string text)
        {
            List<string> result = new List<string>();

            if (!String.IsNullOrEmpty(text))
            {
                char[] charSeparators = new char[] { ' ' };

                string[] arrText = text.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

                if (arrText.Length > 0)
                {
                    string maxWord = arrText[0];

                    for (int i = 0; i < arrText.Length; i++)
                    {
                        if (arrText[i].Length > maxWord.Length)
                        {
                            maxWord = arrText[i];
                        }
                    }

                    for (int i = 0; i < arrText.Length; i++)
                    {
                        if (arrText[i].Length == maxWord.Length)
                        {
                            result.Add(arrText[i]);
                        }
                    }
                }
            }

            return result;
        }
    }
}
