using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[9] { 6, 1, 2, 3, 4, 5, 7, 8, 9 };
            Console.Write("Исходный массив: ");
            for(int i = 0; i < 9; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            for(int i = 0; i < 8; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
            Console.Write("\nИзменённый массив: ");
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
