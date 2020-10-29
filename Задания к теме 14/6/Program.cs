using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int F = 0, F1 = 1, F2 = 1, K = 2;
            while (F < N)
            {
                K++;
                F = F2 + F1;
                F2 = F1;
                F1 = F;
            }
            Console.WriteLine($"K = {K}");
        }
    }
}
