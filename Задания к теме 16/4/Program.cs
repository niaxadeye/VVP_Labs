using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            N = N - 1;
            Random rand = new Random();
            int[] arr = new int[N ];
            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.Next(100);
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Элемент массива - [{i + 1}] = {arr[i]}");
                Console.WriteLine($"Элемент массива - [{N-i + 1}] = {arr[N-i - 1]}");
            }
        }
    }
}
