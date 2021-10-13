using System;
namespace Rabin_Karp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("T= ");
            string t = Console.ReadLine();
            Console.Write("S= ");
            string s = Console.ReadLine();
            const long P = 37;
            //вычисляем массив степеней P
            long[] pwp = new long[t.Length];
            pwp[0] = 1;
            for (int i = 1; i < t.Length; i++)
            {
                pwp[i] = pwp[i - 1] * P;
            }
            //вычисляем массив хэш-значение для всех префиксов строки T
            long[] h = new long[t.Length];
            for (int i = 0; i < t.Length; i++)
            {
                h[i] = (t[i] - 'a' + 1) * pwp[i]; //1
                if (i > 0)
                    h[i] += h[i - 1];
            }
            // вычисляем хэш-значение для подстроки S
            long h_s = 0;
            for (int i = 0; i < s.Length; i++)
            {
                h_s += (s[i] - 'a' + 1) * pwp[i];
            }
            //проводим поиск по хеш-значениям
            for (int i = 0; i + s.Length - 1 < t.Length; i++)
            {
                // находим хэш-значение подстроки T начиная с позиции i длиною s.Length
                long cur_h = h[i + s.Length - 1];
                if (i > 0)
                {
                    cur_h = h[i - 1];
                }
                //приводим хэш-значения двух подстрок к одной степени
                if (cur_h == h_s * pwp[i]) // если хеш-значения равны, то и подстроки равны
                {
                    Console.Write("{0} ", i); // выводим позицию i, с которой начинается повторение
                }
            }
        }
    }
}
