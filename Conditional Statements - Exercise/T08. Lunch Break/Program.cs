using System;

namespace T08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int durationEpisode  = int.Parse(Console.ReadLine());
            int durationBreak = int.Parse(Console.ReadLine());
            double durationLunch = 0.125 * durationBreak;
            double durationRelax = 0.25 * durationBreak;
            double diff = durationBreak - durationRelax - durationLunch;

            if (diff>= durationEpisode)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(diff-durationEpisode)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(durationEpisode-diff)} more minutes.");
            }
        }
    }
}
