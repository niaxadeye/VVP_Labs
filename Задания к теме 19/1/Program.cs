using System;

namespace _1
{
    class Program
    {
        static void Remove(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for(int i = 0; i < index; i++)
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
            int[] arr = new int [10] { 1, 1, 20, 10, 30, 30, 30 ,0 , 0, 5};
            int flag = 0;
            int temp = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (flag == 1)
                {
                    if (arr[i] == temp)
                    {
                        Remove(ref arr, i);
                        i--;
                    }
                    else
                    {
                        temp = arr[i];
                    }
                }
                else
                {
                    temp = arr[i];
                    flag = 1;
                }
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
