using System;

namespace T02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string examName = Console.ReadLine();
            int currGrade = int.Parse(Console.ReadLine());
            double sum = 0;
            int count = 0;
            int fails = 0;
          
            string oldName = String.Empty;
            while (examName != "Enough")
            {
                if (currGrade <= 4)
                {
                    fails++;
                }
                if (fails == badGrades)
                {
                    break;
                }
                sum += currGrade;
                count++;
                
                 oldName = examName;
                examName = Console.ReadLine();
                if(examName == "Enough")
                {
                    break;
                }
                currGrade = int.Parse(Console.ReadLine());
                
            }
            if(fails == badGrades)
            {
                Console.WriteLine($"You need a break, { badGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {(sum/count):f2}");
                Console.WriteLine($"Number of problems: {count}");
                Console.WriteLine($"Last problem: {oldName}");
            }
           
        }
    }
}
