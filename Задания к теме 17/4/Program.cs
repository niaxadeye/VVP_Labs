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
            int flag = 0;
            if(arr[0] > arr[1])
            {
                max = arr[0];
                flag = 1;
            }
            for(int i = 1; i < N; i++)
            {
                if (i == N - 1)
                {
                    if(arr[N-1] > arr[N-2])
                    {   
                        if(flag == 1&& arr[N-1] > max)
                        {
                              max = arr[N - 1];
                        }
                        if(flag == 0)
                        {
                              max = arr[N - 1];
                             flag = 1;
                        }
                    }
                }
                else
                {
                    if (arr[i] > arr[i-1] && arr[i] > arr[i + 1] && arr[i] > max)
                    {
                        max = arr[i];
                        flag = 1;
                    }
                }
            }
            Console.WriteLine($"Локальный максимум = {max}");
        }
    }
}
