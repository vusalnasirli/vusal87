using ConsoleApp20.MODELS;
using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Sum(5, 10));
            Console.WriteLine(Calculator.Subtract(20, 10));
            Console.WriteLine(Calculator.Multiply(3, 4));
            Console.WriteLine(Calculator.Divide(10, 4));


            int num = 3;
            Console.WriteLine(num.Power(3));

        }
    }
}
