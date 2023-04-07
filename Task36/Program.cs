using System;
using System.Linq;

namespace Task36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            var size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];

            var items = numbers?.Select(next => next = new Random().Next(0,9)).ToArray();


            foreach (var t in items)
            {
                Console.Write(t + " ");
            }

            var sum = 0;

            for (int z = 1; z < items.Length; z += 2)
                sum = sum + items[z];

            Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

        }
    }
}
