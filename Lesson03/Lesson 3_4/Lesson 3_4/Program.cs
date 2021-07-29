using System;

namespace Lesson3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            char x = 'X';
            char o = 'O';

            char[,] seawar = new char[10, 10];
            seawar[0, 0] = x;
            seawar[0, 1] = x;
            seawar[0, 2] = o;
            seawar[0, 3] = x;
            seawar[0, 4] = o;
            seawar[0, 5] = o;
            seawar[0, 6] = x;
            seawar[0, 7] = x;
            seawar[0, 8] = x;
            seawar[0, 9] = x;

            seawar[1, 0] = o;
            seawar[1, 1] = o;
            seawar[1, 2] = o;
            seawar[1, 3] = x;
            seawar[1, 4] = o;
            seawar[1, 5] = o;
            seawar[1, 6] = o;
            seawar[1, 7] = o;
            seawar[1, 8] = o;
            seawar[1, 9] = o;

            seawar[2, 0] = o;
            seawar[2, 1] = o;
            seawar[2, 2] = o;
            seawar[2, 3] = x;
            seawar[2, 4] = o;
            seawar[2, 5] = o;
            seawar[2, 6] = o;
            seawar[2, 7] = o;
            seawar[2, 8] = o;
            seawar[2, 9] = x;

            seawar[3, 0] = o;
            seawar[3, 1] = o;
            seawar[3, 2] = o;
            seawar[3, 3] = o;
            seawar[3, 4] = o;
            seawar[3, 5] = o;
            seawar[3, 6] = o;
            seawar[3, 7] = o;
            seawar[3, 8] = o;
            seawar[3, 9] = x;

            seawar[4, 0] = o;
            seawar[4, 1] = x;
            seawar[4, 2] = o;
            seawar[4, 3] = o;
            seawar[4, 4] = o;
            seawar[4, 5] = o;
            seawar[4, 6] = o;
            seawar[4, 7] = o;
            seawar[4, 8] = o;
            seawar[4, 9] = o;

            seawar[5, 0] = o;
            seawar[5, 1] = x;
            seawar[5, 2] = o;
            seawar[5, 3] = o;
            seawar[5, 4] = o;
            seawar[5, 5] = o;
            seawar[5, 6] = x;
            seawar[5, 7] = o;
            seawar[5, 8] = o;
            seawar[5, 9] = o;

            seawar[6, 0] = o;
            seawar[6, 1] = x;
            seawar[6, 2] = o;
            seawar[6, 3] = o;
            seawar[6, 4] = o;
            seawar[6, 5] = o;
            seawar[6, 6] = o;
            seawar[6, 7] = o;
            seawar[6, 8] = o;
            seawar[6, 9] = o;

            seawar[7, 0] = o;
            seawar[7, 1] = o;
            seawar[7, 2] = o;
            seawar[7, 3] = o;
            seawar[7, 4] = o;
            seawar[7, 5] = o;
            seawar[7, 6] = o;
            seawar[7, 7] = o;
            seawar[7, 8] = o;
            seawar[7, 9] = o;

            seawar[8, 0] = o;
            seawar[8, 1] = o;
            seawar[8, 2] = o;
            seawar[8, 3] = x;
            seawar[8, 4] = o;
            seawar[8, 5] = x;
            seawar[8, 6] = o;
            seawar[8, 7] = o;
            seawar[8, 8] = x;
            seawar[8, 9] = o;

            seawar[9, 0] = x;
            seawar[9, 1] = o;
            seawar[9, 2] = o;
            seawar[9, 3] = o;
            seawar[9, 4] = o;
            seawar[9, 5] = o;
            seawar[9, 6] = o;
            seawar[9, 7] = o;
            seawar[9, 8] = x;
            seawar[9, 9] = o;









            for (int i = 0; i < seawar.GetLength(0); i++)
            {
                for (int j = 0; j < seawar.GetLength(1); j++)
                {
                    Console.Write($"{seawar[i, j]}");
                }
                Console.WriteLine();

            }

        }
    }
}
