using System;

namespace T09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d = double.Parse(Console.ReadLine())*0.1;
            double sh = double.Parse(Console.ReadLine())*0.1;
            double v = double.Parse(Console.ReadLine())*0.1;
            double prozent = double.Parse(Console.ReadLine());
            double obem = d * sh * v;
            double mqsto = (d * sh * v)* prozent*0.01;
            double sum = obem - mqsto;
            Console.WriteLine(sum);




        }
    }
}
