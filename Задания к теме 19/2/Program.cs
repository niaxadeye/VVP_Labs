using System;

namespace _2
{
    class Program
    {
        static void Remove(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[11] { 1, 42, 3, 33, 2, 10, 20, 1, 2, 44 ,10};
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1 ; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        if (j > i) j--;
                        Remove(ref arr, i);
                        Remove(ref arr, j);
                        

                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

        }
    }
}
