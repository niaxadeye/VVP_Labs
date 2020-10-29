using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите размер массива N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];
            arr[0] = A;
            arr[1] = B;

            for(int i = 2; i < N; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }
    }
}
