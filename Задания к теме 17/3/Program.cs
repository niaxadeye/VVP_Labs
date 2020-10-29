using System;
using System.Security.Cryptography;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] arr = new int[N];
            int flag = 0;
            int min = -1;
            for (int i = 1; i < N; i+=2)
            {
                arr[i-1] = rand.Next(100);
                arr[i] = rand.Next(100);
                Console.WriteLine($"{arr[i-1]} ");
                Console.WriteLine($"{arr[i]} ");
                if(flag == 0)
                {
                    min = arr[i];
                    flag = 1;
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                }
                
            }

            Console.WriteLine($"Минимальный элемент с чётным номером - {min}");
        }
    }
}
