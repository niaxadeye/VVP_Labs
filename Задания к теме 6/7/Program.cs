using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0, Ax, Ay, k = 0;
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
            Ax = A * A *A ;
            Ay = Ax * Ax;
            Ay = Ay * Ay;
            A = Ax * Ay;
            Console.WriteLine($"A^15 = {A}");
        }
    }
}
