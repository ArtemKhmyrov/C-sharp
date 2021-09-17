using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_pract
{
    class Program
    {
        static void Main(string[] args)
        
       {

            int Number = int.Parse(Console.ReadLine());
            if (Number > 99 && Number < 1000)
            {
                int one = Number / 100;
                int too = (Number / 10) % 10;
                int three = (Number % 100) % 10;

                Console.WriteLine("Разбиваем число на цифры " + one + " " + too + " " + three + " ");

                int One_one = one * 100;
                int Three_three = three * 10;
                int Res = One_one + Three_three + too;
                Console.WriteLine("Поменяли местами " + Res);
                int Count = Res;
                float max = 0;


                while (Count > 0)
                {
                    if (max < Count % 10)
                    
                        max = Count % 10;
                        Count = Count / 10;
                    
                    
                }
                max = max / 2;


                Console.WriteLine("Мксимальное число " + max + " Результат " + Res);



            }

           



            //int number = 1;
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("Задача из первого модуля ");
            //        Console.WriteLine("16) площадь кольца с внутренним радиусом r1 и внешним r2 ");
            //        Console.WriteLine("Введите внутренний радиус r1: ");
            //        double r1 = double.Parse(Console.ReadLine());
            //        Console.WriteLine("Введите внешний радиус r2: ");
            //        double r2 = double.Parse(Console.ReadLine());
            //        double S;
            //        S = 3.14 * (r2 * r2 + r1 * r1);
            //        Console.WriteLine("Площадь кольца = " + Math.Round(S, 2));
            //        goto case 2;
            //    case 2:
            //        Console.WriteLine(" 17) радиус окружности, вписанной в равносторонний треугольник со стороной а");
            //        Console.WriteLine("Задача из первого модуля ");
            //        Console.WriteLine("Введите сторону а:  ");
            //        float a = float.Parse(Console.ReadLine());
            //        double R = a / (2 * Math.Sqrt(3));
            //        Console.WriteLine("Радиуса вписаной окружности = " + R);
            //        goto case 3;

            //    case 3:
            //        Console.WriteLine("Задача из первого модуля ");
            //        Console.WriteLine(" 19) сумму членов арифметической прогрессии, если известен ее первый член, разность и число членов прогрессии");
            //        int Sn;
            //        Console.WriteLine("Введите первый член: ");
            //        int a1 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Введите разность: ");
            //        int d = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Введите число членов: ");
            //        int n = int.Parse(Console.ReadLine());
            //        Sn = (((2 * a1 + d * ((n - 1))) / 2) * n);
            //        Console.WriteLine("Сумма членов: " + Sn);
            //        goto case 4;

            //    case 4:
            //        Console.WriteLine("Задача из второго модуля");
            //        Console.WriteLine(" 3) оканчивается ли данное целое число цифрой A");
            //        Console.WriteLine("Введите число: ");
            //        int N = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Введите цифру A: ");
            //        int A = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine(N % 10 == A ? "Последняя цифра числа равняется " + A : "Последняя цифра числа НЕ равняется числу " + A);
            //        goto case 5;

            //    case 5:
            //        Console.WriteLine("Задача из второго модуля");
            //        Console.WriteLine("11) состоит ли трехзначное число А из разных цифр");
            //        Console.WriteLine("Введите число: ");
            //        int Num = Convert.ToInt32(Console.ReadLine());
            //        int First = Num / 100;
            //        int Second = Num / 10 % 2;
            //        int Third = Num % 100;
            //        Console.WriteLine(First != Second && First != Third && Second != Third ? "Все цифры числа разные" : "В числе есть повторяющиеся цифры");
            //        goto case 6;

            //    case 6:
            //        Console.WriteLine("Задача из второго модуля");
            //        Console.WriteLine("19) является ли треугольник с длинами сторон a, b, c равнобедренным");
            //        Console.WriteLine("Введите сторону a: ");
            //        int x = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Введите сторону b: ");
            //        int b = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Введите сторону c: ");
            //        int c = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine(x == b && x != c && b != c || b == c && b != x && c != x || x == c && x != b && c != b ? x + b < c || x + c < b || c + b < x ? "Не существует" : "Равнобедренный" : "Равносторонний");
            //        break;

            // }
        }
    }
}