using System;

namespace Lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phonelist = new string[5, 2];
            phonelist[0, 0] ="Ivan - ";
            phonelist[1, 0] = "Aleksandr - ";
            phonelist[2, 0] = "Petr - ";
            phonelist[3, 0] = "Vladimir - ";
            phonelist[4, 0] = "Vasiliy - ";
            phonelist[0, 1] = "7(20)300-66-58";
            phonelist[1, 1] = "7(59)090-45-26";
            phonelist[2, 1] = "7(4264)821-04-22" ;
            phonelist[3, 1] = "7(3349)214-21-42";
            phonelist[4, 1] = "7(98)579-84-37 ";


            for (int i = 0; i<phonelist.GetLength(0); i++)
            {
                for(int j =0; j<phonelist.GetLength(1); j++)
                {
                    Console.Write($"{phonelist[i, j]}");
                }
                Console.WriteLine();
            }
        }

    }
}
