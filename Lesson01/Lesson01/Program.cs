using System;

namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime thisDay = DateTime.Now;
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Привет, {userName}, сегодня {thisDay} ");
            Console.ReadKey();
        }
    }
}
