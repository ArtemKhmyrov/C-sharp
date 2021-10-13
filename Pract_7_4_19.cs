using System;

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
            int[,] mas = new int[x,y];
            int[] b = new int[y];
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
                for (int j = 0; j < y; j++)
                    if (mas[i,j] < mas[i,j])
                        mas[i,0] = b[j];
            }

            Console.WriteLine("Новый массив:");

            for (int j = 0; j < y; j++)
            {
                Console.Write(b[j]);
                Console.WriteLine();
            }

        }
    }
}
