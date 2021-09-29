using System;
// 17. Определить, есть ли в данном массиве строка, состоящая только из положительных
// элементов. (||)
namespace Seventh_modul
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите высоту N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину M:");
            int M = int.Parse(Console.ReadLine());
            int[,] arr = new int[N, M];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    arr[i, j] = int.Parse(Console.ReadLine());
            bool flag = false;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] >= 0)
                        flag = true;
                    else
                    {
                        flag = false;
                        break;
                    }
                    Console.Write(arr[i, j]);
                }
          
                if (flag)
                {
                    Console.WriteLine(" строка полностью состоит из положительных чисел");
                    flag = false;
                }
                else
                {
                    Console.WriteLine(" в строке имеются отрицательные числа");
                }
            }
        }
    }
}
