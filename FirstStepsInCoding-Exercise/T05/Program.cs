using System;

namespace T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double himikali = double.Parse(Console.ReadLine())*5.8;
            double markeri = double.Parse(Console.ReadLine())*7.2;
            double preparat = double.Parse(Console.ReadLine()) * 1.2;
            double nam = double.Parse(Console.ReadLine())*0.01;
            double sum = himikali + markeri + preparat   - (himikali + markeri + preparat)*nam;
            Console.WriteLine(sum);

        }
    }
}
