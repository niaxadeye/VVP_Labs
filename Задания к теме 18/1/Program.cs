using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массивов A и B : ");
            int N = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] arr1 = new int[N];
            Console.WriteLine("\nМассив 1:\n");
            for (int i = 0; i < N; i++)
            {
                arr1[i] = rand.Next(100);
                Console.Write($"{arr1[i]} ");
            }
            int[] arr2 = new int[N];
            Console.WriteLine("\n \nМассив 2:\n");
            for (int i = 0; i < N; i++)
            {
                arr2[i] = rand.Next(100);
                Console.Write($"{arr2[i]} ");
            }
            int temp = 0;
            for(int i = 0; i < N; i++){
                temp = arr1[i];
                arr1[i] = arr2[i];
                arr2[i] = temp;
            }
            Console.WriteLine("\n\nМассив 1 (изменённый):\n");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{arr1[i]} ");
            }
            Console.WriteLine("\n\nМассив 2 (изменнёный): \n");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{arr2[i]} ");
            }

        }
    }
}
