using System;

namespace _2
{
    class Program
    {
        static public decimal calc_L(decimal d)
        {
            decimal pi = 3.14M, L;
            L = pi * d;
            return L;

        }
        static void Main(string[] args)
        {
            decimal d = 0, L, k = 0;
            Console.WriteLine("Разделитель - запятая (например 12,2)");
            do
            {
                Console.Write("Введите диаметр окружности: ");
                try
                {
                    d = Convert.ToDecimal(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат");
                    Console.ResetColor();
                }
            } while (k == 0);
            L = calc_L(d);
            Console.WriteLine($"Длина кружности с диаемтром {d} равна {L}");
        }
    }
}
