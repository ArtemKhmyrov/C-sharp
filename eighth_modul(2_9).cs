using System;
using System.Text;

namespace Eighth_modul
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите s: ");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Введите str1: ");
            StringBuilder str1 = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Введите str2: ");
            StringBuilder str2 = new StringBuilder(Console.ReadLine());
            while (s.ToString().IndexOf(str1.ToString()) != -1)
            {
                s.Replace(str1.ToString(), str2.ToString());
                Console.WriteLine("Измененная строка s: {0}", s);
            }   
        }
    }
}