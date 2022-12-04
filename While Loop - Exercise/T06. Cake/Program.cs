using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int cakeSize = w * h;
            int cakePeieces = 0;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                cakePeieces += int.Parse(input);

                if (cakePeieces > cakeSize)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            int diff = cakeSize - cakePeieces;

            if (diff >= 0)
            {
                Console.WriteLine($"{diff} pieces are left.");

            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(diff)} pieces more.");
            }
        }
    }
}