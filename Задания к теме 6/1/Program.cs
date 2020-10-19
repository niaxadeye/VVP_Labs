using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0, B = 0, temp;
            int k = 0;
            do
            {
                Console.Write("Введите число A: ");
                try
                {
                    A = Convert.ToDouble(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0);
            k = 0;
            do
            {
                Console.Write("Введите число B: ");
                try
                {
                    B = Convert.ToDouble(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0);
            temp = A;
            A = B;
            B = temp;
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
        }
    }
}
