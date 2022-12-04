using System;

namespace T07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int place = a * b * c;
            string text = Console.ReadLine();
            int sum = 0;
            while(text != "Done")
            {
                 int  k = int.Parse(text);
                sum += k;
                if(sum > place)
                {
                    Console.WriteLine($"No more free space! You need {sum-place} Cubic meters more.");
                    break;
                }
                text = Console.ReadLine();
            }
            if(text == "Done")
            {
                Console.WriteLine($"{place-sum} Cubic meters left.");
            }
        }
    }
}
