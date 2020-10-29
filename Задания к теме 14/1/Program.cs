using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            while(A <= B)
            {
                int temp = A;
                while(temp > 0)
                {
                    Console.Write($"{A} ");
                    temp--;
                }
                A++;
                Console.Write("\n");
            }
        }
    }
}