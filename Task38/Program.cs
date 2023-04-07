using System;
using System.Linq;

namespace Task38
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[size];

            var items = numbers?.Select(next => next = Convert.ToDouble(new Random().Next(100, 1000)) / 100).ToArray();

            foreach (var t in items)
            {
                Console.Write(t + " ");
            }

            double min = Int32.MaxValue;
            double max = Int32.MinValue;

            foreach (var t in items)
            {
                if (t > max)
                {
                    max = t;
                }

                if (t < min)
                {
                    min = t;
                }
            }

            Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
        }
    }
}
