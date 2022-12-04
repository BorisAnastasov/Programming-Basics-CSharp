using System;

namespace T07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pile = double.Parse(Console.ReadLine())*10.35;
            double riba = double.Parse(Console.ReadLine()) * 12.4;
            double veg = double.Parse(Console.ReadLine()) * 8.15;
            double des = (pile + riba + veg)*0.2;
            double sum = pile + riba + veg+ des + 2.5;
            Console.WriteLine(sum);




        }
    }
}
