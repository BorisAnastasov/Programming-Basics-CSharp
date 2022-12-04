using System;

namespace T01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());
            int sum = sec1 + sec2 + sec3;
            int minutes = sum / 60;
            int seconds = sum % 60; 
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
            
            
        }
    }
}
