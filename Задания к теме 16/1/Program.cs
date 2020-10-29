using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < N; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
