using System;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную темпиратуру:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную темпиратуру:");
            int max = Convert.ToInt32(Console.ReadLine());
            int mid = (min + max) / 2;
            Console.WriteLine($"Средняя темпиратура воздуха за день {mid} градусов");
        }
    }
}
