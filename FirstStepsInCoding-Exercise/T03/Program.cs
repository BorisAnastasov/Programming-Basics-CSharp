using System;

namespace T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depozit = double.Parse(Console.ReadLine());
            int meseci = int.Parse(Console.ReadLine());
            double prozent = double.Parse(Console.ReadLine());
            double lihva = depozit * (prozent * 0.01);
            double lihvaMesec = lihva / 12;
            double sum = depozit + meseci * lihvaMesec;
            Console.WriteLine(sum);


        }
    }
}
