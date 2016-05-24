using System;

namespace MyFirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Calculator.Plus(2, 2);
            Console.WriteLine("x = {0}", x);

            var y = Calculator.Minus(2, -2);
            Console.WriteLine("y = {0}", y);

            Console.ReadKey();
        }
    }
}
