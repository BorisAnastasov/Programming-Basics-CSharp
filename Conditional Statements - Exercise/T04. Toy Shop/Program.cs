using System;

namespace T04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            double puzzle = int.Parse(Console.ReadLine());
            double doll = int.Parse(Console.ReadLine());
            double bear = int.Parse(Console.ReadLine());
            double minion = int.Parse(Console.ReadLine());
            double lorry = int.Parse(Console.ReadLine());
            double all = puzzle + doll + bear + minion + lorry;
            puzzle = puzzle * 2.6;
            doll = doll * 3;
            bear = bear * 4.1;
            minion = minion * 8.2;
            lorry = lorry * 2;
            double sum = puzzle + doll + bear + minion + lorry;
            if(all >= 50)
            {
                sum -= sum * 0.25;
            }
            sum -= sum * 0.1;
            if(sum >= price)
            {
                Console.WriteLine($"Yes! {(sum - price):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(price - sum):f2} lv needed.");
            }
        }
    }
}
