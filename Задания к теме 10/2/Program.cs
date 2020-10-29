using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C: ");
            int C = Convert.ToInt32(Console.ReadLine());
               
            if ( A < B && B < C)
            {
                Console.WriteLine("Высказывание : \"Справедливо двойное неравенство A < B < C\" - истинно");
            }
            else
            {
                Console.WriteLine("Высказывание : \"Справедливо двойное неравенство A < B < C\" - ложно");

            }
        }
    }
}
