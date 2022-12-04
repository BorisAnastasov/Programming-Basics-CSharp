using System;

namespace T03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            if(hour < 23)
            {
                if (minute + 15 < 60)
                {
                    Console.WriteLine($"{hour}:{minute + 15}");
                }
                else if (minute + 15 == 60)
                {
                    hour++;
                    minute = 0;
                    Console.WriteLine($"{hour}:0{minute}");
                }
                else if(minute + 15 > 60)
                {
                    hour++;
                    minute = minute + 15 - 60;
                    if (minute >= 10)
                    {
                        Console.WriteLine($"{hour}:{minute}");
                    }
                    else
                    {
                        Console.WriteLine($"{hour}:0{minute}");
                    }
                        
                }
            }
            else
            {
                if (minute + 15 < 60)
                {
                    Console.WriteLine($"{hour}:{minute + 15}");
                }
                else if (minute + 15 == 60)
                {
                    hour = 0;
                    minute = 0;
                    Console.WriteLine($"{hour}:0{minute}");
                }
                else if (minute + 15 > 60)
                {
                    hour = 0 ;
                    minute = minute + 15 - 60;
                    if (minute >= 10)
                    {
                        Console.WriteLine($"{hour}:{minute}");
                    }
                    else
                    {
                        Console.WriteLine($"{hour}:0{minute}");
                    }

                }
            }
            
        }
    }
}
