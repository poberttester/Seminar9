// Задача 64: Программа выведет все натуральные числа в промежутке от N до 1 с помощью рекурсии.
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ShowNaturalNumbers(7));
            Console.ReadKey();
        }

        static int ShowNaturalNumbers(int N)
        {
            if (N == 1) return 1;

            return N + ShowNaturalNumbers(N - 1);
        }
    }
}
