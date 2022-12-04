using System;

namespace T09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string feedback = Console.ReadLine();
            double price = 0;
            days = days - 1;
            switch (room)
            {
                case "room for one person":
                    price = days * 18;
                    break;
                case "apartment":
                    price = days * 25;
                    if (days < 10)
                    {
                        price -= price * 0.3;
                    }
                    else if(days >=10 && days <= 15)
                    {
                        price -= price * 0.35;
                    }
                    else
                    {
                        price -= price * 0.5;
                    }
                    break;
                case "president apartment":
                    price = days * 35;
                    if (days < 10)
                    {
                        price -= price * 0.1;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price -= price * 0.15;
                    }
                    else
                    {
                        price -= price * 0.2;
                    }
                    break;

            }
            if(feedback == "positive")
            {
                price += price * 0.25;
            }
            else if(feedback == "negative")
            {
                price -= price * 0.1;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
