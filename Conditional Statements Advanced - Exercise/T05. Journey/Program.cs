using System;

namespace T05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = string.Empty;
            string acomudation = string.Empty;
            if (budjet <= 100)
            {
                destination = "Bulgaria";
                if(season == "summer")
                {
                    acomudation = "Camp";
                    budjet = budjet * 0.3;
                }
                else
                {
                    acomudation = "Hotel";
                    budjet = budjet * 0.7;
                }
            }
            else if (budjet <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    acomudation = "Camp";
                    budjet = budjet * 0.4;
                }
                else
                {
                    acomudation = "Hotel";
                    budjet = budjet * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                acomudation = "Hotel";
                budjet = budjet * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{ acomudation} - {budjet:f2}");
        }
    }
}
