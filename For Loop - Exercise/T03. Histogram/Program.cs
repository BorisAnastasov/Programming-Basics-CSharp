using System;

namespace T03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    p2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4++;
                }
                else if (number >= 800)
                {
                    p5++;
                }


            }
            Console.WriteLine($"{(p1 / n * 100):f2}%");
            Console.WriteLine($"{(p2 / n * 100):f2}%");
            Console.WriteLine($"{(p3 / n * 100):f2}%");
            Console.WriteLine($"{(p4 / n * 100):f2}%");
            Console.WriteLine($"{(p5 / n * 100):f2}%");
        }
    }
}
