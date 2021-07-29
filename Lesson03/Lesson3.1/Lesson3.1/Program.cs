using System;

namespace Lesson3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"{new string(' ', i)}{matrix[i, j]}");
                    break;
                }
            }
        }
    }
}
