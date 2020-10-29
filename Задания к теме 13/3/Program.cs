using System;
using System.Diagnostics.CodeAnalysis;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N > 0 : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int n = 1;
            while (sum < N * N)
            {
                sum = sum + (2 * n - 1);
                Console.WriteLine($"Текущая сумма: {sum}");
                n++;
            }
        }
    }
}
