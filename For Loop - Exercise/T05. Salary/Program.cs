using System;

namespace T05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seits = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 1; i <= seits; i++)
            {
                string name = Console.ReadLine();
                if (name == "Facebook")
                {
                    salary -= 150;
                }
                if (name == "Instagram")
                {
                    salary -= 100;
                }
                if (name == "Reddit")
                {
                    salary -= 50;
                }

            }
            if(salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
