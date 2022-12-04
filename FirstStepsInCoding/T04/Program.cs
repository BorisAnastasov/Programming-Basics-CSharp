using System;

namespace T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double sm = inch * 2.54;
            Console.WriteLine(sm);  
        }
    }
}
