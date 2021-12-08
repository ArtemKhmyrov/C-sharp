
using System;
using System.IO;

namespace ConsoleApp7
{

    abstract class Function : IComparable<Function>
    {
        public abstract double A { get; set; }
        public abstract double B { get; set; }
        public abstract double Result(double x);

        public abstract Int32 CompareTo(Function obj);
    }



    class Line : Function
    {
        public sealed override Double A { get; set; }
        public sealed override Double B { get; set; }

        public Line(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double Result(double x)
        {
            return A * x + B;
        }

        public override Int32 CompareTo(Function obj)
        {
            return A.CompareTo(obj.A);
        }
    }


    class Kub : Function
    {
        public sealed override Double A { get; set; }
        public sealed override Double B { get; set; }
        public readonly double C;

        public Kub(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Result(double x)
        {
            return A * x * x + B * x + C;
        }

        public override Int32 CompareTo(Function obj)
        {
            return A.CompareTo(obj.A);
        }
    }



    class Hyperbola : Function
    {
        public sealed override Double A { get; set; }
        public sealed override Double B { get; set; }

        public Hyperbola(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double Result(double x)
        {
            return (A / x) + B;
        }
        public override Int32 CompareTo(Function obj)
        {
            return A.CompareTo(obj.A);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            using (TextReader reader = File.OpenText("input_for_19_module.txt"))
            {
                int l1 = int.Parse(reader.ReadLine());
                int l2 = int.Parse(reader.ReadLine());
                int k1 = int.Parse(reader.ReadLine());
                int k2 = int.Parse(reader.ReadLine());
                int k3 = int.Parse(reader.ReadLine());
                int h1 = int.Parse(reader.ReadLine());
                int h2 = int.Parse(reader.ReadLine());
                int y = int.Parse(reader.ReadLine());


                Function[] func = new Function[3];
                func[0] = new Line(l1, l2);
                func[1] = new Kub(k1, k2, k3);
                func[2] = new Hyperbola(h1, h2);
                int x = y;
                foreach (Function f in func)
                    Console.WriteLine("f(x), где x = {0} равно {1}", x, f.Result(x));
                Array.Sort(func);
               
            }
        }
    }
}

