using System;
using System.Linq;
namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размер массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            Random rand = new Random();
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.Next(0, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //создание запроса

           var lowNums =
           from n in number
           where n < num
           select n * 2;

            //выполнение запроса
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
        }
    }
}

