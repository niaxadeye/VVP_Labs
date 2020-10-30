using System;

namespace _3
{
    class Program
    {
        static void Add_zero_before(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            newArray[index] = 0; 
            for (int i = index + 1; i < array.Length +1; i++)
            {
                newArray[i] = array[i-1];
            }
            array = newArray;
        }
        static void Add_zero_after(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i <= index; i++)
            {
                newArray[i] = array[i];
            }
            newArray[index+1] = 0;
            for (int i = index + 2; i < array.Length + 1; i++)
            {
                newArray[i] = array[i - 1];
            }
            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[11] { 2, 2, 20, 3, 4, 5, 6, 7, 8, 9, 1 };
            int max = arr[0];
            int min = arr[0];
            int max_i = 0;
            int min_i = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    max_i = i;
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                    min_i = i;
                }
            }
            Add_zero_before(ref arr, min_i);
            if(max_i > min_i)
            {
                max_i++;
            }
            Add_zero_after(ref arr, max_i);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
