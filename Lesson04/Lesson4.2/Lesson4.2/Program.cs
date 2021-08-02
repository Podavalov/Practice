using System;
using System.Collections.Generic;
using System.Text;
 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string data = Recieve();
            List<string> parts = Split(data);
            List<int> numbers = Transform(parts);
            int result = Calculate(numbers);
            Result(result);
        }

      

        private static string Recieve()
        {
            Console.Write("Введите числа через пробел: ");
            return Console.ReadLine();
        }

        private static List<string> Split(string data)
        {
            List<string> parts = new List<string>();
            if (string.IsNullOrWhiteSpace(data))
            {
                return parts;
            }
            parts.AddRange(data.Split(' '));
            return parts;
        }

        private static List<int> Transform(List<string> parts)
        {
            List<int> numbers = new List<int>();
            foreach (var part in parts)
            {
                if (int.TryParse(part, out int number))
                {
                    numbers.Add(number);
                }
            }
            return numbers;
        }

        private static int Calculate(List<int> numbers)
        {
            int result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }

        private static void Result(int result)
        {
            Console.WriteLine("Сумма чисел : " + result);
        }
    }
}
