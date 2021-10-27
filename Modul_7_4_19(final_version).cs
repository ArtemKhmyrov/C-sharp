using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество столбцов: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите количество строк: ");
            int y = int.Parse(Console.ReadLine());
            int[,] mas = new int[x, y];
            int[] b = new int[x];
            Console.WriteLine();

            Console.WriteLine("Введите значения матрицы: ");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < x; i++)
            {
                int j = 0;
                while ((j < y - 1) && (mas[i, j] == mas[i, j + 1])){
                    j++;
                }
                if (j == y - 1)
                {
                    b[i] = -1;
                }
                else
                    b[i] = j;
            }

            Console.WriteLine("Новый массив:");

            for (int j = 0; j < x; j++)
            {
                Console.Write(b[j]);
                Console.WriteLine();
            }
        }
    }
}

                