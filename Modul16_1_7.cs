using System;
using System.Linq;
namespace Example
{
    class Program
    {
        static void Main()
        {

            //источник данных - массив
            Console.WriteLine("Введите размер массива: ");
            int arr = Convert.ToInt32(Console.ReadLine());
            int[] N = new int [arr];
            Random rand = new Random();
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < arr; i++)
            {
                N[i] = rand.Next(0, 10);
                Console.Write(N[i] + " ");
            }
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //обращаемся к методу расширения Where
            var lowNums = N.Where(n => n < num);
            //обрабатываем результат
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x * 2);
            }
        }
    }
}
