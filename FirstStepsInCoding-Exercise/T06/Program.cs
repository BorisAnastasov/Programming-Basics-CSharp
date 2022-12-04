using System;

namespace T06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int boq = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine()); 
            int chasove = int.Parse(Console.ReadLine());
            double sumNailon = (nailon + 2) * 1.50;
            double sumBoq = (boq + boq * 0.1) * 14.50;
            double sumRazreditel = razreditel * 5.00;
            double sumTorbichki = 0.40;
            double sum = sumNailon + sumBoq + sumRazreditel + sumTorbichki;
            double sumMas = (sum * 0.3) * chasove;
            double sumKrai = sum + sumMas;
            Console.WriteLine(sumKrai);
        }
    }
}
