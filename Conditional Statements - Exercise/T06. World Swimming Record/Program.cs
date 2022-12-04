using System;

namespace T06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());
            double seconds2 =Math.Floor( distance / 15)* 12.5 ;
           
            double seconds1 = distance * timeForOneMeter;
            double sum = seconds1 + seconds2;
            if(sum < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {sum:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(record - sum):f2} seconds slower.");
            }
        }
    }
}
