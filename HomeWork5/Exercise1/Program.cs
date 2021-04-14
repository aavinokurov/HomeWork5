using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] A = FillMatrix(3, 3);

            Console.WriteLine("Матрицы А: ");
            PrintMatrix(A);

            int[,] B = FillMatrix(3, 4);
            Console.WriteLine("Матрицы B: ");
            PrintMatrix(B);

            Console.WriteLine("Сложение матриц А и В: ");
            PrintMatrix(SumMatrix(A, B));

            Console.WriteLine("Матрицы А: ");
            PrintMatrix(A);

            Console.WriteLine("Матрицы B: ");
            PrintMatrix(B);
        }

        /// <summary>
        /// Заполняет матрицу случайными числами от 0 до 9
        /// </summary>
        /// <param name="row">Кол-во строк</param>
        /// <param name="column">Кол-во столбцов</param>
        /// <returns>Возращает матрицу заданного размера</returns>
        public static int[,] FillMatrix(int row, int column)
        {
            Random rnd = new Random();
            int[,] result = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    result[i, j] = rnd.Next(10);
                }
            }

            return result;
        }

        /// <summary>
        /// Выводит в консоль матрицу
        /// </summary>
        /// <param name="matrix">Входная матрица</param>
        public static void PrintMatrix(int[,] matrix)
        {
            if (matrix != null)
            {
                int row = matrix.GetLength(0);
                int column = matrix.GetLength(1);

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write($"{matrix[i, j],3}");
                    }

                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Умножает матрицу на целое число
        /// </summary>
        /// <param name="matrixA">Входная матрица</param>
        /// <param name="n">Число на которое будет происходить умножение</param>
        /// <returns>Возвращает новую матрицу</returns>
        public static int[,] multiplyMatrix(int[,] matrixA, int n)
        {
            int row = matrixA.GetLength(0);
            int column = matrixA.GetLength(1);

            int[,] temp = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    temp[i, j] = matrixA[i, j] * n;
                }
            }

            return temp;
        }

        /// <summary>
        /// Производит сложение двух матриц
        /// </summary>
        /// <param name="matrixA">Первая матрица</param>
        /// <param name="matrixB">Вторая матрица</param>
        /// <returns>Возвращает новую матрицу. Возращает null, если размеры матриц заданы неправильно</returns>
        public static int[,] SumMatrix(int[,] matrixA, int[,] matrixB)
        {
            int row1 = matrixA.GetLength(0);
            int row2 = matrixB.GetLength(0);
            int column1 = matrixA.GetLength(1);
            int column2 = matrixB.GetLength(1);

            if (row1 == row2 && column1 == column2)
            {
                int[,] result = new int[row1, column1];

                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < column1; j++)
                    {
                        result[i, j] = matrixA[i, j] + matrixB[i, j];
                    }
                }

                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
