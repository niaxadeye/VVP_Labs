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
                Console.Write($"{arr[i]} ");
            }
            int max = arr[0];
            int min = arr[0];
            int Mi = 0;
            int mi = 0;
            for(int i = 1; i < N; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                    Mi = i;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    mi = i;
                }
            }
            int t1, t2;
            if(Mi > mi)
            {
                t1 = mi;
                t2 = Mi;
            }
            else
            {
                t1 = Mi;
                t2 = mi;
            }
            t1++;
            while(t1 < t2)
            {
                arr[t1] = 0;
                t1++;
            }
            Console.WriteLine("\nИзменённый массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
