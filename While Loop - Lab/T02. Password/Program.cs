using System;

namespace T02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string savedPassword = Console.ReadLine();
            string inputPassword = Console.ReadLine();
            while(inputPassword != savedPassword)
            {
                inputPassword = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
