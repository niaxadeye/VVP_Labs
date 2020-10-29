using System;
using System.Data;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] arr = new int[N];
            int k = 1;
            arr[0] = rand.Next(100);
            Console.Write($"{arr[0]} ");
            arr[1] = rand.Next(100);
            Console.Write($"{arr[1]} ");
            int d = arr[1] - arr[0];
            for (int i = 2; i < N; i++)
            {
                arr[i] = rand.Next(100);
                Console.Write($"{arr[i]} ");
                if(arr[i] - arr[i - 1] != d)
                {
                    k = 0;
                }
            }
            if(k == 0)
            {
                Console.WriteLine("\n0");
            }
            else
            {
                Console.WriteLine($"\nd = {d}");
            }
            
        }
    }
}
    