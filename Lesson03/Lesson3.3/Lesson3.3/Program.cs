using System;

namespace Lesson3._3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string word = Console.ReadLine();
           

            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}", word[i]);
            }

        }
    }
}
