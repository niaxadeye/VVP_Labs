using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N > 1: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int K = 1;
            while (sum < N)
            {
                sum = sum + K;
                K++;
            }
            if(sum > N)
            {
                sum -= K;
            }
            Console.WriteLine(sum);
        }
    }
}
