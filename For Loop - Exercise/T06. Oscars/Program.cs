using System;

namespace T06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double sum = points;
            for (int i = 1; i <= n; i++)
            {
                string name1= Console.ReadLine();
                double points1 = double.Parse(Console.ReadLine());
                
                
                sum = sum +  (points1*name1.Length)/2;
                if (sum >= 1250.5)
                {
                    break;
                }


            }
            if (sum >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {sum:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {nameOfActor} you need {(1250.5-sum):f1} more!");
            }
             
        }
    }
}
