using System;

namespace T08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int cat = int.Parse(Console.ReadLine());          
            int cenaCat = cat * 4; 
            double cenaDog = dog*2.5;
            double sum = cenaCat + cenaDog;
            Console.WriteLine($"{sum} lv.");
        }
    }
}
