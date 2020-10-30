using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите размер массива N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rand.Next(100);
                Console.Write($"{A[i]} ");
            }
            int sum = 0;
            int j;
            double[] B = new double[N];
            Console.WriteLine("\n");
            for(int i = 0; i < N; i++)
            {
                sum = 0;
                for(j = 0; j <=i; j ++)
                {
                    sum += A[j];
                }
                B[i] = Math.Round((double)sum /(double)( j ), 3);
                Console.WriteLine($"B[{i+1}] = {B[i]}");
            }

        }
    }
}
