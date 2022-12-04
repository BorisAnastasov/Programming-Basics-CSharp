using System;

namespace T05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            double sum = 0;
            while(text != "NoMoreMoney")
            {
                double amount = double.Parse(text);
                if(amount > 0)
                {
                    sum += amount;
                    Console.WriteLine($"Increase: {amount:f2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                text = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");
            
        }
            
    }
}
