using System;

namespace T08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double score = double.Parse(Console.ReadLine());
            int fails = 0;
            int currentClass = 1;
            double sum = 0;
            while(currentClass <= 12)
            {
                sum += score;
                if(currentClass == 12)
                {
                    break;
                }
                if(score < 4)
                {
                    fails++;
                    
                }
                 if(fails == 2)
                {
                    
                    break;

                }
                currentClass++;
                score = double.Parse(Console.ReadLine());
            }
            if(currentClass == 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(sum/12):f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {currentClass - 1} grade");
            }
        }
    }
}
