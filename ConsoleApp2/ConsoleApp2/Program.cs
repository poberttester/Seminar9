// Задача 66: Программа найдёт сумму натуральных элементов в промежутке от M до N.
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Write first number: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write second number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\nСумма натуральных элементов в промежутке от M до N: {ShowNaturalNumbers(M, N)}");

            Console.ReadKey();
        }
        

        static int ShowNaturalNumbers(int M, int N)
        {
            if (M < N)
            {
                return Recursive1(M, N);
            }

            else
            {
                return Recursive2(M, N);
            }
            
        }

        static int Recursive1(int M, int N)
        {
            if (M == N) return M;

            return (M + ShowNaturalNumbers(M + 1, N));
        }

        static int Recursive2(int M, int N)
        {
            if (M == N) return N;

            return (N + ShowNaturalNumbers(M, N + 1));
        }
    }
}
