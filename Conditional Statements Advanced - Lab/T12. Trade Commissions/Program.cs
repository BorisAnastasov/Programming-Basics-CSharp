using System;

namespace T12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());
            double sum = 0;
            bool b = false;
            if (town == "Sofia")
            {
                if(sells >= 0 && sells <= 500)
                {
                    sum = sells * 0.05;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    sum = sells * 0.07;
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    sum = sells * 0.08;
                }
                else if ( sells > 10000)
                {
                    sum = sells * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                    b = true;
                }


            }
            else if (town == "Varna")
            {
                if (sells >= 0 && sells <= 500)
                {
                    sum = sells * 0.045;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    sum = sells * 0.075;
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    sum = sells * 0.1;
                }
                else if (sells > 10000)
                {
                    sum = sells * 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                    b = true;
                }
            }
            else if(town == "Plovdiv")
            {
                if (sells >= 0 && sells <= 500)
                {
                    sum = sells * 0.055;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    sum = sells * 0.08;
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    sum = sells * 0.12;
                }
                else if (sells > 10000)
                {
                    sum = sells * 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                    b = true;
                }
            }
            else
            {
                Console.WriteLine("error");
                b = true;
            }
            if (!b)
            {
                Console.WriteLine($"{sum:f2}");
            }

        }
    }
}
