using System;

namespace T04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine(); 
            int fishermen = int.Parse(Console.ReadLine());
            double price = 0;
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                break;

                default:
                    break;
            }
            if(fishermen <= 6)
            {
                price -= price * 0.1;

            }
            else if(fishermen < 12)
            {
                price -= price * 0.15;
            }
            else
            {
                price -= price * 0.25;
            }
            if(fishermen%2==0&&season!="Autumn")
            {
                price = price - price * 0.05;
            }
            if (budjet >= price)
            {
                Console.WriteLine($"Yes! You have {(budjet - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(price - budjet):f2} leva.");
            }
        }
    }
}
