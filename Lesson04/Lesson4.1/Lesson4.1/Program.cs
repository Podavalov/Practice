using System;

namespace Lesson4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Иванович", "Фёдр", "Степанович"));
            Console.WriteLine(GetFullName("Николаев", "Станислав", "Дмитриевич"));
            Console.WriteLine(GetFullName("Петров", "Егор", "Сергеевич"));
            Console.WriteLine(GetFullName("Алексеев", "Алексей", "Александрович"));
        }

        static string GetFullName(string lastName, string firstName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }


    }
}
