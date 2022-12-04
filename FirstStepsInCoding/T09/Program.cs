using System;

namespace T09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //namirame kolko sa kv metri
            double metri = double.Parse(Console.ReadLine());
            //posle namirame cenata im
            double cena = metri * 7.61;
            //smqtame cenata s otstypkata
            double discount = cena * 0.18;
            double finalCena = cena - discount;
            //otpechatwame
            Console.WriteLine($"The final price is: {finalCena} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
