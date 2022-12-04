using System;

namespace Т08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            double sum = startingPoints;
            double w = 0;
            for (int i = 1; i <= n; i++)
            {
                string result = Console.ReadLine();
                if(result == "W")
                {
                    sum += 2000;
                    w++;
                }
                else if(result == "F")
                {
                    sum += 1200;
                }
                else if (result == "SF")
                {
                    sum += 720;
                }

            }
            Console.WriteLine($"Final points: {sum}");
            Console.WriteLine($"Average points: {Math.Floor((sum-startingPoints)/n)}");
            Console.WriteLine($"{(w / n * 100):f2}%");
        }
    }
}
