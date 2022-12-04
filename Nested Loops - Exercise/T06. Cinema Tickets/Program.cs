using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            string filmName = Console.ReadLine();

            while (filmName != "Finish")
            {
                int free = int.Parse(Console.ReadLine());

                string type = Console.ReadLine();
                int ticket = 0;

                while (type != "End")
                {
                    if (type == "student")
                    {
                        studentTickets++;
                    }
                    else if (type == "standard")
                    {
                        standardTickets++;
                    }
                    else
                    {
                        kidTickets++;
                    }
                    ticket++;

                    if (ticket == free)
                    {
                        break;
                    }

                    type = Console.ReadLine();
                }

                //процент запълненост на залата 
                double occupancy = ticket * 100.00 / free;

                Console.WriteLine($"{filmName} - {occupancy:F2}% full.");

                filmName = Console.ReadLine();
            }

            int totalTickets = studentTickets + standardTickets + kidTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTickets * 100.00 / totalTickets):F2}% student tickets.");
            Console.WriteLine($"{(standardTickets * 100.00 / totalTickets):F2}% standard tickets.");
            Console.WriteLine($"{(kidTickets * 100.00 / totalTickets):F2}% kids tickets.");

        }
    }
}