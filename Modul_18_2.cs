using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp6
{

    abstract class Function
    {
        public abstract double Result(double x);
    }

    class Line : Function
    {
        public readonly double A;
        public readonly double B;

        public Line(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double Result(double x)
        {
            return A * x + B;
        }
    }

    class Kub : Function
    {
        public readonly double A;
        public readonly double B;
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
    }

    class Hyperbola : Function
    {
        public readonly double A;

        public Hyperbola(double a)
        {
            A = a;
        }

        public override double Result(double x)
        {
            return A / x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            using (TextReader reader = File.OpenText("input_for_18_module.txt"))
            {
                int l1 = int.Parse(reader.ReadLine());
                int l2 = int.Parse(reader.ReadLine());
                int k1 = int.Parse(reader.ReadLine());
                int k2 = int.Parse(reader.ReadLine());
                int k3 = int.Parse(reader.ReadLine());
                int h1 = int.Parse(reader.ReadLine());
                double y = double.Parse(reader.ReadLine());



                Function[] func = new Function[3];
                func[0] = new Line(l1, l2);
                func[1] = new Kub(k1, k2, k3);
                func[2] = new Hyperbola(h1);
                double x = y;
                foreach (Function f in func)
                    Console.WriteLine(" f(x), где x = {0} = {1}", x, f.Result(x));

            }

        }
    }
}