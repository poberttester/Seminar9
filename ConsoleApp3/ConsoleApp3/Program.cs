// Задача 68: Программа вычисляет функцию Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint m = 3, n = 0;
            Console.WriteLine($"Результат вычисления функции Аккермана: {Akkerman(m, n)}");

            Console.ReadKey();
        }

        static uint Akkerman(uint m, uint n)
        {           
            if (m == 0)
            {
                return n + 1;
            }

            else if ((m > 0) && (n == 0))
            {
                return Akkerman(m - 1, 1);
            }

            else
            {
                return Akkerman(m - 1, Akkerman(m, n - 1));
            }

        }
    }
}
