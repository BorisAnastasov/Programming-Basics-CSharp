using System;

namespace T07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());
            int chasove = project * 3;
            Console.WriteLine($"The architect {name} will need {chasove} hours to complete {project} project/s.");
        }
    }
}
