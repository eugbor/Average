using System;
/// <summary>
/// Cреднее арифметическое через цикл do while.
/// </summary>
namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int counter = 0;
            double sum = 0;
            double average = 0;

            do
            {
                a = int.Parse(Console.ReadLine());
                if (a != 0) { counter++; }
                sum += a;
            } while (a != 0);
            average = sum / counter;

            Console.WriteLine("количество чисел: {0}\n" +
                              "общая сумма: {1}\n" +
                              "среднее арифметическое: {2:0.00}", counter, sum, average);
            Console.ReadLine();
        }
    }
}
