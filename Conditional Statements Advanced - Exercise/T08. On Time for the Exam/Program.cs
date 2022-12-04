using System;

namespace T08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());
            examMin = examMin + examHour * 60;
            arrivalMin += arrivalHour * 60;
            int difference = examMin - arrivalMin;
            if (difference <0)
            {
                Console.WriteLine("Late");
            }
            else if(difference >= 0 && difference<=30)
            {
                Console.WriteLine("On time");

            }
            else
            {
                Console.WriteLine("Early");
            }
            if(difference < 59 && difference > 0)
            {
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}
