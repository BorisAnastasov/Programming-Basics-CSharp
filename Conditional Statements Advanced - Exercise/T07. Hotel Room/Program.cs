using System;

namespace ddzbrat
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());
            double sumAp = 0;
            double sumSt = 0;
            
            if( mounth == "May" || mounth == "October")
            {
                if(days > 7 && days <= 14)
                {
                    sumSt = days * 50;
                    sumSt -= sumSt * 0.05;
                    sumAp = days * 65;
                }
                else if(days > 14)
                {
                    sumSt = days * 50;
                    sumSt -= sumSt * 0.3;
                    sumAp = days * 65;
                    sumAp -= sumAp * 0.1;
                }
                else
                {
                    sumSt = days * 50;
                    sumAp = days * 65;
                }
            }
            if(mounth == "June" || mounth == "September")
            {
                if(days > 14)
                {
                    sumSt = days * 75.2;
                    sumSt -= sumSt * 0.2;
                    sumAp = days * 68.7;
                    sumAp -= sumAp * 0.1;
                }
                else
                {
                    sumSt = days * 75.2;
                    sumAp = days * 68.7;
                }
            }
            if(mounth == "July" || mounth == "August")
            {
                if (days > 14)
                {
                    sumSt = days * 76;
                    
                    sumAp = days * 77;
                    sumAp -= sumAp * 0.1;
                }
                else
                {
                    sumSt = days * 76;
                    sumAp = days * 77;
                }
            }
            Console.WriteLine($"Apartment: { sumAp:f2} lv.");
            Console.WriteLine($"Studio: {sumSt:f2} lv.");
        }
    }
}