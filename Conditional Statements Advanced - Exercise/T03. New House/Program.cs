using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int biodjet = int.Parse(Console.ReadLine());
            double sum = 0;
            double rose = 5;
            double dahlia = 3.8;
            double tulips = 2.8;
            double narciss = 3;
            double gladiol = 2.5;
            switch (typeFlower)
            {
                case "Roses":
                    sum = amount * rose;
                    if(amount > 80)
                    {
                        sum = sum * 0.9;
                    }
                    
                    break;
                case "Dahlias":
                    sum = amount * dahlia;
                    if (amount > 90)
                    {
                        sum = sum * 0.85;
                    }
                    break;
                case "Tulips":
                    sum = amount * tulips;
                    if (amount > 80)
                    {
                        sum = sum * 0.85;
                    }
                    break;
                case "Narcissus":
                    sum = amount * narciss;
                    if(amount < 120)
                    {
                        sum += sum * 0.15;
                    }
                    break;
                case "Gladiolus":
                    sum = amount * gladiol;
                    if (amount < 80)
                    {
                        sum += sum * 0.2;
                    }
                    break;

            }
            if(biodjet-sum >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {amount} {typeFlower} and {biodjet-sum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(biodjet-sum)*(-1):f2} leva more.");
            }

        }
    }
}
