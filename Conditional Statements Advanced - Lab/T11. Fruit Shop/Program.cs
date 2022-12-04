using System;

namespace T11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double sum = 0;
            bool b = false;
            if(day == "Saturday" || day == "Sunday")
            {
                switch (fruit) 
                {
                    case "banana":
                        sum = 2.7 * amount;
                        break;
                    case "apple":
                        sum = 1.25 * amount;
                        break;
                    case "orange":
                        sum = 0.9 * amount;
                        break;
                    case "grapefruit":
                        sum = 1.6 * amount;
                        break;
                    case "kiwi":
                        sum = 3 * amount;
                        break;
                    case "pineapple":
                        sum = 5.6 * amount;
                        break;
                    case "grapes":
                        sum = 4.2 * amount;
                        break;
                        default:
                        Console.WriteLine("error");
                        b = true;
                        break;
                }

            }
            else if(day =="Monday" || day =="Tuesday" || day =="Wednesday" || day =="Thursday" || day =="Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        sum = 2.5 * amount;
                        break;
                    case "apple":
                        sum = 1.2 * amount;
                        break;
                    case "orange":
                        sum = 0.85 * amount;
                        break;
                    case "grapefruit":
                        sum = 1.45 * amount;
                        break;
                    case "kiwi":
                        sum = 2.7 * amount;
                        break;
                    case "pineapple":
                        sum = 5.5 * amount;
                        break;
                    case "grapes":
                        sum = 3.85 * amount;
                        break;
                    default:
                        Console.WriteLine("error");
                        b = true;
                        break;
                }
            }
            else
            {
                b = true;
                Console.WriteLine("error");
            }

            if (!b)
            {
                Console.WriteLine($"{sum:f2}");
            }
            
            
                
            
            
        }
    }
}
