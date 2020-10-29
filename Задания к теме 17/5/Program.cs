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
            int ix = 0, jx = 0;
            for(int i = 0; i < N; i++)
            {
                for(int j = i + 1; j < N; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        ix = i;
                        jx = j;
                    }
                }
            }
            if (jx > ix)
            {
                Console.WriteLine($"Номаре элементов: {jx} и {ix}");
            }
            else
            {
                Console.WriteLine($"Номаре элементов: {ix} и {jx}");
            }
        }
    }
}
