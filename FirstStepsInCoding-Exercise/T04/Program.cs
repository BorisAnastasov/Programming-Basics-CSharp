using System;

namespace T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int str = int.Parse(Console.ReadLine());
            int chas = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int strDay = str/chas;
            int chasDay = strDay / days;
            Console.WriteLine(chasDay);
        
        }
    }
}
