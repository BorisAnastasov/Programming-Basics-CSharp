using System;

namespace T07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int video = int.Parse(Console.ReadLine());
            int intel = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            double sumVideo = video * 250;
            double sumIntel = intel * sumVideo * 0.35;
            double sumRam = ram * sumVideo * 0.1;
            double sum = sumRam + sumVideo + sumIntel;
            if(video > intel)
            {
                sum -= sum * 0.15;
            }
            if(budjet >= sum)
            {
                Console.WriteLine($"You have {(budjet-sum):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(sum-budjet):f2} leva more!");
            }
        }
    }
}
