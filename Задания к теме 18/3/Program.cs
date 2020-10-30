using System;

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
            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.Next(100);
                Console.Write($"{arr[i]} ");
            }
            int nch = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    nch = arr[i];
                }

            }
            for(int i = 0; i < N; i++)
            {
                if(arr[i]%2 != 0)
                {
                    arr[i] = arr[i] + nch;
                }
            }
            Console.WriteLine("\nИзменнённый массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
