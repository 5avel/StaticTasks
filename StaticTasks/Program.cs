using System;

namespace StaticTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calc.Add(5,5));
            Console.WriteLine(Calc.Sub(5, 5));
            Console.WriteLine(Calc.Mul(5, 5));
            Console.WriteLine(Calc.Div(5, 5));
            Console.ReadKey();
        }


    }

    public static class Calc
    {
        public static double Add(double x, double y) => x + y;
        public static double Sub(double x, double y) => x - y;
        public static double Mul(double x, double y) => x * y;
        public static double Div(double x, double y) => x / y;

    }
}
