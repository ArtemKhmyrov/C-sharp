using System;
using System.Diagnostics;


namespace Example
    
{
    class Program
    {
        public static int get_info()
        {
            Console.WriteLine("Версия Windows: {0}", Environment.OSVersion);
            Console.WriteLine("64 Bit операционная система? : {0}", Environment.Is64BitOperatingSystem ? "Да" : "Нет");
            Console.WriteLine("Имя компьютера : {0}", Environment.MachineName);
            Console.WriteLine("Число процессоров : {0}", Environment.ProcessorCount);
            Console.WriteLine("Системная папка : {0}", Environment.SystemDirectory);
            Console.WriteLine("Логические диски : {0}", String.Join(", ", Environment.GetLogicalDrives())
               .TrimEnd(',', ' ')
               .Replace("\\", String.Empty));
            return 0;
        }


        public static ulong undigitsSum(ulong n1) // не рекурсия
        {
            ulong ret = 0;
            foreach (ulong c in n1.ToString())
                ret += c - '0';
            return ret;
        }

        public static ulong digitsSum(ulong n2) //рекурсия
        {
            if (n2 == 0) 
            return 0;
            return n2 % 10 + digitsSum(n2 / 10);
        }

        static void Main() //основной метод
        {

            Console.Write("n1=");
            ulong n1 = ulong.Parse(Console.ReadLine());
            ulong fn;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            fn = undigitsSum(n1);
            timer.Stop();
            Console.WriteLine("f{0}={1}", n1, fn);
            Console.WriteLine("Время выполнения НЕ РЕКУРСИВНЫМ методомравно {0}", timer.ElapsedTicks);
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.Write("n2=");
            ulong n2 = ulong.Parse(Console.ReadLine());
            ulong fn2;
            Stopwatch timer2 = new Stopwatch();
            timer2.Start();
            fn2 = digitsSum(n2);
            timer2.Stop();
            Console.WriteLine("f{0}={1}", n2, fn2);
            Console.WriteLine("Время выполнения РЕКУРСИВНЫМ методом равно {0}", timer2.ElapsedTicks);
            GC.Collect();
            GC.WaitForPendingFinalizers();


            Console.WriteLine("\n");
            get_info();

        }

       
    }
}
