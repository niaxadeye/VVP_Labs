using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.Next(100);
                Console.WriteLine($"{arr[i]} ");
            }
            int max = 0;
            if(arr[0] > arr[1])
            {
                max = 1;
            }
            for(int i = 1; i < N; i++)
            {
                if (i == N - 1)
                {
                    if(arr[N-1] > arr[N-2])
                    {   
                         max = N;
                    }
                }
                else
                {
                    if (arr[i] > arr[i-1] && arr[i] > arr[i + 1])
                    {
                        max = i+1;
                    }
                }
            }
            Console.WriteLine($"Номер последнего локального максимума - {max}");
        }
    }
}
