using System;

namespace T08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxPerYear = double.Parse(Console.ReadLine());
            double shoesPrice = taxPerYear*0.6;
            double outfitPrice = shoesPrice * 0.8;
            double ballPrice = outfitPrice * 0.25;
            double aks = ballPrice / 5;
            double sum = taxPerYear + shoesPrice + outfitPrice + ballPrice + aks;
            Console.WriteLine(sum); 
        }
    }
}
