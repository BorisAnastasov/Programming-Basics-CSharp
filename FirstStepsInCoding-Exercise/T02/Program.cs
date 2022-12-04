using System;

namespace T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double grad = radians * 180 / Math.PI;
            Console.WriteLine(grad);
        }
    }
}
