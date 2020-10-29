using System;

namespace _5
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

            Console.WriteLine("Элементы с нечетными номерами в порядке возрастания номеров: ");
            for (int i = 0; i < N; i+=2)
            {
                Console.WriteLine($"Элемент массива - [{i+1}] = {arr[i]}");
            }
            Console.WriteLine("Элементы с четными номерами в порядке убывания номеров: ");
            if (N% 2 == 0)
            {
                for (int i = 0; i < N; i += 2)
                {
                    Console.WriteLine($"Элемент массива - [{N-i}] = {arr[N-i-1]}");
                }
            }
            else
            {
                for (int i = 0; i < N-1; i += 2)
                {
                    Console.WriteLine($"Элемент массива - [{N - i-1}] = {arr[N - i-2]}");
                }
            }
        }
    }
}
