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


            //// 1 модуль задача 8

            //Console.WriteLine("Введите x ");
            //double x = int.Parse(Console.ReadLine());
            //double y = (3 * x + 4) / (Math.Sqrt(x * x + 2 * x + 1));
            //Console.WriteLine("Результат " + y);


            //////////////////////////////////////////////////////////////////////////////////////////////////


            //// 2 модуль задача 2

            //Console.Write("x= ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("y= ");
            //double y = double.Parse(Console.ReadLine());
            //const int r1 = 3;
            //const int r2 = 7;
            //if (x * x + y * y > r1 * r1 && x * x + y * y < r2 * r2)
            //{
            //    Console.WriteLine(" да ");
            //}
            //else
            //{
            //    if (x * x + y * y < r1 * r1 || x * x + y * y > r2 * r2)
            //    {
            //        Console.WriteLine(" нет ");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" на границе ");
            //    }
            //}


            //////////////////////////////////////////////////////////////////////////////////////////////////
            

            //// 3 модуль задача 8) Дан возраст человека мужского пола в годах.Вывести на экран возрастную категорию:
            //// до года – «младенец», от года до 11 лет – «ребенок», от 12 до 15 лет – «подросток», от 16
            //// до 25 лет – «юноша», от 26 до 70 лет – «мужчина», более 70 лет – «пожилой человек».

            //Console.WriteLine("Введите возраст человека: ");
            //double q = double.Parse(Console.ReadLine());
            //switch(q)
            //{
            //    case < 1.0:
            //        Console.WriteLine("Младенец");
            //    break;
            //    case <= 11:
            //        Console.WriteLine("Ребенок");
            //        break;
            //    case <= 15:
            //        Console.WriteLine("Подросток");
            //        break;
            //    case <= 25:
            //        Console.WriteLine("Юноша");
            //        break;
            //    case <= 70:
            //        Console.WriteLine("Мужчина");
            //        break;
            //    case > 70:
            //        Console.WriteLine("Пожилой человек");
            //        break;
            //}


            //////////////////////////////////////////////////////////////////////////////////////////////////


            //// 4 модуль задача 12) все четные числа из диапазона от А до В, некратные пяти(АВ);

            //Console.WriteLine("Введите a: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите b: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Результат ");

            //    if (a % 2 != 0)
            //    {
            //        a++;
            //    }
            //    for (int i = a; i < b; i+=2)

            //    if (i % 5 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }


            //////////////////////////////////////////////////////////////////////////////////////////////////


            //// 5 модуль задача 8

            //int counter = 0;
            //for (int i = 6; i <= 10; i++)
            //{
            // for (int j = 6; j < 10 - counter; j++)
            //    {        
            //        Console.Write(i + " ");
            //        System.Threading.Thread.Sleep(1000);
            //    }

            //    counter++;
            //    Console.WriteLine(i + " ");
            //    System.Threading.Thread.Sleep(1000);
            //}


            //////////////////////////////////////////////////////////////////////////////////////////////////


            //// модуль 6 задача 20

            //Console.Write("a= ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("h= ");
            //double h = double.Parse(Console.ReadLine());
            //double y;
            //int i = 1;
            //double pi = 3.14;
            //Console.WriteLine("{0,3} {1,5} {1,5}", "#", "x", "f(x)");
            //for (double x = a; x <= b; x += h, ++i)
            //{
            //    if (Math.Abs(x) < pi / 2)
            //    {
            //        y = Math.Sin(x);
            //    }
            //    else
            //    {
            //        if (Math.Abs(x) >= pi/2 && Math.Abs(x) <= pi)
            //        {
            //            y = Math.Cos(x);
            //        }
            //        else
            //        {
            //            y = 0;
            //        }
            //    }
            //    Console.WriteLine("{0,3} {1,5:f2} {2,5:f2}", i, x, y);
            //}


        }
    }
}

            
    
