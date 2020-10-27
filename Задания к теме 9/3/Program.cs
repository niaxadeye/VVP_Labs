using System;
using System.Runtime.InteropServices;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число K, лежащее в диапазоне 1–365: ");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число N, лежащее в диапазоне 1–7 (день недели 1 января данного года): ");
            int N = Convert.ToInt32(Console.ReadLine());
            int ans = K % 7 + N - 1;
            if (ans == 0)
            {
                ans = 7;
            }
            Console.WriteLine($"Номер дня недели для {K}-го дня года - {ans}");
        }
    }
}
