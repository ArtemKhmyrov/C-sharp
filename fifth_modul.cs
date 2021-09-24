using System;
using System.Collections.Generic;
using System.Threading;
namespace fifth
{
    class Program
    {

        public static int getsumN(int N) // метод для общего задания с поиском суммы 
        {
            int counter = 0;
            while (N > 0)
            {
                counter = counter + N % 10;
                N = N / 10;
            }
            return counter;
        }


        static void getsumA(int A, int B) // a) для каждого целого числа на отрезке [a, b] вывести на экран сумму четных цифр в числе;
        {
            for (int i = A; i <= B; i++)
            {
                int s = 0;
                while (A > 0)
                {
                    s = s + A % 10;
                    A = A / 10;
                }
                A = i + 1;
                if (i % 2 == 0)
                    Console.WriteLine("Сумма цифр числа " + i + " = " + s);
            }
        }

        static void getsumAdivThree(int A1, int B1) //b) вывести на экран только те целые числа отрезка [a, b], для которых сумма четных 
                                                    //цифр х цифр в числе кратна 3;
        {
            for (int i = A1; i <= B1; i++)
            {
                int s = 0;
                while (A1 > 0)
                {

                    s = s + A1 % 10;
                    A1 = A1 / 10;

                }
                A1 = i + 1;
                if (s % 3 == 0 && i % 2 == 0)
                {
                    Console.WriteLine("Сумма цифр числа " + i + " = " + s);
                }
            }
        }


        static void getsumAdivnumber(int A2, int B2) // c) вывести на экран только те целые числа отрезка[a, b], для которых сумма четных цифр является
                                                     // простым числом;

        {
            for (int i = A2; i <= B2; i++)
            {
                int Result = 0;
                int s = 0;
                while (A2 > 0)
                {

                    s = s + A2 % 10;
                    A2 = A2 / 10;

                }
                A2 = i + 1;
                for (int j = 2; j <= s; j++)
                {
                    if (s % j == 0)
                    {
                        Result = Result + 1;
                    }
                }
                if (Result == 1 && i % 2 == 0)
                {
                    Console.WriteLine("Сумма цифр числа " + i + " = " + s + " оно является простым числом ");
                }

            }
        }

        static void getsumAequalsB(int A3, int B3) // d) для заданного числа А вывести на экран ближайшее следующее за ним число, сумма четных
                                                    // цифр в котором равно В.

        {
            int i = A3;
            for (; ;)
            {
                i++;
                int s = 0;
                while (A3 > 0)
                {
                    s = s + A3 % 10;
                    A3 = A3 / 10;
                }
                A3 = i + 1;
                if (s == B3)
                {
                    Console.WriteLine("Сумма цифр числа " + i + " = " + s);
                    break;
                }    
            }  
        }


        static void Main() // главная функция, где выполняются все телодвижения 
        {
            Console.WriteLine("Разработать метод, который для заданного натурального числа N возвращает сумму его цифр");
            Console.WriteLine("Введите натуральное число N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма цифр числа N - " + getsumN(N));

            Console.WriteLine("для каждого целого числа на отрезке [a, b] вывести на экран сумму четных цифр в числе");
            Console.WriteLine("Введите натуральное число A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите натуральное число B: ");
            int B = int.Parse(Console.ReadLine());
            getsumA(A, B);

            Console.WriteLine("вывести на экран только те целые числа отрезка [a, b], для которых сумма четных цифр в числе кратна 3");
            Console.WriteLine("Введите натуральное число A: ");
            int A1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите натуральное число B: ");
            int B1 = int.Parse(Console.ReadLine());
            getsumAdivThree(A1, B1);

            Console.WriteLine("вывести на экран только те целые числа отрезка [a, b], для которых сумма четных цифр является простым числом");
            Console.WriteLine("Введите натуральное число A: ");
            int A2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите натуральное число B: ");
            int B2 = int.Parse(Console.ReadLine());
            getsumAdivnumber(A2, B2);

            Console.WriteLine("для заданного числа А вывести на экран ближайшее следующее за ним число, сумма четных цифр в котором равно В.");
            Console.WriteLine("Введите натуральное число A: ");
            int A3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите натуральное число B: ");
            int B3 = int.Parse(Console.ReadLine());
            getsumAequalsB(A3, B3);
        }
    }
}
