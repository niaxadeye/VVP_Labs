using System;

namespace _4
{
    class Program
    {
        static void Add_zero_after(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i <= index; i++)
            {
                newArray[i] = array[i];
            }
            newArray[index + 1] = 0;
            for (int i = index + 2; i < array.Length + 1; i++)
            {
                newArray[i] = array[i - 1];
            }
            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[11] { -2, 2, 20, 3, -4, 5, 6, -7, 8, 9, -1 };

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Add_zero_after(ref arr, i);
                } 
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

        }
    }
}
