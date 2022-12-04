using System;

namespace T05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            double priceDress = double.Parse(Console.ReadLine());
            double decor = budjet * 0.1;
            if(statisti > 150)
            {
                priceDress = priceDress * 0.9;
            }
            double sum = priceDress * statisti + decor;
            if(sum  > budjet)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {(sum-budjet):f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {(budjet-sum):f2} leva left.");
            }
        }
    }
}
