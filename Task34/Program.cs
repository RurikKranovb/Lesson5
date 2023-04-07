using System;
using System.Linq;

namespace Task34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];

            var items = numbers?.Select(next => next = new Random().Next(99, 1000)).ToArray();

            foreach (var t in items)
            {
                Console.Write(t + " ");
            }

            Console.WriteLine();

            int count = items.Count(t => t % 2 == 0);

            Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

        }
    }
}