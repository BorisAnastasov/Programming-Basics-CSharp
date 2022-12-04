using System;

namespace T10._Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n >= 100 && n <=200 || n == 0)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
