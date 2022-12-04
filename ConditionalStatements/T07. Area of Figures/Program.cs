using System;

namespace T07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figur = Console.ReadLine();

            if (figur == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * a:f3}");
            }
            else if(figur == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * b:f3}");
            }
            else if (figur == "circle")
            {
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine($"{ Math.PI * a*a}"); 
            }
            else if (figur == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine($"{a*b/2:f3}");
            }
        }
    }
}
