using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0, k = 0;
            do
            {
                Console.Write("Введите число A: ");
                try
                {
                    A = Convert.ToInt32(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0);
            int Ax = A * A;
            A = Ax * Ax * Ax;
            Console.WriteLine($"A^8 = {A}");
        }
    }
}
