using System;

namespace _1
{
    class Program
    {
        static int Main(string[] args)
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

            Console.Write("\nВведите число K: ");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число L: ");
            int L = Convert.ToInt32(Console.ReadLine());
            int temp = L - K + 1;
            int sum = 0;
            L = L - 1;
            K = K - 1;
            while(K <= L)
            {
                sum += arr[K];
                K++;
            }
            double sr_ar = (double)sum / (double)temp;
            Console.WriteLine($"Cреднее арифметическое элементов массива с номерами от K до L включительно - {sr_ar}");
            return 0;
        }
    }
}
