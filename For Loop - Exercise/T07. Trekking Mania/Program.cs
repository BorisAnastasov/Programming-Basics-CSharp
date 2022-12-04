using System;

namespace T07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double musala = 0;
            double monblan = 0;
            double kil = 0;
            double k2 = 0;
            double everest = 0;
            for (int i = 1; i <= n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                sum += people;
                
                if(people <= 5)
                {
                   musala += people;
                }
                else if(people >=6 && people <= 12)
                {
                    monblan += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    kil += people;
                }
                else if (people >= 26 && people <= 40)
                {
                    k2 += people;
                }
                else if (people >= 41)
                {
                    everest += people;
                }
            }
            Console.WriteLine($"{(musala / sum * 100):f2}%");
            Console.WriteLine($"{(monblan / sum * 100):f2}%");
            Console.WriteLine($"{(kil / sum * 100):f2}%");
            Console.WriteLine($"{(k2 / sum * 100):f2}%");
            Console.WriteLine($"{(everest / sum * 100):f2}%");
        }
    }
}
